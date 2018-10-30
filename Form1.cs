using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Hàm màu
        public void CapNhatMau()     
        {
            Label[,] Game = {
                                {lbl1,lbl2,lbl3,lbl4},
                                {lbl5,lbl6,lbl7,lbl8},
                                {lbl9,lbl10,lbl11,lbl12},
                                {lbl13,lbl14,lbl15,lbl16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (Game[i, j].Text == "")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.CadetBlue;
                    }
                    if (Game[i, j].Text == "2")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Silver;
                        Game[i, j].ForeColor = System.Drawing.Color.White;

                    }
                    if (Game[i, j].Text == "4")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Gray;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "8")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "16")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Black;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "32")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Yellow;
                        Game[i, j].ForeColor = System.Drawing.Color.Silver;
                    }
                    if (Game[i, j].Text == "64")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "128")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Olive;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "256")
                    {
                        Game[i, j].BackColor = Color.Gold;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "512")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "1024")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "2048")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
                        Game[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                    }
                    if (Game[i, j].Text == "4096")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                        Game[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                    }
                    if (Game[i, j].Text == "8192")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Maroon;
                        Game[i, j].ForeColor = System.Drawing.Color.Yellow;
                    }
                }
            }
        }
    }
}
