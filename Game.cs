using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheSnakeGame
{
    public partial class Game : Form
    {
        int horVelocity = 0;
        int verVelocity = 0;
        int step = 20;

        Area area = new Area();
        Snake snake = new Snake();
        Timer mainTimer = new Timer();

        public Game()
        {
            InitializeComponent();
            InitiliazeGameArea();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            mainTimer.Interval = 500;
            mainTimer.Tick += new EventHandler(MainTimer_Tick);
            mainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            //snake.Top += verVelocity;
            //snake.Left += horVelocity;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                verVelocity = -step;
                horVelocity = 0;
            }
            else if (e.KeyCode == Keys.S)
            {
                verVelocity = step;
                horVelocity = 0;
            }
            else if (e.KeyCode == Keys.A)
            {
                verVelocity = 0;
                horVelocity = -step;

            }
            else if (e.KeyCode == Keys.D)
            {
                verVelocity = 0;
                horVelocity = step;
            }
        }

        private void InitiliazeGameArea()
        {
            this.Height = 600;
            this.Width = 600;

            this.Controls.Add(area);
            area.Top = 100;
            area.Left = 100;
            //area.Location = new Point(100,100);

            snake.Render(this);
        }
    }
}