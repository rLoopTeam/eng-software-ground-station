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
        public float[,] CellVoltages; //Volts
        public float[,] CellPositiveTabTemperature; //Degrees C
        public float[,] CellNegativeTabTemperature; //Degrees C
        public bool[] BatteryRowDischarging; //If the BMS is currently discharging/bypassing a paralled set of cells
        public float BatteryPackVoltage;
        public float BatteryPackTemperature;

        public rPodStatePowerNode()
        {
            CellVoltages = new float[18,6];
            CellPositiveTabTemperature = new float[18, 6];
            CellNegativeTabTemperature = new float[18, 6];
            BatteryRowDischarging = new bool[18];


            for (int y = 0; y < 18; y++)
            {
                BatteryRowDischarging[y] = false;
                for (int x = 0; x < 6; x++)
                {
                    CellVoltages[y, x] = -1;
                    CellPositiveTabTemperature[y, x] = -1;
                    CellNegativeTabTemperature[y, x] = -1;
                }
            }
        }

        //Should always line up with: http://confluence.rloop.org/display/SD/Power+Node+Telemetry
        public override void ProcessParameter(List<DataParameter> parameterList)
        {
            int batteryCellRowIndex;
            int batteryCellColumnIndex;

            foreach (DataParameter p in parameterList)
            {
               
                if (p.Index >= 3 && p.Index <= 20 && p.Data is float)
                {
                    batteryCellRowIndex = (p.Index - 3) / 6;
                    batteryCellColumnIndex = (p.Index - 3) % 6;

                    // store the parameter value into the 2D storage array
                    try
                    {
                        Console.WriteLine("RX Voltage parameter: "+parameterList[p.Index].Data.ToString());
                        CellVoltages[batteryCellRowIndex, batteryCellColumnIndex] = (float)parameterList[p.Index].Data;
                        Console.WriteLine("RX Voltage [y:" + batteryCellRowIndex + ", x:" + batteryCellColumnIndex + "] " + parameterList[p.Index].Data.ToString());
                    }
                    catch (Exception eeee)
                    {
                        Console.WriteLine("RX Voltage [y:" + batteryCellRowIndex + ", x:" + batteryCellColumnIndex + "]");
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
                    BatteryPackVoltage = (float)p.Data;
                }


                /*
                * Indices 23 - 130 are the temperature sensors for the positive tabs of the battery cells
                */
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


                /*
                * Indices 131 - 238 are the temperature sensors for the positive tabs of the battery cells
                */
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
            }
        }
    }
}

