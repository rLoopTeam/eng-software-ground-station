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


        #region EddyBrakes

        /// <summary>
        /// left eddy brakes screw position in mm
        /// </summary>
        public float EBLeftScrewPosition;

        /// <summary>
        /// right eddy brakes screw position in mm
        /// </summary>
        public float EBRightScrewPosition;

        /// <summary>
        /// 0 = open, 1 = closed
        /// </summary>
        public byte EBLeftLimitSwitchExtend;

        /// <summary>
        /// 0 = open, 1 = closed
        /// </summary>
        public byte EBRightLimitSwitchExtend;

        /// <summary>
        /// 0 = open, 1 = closed
        /// </summary>
        public byte EBLeftLimitSwitchRetract;

        /// <summary>
        /// 0 = open, 1 = closed
        /// </summary>
        public byte EBRightLimitSwitchRetract;

        /// <summary>
        /// in mm
        /// </summary>
        public float EBLeftIBeamDist;

        /// <summary>
        /// in mm
        /// </summary>
        public float EBRightIBeamDist;

        public UInt16 EBLeftMLPADCRaw;
        public UInt16 EBRightMLPADCRaw;

        /// <summary>
        /// in mm
        /// </summary>
        public float EBLeftMLPScaled;

        /// <summary>
        /// in mm
        /// </summary>
        public float EBRightMLPScaled;
        #endregion

        #region OptoNCDT Lasers

        /// <summary>
        /// Height distance sensor 1 in mm
        /// </summary>
        public float HDS1Value;

        /// <summary>
        /// Height distance sensor 2 in mm
        /// </summary>
        public float HDS2Value;

        /// <summary>
        /// Height distance sensor 3 in mm
        /// </summary>
        public float HDS3Value;

        /// <summary>
        /// Height distance sensor 4 in mm
        /// </summary>
        public float HDS4Value;

        /// <summary>
        /// Height I-Beam sensor 1 in mm
        /// </summary>
        public float IBDS1Value;

        /// <summary>
        /// Height I-Beam sensor 2 in mm
        /// </summary>
        public float IBDS2Value;

        #endregion

        #region Pusher
        /// <summary>
        /// Pusher Switch A. 0 = Open, 1 = Closed
        /// </summary>
        public byte PusherSwitchA;
        /// <summary>
        /// Pusher Switch B. 0 = Open, 1 = Closed
        /// </summary>
        public byte PusherSwitchB;
        /// <summary>
        /// Pusher State, need to look at enum
        /// </summary>
        public byte PusherState;
        #endregion

        #region Accel

        /// <summary>
        /// Accel 1 X-Axis Raw
        /// </summary>
        public Int16 Accel1XRaw;
        /// <summary>
        /// Accel 1 Y-Axis Raw
        /// </summary>
        public Int16 Accel1YRaw;
        /// <summary>
        /// Accel 1 Z-Axis Raw
        /// </summary>
        public Int16 Accel1ZRaw;

        /// <summary>
        /// Accel 1 X-Axis Gs
        /// </summary>
        public float Accel1XGs;
        /// <summary>
        /// Accel 1 Y-Axis Gs
        /// </summary>
        public float Accel1YGs;
        /// <summary>
        /// Accel 1 Z-Axis Gs
        /// </summary>
        public float Accel1ZGs;
        #endregion

        #region EBLowLevelCommand

        public bool SetEBLeftMicroStepsPerRevolution(UInt32 value)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();
            
            DataParameter p = new DataParameter();
            p.Index = 0x5150;
            p.Data = value;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }
        public bool SetEBLeftMaxAcceleration(Int32 value)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0x5151;
            p.Data = value;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }
        public bool SetEBLeftLinearMicronsPerRevolution(Int32 value)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0x5152;
            p.Data = value;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }
        public bool SetEBLeftStepsPerRevolution(UInt32 value)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0x5153;
            p.Data = value;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }
        public bool SetEBLeftMaxAngularVeolocity(Int32 value)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0x5154;
            p.Data = value;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }
        public bool SetEBRightMicroStepsPerRevolution(UInt32 value)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0x5160;
            p.Data = value;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }
        public bool SetEBRightMaxAcceleration(Int32 value)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0x5161;
            p.Data = value;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }
        public bool SetEBRightLinearMicronsPerRevolution(Int32 value)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0x5162;
            p.Data = value;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }
        public bool SetEBRightStepsPerRevolution(UInt32 value)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0x5163;
            p.Data = value;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }
        public bool SetEBRightMaxAngularVeolocity(Int32 value)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0x5164;
            p.Data = value;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }
        #endregion

        #region Misc Commands

        public rPodStateFlightControlUnitNode()
        {
        }

        /// <summary>
        /// Set the brake distance from the I-Beams
        /// </summary>
        /// <param name="dist">Distance in mm, 25 - 0.</param>
        /// <returns>True if the command made it to the Pi, false if the Pi does not respond or an invalid value is given.</returns>
        public bool setIBeamDistance(float dist)
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            if (dist < 0 || dist > 25)
                return false;

            DataParameter p = new DataParameter();
            p.Index = 0x5100;
            p.Data = dist;

            paramsToSend.Add(p);

            return SendCommand(paramsToSend);
        }

        public bool SendPodStop()
        {
            List<DataParameter> paramsToSend = new List<DataParameter>();

            DataParameter p = new DataParameter();
            p.Index = 0x5000;
            p.Data = (UInt32)(0x4567A0B1);

            paramsToSend.Add(p);

            DataParameter p2 = new DataParameter();
            p2.Index = 0x5001;
            p2.Data = (UInt32)(0x00000000);

            paramsToSend.Add(p2);

            return SendCommand(paramsToSend);
        }

        #endregion

        //Should always line up with: http://confluence.rloop.org/display/SD/FCU+Node+Telemetry
        public override void ProcessParameter(List<DataParameter> parameterList)
        {
            LastHeard = DateTime.Now;

            foreach (DataParameter p in parameterList)
            {
                #region Brakes Confluence
                if (p.Index == 0x5200 && p.Data is float)
                    EBLeftScrewPosition = (float)p.Data;
                if (p.Index == 0x5201 && p.Data is float)
                    EBRightScrewPosition = (float)p.Data;
                if (p.Index == 0x5202 && p.Data is byte)
                    EBLeftLimitSwitchExtend = (byte)p.Data;
                if (p.Index == 0x5203 && p.Data is byte)
                    EBRightLimitSwitchExtend = (byte)p.Data;
                if (p.Index == 0x5204 && p.Data is byte)
                    EBLeftLimitSwitchRetract = (byte)p.Data;
                if (p.Index == 0x5205 && p.Data is byte)
                    EBRightLimitSwitchRetract = (byte)p.Data;
                if (p.Index == 0x5206 && p.Data is float)
                    EBLeftIBeamDist = (float)p.Data;
                if (p.Index == 0x5207 && p.Data is float)
                    EBRightIBeamDist = (float)p.Data;
                if (p.Index == 0x5208 && p.Data is UInt16)
                    EBLeftMLPADCRaw = (UInt16)p.Data;
                if (p.Index == 0x5209 && p.Data is UInt16)
                    EBRightMLPADCRaw = (UInt16)p.Data;
                if (p.Index == 0x520A && p.Data is float)
                    EBLeftMLPScaled = (float)p.Data;
                if (p.Index == 0x520B && p.Data is float)
                    EBRightMLPScaled = (float)p.Data;
                #endregion

                #region OptoNCDT Parameters 0x5300 - 0x5305

                if (p.Index == 0x5300 && p.Data is float)
                {
                    HDS1Value = (float)p.Data;
                }
                if (p.Index == 0x5301 && p.Data is float)
                {
                    HDS2Value = (float)p.Data;
                }
                if (p.Index == 0x5302 && p.Data is float)
                {
                    HDS3Value = (float)p.Data;
                }
                if (p.Index == 0x5303 && p.Data is float)
                {
                    HDS4Value = (float)p.Data;
                }
                if (p.Index == 0x5304 && p.Data is float)
                {
                    IBDS1Value = (float)p.Data;
                }
                if (p.Index == 0x5305 && p.Data is float)
                {
                    HDS2Value = (float)p.Data;
                }

                #endregion

                #region Pusher
                if (p.Index == 0x5400 && p.Data is byte)
                    PusherSwitchA = (byte)p.Data;
                if (p.Index == 0x5401 && p.Data is byte)
                    PusherSwitchB = (byte)p.Data;
                if (p.Index == 0x5402 && p.Data is byte)
                    PusherState = (byte)p.Data;
                #endregion

                #region Accel Parameter
                if (p.Index == 0x5500 && p.Data is Int16)
                    Accel1XRaw = (Int16)p.Data;
                if (p.Index == 0x5501 && p.Data is Int16)
                    Accel1YRaw = (Int16)p.Data;
                if (p.Index == 0x5502 && p.Data is Int16)
                    Accel1ZRaw = (Int16)p.Data;
                if (p.Index == 0x5503 && p.Data is float)
                    Accel1XGs = (float)p.Data;
                if (p.Index == 0x5504 && p.Data is float)
                    Accel1YGs = (float)p.Data;
                if (p.Index == 0x5505 && p.Data is float)
                    Accel1ZGs = (float)p.Data;
                #endregion

            }
        }
    }
}
