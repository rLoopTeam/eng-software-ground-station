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
        public abstract void ProcessParameter(double param, double value);
        public string NodeName;
        public bool IsAlive;
        public DateTime LastHeard;
        public int NodeId;
    }
}
