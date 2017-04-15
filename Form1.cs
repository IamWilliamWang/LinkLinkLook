using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkLinkLook
{
    public partial class Form1 : Form
    {
        int nil = 0;

        int[,] cells = new int[,] { {100, 0, 0, 0, 0, 0, 0,100},
                                    {  0, 1, 2, 3, 3, 4, 5,  0},
                                    {  0, 6, 7, 6, 7, 8, 9,  0},
                                    {  0, 2,10,11,12,13, 5,  0},
                                    {  0, 1,14,11, 4,13, 8,  0},
                                    {  0,15,15,14,16,12,17,  0},
                                    {  0,18,10,18,16,17, 9,  0},
                                    {100, 0, 0, 0, 0, 0, 0,100} };

        int firstPointX = 1, firstPointY = 1;
        enum ClickStates {firstClick,secondClick};
        ClickStates states = ClickStates.secondClick;

        public Form1()
        {
            InitializeComponent();
        }

        private void setXY(int x,int y)
        {
            this.firstPointX = x;
            this.firstPointY = y;
        }

        private bool canFind(int nowX,int nowY,int arriveX,int arriveY,bool[,] visited)
        {

            if (nowX < 0 || nowX > 7 || nowY < 0 || nowY > 7) //如果溢出
            {
                return false;
            }
            if (visited[nowX, nowY] == true)//遍历到外面
            {
                if (nowX == arriveX && nowY == arriveY)//发现目标
                {
                    return true;
                }
                else
                    return false;
            }

            visited[nowX, nowY] = true;

            if(canFind(nowX+1,nowY,arriveX,arriveY,visited) ||
                canFind(nowX-1,nowY, arriveX, arriveY, visited) ||
                canFind(nowX,nowY-1, arriveX, arriveY, visited) ||
                canFind(nowX, nowY + 1, arriveX, arriveY, visited))
            {
                return true;
            }
            else
            return false;
        }

        private bool checkCurrect(int firstX,int firstY,int secondX,int secondY)
        {
            bool[,] visited = new bool[8, 8];//将所有不可遍历的点标出来
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (this.cells[i, j] != this.nil)
                        visited[i, j] = true;
                    else
                        visited[i, j] = false;
                }
            visited[firstX, firstY] = false;
            //如果两个长的不一样
            if (cells[firstX, firstY] != cells[secondX, secondY])
                return false;
            
            if(canFind(firstX, firstY, secondX,secondY,visited))
            {
                return true;
            }
            else
            return false;
        }

        private void updateTextBoxes(int x,int y)
        {
            //代码为了调试用，已删除
        }

        private void changeStates()
        {
            if (this.states == ClickStates.firstClick)
                this.states = ClickStates.secondClick;
            else if (this.states == ClickStates.secondClick)
                this.states = ClickStates.firstClick;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int myX = 1, myY = 1;

            //防止点空位置
            if (pictureBox1.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states==ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox1.Visible = false;
                    this.pictureBox19.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int myX = 1, myY = 2;

            //防止点空位置
            if (pictureBox2.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox2.Visible = false;
                    this.pictureBox13.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int myX = 1, myY = 3;

            //防止点空位置
            if (pictureBox3.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox3.Visible = false;
                    this.pictureBox4.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int myX = 1, myY = 4;

            //防止点空位置
            if (pictureBox4.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox4.Visible = false;
                    this.pictureBox3.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int myX = 1, myY = 5;

            //防止点空位置
            if (pictureBox5.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox5.Visible = false;
                    this.pictureBox22.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int myX = 1, myY = 6;

            //防止点空位置
            if (pictureBox6.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox6.Visible = false;
                    this.pictureBox18.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int myX = 2, myY = 1;

            //防止点空位置
            if (pictureBox7.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox7.Visible = false;
                    this.pictureBox9.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int myX = 2, myY = 2;

            //防止点空位置
            if (pictureBox8.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox8.Visible = false;
                    this.pictureBox10.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int myX = 2, myY = 3;

            //防止点空位置
            if (pictureBox9.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox9.Visible = false;
                    this.pictureBox7.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int myX = 2, myY = 4;

            //防止点空位置
            if (pictureBox10.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox10.Visible = false;
                    this.pictureBox8.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            int myX = 2, myY = 5;

            //防止点空位置
            if (pictureBox11.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox11.Visible = false;
                    this.pictureBox24.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int myX = 2, myY = 6;

            //防止点空位置
            if (pictureBox12.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox12.Visible = false;
                    this.pictureBox36.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            int myX = 3, myY = 1;

            //防止点空位置
            if (pictureBox13.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox13.Visible = false;
                    this.pictureBox2.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            int myX = 3, myY = 2;

            //防止点空位置
            if (pictureBox14.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox14.Visible = false;
                    this.pictureBox32.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            int myX = 3, myY = 3;

            //防止点空位置
            if (pictureBox15.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox15.Visible = false;
                    this.pictureBox21.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            int myX = 3, myY = 4;

            //防止点空位置
            if (pictureBox16.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox16.Visible = false;
                    this.pictureBox29.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            int myX = 3, myY = 5;

            //防止点空位置
            if (pictureBox17.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox17.Visible = false;
                    this.pictureBox23.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            int myX = 3, myY = 6;

            //防止点空位置
            if (pictureBox18.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox18.Visible = false;
                    this.pictureBox6.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            int myX = 4, myY = 1;

            //防止点空位置
            if (pictureBox19.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox1.Visible = false;
                    this.pictureBox19.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {int myX = 4, myY = 2;

            //防止点空位置
            if (pictureBox20.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states==ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox20.Visible = false;
                    this.pictureBox27.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            int myX = 4, myY = 3;

            //防止点空位置
            if (pictureBox21.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox21.Visible = false;
                    this.pictureBox15.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            int myX = 4, myY = 4;

            //防止点空位置
            if (pictureBox22.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox5.Visible = false;
                    this.pictureBox22.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            int myX = 4, myY = 5;

            //防止点空位置
            if (pictureBox23.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox17.Visible = false;
                    this.pictureBox23.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            int myX = 4, myY = 6;

            //防止点空位置
            if (pictureBox24.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox11.Visible = false;
                    this.pictureBox24.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            int myX = 5, myY = 1;

            //防止点空位置
            if (pictureBox25.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox25.Visible = false;
                    this.pictureBox26.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            int myX = 5, myY = 2;

            //防止点空位置
            if (pictureBox26.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox25.Visible = false;
                    this.pictureBox26.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            int myX = 5, myY = 3;

            //防止点空位置
            if (pictureBox27.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox20.Visible = false;
                    this.pictureBox27.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            int myX = 5, myY = 4;

            //防止点空位置
            if (pictureBox28.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox28.Visible = false;
                    this.pictureBox34.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            int myX = 5, myY = 5;

            //防止点空位置
            if (pictureBox29.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox16.Visible = false;
                    this.pictureBox29.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            int myX = 5, myY = 6;

            //防止点空位置
            if (pictureBox30.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox30.Visible = false;
                    this.pictureBox35.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            int myX = 6, myY = 1;

            //防止点空位置
            if (pictureBox31.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox31.Visible = false;
                    this.pictureBox33.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            int myX = 6, myY = 2;

            //防止点空位置
            if (pictureBox32.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox14.Visible = false;
                    this.pictureBox32.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            int myX = 6, myY = 3;

            //防止点空位置
            if (pictureBox33.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox31.Visible = false;
                    this.pictureBox33.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            int myX = 6, myY = 4;

            //防止点空位置
            if (pictureBox34.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox28.Visible = false;
                    this.pictureBox34.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            int myX = 6, myY = 5;

            //防止点空位置
            if (pictureBox35.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox35.Visible = false;
                    this.pictureBox30.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            int myX = 6, myY = 6;

            //防止点空位置
            if (pictureBox36.Visible == false)
            {
                this.states = ClickStates.secondClick;
                return;
            }
            //先更新点击状态
            changeStates();


            updateTextBoxes(myX, myY);
            if (states == ClickStates.firstClick)
            {
                this.setXY(myX, myY);
            }
            else
            {
                if (this.checkCurrect(firstPointX, firstPointY, myX, myY))
                {
                    this.pictureBox12.Visible = false;
                    this.pictureBox36.Visible = false;
                    this.cells[firstPointX, firstPointY] = this.nil;//给点置空值
                    this.cells[myX, myY] = this.nil;
                }
            }
        }
    }
}
