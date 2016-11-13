using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rLoop_Ground_Station
{
    public class rPodI2CTX
    {
        private byte[] transmitBuffer;
        private int bufferPos;
        byte RPOD_CONTROL_CHAR = 0xD5;
        byte RPOD_FRAME_START = 0xD0;
        byte RPOD_FRAME_END = 0xD8;
        byte RPOD_PARAMETER_START = 0xD3;
        
        byte calculateChecksum(byte[] buf, int lastByte)
        {
            byte checksum = 0;

            for (int i = 0; i < lastByte; i++)
                checksum ^= buf[i];

            return checksum;
        }

        public byte[] formatTransmitParameters(List<DataParameter> parameters)
        {
            transmitBuffer = new byte[5000];

            bufferPos = 0;

            foreach (DataParameter p in parameters)
            {
                if(p.Data is byte)
                    addParameter(p.Index, (byte)p.Data);
                if (p.Data is sbyte)
                    addParameter(p.Index, (sbyte)p.Data);
                if (p.Data is Int16)
                    addParameter(p.Index, (Int16)p.Data);
                if (p.Data is UInt16)
                    addParameter(p.Index, (UInt16)p.Data);
                if (p.Data is Int32)
                    addParameter(p.Index, (Int32)p.Data);
                if (p.Data is UInt32)
                    addParameter(p.Index, (UInt32)p.Data);
                if (p.Data is Int64)
                    addParameter(p.Index, (Int64)p.Data);
                if (p.Data is UInt64)
                    addParameter(p.Index, (UInt64)p.Data);
                if (p.Data is float)
                    addParameter(p.Index, (float)p.Data);
                if (p.Data is double)
                    addParameter(p.Index, (double)p.Data);
            }

            byte[] framelength = BitConverter.GetBytes((UInt16)(bufferPos+4));
            byte length1 = framelength[1];
            byte length2 = framelength[0];

            byte[] headerbuffer = new byte[5010];
            headerbuffer[0] = RPOD_CONTROL_CHAR;
            headerbuffer[1] = RPOD_FRAME_START;
            headerbuffer[2] = length1;
            int at = 3;
            if (length1 == RPOD_CONTROL_CHAR)
                headerbuffer[at++] = RPOD_CONTROL_CHAR;
            headerbuffer[at++] = length2;
            if (length2 == RPOD_CONTROL_CHAR)
                headerbuffer[at++] = RPOD_CONTROL_CHAR;

            transmitBuffer.CopyTo(headerbuffer, at);

            bufferPos += at;
            headerbuffer[bufferPos++] = RPOD_CONTROL_CHAR;
            headerbuffer[bufferPos++] = RPOD_FRAME_END;
            headerbuffer[bufferPos++] = calculateChecksum(headerbuffer,bufferPos-3);
            headerbuffer[bufferPos++] = 0x00;

            return headerbuffer.Take(bufferPos).ToArray();
        }

        private void addCheckedByte(byte byt)
        {
            transmitBuffer[bufferPos++] = byt;
            if(byt == RPOD_CONTROL_CHAR)
                transmitBuffer[bufferPos++] = byt;
        }

        private void addUncheckedByte(byte byt)
        {
            transmitBuffer[bufferPos++] = byt;
        }

        private void addHeader(byte dataType, UInt16 index)
        {
            addUncheckedByte(RPOD_CONTROL_CHAR);
            addCheckedByte(RPOD_PARAMETER_START);
            addCheckedByte(dataType);

            byte[] bytes = BitConverter.GetBytes(index);

            //Convert to network order if need be
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);

            addCheckedByte(bytes[0]);
            addCheckedByte(bytes[1]);
        }

        private void addParameter(UInt16 index, byte data)
        {
            addHeader(0x12, index);
            addCheckedByte(data);
        }

        private void addParameter(UInt16 index, sbyte data)
        {
            addHeader(0x11, index);
            addCheckedByte(BitConverter.GetBytes(data)[0]);
        }

        private void addParameter(UInt16 index, Int16 data)
        {
            addHeader(0x21, index);
            byte[] bytes = BitConverter.GetBytes(data);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            addCheckedByte(bytes[0]);
            addCheckedByte(bytes[1]);
        }

        private void addParameter(UInt16 index, UInt16 data)
        {
            addHeader(0x22, index);
            byte[] bytes = BitConverter.GetBytes(data);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            addCheckedByte(bytes[0]);
            addCheckedByte(bytes[1]);
        }

        private void addParameter(UInt16 index, Int32 data)
        {
            addHeader(0x41, index);
            byte[] bytes = BitConverter.GetBytes(data);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            addCheckedByte(bytes[0]);
            addCheckedByte(bytes[1]);
            addCheckedByte(bytes[2]);
            addCheckedByte(bytes[3]);
        }

        private void addParameter(UInt16 index, UInt32 data)
        {
            addHeader(0x42, index);
            byte[] bytes = BitConverter.GetBytes(data);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            addCheckedByte(bytes[0]);
            addCheckedByte(bytes[1]);
            addCheckedByte(bytes[2]);
            addCheckedByte(bytes[3]);
        }

        private void addParameter(UInt16 index, Int64 data)
        {
            addHeader(0x81, index);
            byte[] bytes = BitConverter.GetBytes(data);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            addCheckedByte(bytes[0]);
            addCheckedByte(bytes[1]);
            addCheckedByte(bytes[2]);
            addCheckedByte(bytes[3]);
            addCheckedByte(bytes[4]);
            addCheckedByte(bytes[5]);
            addCheckedByte(bytes[6]);
            addCheckedByte(bytes[7]);
        }

        private void addParameter(UInt16 index, UInt64 data)
        {
            addHeader(0x82, index);
            byte[] bytes = BitConverter.GetBytes(data);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            addCheckedByte(bytes[0]);
            addCheckedByte(bytes[1]);
            addCheckedByte(bytes[2]);
            addCheckedByte(bytes[3]);
            addCheckedByte(bytes[4]);
            addCheckedByte(bytes[5]);
            addCheckedByte(bytes[6]);
            addCheckedByte(bytes[7]);
        }

        private void addParameter(UInt16 index, double data)
        {
            addHeader(0x83, index);
            byte[] bytes = BitConverter.GetBytes(data);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            addCheckedByte(bytes[0]);
            addCheckedByte(bytes[1]);
            addCheckedByte(bytes[2]);
            addCheckedByte(bytes[3]);
            addCheckedByte(bytes[4]);
            addCheckedByte(bytes[5]);
            addCheckedByte(bytes[6]);
            addCheckedByte(bytes[7]);
        }

        private void addParameter(UInt16 index, float data)
        {
            addHeader(0x43, index);
            byte[] bytes = BitConverter.GetBytes(data);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bytes);
            addCheckedByte(bytes[0]);
            addCheckedByte(bytes[1]);
            addCheckedByte(bytes[2]);
            addCheckedByte(bytes[3]);
        }
    }
}
