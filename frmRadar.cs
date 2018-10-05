using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CsGoRadar
{
    public partial class frmRadar : Form
    {
        private readonly MemoryReader memoryReader;
        private readonly Radar radar;
        private readonly DisplayRadar displayRadar;
        private readonly int bEngine;
        private readonly int bClient;
        private bool isRunning = false;

        private int rdarcenterX;
        private int rdarcenterY;

        private Thread thread;

        private int fanX;
        private int fanY;
        private int spread;
        private int size;

        public frmRadar()
        {
            InitializeComponent();

            rdarcenterX = (Screen.PrimaryScreen.Bounds.Width / 2);
            rdarcenterY = (Screen.PrimaryScreen.Bounds.Height / 2);

            try
            {
                memoryReader = new MemoryReader("csgo");
                bEngine = memoryReader.getEngine();
                bClient = memoryReader.getClient();
                radar = new Radar(memoryReader, rdarcenterX, rdarcenterY, bClient, chkDisplayEnemies.Checked, chkDisplayTeam.Checked, chkStreched.Checked);
                displayRadar = new DisplayRadar(memoryReader, radar, bEngine);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error on Mod Start: " + e.Message);
            }

            trkLeft.Maximum = Screen.PrimaryScreen.Bounds.Width;
            trkLeft.Value = rdarcenterX;
            trkTop.Maximum = Screen.PrimaryScreen.Bounds.Height;
            trkTop.Value = rdarcenterY;

            //800x600
            trkLeft.Value = 689;
            trkTop.Value = 137;
            trkSpread.Value = 24;
            trkDotSize.Value = 3;

            //1024
            //trkLeft.Value = 881;
            //trkTop.Value = 178;
            //trkSpread.Value = 18;
            //trkDotSize.Value = 3;

            trkChange(null, null);
            trkLeft.Scroll += trkChange;
            trkTop.Scroll += trkChange;
            trkSpread.Scroll += trkChange;
            trkDotSize.Scroll += trkChange;
            StartThread();
        }

        private void trkChange(object sender, EventArgs e)
        {
            fanX = trkLeft.Value - rdarcenterX;
            fanY = trkTop.Value - rdarcenterY;
            size = trkDotSize.Value;
            spread = trkSpread.Value;
            Thread.Sleep(100);
        }

        private void startMod()
        {
            PlayerPosition me = null;
            List<PlayerPosition> otherPlayers = null;

            while (true)
            {
                if (isRunning)
                {
                    me = radar.getMe();

                    if (me.Id == 0)
                    {
                        Thread.Sleep(500);
                    }
                    else
                    {
                        otherPlayers = radar.getOtherPlayers(me);
                        displayRadar.render(me, otherPlayers, fanX, fanY, spread, size * 2);
                        Thread.Sleep(250);
                    }
                }

            }
        }

        private void StartThread()
        {
            thread = new Thread(delegate ()
            {
                try
                {
                    startMod();
                }
                catch (Exception e)
                {
                    MessageBox.Show("error while modding: " + e.Message + " " + String.Join(",", e.StackTrace));
                }
            });

            thread.Start();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
            btnRun.BackColor = isRunning ? Color.Red : Color.LightGreen;
            btnRun.Text = isRunning ? "Stop" : "Start";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
