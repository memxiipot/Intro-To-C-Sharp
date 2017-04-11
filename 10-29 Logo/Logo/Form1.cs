using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }  
        

        private void button1_Click(object sender, EventArgs e)
        {
            

            

            
            //Label a = new Label();
            //a.Size = new Size(270, 60);
            //a.Font = new Font("Tahoma", 40);
            //a.Location = new Point(205, 235);
            //a.BackColor = ColorTranslator.FromHtml("#c4d0a2");
            //a.ForeColor = Color.Black;
            //a.Text = "Pokemon!";
            //Controls.Add(a);


            Graphics g;
            Pen p0;
            Pen p1;
            Pen p2;
            Pen p3;
            Pen p4;
            Pen p5;
            Pen p6;
            Pen p7;
            Brush b0;
            Brush b1;
            Brush b2;

            g = this.CreateGraphics();
            p0 = new Pen(Color.White, 5);
            p1 = new Pen(Color.Black, 5);
            p2 = new Pen(ColorTranslator.FromHtml("#ffb700"), 5);
            p3 = new Pen(ColorTranslator.FromHtml("#ffdd00"), 5);
            p4 = new Pen(ColorTranslator.FromHtml("#ee0048"), 5);
            p5 = new Pen(Color.Red, 5);
            p6 = new Pen(Color.LightGray, 5);
            p7 = new Pen(Color.Firebrick, 5);
            b0 = new SolidBrush(ColorTranslator.FromHtml("#4d5794"));
            b1 = new SolidBrush(Color.Black);
            b2 = new SolidBrush(ColorTranslator.FromHtml("#323963"));

            //background
            g.FillRectangle(b1, 110, 30, 440, 340);
            g.FillRectangle(b0, 130, 50, 400, 300);
            g.FillRectangle(b2, 130, 50, 20, 300);
            g.FillRectangle(b2, 130, 330, 400, 20);

            //pokeball
            g.DrawLine(p1, 210, 170, 215, 170);
            g.DrawLine(p1, 210, 175, 215, 175);
            g.DrawLine(p1, 210, 180, 215, 180);
            g.DrawLine(p1, 210, 185, 215, 185);
            g.DrawLine(p1, 210, 190, 215, 190);

            g.DrawLine(p1, 215, 165, 220, 165);
            g.DrawLine(p1, 215, 170, 220, 170);
            g.DrawLine(p7, 215, 175, 220, 175);
            g.DrawLine(p1, 215, 180, 220, 180);
            g.DrawLine(p6, 215, 185, 220, 185);
            g.DrawLine(p1, 215, 190, 220, 190);
            g.DrawLine(p1, 215, 195, 220, 195);

            g.DrawLine(p1, 220, 160, 225, 160);
            g.DrawLine(p1, 220, 165, 225, 165);
            g.DrawLine(p7, 220, 170, 225, 170);
            g.DrawLine(p7, 220, 175, 225, 175);
            g.DrawLine(p1, 220, 180, 225, 180);
            g.DrawLine(p6, 220, 185, 225, 185);
            g.DrawLine(p6, 220, 190, 225, 190);
            g.DrawLine(p1, 220, 195, 225, 195);
            g.DrawLine(p1, 220, 200, 225, 200);

            g.DrawLine(p1, 225, 160, 230, 160);
            g.DrawLine(p7, 225, 165, 230, 165);
            g.DrawLine(p7, 225, 170, 230, 170);
            g.DrawLine(p1, 225, 175, 230, 175);
            g.DrawLine(p1, 225, 180, 230, 180);
            g.DrawLine(p1, 225, 185, 230, 185);
            g.DrawLine(p6, 225, 190, 230, 190);
            g.DrawLine(p6, 225, 195, 230, 195);
            g.DrawLine(p1, 225, 200, 230, 200);

            g.DrawLine(p1, 230, 160, 235, 160);
            g.DrawLine(p7, 230, 165, 235, 165);
            g.DrawLine(p5, 230, 170, 235, 170);
            g.DrawLine(p1, 230, 175, 235, 175);
            g.DrawLine(p6, 230, 180, 235, 180);
            g.DrawLine(p1, 230, 185, 235, 185);
            g.DrawLine(p0, 230, 190, 235, 190);
            g.DrawLine(p6, 230, 195, 235, 195);
            g.DrawLine(p1, 230, 200, 235, 200);

            g.DrawLine(p1, 235, 160, 240, 160);
            g.DrawLine(p7, 235, 165, 240, 165);
            g.DrawLine(p5, 235, 170, 240, 170);
            g.DrawLine(p1, 235, 175, 240, 175);
            g.DrawLine(p1, 235, 180, 240, 180);
            g.DrawLine(p1, 235, 185, 240, 185);
            g.DrawLine(p0, 235, 190, 240, 190);
            g.DrawLine(p6, 235, 195, 240, 195);
            g.DrawLine(p1, 235, 200, 240, 200);

            g.DrawLine(p1, 240, 160, 245, 160);
            g.DrawLine(p1, 240, 165, 245, 165);
            g.DrawLine(p5, 240, 170, 245, 170);
            g.DrawLine(p5, 240, 175, 245, 175);
            g.DrawLine(p1, 240, 180, 245, 180);
            g.DrawLine(p0, 240, 185, 245, 185);
            g.DrawLine(p0, 240, 190, 245, 190);
            g.DrawLine(p1, 240, 195, 245, 195);
            g.DrawLine(p1, 240, 200, 245, 200);

            g.DrawLine(p1, 245, 165, 250, 165);
            g.DrawLine(p1, 245, 170, 250, 170);
            g.DrawLine(p5, 245, 175, 250, 175);
            g.DrawLine(p1, 245, 180, 250, 180);
            g.DrawLine(p0, 245, 185, 250, 185);
            g.DrawLine(p1, 245, 190, 250, 190);
            g.DrawLine(p1, 245, 195, 250, 195);

            g.DrawLine(p1, 250, 170, 255, 170);
            g.DrawLine(p1, 250, 175, 255, 175);
            g.DrawLine(p1, 250, 180, 255, 180);
            g.DrawLine(p1, 250, 185, 255, 185);
            g.DrawLine(p1, 250, 190, 255, 190);



            //pikachu
            g.DrawLine(p1, 295, 80, 300, 80);
            g.DrawLine(p1, 300, 85, 305, 85);

            g.DrawLine(p1, 280, 105, 285, 105);
            g.DrawLine(p1, 280, 110, 285, 110);

            g.DrawLine(p1, 285, 105, 290, 105);
            g.DrawLine(p1, 285, 110, 290, 110);
            g.DrawLine(p1, 285, 115, 290, 115);

            g.DrawLine(p1, 290, 85, 295, 85);
            g.DrawLine(p1, 290, 90, 295, 90);
            g.DrawLine(p1, 290, 95, 295, 95);
            g.DrawLine(p1, 290, 100, 295, 100);
            g.DrawLine(p1, 290, 105, 295, 105);
            g.DrawLine(p2, 290, 110, 295, 110);
            g.DrawLine(p1, 290, 115, 295, 115);
            g.DrawLine(p1, 295, 80, 300, 80);
            g.DrawLine(p3, 295, 85, 300, 85);
            g.DrawLine(p3, 295, 90, 300, 90);
            g.DrawLine(p3, 295, 95, 300, 95);
            g.DrawLine(p3, 295, 100, 300, 100);
            g.DrawLine(p1, 295, 105, 300, 105);
            g.DrawLine(p3, 295, 110, 300, 110);
            g.DrawLine(p2, 295, 115, 300, 115);
            g.DrawLine(p1, 295, 120, 300, 120);
            g.DrawLine(p1, 295, 140, 300, 140);
            g.DrawLine(p1, 295, 145, 300, 145);
            g.DrawLine(p1, 295, 150, 300, 150);
            g.DrawLine(p1, 295, 165, 300, 165);
            g.DrawLine(p1, 295, 170, 300, 170);
            g.DrawLine(p1, 295, 175, 300, 175);
            g.DrawLine(p1, 295, 180, 300, 180);
            g.DrawLine(p1, 295, 185, 300, 185);
            g.DrawLine(p1, 295, 195, 300, 195);

            g.DrawLine(p1, 300, 85, 305, 85);
            g.DrawLine(p3, 300, 90, 305, 90);
            g.DrawLine(p3, 300, 95, 305, 95);
            g.DrawLine(p3, 300, 100, 305, 100);
            g.DrawLine(p1, 300, 105, 305, 105);
            g.DrawLine(p2, 300, 110, 305, 110);
            g.DrawLine(p3, 300, 115, 305, 115);
            g.DrawLine(p1, 300, 120, 305, 120);
            g.DrawLine(p1, 300, 125, 305, 125);
            g.DrawLine(p1, 300, 130, 305, 130);
            g.DrawLine(p1, 300, 135, 305, 135);
            g.DrawLine(p1, 300, 140, 305, 140);
            g.DrawLine(p4, 300, 145, 305, 145);
            g.DrawLine(p1, 300, 150, 305, 150);
            g.DrawLine(p1, 300, 155, 305, 155);
            g.DrawLine(p1, 300, 160, 305, 160);
            g.DrawLine(p1, 300, 165, 305, 165);
            g.DrawLine(p2, 300, 170, 305, 170);
            g.DrawLine(p3, 300, 175, 305, 175);
            g.DrawLine(p3, 300, 180, 305, 180);
            g.DrawLine(p1, 300, 185, 305, 185);
            g.DrawLine(p1, 300, 190, 305, 190);
            g.DrawLine(p3, 300, 195, 305, 195);
            g.DrawLine(p1, 300, 200, 305, 200);

            g.DrawLine(p1, 305, 90, 310, 90);
            g.DrawLine(p3, 305, 95, 310, 95);
            g.DrawLine(p3, 305, 100, 310, 100);
            g.DrawLine(p1, 305, 105, 310, 105);
            g.DrawLine(p1, 305, 110, 310, 110);
            g.DrawLine(p3, 305, 115, 310, 115);
            g.DrawLine(p2, 305, 120, 310, 120);
            g.DrawLine(p1, 305, 125, 310, 125);
            g.DrawLine(p2, 305, 130, 310, 130);
            g.DrawLine(p3, 305, 135, 310, 135);
            g.DrawLine(p3, 305, 140, 310, 140);
            g.DrawLine(p4, 305, 145, 310, 145);
            g.DrawLine(p4, 305, 150, 310, 150);
            g.DrawLine(p1, 305, 155, 310, 155);
            g.DrawLine(p2, 305, 160, 310, 160);
            g.DrawLine(p3, 305, 165, 310, 165);
            g.DrawLine(p3, 305, 170, 310, 170);
            g.DrawLine(p3, 305, 175, 310, 175);
            g.DrawLine(p1, 305, 180, 310, 180);
            g.DrawLine(p2, 305, 185, 310, 185);
            g.DrawLine(p1, 305, 190, 310, 190);
            g.DrawLine(p3, 305, 195, 310, 195);
            g.DrawLine(p1, 305, 200, 310, 200);

            g.DrawLine(p1, 310, 95, 315, 95);
            g.DrawLine(p3, 310, 100, 315, 100);
            g.DrawLine(p1, 310, 105, 315, 105);
            g.DrawLine(p1, 310, 110, 315, 110);
            g.DrawLine(p3, 310, 115, 315, 115);
            g.DrawLine(p3, 310, 120, 315, 120);
            g.DrawLine(p2, 310, 125, 315, 125);
            g.DrawLine(p3, 310, 130, 315, 130);
            g.DrawLine(p1, 310, 135, 315, 135);
            g.DrawLine(p1, 310, 140, 315, 140);
            g.DrawLine(p3, 310, 145, 315, 145);
            g.DrawLine(p4, 310, 150, 315, 150);
            g.DrawLine(p2, 310, 155, 315, 155);
            g.DrawLine(p3, 310, 160, 315, 160);
            g.DrawLine(p3, 310, 165, 315, 165);
            g.DrawLine(p2, 310, 170, 315, 170);
            g.DrawLine(p1, 310, 175, 315, 175);
            g.DrawLine(p3, 310, 180, 315, 180);
            g.DrawLine(p3, 310, 185, 315, 185);
            g.DrawLine(p2, 310, 190, 315, 190);
            g.DrawLine(p1, 310, 195, 315, 195);
            g.DrawLine(p1, 310, 200, 315, 200);

            g.DrawLine(p1, 315, 100, 320, 100);
            g.DrawLine(p3, 315, 105, 320, 105);
            g.DrawLine(p1, 315, 110, 320, 110);
            g.DrawLine(p2, 315, 115, 320, 115);
            g.DrawLine(p3, 315, 120, 320, 120);
            g.DrawLine(p3, 315, 125, 320, 125);
            g.DrawLine(p3, 315, 130, 320, 130);
            g.DrawLine(p0, 315, 135, 320, 135);
            g.DrawLine(p1, 315, 140, 320, 140);
            g.DrawLine(p3, 315, 145, 320, 145);
            g.DrawLine(p3, 315, 150, 320, 150);
            g.DrawLine(p3, 315, 155, 320, 155);
            g.DrawLine(p2, 315, 160, 320, 160);
            g.DrawLine(p3, 315, 165, 320, 165);
            g.DrawLine(p3, 315, 170, 320, 170);
            g.DrawLine(p3, 315, 175, 320, 175);
            g.DrawLine(p3, 315, 180, 320, 180);
            g.DrawLine(p3, 315, 185, 320, 185);
            g.DrawLine(p3, 315, 190, 320, 190);
            g.DrawLine(p1, 315, 195, 320, 195);

            g.DrawLine(p1, 320, 105, 325, 105);
            g.DrawLine(p1, 320, 110, 325, 110);
            g.DrawLine(p3, 320, 115, 325, 115);
            g.DrawLine(p3, 320, 120, 325, 120);
            g.DrawLine(p3, 320, 125, 325, 125);
            g.DrawLine(p3, 320, 130, 325, 130);
            g.DrawLine(p3, 320, 135, 325, 135);
            g.DrawLine(p3, 320, 140, 325, 140);
            g.DrawLine(p3, 320, 145, 325, 145);
            g.DrawLine(p3, 320, 150, 325, 150);
            g.DrawLine(p3, 320, 155, 325, 155);
            g.DrawLine(p3, 320, 160, 325, 160);
            g.DrawLine(p3, 320, 165, 325, 165);
            g.DrawLine(p3, 320, 170, 325, 170);
            g.DrawLine(p3, 320, 175, 325, 175);
            g.DrawLine(p3, 320, 180, 325, 180);
            g.DrawLine(p3, 320, 185, 325, 185);
            g.DrawLine(p2, 320, 190, 325, 190);
            g.DrawLine(p1, 320, 195, 325, 195);

            g.DrawLine(p1, 325, 110, 330, 110);
            g.DrawLine(p3, 325, 115, 330, 115);
            g.DrawLine(p3, 325, 120, 330, 120);
            g.DrawLine(p3, 325, 125, 330, 125);
            g.DrawLine(p3, 325, 130, 330, 130);
            g.DrawLine(p3, 325, 135, 330, 135);
            g.DrawLine(p3, 325, 140, 330, 140);
            g.DrawLine(p3, 325, 145, 330, 145);
            g.DrawLine(p3, 325, 150, 330, 150);
            g.DrawLine(p2, 325, 155, 330, 155);
            g.DrawLine(p3, 325, 160, 330, 160);
            g.DrawLine(p2, 325, 165, 330, 165);
            g.DrawLine(p3, 325, 170, 330, 170);
            g.DrawLine(p3, 325, 175, 330, 175);
            g.DrawLine(p3, 325, 180, 330, 180);
            g.DrawLine(p3, 325, 185, 330, 185);
            g.DrawLine(p1, 325, 190, 330, 190);
            g.DrawLine(p1, 325, 195, 330, 195);

            g.DrawLine(p1, 330, 110, 335, 110);
            g.DrawLine(p3, 330, 115, 335, 115);
            g.DrawLine(p3, 330, 120, 335, 120);
            g.DrawLine(p3, 330, 125, 335, 125);
            g.DrawLine(p3, 330, 130, 335, 130);
            g.DrawLine(p3, 330, 135, 335, 135);
            g.DrawLine(p3, 330, 140, 335, 140);
            g.DrawLine(p1, 330, 145, 335, 145);
            g.DrawLine(p3, 330, 150, 335, 150);
            g.DrawLine(p1, 330, 155, 335, 155);
            g.DrawLine(p3, 330, 160, 335, 160);
            g.DrawLine(p2, 330, 165, 335, 165);
            g.DrawLine(p2, 330, 170, 335, 170);
            g.DrawLine(p3, 330, 175, 335, 175);
            g.DrawLine(p3, 330, 180, 335, 180);
            g.DrawLine(p3, 330, 185, 335, 185);
            g.DrawLine(p1, 330, 190, 335, 190);
            g.DrawLine(p1, 330, 195, 335, 195);

            g.DrawLine(p1, 335, 110, 340, 110);
            g.DrawLine(p3, 335, 115, 340, 115);
            g.DrawLine(p3, 335, 120, 340, 120);
            g.DrawLine(p3, 335, 125, 340, 125);
            g.DrawLine(p3, 335, 130, 340, 130);
            g.DrawLine(p3, 335, 135, 340, 135);
            g.DrawLine(p3, 335, 140, 340, 140);
            g.DrawLine(p3, 335, 145, 340, 145);
            g.DrawLine(p3, 335, 150, 340, 150);
            g.DrawLine(p2, 335, 155, 340, 155);
            g.DrawLine(p3, 335, 160, 340, 160);
            g.DrawLine(p2, 335, 165, 340, 165);
            g.DrawLine(p3, 335, 170, 340, 170);
            g.DrawLine(p3, 335, 175, 340, 175);
            g.DrawLine(p3, 335, 180, 340, 180);
            g.DrawLine(p3, 335, 185, 340, 185);
            g.DrawLine(p1, 335, 190, 340, 190);
            g.DrawLine(p1, 335, 195, 340, 195);

            g.DrawLine(p1, 340, 110, 345, 110);
            g.DrawLine(p3, 340, 115, 345, 115);
            g.DrawLine(p3, 340, 120, 345, 120);
            g.DrawLine(p3, 340, 125, 345, 125);
            g.DrawLine(p3, 340, 130, 345, 130);
            g.DrawLine(p3, 340, 135, 345, 135);
            g.DrawLine(p3, 340, 140, 345, 140);
            g.DrawLine(p3, 340, 145, 345, 145);
            g.DrawLine(p3, 340, 150, 345, 150);
            g.DrawLine(p3, 340, 155, 345, 155);
            g.DrawLine(p3, 340, 160, 345, 160);
            g.DrawLine(p3, 340, 165, 345, 165);
            g.DrawLine(p3, 340, 170, 345, 170);
            g.DrawLine(p3, 340, 175, 345, 175);
            g.DrawLine(p3, 340, 180, 345, 180);
            g.DrawLine(p3, 340, 185, 345, 185);
            g.DrawLine(p2, 340, 190, 345, 190);
            g.DrawLine(p1, 340, 195, 345, 195);

            g.DrawLine(p1, 345, 105, 350, 105);
            g.DrawLine(p1, 345, 110, 350, 110);
            g.DrawLine(p2, 345, 115, 350, 115);
            g.DrawLine(p3, 345, 120, 350, 120);
            g.DrawLine(p3, 345, 125, 350, 125);
            g.DrawLine(p3, 345, 130, 350, 130);
            g.DrawLine(p1, 345, 135, 350, 135);
            g.DrawLine(p1, 345, 140, 350, 140);
            g.DrawLine(p3, 345, 145, 350, 145);
            g.DrawLine(p3, 345, 150, 350, 150);
            g.DrawLine(p3, 345, 155, 350, 155);
            g.DrawLine(p2, 345, 160, 350, 160);
            g.DrawLine(p3, 345, 165, 350, 165);
            g.DrawLine(p3, 345, 170, 350, 170);
            g.DrawLine(p3, 345, 175, 350, 175);
            g.DrawLine(p3, 345, 180, 350, 180);
            g.DrawLine(p3, 345, 185, 350, 185);
            g.DrawLine(p3, 345, 190, 350, 190);
            g.DrawLine(p1, 345, 195, 350, 195);

            g.DrawLine(p1, 350, 100, 355, 100);
            g.DrawLine(p1, 350, 105, 355, 105);
            g.DrawLine(p3, 350, 110, 355, 110);
            g.DrawLine(p3, 350, 115, 355, 115);
            g.DrawLine(p3, 350, 120, 355, 120);
            g.DrawLine(p3, 350, 125, 355, 125);
            g.DrawLine(p3, 350, 130, 355, 130);
            g.DrawLine(p0, 350, 135, 355, 135);
            g.DrawLine(p1, 350, 140, 355, 140);
            g.DrawLine(p3, 350, 145, 355, 145);
            g.DrawLine(p4, 350, 150, 355, 150);
            g.DrawLine(p2, 350, 155, 355, 155);
            g.DrawLine(p3, 350, 160, 355, 160);
            g.DrawLine(p3, 350, 165, 355, 165);
            g.DrawLine(p2, 350, 170, 355, 170);
            g.DrawLine(p1, 350, 175, 355, 175);
            g.DrawLine(p3, 350, 180, 355, 180);
            g.DrawLine(p3, 350, 185, 355, 185);
            g.DrawLine(p2, 350, 190, 355, 190);
            g.DrawLine(p1, 350, 195, 355, 195);
            g.DrawLine(p1, 350, 200, 355, 200);

            g.DrawLine(p1, 355, 90, 360, 90);
            g.DrawLine(p1, 355, 95, 360, 95);
            g.DrawLine(p3, 355, 100, 360, 100);
            g.DrawLine(p3, 355, 105, 360, 105);
            g.DrawLine(p3, 355, 110, 360, 110);
            g.DrawLine(p3, 355, 115, 360, 115);
            g.DrawLine(p2, 355, 120, 360, 120);
            g.DrawLine(p1, 355, 125, 360, 125);
            g.DrawLine(p2, 355, 130, 360, 130);
            g.DrawLine(p3, 355, 135, 360, 135);
            g.DrawLine(p3, 355, 140, 360, 140);
            g.DrawLine(p4, 355, 145, 360, 145);
            g.DrawLine(p4, 355, 150, 360, 150);
            g.DrawLine(p1, 355, 155, 360, 155);
            g.DrawLine(p2, 355, 160, 360, 160);
            g.DrawLine(p3, 355, 165, 360, 165);
            g.DrawLine(p3, 355, 170, 360, 170);
            g.DrawLine(p3, 355, 175, 360, 175);
            g.DrawLine(p1, 355, 180, 360, 180);
            g.DrawLine(p2, 355, 185, 360, 185);
            g.DrawLine(p1, 355, 190, 360, 190);
            g.DrawLine(p3, 355, 195, 360, 195);
            g.DrawLine(p1, 355, 200, 360, 200);

            g.DrawLine(p1, 360, 85, 365, 85);
            g.DrawLine(p1, 360, 90, 365, 90);
            g.DrawLine(p1, 360, 95, 365, 95);
            g.DrawLine(p1, 360, 100, 365, 100);
            g.DrawLine(p2, 360, 105, 365, 105);
            g.DrawLine(p1, 360, 110, 365, 110);
            g.DrawLine(p1, 360, 115, 365, 115);
            g.DrawLine(p1, 360, 120, 365, 120);
            g.DrawLine(p1, 360, 125, 365, 125);
            g.DrawLine(p1, 360, 130, 365, 130);
            g.DrawLine(p1, 360, 135, 365, 135);
            g.DrawLine(p1, 360, 140, 365, 140);
            g.DrawLine(p4, 360, 145, 365, 145);
            g.DrawLine(p1, 360, 150, 365, 150);
            g.DrawLine(p1, 360, 155, 365, 155);
            g.DrawLine(p1, 360, 160, 365, 160);
            g.DrawLine(p1, 360, 165, 365, 165);
            g.DrawLine(p2, 360, 170, 365, 170);
            g.DrawLine(p3, 360, 175, 365, 175);
            g.DrawLine(p3, 360, 180, 365, 180);
            g.DrawLine(p1, 360, 185, 365, 185);
            g.DrawLine(p1, 360, 190, 365, 190);
            g.DrawLine(p3, 360, 195, 365, 195);
            g.DrawLine(p1, 360, 200, 365, 200);

            g.DrawLine(p1, 365, 85, 370, 85);
            g.DrawLine(p1, 365, 90, 370, 90);
            g.DrawLine(p1, 365, 95, 370, 95);
            g.DrawLine(p1, 365, 100, 370, 100);
            g.DrawLine(p1, 365, 105, 370, 105);
            g.DrawLine(p1, 365, 110, 370, 110);

            g.DrawLine(p1, 365, 140, 370, 140);
            g.DrawLine(p1, 365, 145, 370, 145);
            g.DrawLine(p1, 365, 150, 370, 150);

            g.DrawLine(p1, 365, 165, 370, 165);
            g.DrawLine(p1, 365, 170, 370, 170);
            g.DrawLine(p1, 365, 175, 370, 175);
            g.DrawLine(p1, 365, 180, 370, 180);
            g.DrawLine(p1, 365, 185, 370, 185);

            g.DrawLine(p1, 365, 195, 370, 195);



            //pokeball
            g.DrawLine(p1, 410, 170, 415, 170);
            g.DrawLine(p1, 410, 175, 415, 175);
            g.DrawLine(p1, 410, 180, 415, 180);
            g.DrawLine(p1, 410, 185, 415, 185);
            g.DrawLine(p1, 410, 190, 415, 190);

            g.DrawLine(p1, 415, 165, 420, 165);
            g.DrawLine(p1, 415, 170, 420, 170);
            g.DrawLine(p7, 415, 175, 420, 175);
            g.DrawLine(p1, 415, 180, 420, 180);
            g.DrawLine(p6, 415, 185, 420, 185);
            g.DrawLine(p1, 415, 190, 420, 190);
            g.DrawLine(p1, 415, 195, 420, 195);

            g.DrawLine(p1, 420, 160, 425, 160);
            g.DrawLine(p1, 420, 165, 425, 165);
            g.DrawLine(p7, 420, 170, 425, 170);
            g.DrawLine(p7, 420, 175, 425, 175);
            g.DrawLine(p1, 420, 180, 425, 180);
            g.DrawLine(p6, 420, 185, 425, 185);
            g.DrawLine(p6, 420, 190, 425, 190);
            g.DrawLine(p1, 420, 195, 425, 195);
            g.DrawLine(p1, 420, 200, 425, 200);

            g.DrawLine(p1, 425, 160, 430, 160);
            g.DrawLine(p7, 425, 165, 430, 165);
            g.DrawLine(p7, 425, 170, 430, 170);
            g.DrawLine(p1, 425, 175, 430, 175);
            g.DrawLine(p1, 425, 180, 430, 180);
            g.DrawLine(p1, 425, 185, 430, 185);
            g.DrawLine(p6, 425, 190, 430, 190);
            g.DrawLine(p6, 425, 195, 430, 195);
            g.DrawLine(p1, 425, 200, 430, 200);

            g.DrawLine(p1, 430, 160, 435, 160);
            g.DrawLine(p7, 430, 165, 435, 165);
            g.DrawLine(p5, 430, 170, 435, 170);
            g.DrawLine(p1, 430, 175, 435, 175);
            g.DrawLine(p6, 430, 180, 435, 180);
            g.DrawLine(p1, 430, 185, 435, 185);
            g.DrawLine(p0, 430, 190, 435, 190);
            g.DrawLine(p6, 430, 195, 435, 195);
            g.DrawLine(p1, 430, 200, 435, 200);

            g.DrawLine(p1, 435, 160, 440, 160);
            g.DrawLine(p7, 435, 165, 440, 165);
            g.DrawLine(p5, 435, 170, 440, 170);
            g.DrawLine(p1, 435, 175, 440, 175);
            g.DrawLine(p1, 435, 180, 440, 180);
            g.DrawLine(p1, 435, 185, 440, 185);
            g.DrawLine(p0, 435, 190, 440, 190);
            g.DrawLine(p6, 435, 195, 440, 195);
            g.DrawLine(p1, 435, 200, 440, 200);

            g.DrawLine(p1, 440, 160, 445, 160);
            g.DrawLine(p1, 440, 165, 445, 165);
            g.DrawLine(p5, 440, 170, 445, 170);
            g.DrawLine(p5, 440, 175, 445, 175);
            g.DrawLine(p1, 440, 180, 445, 180);
            g.DrawLine(p0, 440, 185, 445, 185);
            g.DrawLine(p0, 440, 190, 445, 190);
            g.DrawLine(p1, 440, 195, 445, 195);
            g.DrawLine(p1, 440, 200, 445, 200);

            g.DrawLine(p1, 445, 165, 450, 165);
            g.DrawLine(p1, 445, 170, 450, 170);
            g.DrawLine(p5, 445, 175, 450, 175);
            g.DrawLine(p1, 445, 180, 450, 180);
            g.DrawLine(p0, 445, 185, 450, 185);
            g.DrawLine(p1, 445, 190, 450, 190);
            g.DrawLine(p1, 445, 195, 450, 195);

            g.DrawLine(p1, 450, 170, 455, 170);
            g.DrawLine(p1, 450, 175, 455, 175);
            g.DrawLine(p1, 450, 180, 455, 180);
            g.DrawLine(p1, 450, 185, 455, 185);
            g.DrawLine(p1, 450, 190, 455, 190);
             
        }
            
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Image imag = Image.FromFile(@"logo.gif", true);
            e.Graphics.DrawImage(imag, new Point(40, 0)); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        

        



    }
}
