/*
A simple pong game using C#
 */
using System;
using System.Threading;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();}
			
			Bitmap btm;
			Graphics bGraphics;
			Graphics sGraphics;
			
			Thread mth;
			
			Rectangle lPaddle = Rectangle.Empty;
			Rectangle rPaddle = Rectangle.Empty;
			Rectangle ball = Rectangle.Empty;
			
			//int ballSx, ballSy, paddleS;
			
			int ballSx = 1;
			int ballSy = 1;
			int paddleS = 5;
			
			Point movePaddle =  Point.Empty;
			Point moveBall =  Point.Empty;
			
			bool looper = true;
			
			private void MainForm_Load (object sender, EventArgs e)
			{
				btm =  new Bitmap (this.Width, this.Height);
				//btm =  new Bitmap (800, 600);
				bGraphics = Graphics.FromImage(btm);
				sGraphics = this.CreateGraphics();
				
				ball = new Rectangle(this.Width/2, this.Height/3, 40, 40);
				rPaddle = new Rectangle((this.Width - 50), this.Height/3, 30, 150);
				lPaddle = new Rectangle(5, this.Height/3, 30, 150);
				
				mth = new Thread(draw);
				
				mth.IsBackground = true;
				
				mth.Start();
			}
			
			public void draw()
			{
				while(looper)
				{
					bGraphics.Clear(Color.White);
					
					if(movePaddle.Y > rPaddle.Y + 100) rPaddle.Y +=  paddleS;
					
					if(movePaddle.Y < rPaddle.Y + 100) rPaddle.Y -=  paddleS;
					
					if(ball.Y > lPaddle.Y + 100) lPaddle.Y +=  paddleS;
					
					if(ball.Y < lPaddle.Y + 100) lPaddle.Y -=  paddleS;

					ball.X += ballSx;
					
					if(moveBall.Y > ball.Y) ball.Y +=  ballSy;
					
					if(moveBall.Y < ball.Y) ball.Y -=  ballSy;
					
					if((rPaddle.IntersectsWith(ball)) || (lPaddle.IntersectsWith(ball))) ballSx *= (-1);
					
					if(ball.Y < 20) moveBall.Y +=  this.Height;
					
					if(ball.Y < this.Height - 80 ) moveBall.Y -=  0;
					
					if(ball.Y < -40) ball.X +=  this.Width/2;
					
					if(ball.Y < this.Width ) ball.X +=  this.Width/2;

					
					
					bGraphics.FillEllipse(Brushes.Black, ball);
					bGraphics.FillRectangle(Brushes.Red, lPaddle);
					bGraphics.FillRectangle(Brushes.Blue, rPaddle);
					
					sGraphics.DrawImage(btm, 0, 0, this.Width, this.Height);
					
					
				}
					
			}
			
			private void mouseMove_1(object sender, MouseEventArgs e)
			{
				movePaddle = e.Location;
			}
			
			private void mouseClick_1(object sender, MouseEventArgs e)
			{
				moveBall = e.Location;
			}
		}
	}

