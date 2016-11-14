using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rLoop_Ground_Station.Pod_State.Nodes
{
    public class rPodStateLandingControlUnitNode : rPodStateNodeStateI
    {
        public float LM1LimitSwitch;
        public float LM2LimitSwitch;
        public float LMForward1LimitSwitch;
        public float LMForward2LimitSwitch;
        public float LMAft1MLP;
        public float LMAft2MLP;
        public float LMAForward1MLP;
        public float LMAForward2MLP;

        public rPodStateLandingControlUnitNode()
        {
        }

        //Should always line up with: http://confluence.rloop.org/display/SD/FCU+Node+Telemetry
        public override void ProcessParameter(List<DataParameter> parameterList)
        {
            foreach (DataParameter p in parameterList)
            {
                if (p.Index == 0 && p.Data is float)
                {
                    LM1LimitSwitch = (float)p.Data;
                }
                if (p.Index == 1 && p.Data is float)
                {
                    LM2LimitSwitch = (float)p.Data;
                }
                if (p.Index == 2 && p.Data is float)
                {
                    LMForward1LimitSwitch = (float)p.Data;
                }
                if (p.Index == 3 && p.Data is float)
                {
                    LMForward2LimitSwitch = (float)p.Data;
                }
                if (p.Index == 4 && p.Data is float)
                {
                    LMAft1MLP = (float)p.Data;
                }
                if (p.Index == 5 && p.Data is float)
                {
                    LMAft2MLP = (float)p.Data;
                }
                if (p.Index == 6 && p.Data is float)
                {
                    LMAForward1MLP = (float)p.Data;
                }
                if (p.Index == 7 && p.Data is float)
                {
                    LMAForward2MLP = (float)p.Data;
                }
            }
        }
    }
}
