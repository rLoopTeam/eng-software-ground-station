using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rLoop_Ground_Station.Pod_State.Nodes
{
    public class rPodStateLandingGearUnitNode : rPodStateNodeStateI
    {
        public byte LM1LimitSwitch;
        public byte LM2LimitSwitch;
        public byte LMForward1LimitSwitch;
        public byte LMForward2LimitSwitch;
        public byte LMAft1MLP;
        public byte LMAft2MLP;
        public byte LMAForward1MLP;
        public byte LMAForward2MLP;

        public rPodStateLandingGearUnitNode()
        {
        }

        #region LGU Actuator Commands

        public bool SetForward1Up() { return false; }
        public bool SetForward1Down() { return false; }
        public bool SetForward1Speed(float speed) { return false; }
        public bool SetForward2Up() { return false; }
        public bool SetForward2Down() { return false; }
        public bool SetForward2Speed(float speed) { return false; }
        public bool SetAft1Up() { return false; }
        public bool SetAft1Down() { return false; }
        public bool SetAft1Speed(float speed) { return false; }
        public bool SetAft2Up() { return false; }
        public bool SetAft2Down() { return false; }
        public bool SetAft2Speed(float speed) { return false; }

        #endregion

        //Should always line up with: http://confluence.rloop.org/display/SD/FCU+Node+Telemetry
        public override void ProcessParameter(List<DataParameter> parameterList)
        {
            LastHeard = DateTime.Now;

            foreach (DataParameter p in parameterList)
            {
                if (p.Index == 0 && p.Data is byte)
                {
                    LM1LimitSwitch = (byte)p.Data;
                }
                if (p.Index == 1 && p.Data is byte)
                {
                    LM2LimitSwitch = (byte)p.Data;
                }
                if (p.Index == 2 && p.Data is byte)
                {
                    LMForward1LimitSwitch = (byte)p.Data;
                }
                if (p.Index == 3 && p.Data is byte)
                {
                    LMForward2LimitSwitch = (byte)p.Data;
                }
                if (p.Index == 4 && p.Data is byte)
                {
                    LMAft1MLP = (byte)p.Data;
                }
                if (p.Index == 5 && p.Data is byte)
                {
                    LMAft2MLP = (byte)p.Data;
                }
                if (p.Index == 6 && p.Data is byte)
                {
                    LMAForward1MLP = (byte)p.Data;
                }
                if (p.Index == 7 && p.Data is float)
                {
                    LMAForward2MLP = (byte)p.Data;
                }
            }
        }
    }
}
