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

        public rPodStatePowerNode()
        {
            CellVoltages = new float[18,6];
            CellPositiveTabTemperature = new float[18, 6];
            CellNegativeTabTemperature = new float[18, 6];
            BatteryRowDischarging = new bool[18];


            for (int i = 0; i < 18; i++)
            {
                BatteryRowDischarging[i] = false;
                for (int x = 0; x < 6; x++)
                {
                    CellVoltages[i, x] = -1;
                    CellPositiveTabTemperature[i, x] = -1;
                    CellNegativeTabTemperature[i, x] = -1;
                }
            }
        }

        public override void ProcessParameter(double param, double value)
        {
        }
    }
}

