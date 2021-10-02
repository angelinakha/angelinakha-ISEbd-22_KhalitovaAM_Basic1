﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBattleship
{
	public partial class FormBattleship : Form
	{
		Graphics g;
		battleship ship;

		public FormBattleship()
		{
			InitializeComponent();
			g = CreateGraphics();
			ship = new battleship();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxShip.Width, pictureBoxShip.Height);
			Graphics gr = Graphics.FromImage(bmp);
			ship.DrawShip(gr);
			pictureBoxShip.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			ship = new battleship();
			ship.Init(rnd.Next(200, 300), rnd.Next(1000, 2000), Color.Black,
		   Color.DarkOliveGreen, true, true); ship.SetPosition(rnd.Next(10, 100),
		   rnd.Next(10, 100), pictureBoxShip.Width, pictureBoxShip.Height);
			Draw();
		}

        private void buttonMove_Click(object sender, EventArgs e)
		{
			//получаем имя кнопки
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					ship.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					ship.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					ship.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					ship.MoveTransport(Direction.Right);
					break;
			}
			Draw();

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

        private void FormBattleship_Load(object sender, EventArgs e)
        {

        }


    }
}
