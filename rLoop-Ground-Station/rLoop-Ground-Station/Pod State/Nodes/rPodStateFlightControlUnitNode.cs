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
            }
        }
    }
}
