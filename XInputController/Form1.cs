using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.XInput;

namespace XInputController
{
    public partial class Form1 : Form
    {
        private float hertz = 60;
        private Timer timer;
        private Controller[] controllers = { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };

        public Form1()
        {
            
            InitializeComponent();
            timer = new Timer();
            timer.Interval = getMSInterval();
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
            InputHertz.Text = hertz.ToString();
            SoundPlayer s = new SoundPlayer("XboxSounds.wav"); //Original Xbox console boot and menu sounds
            s.PlayLooping();
            
        }

        private void Timer_Tick(object sender, EventArgs args)
        {
            //Console.WriteLine("Tick");
            string output = "";
            foreach(Controller c in controllers)
            {
                if (!c.IsConnected)
                {
                    output += "Controller is not connected";
                }
                else
                {
                    SharpDX.XInput.Capabilities capabilities=c.GetCapabilities(DeviceQueryType.Any);
                    BatteryInformation batinfo =c.GetBatteryInformation(BatteryDeviceType.Gamepad);
                    State state = c.GetState();
                    output += "Controller Type: " + capabilities.Type.ToString() + "\n";
                    output += "Controller SubType: " + capabilities.SubType.ToString() + "\n";
                    output += "Battery Type: "+batinfo.BatteryType.ToString()+"\n";
                    output += "Battery Level: " + batinfo.BatteryLevel.ToString() + "\n";
                    output += "Current Packet Number: " + state.PacketNumber + "\n";
                    output += "Gamepad State: " + state.Gamepad.ToString() + "\n";
                    Vibration vibration = new Vibration();
                    if ((state.Gamepad.Buttons & GamepadButtonFlags.Back) != 0)
                    {
                        vibration.LeftMotorSpeed = ushort.MaxValue;
                    }
                    else
                    {
                        vibration.LeftMotorSpeed = ushort.MinValue;
                    }
                    if ((state.Gamepad.Buttons & GamepadButtonFlags.Start) != 0)
                    {
                        vibration.RightMotorSpeed = ushort.MaxValue;
                    }
                    else
                    {
                        vibration.RightMotorSpeed = ushort.MinValue;
                    }
                    c.SetVibration(vibration);
                }
                output += "\n----------------------------\n";
            }
            OutputLabel.Text = output;
        }
 
        private int getMSInterval()
        {
            return (int)((1.0 / hertz)*1000);
        }

        private void InputHertz_TextChanged(object sender, EventArgs args)
        {

            if (InputHertz.Text.Length!=0)
            {
                try
                {
                    hertz = float.Parse(InputHertz.Text);
                    timer.Interval = getMSInterval();
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.ToString());
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.ToString());
                }
                catch(ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
