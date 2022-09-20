using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OldSchoolDialer
{
    public partial class dialingFrm : Form
    {

        System.Windows.Forms.Timer aTimer = new System.Windows.Forms.Timer();
        public dialingFrm()
        {
            InitializeComponent();
        }
       
       private static void OnTimedEvent(object source, EventArgs e)
        {
            Connector.ConnectInternet();
        }

        private static void PlaySound()
        {
            var player = new SoundPlayer();
            string path =
                @".\Resources\dialup.wav";
            player.SoundLocation = path;
            player.PlaySync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            PlaySound();
            Connector.ConnectInternet();
            Thread.Sleep(2000);
            Connector.ThrottleInternet();
            var form = new connectedFrm();
            form.Show();
            Hide();
        }

        private void dialingFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
