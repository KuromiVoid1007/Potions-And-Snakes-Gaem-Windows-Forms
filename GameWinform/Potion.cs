using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWinform
{
    internal class Potion
    {
        public string direction;
        public int potionLeft;
        public int potionTop;

        private int speed = 20;
        private PictureBox potion = new PictureBox();
        private Timer potionTimer = new Timer();



        public void MakePotion(Form form)
        {

            potion.BackColor = Color.Transparent;
            potion.Size = new Size(35, 35);
            potion.BackgroundImage = global::GameWinform.Properties.Resources.potion_efect;
            potion.Tag = "potion";
            potion.Left = potionLeft;
            potion.Top = potionTop;
            potion.BringToFront();


            form.Controls.Add(potion);


            potionTimer.Interval = speed;
            potionTimer.Tick += new EventHandler(PotionTimerEvent);
            potionTimer.Start();

        }

        private void PotionTimerEvent(object sender, EventArgs e)
        {

            if (direction == "left")
            {
                potion.Left -= speed;
            }

            if (direction == "right")
            {
                potion.Left += speed;
            }

            if (direction == "up")
            {
                potion.Top -= speed;
            }

            if (direction == "down")
            {
                potion.Top += speed;
            }


            if (potion.Left < 10 || potion.Left > 860 || potion.Top < 10 || potion.Top > 600)
            {
                potionTimer.Stop();
                potionTimer.Dispose();
                potion.Dispose();
                potionTimer = null;
                potion = null;
            }
        }
    }
}
