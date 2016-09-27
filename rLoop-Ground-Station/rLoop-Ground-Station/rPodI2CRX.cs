using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rLoop_Ground_Station
{
    public class DataParameter {
        public UInt16 Index;
        public object Data;
        public int length; //Technically for byte arrays which aren't really implmented anywhere else
    }

    //Since this is based on a single zmq message it will assume it's be given a single full frame of data
    public class rPodI2CRX
    {
        public List<DataParameter> ProcessFrame(byte[] dataFrame)
        {
            List<DataParameter> dataList = new List<DataParameter>();

            const byte I2C_CONTROL_CHAR = 0xD5;
            const byte I2C_FRAME_START = 0xD0;
            const byte I2C_PARAMETER_START = 0xD3;
            const byte I2C_FRAME_END = 0xD8;
            int length = dataFrame.Length;

            //Check the start and end headers
            if ( dataFrame.Length > 7 && dataFrame[0] != I2C_CONTROL_CHAR || dataFrame[1] != I2C_FRAME_START || dataFrame[length - 4] != I2C_CONTROL_CHAR || dataFrame[length - 3] != I2C_FRAME_END)
                return dataList;

            int i = 0;
            int checksum = 0;
            for (i = 0; i < length - 4; i++)
            {
                checksum ^= dataFrame[i];
                checksum &= 0xFF;
            }

            if (dataFrame[length - 2] != checksum)
            {
                return dataList;
            }
            else { } //All good, continue on

            //Shorten any escaped data now that we've isolated a single frame
            for (i = 2; i < length - 1; i++)
            {
                if (dataFrame[i] == I2C_CONTROL_CHAR && dataFrame[i + 1] == I2C_CONTROL_CHAR)
                {
                    int x;
                    for (x = i + 1; x < length - 1; x++)
                    {
                        dataFrame[x] = dataFrame[x + 1];
                    }
                    dataFrame[length - 1] = 0x00;
                }
                else { }//no escaped data here, continue on.
            }

            int position = 4;
            while (position < length)
            {
                if (dataFrame[position] == 0xD5)
                {
                    position++;
                    switch (dataFrame[position])
                    {
                        case I2C_PARAMETER_START:
                            {
                                position++;

                                int dataType = dataFrame[position] & 0x0F;
                                int dataSize = (dataFrame[position] & 0xF0) / 16;

                                DataParameter p = new DataParameter();
                                p.Index = (UInt16)(dataFrame[position + 1] * 256 + dataFrame[position + 2]);
                                byte[] dataBytes = dataFrame.Skip(position + 3).Take(dataSize).ToArray();

                                switch(dataFrame[position]){
                                    case 0x11: //int 8
                                        p.Data = (sbyte)(dataFrame[position + 3]);
                                        break;
                                    case 0x12: //uint 8
                                        p.Data = dataFrame[position + 3];
                                        break;
                                    case 0x21: //int 16
                                        dataBytes = dataBytes.Reverse().ToArray();
                                        p.Data = BitConverter.ToInt16(dataBytes, 0);
                                        break;
                                    case 0x22: //uint 16
                                        dataBytes = dataBytes.Reverse().ToArray();
                                        p.Data = BitConverter.ToUInt16(dataBytes, 0);
                                        break;
                                    case 0x41: //int 32
                                        dataBytes = dataBytes.Reverse().ToArray();
                                        p.Data = BitConverter.ToInt32(dataBytes, 0);
                                        break;
                                    case 0x42: //uint 32
                                        dataBytes = dataBytes.Reverse().ToArray();
                                        p.Data = BitConverter.ToUInt32(dataBytes, 0);
                                        break;
                                    case 0x81: //int 64
                                        dataBytes = dataBytes.Reverse().ToArray();
                                        p.Data = BitConverter.ToInt64(dataBytes, 0);
                                        break;
                                    case 0x82: //uint 64
                                        dataBytes = dataBytes.Reverse().ToArray();
                                        p.Data = BitConverter.ToUInt64(dataBytes, 0);
                                        break;
                                    case 0x43: //float
                                        p.Data = BitConverter.ToSingle(dataBytes, 0);
                                        break;
                                    case 0x83: //double
                                        p.Data = BitConverter.ToDouble(dataBytes, 0);
                                        break;
                                }

                                dataList.Add(p);
                                position += dataSize + 3;
                            }
                            break;
                    }
                }
                else
                {
                    //Should report an error
                    position++;
                }
            }
            return dataList;
        }
    }
}
