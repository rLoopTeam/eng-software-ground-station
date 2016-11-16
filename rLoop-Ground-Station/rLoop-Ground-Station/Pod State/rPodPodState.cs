using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rLoop_Ground_Station.Pod_State.Nodes;
using System.Threading;

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
        static public rPodStatePowerNode PowerNodeA;
        static public rPodStatePowerNode PowerNodeB;
        static public rPodStateFlightControlUnitNode FlightControlUnitNode;
        static public rPodStateLandingGearUnitNode LandingGearUnitNode;

        static rPodPodState()
        {
            //Be careful here, the compiler gives odd "type initializer" errors
            //in other areas of code instead of crashing here

            Nodes = new List<rPodStateNodeStateI>();

            PowerNodeA = new rPodStatePowerNode();
            PowerNodeB = new rPodStatePowerNode();
            FlightControlUnitNode = new rPodStateFlightControlUnitNode();
            LandingGearUnitNode = new rPodStateLandingGearUnitNode();

            PowerNodeA.NodeName = "PowerA";
            PowerNodeB.NodeName = "PowerB";
            FlightControlUnitNode.NodeName = "FlightControlUnit";
            LandingGearUnitNode.NodeName = "LandingGearUnit";

            Nodes.Add(PowerNodeA);
            Nodes.Add(PowerNodeB);
            Nodes.Add(FlightControlUnitNode);
            Nodes.Add(LandingGearUnitNode);
        }
    }
}
