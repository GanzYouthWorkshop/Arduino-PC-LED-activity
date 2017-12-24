using GEV.Layouts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEV.PCActivity
{
    public partial class MainForm : GCLForm
    {
        private Dictionary<string, string> m_AvailableCounters { get; } = new Dictionary<string, string>()
        {
            { "Processor.% Processor Time._Total", "Processzor használat"  }
        };

        List<PerformanceCounter> m_UsedCounters { get; } = new List<PerformanceCounter>()
        {
            null,
            null,
            null,
            null,
        };

        private Timer m_Timer;
        private SerialPort m_ArduinoPort;

        public MainForm()
        {
            InitializeComponent();

            this.m_Timer = new Timer();
            this.m_Timer.Interval = 100;
            this.m_Timer.Tick += M_Timer_Tick;

            var ds = this.m_AvailableCounters.ToList();

            this.cbxCounter1.DataSource = ds;
            this.cbxCounter1.DisplayMember = "Value";
            this.cbxCounter1.ValueMember = "Key";
            this.cbxCounter2.DataSource = ds;
            this.cbxCounter2.DisplayMember = "Value";
            this.cbxCounter2.ValueMember = "Key";
            this.cbxCounter3.DataSource = ds;
            this.cbxCounter3.DisplayMember = "Value";
            this.cbxCounter3.ValueMember = "Key";
            this.cbxCounter4.DataSource = ds;
            this.cbxCounter4.DisplayMember = "Value";
            this.cbxCounter4.ValueMember = "Key";

        }

        private void M_Timer_Tick(object sender, EventArgs e)
        {
            if(this.m_ArduinoPort != null && this.m_ArduinoPort.IsOpen)
            {
                for(int i = 0; i < this.m_UsedCounters.Count; i++)
                {
                    if(this.m_UsedCounters[i] != null)
                    {
                        this.m_ArduinoPort.Write(String.Format("{0}:{1}", i, (int)this.m_UsedCounters[i].NextValue()));
                    }
                }
            }
        }

        private void gclButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_ArduinoPort = new SerialPort(this.cbxSerialPort.Text, 9600);
                this.m_ArduinoPort.Open();

                this.m_Timer.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void OnChangeCounter(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            int counter = -1;

            if (cb == this.cbxCounter1) counter = 0;
            if (cb == this.cbxCounter2) counter = 1;
            if (cb == this.cbxCounter3) counter = 2;
            if (cb == this.cbxCounter4) counter = 3;

            if(counter != -1)
            {
                string[] perfmon = ((KeyValuePair<string, string>)cb.SelectedValue).Key.Split('.');

                if(perfmon.Length > 2)
                {
                    this.m_UsedCounters[counter] = new PerformanceCounter(perfmon[0], perfmon[1], perfmon[2], true);
                }
                else
                {
                    this.m_UsedCounters[counter] = new PerformanceCounter(perfmon[0], perfmon[1], true);
                }
            }
        }
    }
}
