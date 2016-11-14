using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rLoop_Ground_Station.Pod_State.Nodes
{
    public class rPodStateBrakeNode : rPodStateNodeStateI
    {
        public float EBLeftLimitSwitch;
        public float EBRightLimitSwitch;
        public float EBLeftMLP; // lblLeftMLP
        public float EBRightMLP; //lblRightMLP

        public rPodStateBrakeNode()
        {
        }

        //Should always line up with: http://confluence.rloop.org/display/SD/FCU+Node+Telemetry
        public override void ProcessParameter(List<DataParameter> parameterList)
        {
            foreach (DataParameter p in parameterList)
            {
                if (p.Index == 0 && p.Data is float)
                {
                    EBLeftLimitSwitch = (float)p.Data;
                }
                if (p.Index == 1 && p.Data is float)
                {
                    EBRightLimitSwitch = (float)p.Data;
                }
                if (p.Index == 2 && p.Data is float)
                {
                    EBLeftMLP = (float)p.Data;
                }
                if (p.Index == 3 && p.Data is float)
                {
                    EBRightMLP = (float)p.Data;
                }
            }
        }
    }
}
