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
        Area area = new Area();
        Snake snake = new Snake();

        public Game()
        {
            InitializeComponent();
            InitiliazeGameArea();
        }

        private void InitiliazeGameArea()
        {
            this.Height = 600;
            this.Width = 600;

            this.Controls.Add(area);
            area.Top = 100;
            area.Left = 100;
            //area.Location = new Point(100,100);

            //this.Controls.Add(snake.snakePixels[0]);
            snake.Render(this);
        }
    }
}