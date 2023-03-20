using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.DAQmx;


namespace Counters
{
    public partial class Form1 : Form
    {
        NationalInstruments.DAQmx.Task myTask;
        NationalInstruments.DAQmx.Task measTask;
        CounterSingleChannelReader myReader;

        bool started;
        bool read;
        double actfreq;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            tbActFreq.Enabled= false;

            nudFreq.Minimum = 0;
            nudFreq.Maximum = 20000000;

            nudDuty.Minimum = 1;
            nudDuty.Maximum = 99;

            nudFreq.Value= 1000;
            nudDuty.Value = 50;
            tbActFreq.Text = "0";

            cboCountIn.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.CO, PhysicalChannelAccess.External));
            if (cboCountIn.Items.Count > 0)
                cboCountIn.SelectedIndex = 0;

            cboCountOut.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.CO, PhysicalChannelAccess.External));
            if (cboCountOut.Items.Count > 0)
                cboCountOut.SelectedIndex = 1;

            cboDev.Items.AddRange(DaqSystem.Local.Devices);
            cboDev.SelectedIndex = 0;

        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            try
            {
                if(started == true)
                {
                    myTask.Stop();
                    started = false;
                    btnOutput.BackColor = System.Drawing.Color.Transparent;

                    cboDev.Enabled = true;
                    cboCountIn.Enabled = true;
                    cboCountOut.Enabled = true;
                    nudInput.Enabled = true;
                    nudOutput.Enabled = true;
                }
                else
                {
                    if (myTask == null)
                    {
                        myTask = new NationalInstruments.DAQmx.Task();

                        myTask.COChannels.CreatePulseChannelFrequency(cboCountOut.Text, "ContinuousPulseTrain", COPulseFrequencyUnits.Hertz, COPulseIdleState.Low, 0.0, (double)(nudFreq.Value),
                            (double)(nudDuty.Value / 100));

                        myTask.Timing.ConfigureImplicit(SampleQuantityMode.ContinuousSamples, 1000);

                        myTask.COChannels.All.PulseTerminal = "/Dev" + (cboDev.SelectedIndex + 1) + "/PFI" + nudOutput.Value;
                    }

                    myTask.Start();

                    started = true;

                    btnOutput.BackColor = System.Drawing.Color.Green;

                    cboDev.Enabled = false;
                    cboCountIn.Enabled = false;
                    cboCountOut.Enabled = false;
                    nudInput.Enabled = false;
                    nudOutput.Enabled = false;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void nudFreq_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (started == true)
                {
                    myTask.Stop();
                    myTask.COChannels[0].PulseFrequency = (double)nudFreq.Value;

                    myTask.Start();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void nudDuty_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (started == true)
                {
                    myTask.Stop();
                    myTask.COChannels[0].PulseFrequency = (double)nudFreq.Value;

                    myTask.Start();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(myTask!= null)
            {
                myTask.Dispose();
            }
            if(measTask != null)
            { measTask.Dispose(); }
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            try
            {
                if(read != true)
                {
                    measTask = new NationalInstruments.DAQmx.Task();
                    measTask.CIChannels.CreateFrequencyChannel(cboCountIn.Text, "measChan", 1, 20000000, CIFrequencyStartingEdge.Rising, CIFrequencyMeasurementMethod.LowFrequencyOneCounter,
                        0.01, 4, CIFrequencyUnits.Hertz);
                    myReader = new CounterSingleChannelReader(measTask.Stream);

                    read = true;
                }

                measTask.CIChannels.All.FrequencyTerminal = "/Dev" + (cboDev.SelectedIndex + 1) + "/PFI" + nudInput.Value;

                actfreq = myReader.ReadSingleSampleDouble();

                Math.Round(actfreq, 3);

                tbActFreq.Text = actfreq.ToString("0.000");

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
