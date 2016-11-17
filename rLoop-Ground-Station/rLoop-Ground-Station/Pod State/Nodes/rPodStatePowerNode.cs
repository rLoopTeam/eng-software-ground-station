using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rLoop_Ground_Station.Pod_State.Nodes
{
    //Contains all the feedback from the power node
    public class rPodStatePowerNode : rPodStateNodeStateI
    {
        //6P18S Cell configuration
        //Temperature sensors on the positive and negative tab of each cell
        //Temperature sensors between each cells
        //Battery Cells: 1 - 18, A - F
        public float[] RowVoltage;
        public float[,] CellVoltages; //Volts
        public float[,] CellPositiveTabTemperature; //Degrees C
        public float[,] CellNegativeTabTemperature; //Degrees C
        public bool[] BatteryRowDischarging; //If the BMS is currently discharging/bypassing a paralled set of cells
        public float BatteryPackVoltage;


        /// <summary>
        /// In bars.
        /// </summary>
        public float BatteryPackPressure;

        /// <summary>
        /// Degrees C
        /// </summary>
        public float BatteryPackTemperature;

        public rPodStatePowerNode()
        {
            CellVoltages = new float[18,6];
            CellPositiveTabTemperature = new float[18, 6];
            CellNegativeTabTemperature = new float[18, 6];
            BatteryRowDischarging = new bool[18];
            RowVoltage = new float[18];


            for (int y = 0; y < 18; y++)
            {
                BatteryRowDischarging[y] = false;
                RowVoltage[y] = -1;
                for (int x = 0; x < 6; x++)
                {
                    CellVoltages[y, x] = -1;
                    CellPositiveTabTemperature[y, x] = -1;
                    CellNegativeTabTemperature[y, x] = -1;
                }
            }
        }

        public bool SendPodSafe()
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0xA000;
            p.Data = (UInt32)(0xABCD1298);

            paramsToSend.Add(p);

            DataParameter p2 = new DataParameter();
            p2.Index = 0xA001;
            p2.Data = (UInt32)(0x00000000);

            paramsToSend.Add(p2);

            return SendCommand(paramsToSend);
        }

        /// <summary>
        /// Turns streaming the temperature on and off. True = streaming
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public bool SetStreamTemp(bool stream)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0xA100;
            if (stream)
                p.Data = (byte)1;
            else
                p.Data = (byte)0;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }

        /// <summary>
        /// Turns streaming the pressure on and off. True = streaming
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public bool SetStreamPressure(bool stream)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0xA200;
            if (stream)
                p.Data = (byte)1;
            else
                p.Data = (byte)0;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }

        /// <summary>
        /// Turns the charge relay on and off. True = on
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public bool SetChargeRelay(bool on)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0xA300;
            if (on)
                p.Data = (byte)1;
            else
                p.Data = (byte)0;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }

        //Should always line up with: http://confluence.rloop.org/display/SD/Power+Node+Telemetry
        public override void ProcessParameter(List<DataParameter> parameterList)
        {
            int batteryCellRowIndex;
            int batteryCellColumnIndex;

            LastHeard = DateTime.Now;

            foreach (DataParameter p in parameterList)
            {
                #region BatStuff;

                /*

                #region Battery Pack Voltages

                if (p.Index >= 3 && p.Index <= 20 && p.Data is float)
                {
                    batteryCellRowIndex = (p.Index - 3) % 18;

                    // store the parameter value into the 2D storage array
                    try
                    {
                        Console.WriteLine("RX Voltage parameter: "+parameterList[p.Index].Data.ToString());
                        RowVoltage[batteryCellRowIndex] = (float)parameterList[p.Index].Data;
                    }
                    catch (Exception eeee)
                    {
                        Console.WriteLine("RX Voltage [y:" + batteryCellRowIndex + "]");
                        Console.WriteLine(eeee.Message);
                    }

                    continue;
                }


                if (p.Index == 21 && p.Data is float)
                {
                    BatteryPackVoltage = (float)p.Data;
                }

                if (p.Index == 22 && p.Data is float)
                {
                    BatteryPackTemperature = (float)p.Data;
                }

                #endregion

                #region Battery Temps

                //Indices 23 - 130 are the temperature sensors for the positive tabs of the battery cells
                if (p.Index >= 23 && p.Index <= 130 && p.Data is float)
                {
                    batteryCellRowIndex = (p.Index - 23) / 6;
                    batteryCellColumnIndex = (p.Index - 23) % 6;

                    // store the parameter value into the 2D storage array
                    try { 
                        CellPositiveTabTemperature[batteryCellRowIndex, batteryCellColumnIndex] = (float)parameterList[p.Index].Data;
                    } catch(Exception eeee)
                    {
                        Console.WriteLine("RX [y:" + batteryCellRowIndex + ", x:" + batteryCellColumnIndex + "] parameter is NULL!!");
                    }
                    continue;
                }

                //Indices 131 - 238 are the temperature sensors for the positive tabs of the battery cells

                if (p.Index >= 131 && p.Index <= 238 && p.Data is float)
                {
                    batteryCellRowIndex = (p.Index - 131) / 6;
                    batteryCellColumnIndex = (p.Index - 131) % 6;

                    // store the parameter value into the 2D storage array
                    try
                    {
                        CellNegativeTabTemperature[batteryCellRowIndex, batteryCellColumnIndex] = (float)parameterList[p.Index].Data;
                    }
                    catch (Exception eeee)
                    {
                        Console.WriteLine("RX [y:" + batteryCellRowIndex + ", x:" + batteryCellColumnIndex + "] parameter is NULL!!");
                    }
                    continue;
                }

                #endregion

    */

                #endregion

                //Temperature in Degrees C
                if (p.Index == 0xA101 && p.Data is float)
                    BatteryPackTemperature = (float)p.Data;

                //Pressure in Bar
                if (p.Index == 0xA201 && p.Data is float)
                    BatteryPackPressure = (float)p.Data;

            }
        }
    }
}

