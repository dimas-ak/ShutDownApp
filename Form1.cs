using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDownApp
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer;

        static int selected_time = 0;
        static string required = "[required*]";
        public Form1()
        {
            ControlBox = false;
            InitializeComponent();
            batal.Enabled = false;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            // jika durasi tidak di pilih
            if(durasi.SelectedItem == null)
            {
                required_duration.Text = required;
                required_off.Text = null;
            }
            // jika radio tidak ada yang di pilih
            else if(!off_restart.Checked && !off_shutdown.Checked)
            {
                required_duration.Text = null;
                required_off.Text = required;
            }
            else
            {
                bool is_shutdown = off_shutdown.Checked ? true : false;

                required_duration.Text = null;
                required_off.Text = null;
                // mendapatkan waktu detik berdasarkan ComboBox yang di pilih
                selected_time = Controller.GetOptions(durasi.SelectedIndex);

                Controller.SetOff(selected_time, is_shutdown);

                timer = new System.Timers.Timer(1000);

                timer.Elapsed += Form1_Elapsed;

                timer.AutoReset = true;
                timer.Enabled = true;

                // disable button simpan, waktu durasi, radio shutdown, radio restart
                simpan.Enabled = false;
                durasi.Enabled = false;
                off_shutdown.Enabled = false;
                off_restart.Enabled = false;

                batal.Enabled = true;
            }
        }

        private void Form1_Elapsed(object sender, ElapsedEventArgs e)
        {
            string[] getTimes = Controller.GetTime(selected_time);
            string times = getTimes[0] + ":" + getTimes[1] + ":" + getTimes[2];
            SetText(times, Controller.Calculated(selected_time));
        }

        private void SetText(string times, int value)
        {
            time.Invoke((Action) delegate () {
                // set waktu durasi HH : MM : SS
                time.Text = times;
                if(value > 100)
                {
                    timer.Enabled = false;
                    timer.Stop();
                }
                // udpate value progress bar
                progress_bar.Value = value;
            });
        }

        private void Keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Batal_Click(object sender, EventArgs e)
        {
            Controller.CancelOff();
            batal.Enabled = false;

            timer.Enabled = false;
            timer.Stop();

            time.Text = null;
            progress_bar.Value = 0;

            // enable button simpan, waktu durasi, radio shutdown, radio restart
            durasi.Enabled = true;
            off_shutdown.Enabled = true;
            off_restart.Enabled = true;
            simpan.Enabled = true;
        }
    }
}
