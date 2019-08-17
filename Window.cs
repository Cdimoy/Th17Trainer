using System;
using System.Drawing;
using System.Windows.Forms;

namespace TH17Trainer
{
    public partial class Window : Form
    {
        Point  lastPoint = new Point();
        THGame tGame     = new THGame("th17");
        public Window()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(-e.X, -e.Y);
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mp = MousePosition;
                mp.Offset(lastPoint.X, lastPoint.Y);
                Location = mp;
            }
        }

        private void GsTimer_Tick(object sender, EventArgs e)
        {
            Focus(); // So no ugly rectangles
            if (tGame.IsRuning())
            {
                if (!tGame.IsAttached())
                {
                    tGame.Attach();
                    stateLabel.ForeColor = Color.Green;

                }
                else
                {
                    if (immortalityBox.Checked)
                    {
                        int lives = tGame.ReadInt(tGame.livesAddress);
                        if (lives == 0)
                            tGame.WriteInt(tGame.livesAddress, 8);
                    }

                    if (infbombsBox.Checked)
                    {
                        int bobms = tGame.ReadInt(tGame.bombsAddress);
                        if (bobms == 0)
                            tGame.WriteInt(tGame.bombsAddress, 8);
                    }

                    if (powerBox.Checked)
                    {
                        int power = tGame.ReadInt(tGame.powerAddress);
                        if (power < 399)
                            tGame.WriteInt(tGame.powerAddress, 399);
                    }
                }
            }
            else
            {
                if (tGame.IsAttached())
                    tGame.Detach();
                stateLabel.ForeColor = Color.Red;
            }
        }

        private void ImmortalityBox_CheckedChanged(object sender, EventArgs e)
        {
            if (immortalityBox.Checked)
                immortalityBox.ForeColor = Color.ForestGreen;
            else
                immortalityBox.ForeColor = Color.Black;
        }

        private void InfbombsBox_CheckedChanged(object sender, EventArgs e)
        {
            if (infbombsBox.Checked)
                infbombsBox.ForeColor = Color.ForestGreen;
            else
                infbombsBox.ForeColor = Color.Black;
        }

        private void PowerBox_CheckedChanged(object sender, EventArgs e)
        {
            if (powerBox.Checked)
                powerBox.ForeColor = Color.ForestGreen;
            else
                powerBox.ForeColor = Color.Black;
        }
    }
}
