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
        /// Set the direction of forward 1 landing mechanism
        /// </summary>
        /// <param name="direction">Direction: Up: 1 - Down: 0.</param>
        /// <returns>True if the command made it to the Pi, false if the Pi does not respond or an invalid value is given.</returns>
        public bool setLMForward1Direction(int direction)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            if (direction != 0 && direction != 1)
                return false;

            DataParameter p = new DataParameter();
            p.Index = 0x398; // 920
            p.Data = direction;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }

        /// <summary>
        /// Set the direction of forward 2 landing mechanism
        /// </summary>
        /// <param name="direction">Direction: Up: 1 - Down: 0.</param>
        /// <returns>True if the command made it to the Pi, false if the Pi does not respond or an invalid value is given.</returns>
        public bool setLMForward2Direction(int direction)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            if (direction != 0 && direction != 1)
                return false;

            DataParameter p = new DataParameter();
            p.Index = 0x399; // 921
            p.Data = direction;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }

        /// <summary>
        /// Set the direction of aft 1 landing mechanism
        /// </summary>
        /// <param name="direction">Direction: Up: 1 - Down: 0.</param>
        /// <returns>True if the command made it to the Pi, false if the Pi does not respond or an invalid value is given.</returns>
        public bool setLMAft1Direction(int direction)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            if (direction != 0 && direction != 1)
                return false;

            DataParameter p = new DataParameter();
            p.Index = 0x396; // 918
            p.Data = direction;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }

        /// <summary>
        /// Set the direction of aft 2 landing mechanism
        /// </summary>
        /// <param name="direction">Direction: Up: 1 - Down: 0.</param>
        /// <returns>True if the command made it to the Pi, false if the Pi does not respond or an invalid value is given.</returns>
        public bool setLMAft2Direction(int direction)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            if (direction != 0 && direction != 1)
                return false;

            DataParameter p = new DataParameter();
            p.Index = 0x397; // 919
            p.Data = direction;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }

        /// <summary>
        /// Set the speed of forward 1 landing mechanism
        /// </summary>
        /// <param name="speed">Speed: Up - Down.</param>
        /// <returns>True if the command made it to the Pi, false if the Pi does not respond or an invalid value is given.</returns>
        public bool setLMForward1Speed(int speed)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            if (speed != 0 && speed != 1)
                return false;

            DataParameter p = new DataParameter();
            p.Index = 0x39C; // 924
            p.Data = speed;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }

        /// <summary>
        /// Set the speed of forward 2 landing mechanism
        /// </summary>
        /// <param name="speed">Speed: Up - Down.</param>
        /// <returns>True if the command made it to the Pi, false if the Pi does not respond or an invalid value is given.</returns>
        public bool setLMForward2Speed(int speed)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            if (speed != 0 && speed != 1)
                return false;

            DataParameter p = new DataParameter();
            p.Index = 0x39D; // 925
            p.Data = speed;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }

        /// <summary>
        /// Set the speed of aft 1 landing mechanism
        /// </summary>
        /// <param name="speed">Speed: Up - Down.</param>
        /// <returns>True if the command made it to the Pi, false if the Pi does not respond or an invalid value is given.</returns>
        public bool setLMAft1Speed(int speed)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            if (speed != 0 && speed != 1)
                return false;

            DataParameter p = new DataParameter();
            p.Index = 0x39A; // 922
            p.Data = speed;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }

        /// <summary>
        /// Set the speed of aft 2 landing mechanism
        /// </summary>
        /// <param name="speed">Speed: Up - Down.</param>
        /// <returns>True if the command made it to the Pi, false if the Pi does not respond or an invalid value is given.</returns>
        public bool setLMAft2Speed(int speed)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            if (speed != 0 && speed != 1)
                return false;

            DataParameter p = new DataParameter();
            p.Index = 0x39B; // 923
            p.Data = speed;

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
