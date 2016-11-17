using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rLoop_Ground_Station.Pod_State;

namespace rLoop_Ground_Station.Pod_State.Nodes
{
    public abstract class rPodStateNodeStateI 
    {
        public abstract void ProcessParameter(List<DataParameter> parameters);
        public string NodeName;
        public bool IsAlive;
        public DateTime LastHeard;
        public bool PodStopped;
        public static int HeartbeatRate;

        public bool SendCommand(List<DataParameter> commands)
        {
            //If we don't have telemetry from the node
            //dont bother sending any commands
            //if (Math.Abs((DateTime.Now - LastHeard).TotalSeconds) > 3)
            //    return false;
            return rPodNetworking.setParameters(NodeName + " Node", commands);
        }

    }
}
