using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PRG282_PROJECT_Military_Simulations
{
    class Bullets
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int speed = 20;
        private PictureBox bulletBox = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void makeBullet(Form form)
        {
            bulletBox.BackColor = Color.White;
            bulletBox.Size = new Size(5,5);
            bulletBox.Tag = "bullet";
            bulletBox.Left = bulletLeft;
            bulletBox.Top = bulletTop;
            bulletBox.BringToFront();

            form.Controls.Add(bulletBox);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(bulletTimerEvent);
            bulletTimer.Start();
        }
        private void bulletTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                bulletBox.Left -= speed;
            }
            if (direction == "right")
            {
                bulletBox.Left += speed;
            }
            if (direction == "up")
            {
                bulletBox.Top -= speed;
            }
            if (direction == "down")
            {
                bulletBox.Top += speed;
            }
            


            //Form size
            //958, 603
            if (bulletBox.Left < 10 || bulletBox.Left > 9000 || bulletBox.Top < 10 || bulletBox.Top > 1000)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bulletBox.Dispose();
                bulletBox = null;
            }
        }
    }
}
