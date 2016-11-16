using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rLoop_Ground_Station.Pod_State.Nodes
{
    public class rPodStateLandingGearUnitNode : rPodStateNodeStateI
    {
        public float LM1LimitSwitch;
        public float LM2LimitSwitch;
        public float LMForward1LimitSwitch;
        public float LMForward2LimitSwitch;
        public float LMAft1MLP;
        public float LMAft2MLP;
        public float LMAForward1MLP;
        public float LMAForward2MLP;

        public rPodStateLandingGearUnitNode()
        {
        }

        /// <summary>
        /// Set the direction of landing mechanism
        /// </summary>
        /// <param name="dir">Direction: Up - Down.</param>
        /// <returns>True if the command made it to the Pi, false if the Pi does not respond or an invalid value is given.</returns>
        public bool setLMDirection(RadioButton radiobutton)
        {
            string direction = radiobutton.Text;
            string radiobuttonName = radiobutton.Name;
            List<DataParameter> paramsToSend = new List<DataParameter>();

            if (direction != "Up" && direction != "Down")
                return false;

            DataParameter p = new DataParameter();
            
            //TODO clarify the values to use
            if (direction == "Up")
                p.Data = 0x01;
            else if (direction == "Down")
                p.Data = 0x00;

            //TODO clarify the index to use
            switch(radiobuttonName)
            {
                case "radioFwd1Up":
                    p.Index = 0x5100;
                    break;
                case "radioFwd1Down":
                    p.Index = 0x5100;
                    break;
                case "radioFwd2Up":
                    p.Index = 0x5100;
                    break;
                case "radioFwd2Down":
                    p.Index = 0x5100;
                    break;
            }
            
            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }
        

        //Should always line up with: http://confluence.rloop.org/display/SD/FCU+Node+Telemetry
        public override void ProcessParameter(List<DataParameter> parameterList)
        {
            LastHeard = DateTime.Now;

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
