using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rLoop_Ground_Station.Pod_State.Nodes
{
    public class rPodStateFlightControlUnitNode : rPodStateNodeStateI
    {
        public float CGHeight;
        public float XCG;
        public float YCG;
        public float Pitch;
        public float Yaw;
        public float Roll;
        public float Speed;
        public float Acceleration;

        public float EBLeftLimitSwitch;
        public float EBRightLimitSwitch;
        public float EBLeftMLP;
        public float EBRightMLP;
        public float EBLeftDistance;
        public float EBRightDistance;

        public float HDS1Value;
        public float HDS2Value;
        public float HDS3Value;
        public float HDS4Value;
        public float IBDS1Value;
        public float IBDS2Value;

        public rPodStateFlightControlUnitNode()
        {
        }

        //Should always line up with: http://confluence.rloop.org/display/SD/FCU+Node+Telemetry
        public override void ProcessParameter(List<DataParameter> parameterList)
        {
            foreach (DataParameter p in parameterList)
            {
                if (p.Index == 0 && p.Data is float)
                {
                    CGHeight = (float)p.Data;
                }
                if (p.Index == 1 && p.Data is float)
                {
                    XCG = (float)p.Data;
                }
                if (p.Index == 2 && p.Data is float)
                {
                    YCG = (float)p.Data;
                }
                if (p.Index == 3 && p.Data is float)
                {
                    Pitch = (float)p.Data;
                }
                if (p.Index == 4 && p.Data is float)
                {
                    Yaw = (float)p.Data;
                }
                if (p.Index == 5 && p.Data is float)
                {
                    Roll = (float)p.Data;
                }
                if (p.Index == 6 && p.Data is float)
                {
                    Speed = (float)p.Data;
                }
                if (p.Index == 7 && p.Data is float)
                {
                    Acceleration = (float)p.Data;
                }

                if (p.Index == 8 && p.Data is float)
                {
                    EBLeftLimitSwitch = (float)p.Data;
                }
                if (p.Index == 9 && p.Data is float)
                {
                    EBRightLimitSwitch = (float)p.Data;
                }
                if (p.Index == 10 && p.Data is float)
                {
                    EBLeftMLP = (float)p.Data;
                }
                if (p.Index == 11 && p.Data is float)
                {
                    EBRightMLP = (float)p.Data;
                }
                if (p.Index == 10 && p.Data is float)
                {
                    EBLeftDistance = (float)p.Data;
                }
                if (p.Index == 11 && p.Data is float)
                {
                    EBRightDistance = (float)p.Data;
                }

                if (p.Index == 12 && p.Data is float)
                {
                    HDS1Value = (float)p.Data;
                }
                if (p.Index == 13 && p.Data is float)
                {
                    HDS2Value = (float)p.Data;
                }
                if (p.Index == 14 && p.Data is float)
                {
                    HDS3Value = (float)p.Data;
                }
                if (p.Index == 15 && p.Data is float)
                {
                    HDS4Value = (float)p.Data;
                }
                if (p.Index == 16 && p.Data is float)
                {
                    IBDS1Value = (float)p.Data;
                }
                if (p.Index == 17 && p.Data is float)
                {
                    HDS2Value = (float)p.Data;
                }
            }
        }
    }
}
