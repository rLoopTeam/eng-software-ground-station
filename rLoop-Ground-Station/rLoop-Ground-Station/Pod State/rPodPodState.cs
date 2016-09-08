using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rLoop_Ground_Station.Pod_State.Nodes;

/*
 * This is the top class for accessing the state of the Pod.
 * The network class keeps this updated and the gui class
 * can read it as needed based on open tabs
 */

namespace rLoop_Ground_Station
{
    public static class rPodPodState
    {
        public enum rPodPodStateEnum {
            rPodMaintenanceState = 0, //Default state to allow for manual control of actuators and sensor feedback
            rPodStandbyState, //Standing by to be pushed
            rPodBeingPushedState, //Currently being accelerating by the pusher
            rPodCoastingState, //Currently coasting down the track
            rPodBrakingState, //Braking to a stop
            rPodFinalParkingState, //Using aux prop to maneuver into desired parking spot
            rPodRunCompleteState, //Parking complete, run finished
            rPodEmergencyStopState}; //Uh-oh
        static public List<rPodStateNodeStateI> Nodes;
        static public rPodPodStateEnum rPodPodState_RunMode;
        static public rPodStateBrakeNode BrakeNodeA;
        static public rPodStateBrakeNode BrakeNodeB;
        static public rPodStateCommandControlNode CommandNode;
        static public rPodStateStepperNode StepperNode;
        static public rPodStatePowerNode PowerNodeA;
        static public rPodStatePowerNode PowerNodeB;

        static rPodPodState()
        {
            Nodes.Add(BrakeNodeA);
            Nodes.Add(BrakeNodeB);
            Nodes.Add(CommandNode);
            Nodes.Add(StepperNode);
            Nodes.Add(PowerNodeA);
            Nodes.Add(PowerNodeB);
        }
    }
}
