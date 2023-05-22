using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMX3ApiCLR;

namespace amr_wmx
{
    public class WMXController
    {
        private static WMXController controller;
        private static WMX3Api device;
        private static CoreMotion coreMotion;
        int apiCallError;
        public WMX3Api WMX3API
        {
            get { return device; }
            set { device = value; }
        }
        public static WMXController GetInstance()
        {
            if (null == controller)
            {
                controller = new WMXController();
            }

            return controller;
        }

        #region initialize
        public WMXController()
        {       
            device = new WMX3Api();
            coreMotion = new CoreMotion();
        }
        #endregion

        #region CreateDevice
        public void CreateDevice()
        {
            if (null != device)
            {
                apiCallError = device.CreateDevice("C:\\Program Files\\SoftServo\\WMX3\\", DeviceType.DeviceTypeNormal, 1000);
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

                DevicesInfo devInfo = new DevicesInfo();
                device.GetAllDevices(ref devInfo);
                if (0 == devInfo.Count)
                {
                    // Start Engine : Automatically start engine on CreateDevice().
                    CreateDevice();
                }
                else
                {
                    EngineStatus status = new EngineStatus();
                    device.GetEngineStatus(ref status);
                    if (EngineState.Running == status.State)
                    {
                        // Restart Engine
                        device.RestartEngine("C:\\Program Files\\SoftServo\\WMX3\\", 1000);
                    }
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
                    coreMotion.AxisControl.SetServoOn(0, 1);
                }
                else
                {
                    // OFF
                    coreMotion.AxisControl.SetServoOn(0, 0);
                }

            }
        }
        #endregion
    }
}
