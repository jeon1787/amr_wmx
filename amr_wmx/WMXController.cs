﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMX3ApiCLR;
using static WMX3ApiCLR.Config;
using static WMX3ApiCLR.Motion;

namespace amr_wmx
{
    public class WMXController
    {
        private static WMXController controller;
        private static WMX3Api device;
        private static CoreMotion coreMotion;
        int apiCallError;

        #region Getter
        public WMX3Api Device
        {
            get { return device; }
        }

        public CoreMotion CoreMotion 
        {
            get { return coreMotion; } 
        }
        #endregion

        #region Get Instance
        public static WMXController GetInstance()
        {
            if (null == controller)
            {
                controller = new WMXController();
            }

            return controller;
        }

        public static WMXController NewInstance()
        {
            return new WMXController();
        }
        #endregion

        #region Constructor
        public WMXController()
        {       
            device = new WMX3Api();
            coreMotion = new CoreMotion(device);
            CreateDevice();
        }
        #endregion

        #region Create Device
        public void CreateDevice()
        {
            if (null != device)
            {
                apiCallError = device.CreateDevice("C:\\Program Files\\SoftServo\\WMX3\\");
                if (ErrorCode.SystemInitializationNotDone == apiCallError)
                {
                    // Error
                    Console.WriteLine(string.Format("[CreateDevice] Device is created successfully but initialization of system is not done in specified time."));
                }
                device.SetDeviceName("device_01");
            }
        }
        #endregion

        #region Start Comm
        public void StartCommunication()
        {
            if (null != device)
            {
                apiCallError = device.StartCommunication(1000);
                if (ErrorCode.StartCommunicationError == apiCallError) 
                {
                    // Error
                    Console.WriteLine("[StartCommunication] Start communication failed. Please check the connection of the slave.");
                } 
            }
        }
        #endregion

        #region Stop Comm
        public void StopCommunication()
        {
            if(null != device)
            {
                // 성공적으로 연결 종료시 Engine State : Communicating -> Running
                device.StopCommunication(1000);
            }
        }
        #endregion

        #region Start Engine
        public void StartEngine()
        {
            if (null != device)
            {
                if (false == device.IsDeviceValid())
                {
                    // device is null -> create Device & start Engine
                    device.CreateDevice("C:\\Program Files\\SoftServo\\WMX3\\");
                }
                else
                {
                    // device is not null -> start Engine
                    device.StartEngine("C:\\Program Files\\SoftServo\\WMX3\\", 1000);
                }

            }
        }
        #endregion

        #region Stop Engine
        public void StopEngine()
        {
            if (null != device)
            {
                device.StopEngine();
            }
        }
        #endregion

        #region Set Servo ON
        public void SetServoOn(int axis, bool turnOn) {
            if (null != device)
            {
                if (turnOn)
                {
                    // ON
                    coreMotion.AxisControl.SetServoOn(axis, 1);
                }
                else
                {
                    // OFF
                    coreMotion.AxisControl.SetServoOn(axis, 0);
                }
            }
        }
        #endregion

        #region Get Engine Status
        public EngineStatus GetEngineStatus()
        {
            if (null != device)
            {
                EngineStatus status = new EngineStatus();
                device.GetEngineStatus(ref status);
                return status;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Get Axes Status
        public CoreMotionAxisStatus[] GetAxesStatus()
        {
            var cmStatus = new CoreMotionStatus();
            coreMotion.GetStatus(ref cmStatus);
            return cmStatus.AxesStatus;
        }
        #endregion

        #region Velocity Move
        public void VelMove(int axis, double vel, double acc, double dec, double jerkAcc, double jerkDec)
        {
            JogCommand jogCommand = new JogCommand();
            jogCommand.Axis = axis;
            jogCommand.Profile.Type = ProfileType.Trapezoidal; // 가속도 곡선 : 사다리형
            jogCommand.Profile.Velocity = vel;
            jogCommand.Profile.Acc = acc;
            jogCommand.Profile.Dec = dec;
            jogCommand.Profile.JerkAccRatio = jerkAcc;
            jogCommand.Profile.JerkDecRatio = jerkDec;
            coreMotion.Motion.StartJog(jogCommand);
        }
        #endregion


        #region Relative Move
        public void RelMove(int axis, double target, double vel, double acc, double dec, double jerkAcc, double jerkDec)
        {
            PosCommand posCommand = new PosCommand();
            posCommand.Axis = axis;
            posCommand.Target = target;
            posCommand.Profile.Type = ProfileType.Trapezoidal; // 가속도 곡선 : 사다리형
            posCommand.Profile.Velocity = vel;
            posCommand.Profile.Acc = acc;
            posCommand.Profile.Dec = dec;
            posCommand.Profile.JerkAccRatio = jerkAcc;
            posCommand.Profile.JerkDecRatio = jerkDec;
            coreMotion.Motion.StartMov(posCommand);
        }
        #endregion

        #region Absolute Move
        public void AbsMove(int axis, double target, double vel, double acc, double dec, double jerkAcc, double jerkDec)
        {
            PosCommand posCommand = new PosCommand();
            posCommand.Axis = axis;
            posCommand.Target = target;
            posCommand.Profile.Type = ProfileType.Trapezoidal; // 가속도 곡선 : 사다리형
            posCommand.Profile.Velocity = vel;
            posCommand.Profile.Acc = acc;
            posCommand.Profile.Dec = dec;
            posCommand.Profile.JerkAccRatio = jerkAcc;
            posCommand.Profile.JerkDecRatio = jerkDec;
            coreMotion.Motion.StartPos(posCommand);
        }
        #endregion

        #region Stop Move
        public void StopMotion(int axis)
        {
            coreMotion.Motion.Stop(axis);
        }
        #endregion
    }
}
