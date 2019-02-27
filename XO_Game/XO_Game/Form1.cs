using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i;
        bool flag = false;
        bool f = false;
        bool Of = false;
        bool Xf = false;
        int numberGame = 0; 
        int OWin = 0; 
        int XWin = 0; 
        string[] arr = new string[10]; 
        Button[] butt = new Button[10];

        public void refresch()
        {
            flag = false;

            butt[1] = button1;
            butt[2] = button2;
            butt[3] = button3;
            butt[4] = button4;
            butt[5] = button5;
            butt[6] = button6;
            butt[7] = button7;
            butt[8] = button8;
            butt[9] = button9;

            for(int i = 1; i < butt.Length; i++)
            {
                butt[i].Enabled = true;
                butt[i].Text = "";
            }


            for (int i = 0; i < 10; i++) 
            {
                arr[i] = "";
            }
            i = 1; 
            numberGame = numberGame + 1; 
            label2.Text = "Игра: " + numberGame; 
        }
        public void win()
        {

            if ((arr[1] == "X" && arr[2] == "X" && arr[3] == "X") || (arr[1] == "X" && arr[5] == "X" && arr[9] == "X") || (arr[1] == "X" && arr[4] == "X" && arr[7] == "X") || (arr[2] == "X" && arr[5] == "X" && arr[8] == "X") || (arr[3] == "X" && arr[6] == "X" && arr[9] == "X") || (arr[3] == "X" && arr[5] == "X" && arr[7] == "X") || (arr[4] == "X" && arr[5] == "X" && arr[6] == "X") || (arr[7] == "X" && arr[8] == "X" && arr[9] == "X"))
            { 
                XWin = XWin + 1; 
                flag = true;
                Xf = true;
                label3.Text = "X : O\n" + XWin.ToString() + " : " + OWin.ToString(); 
                MessageBox.Show(" X победили!"); 
            }

            if ((arr[1] == "O" && arr[2] == "O" && arr[3] == "O") || (arr[1] == "O" && arr[5] == "O" && arr[9] == "O") || (arr[1] == "O" && arr[4] == "O" && arr[7] == "O") || (arr[2] == "O" && arr[5] == "O" && arr[8] == "O") || (arr[3] == "O" && arr[6] == "O" && arr[9] == "O") || (arr[3] == "O" && arr[5] == "O" && arr[7] == "O") || (arr[4] == "O" && arr[5] == "O" && arr[6] == "O") || (arr[7] == "O" && arr[8] == "O" && arr[9] == "O"))
            {
                OWin = OWin + 1;
                flag = true;
                Xf = true;
                label3.Text = "X : O\n" + XWin.ToString() + " : " + OWin.ToString();
                MessageBox.Show(" O победили!");
            }

                if ((arr[1] != "") && (arr[2] != "") && (arr[3] != "") && (arr[4] != "") && (arr[5] != "") && (arr[6] != "") && (arr[7] != "") && (arr[8] != "") && (arr[9] != "") && (Xf == false) && (Of == false))
                {
                    flag = true;

                    MessageBox.Show(" Ничья! :)");
                }

            Of = false;
            Xf = false;

        }

        public void moveComp()
        {
            Random Rand = new Random();
            while (f == false && i < 9)
            {
                int IndexStep = Rand.Next(1, 9);
                if (butt[IndexStep].Enabled == true)
                {
                    f = true;
                    i = i + 1;
                    butt[IndexStep].Text = "O";
                    butt[IndexStep].Enabled = false;
                    arr[IndexStep] = "O";
                    win();
                    if (flag == true)
                        refresch();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            refresch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = false;
            i = i + 1;
            button1.Text = "X";
            button1.Enabled = false;
            arr[1] = "X";
            win();
            if (flag == false)
                moveComp();
            else refresch();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = false;
            i = i + 1;
            button2.Text = "X";
            button2.Enabled = false;
            arr[2] = "X";
            win();
            if (flag == false)
                moveComp();
            else refresch();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f = false;
            i = i + 1;
            button3.Text = "X";
            button3.Enabled = false;
            arr[3] = "X";
            win();
            if (flag == false)
                moveComp();
            else refresch();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f = false;
            i = i + 1;
            button4.Text = "X";
            button4.Enabled = false;
            arr[4] = "X";
            win();
            if (flag == false)
                moveComp();
            else refresch();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f = false;
            i = i + 1;
            button5.Text = "X";
            button5.Enabled = false;
            arr[5] = "X";
            win();
            if (flag == false)
                moveComp();
            else refresch();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f = false;
            i = i + 1;
            button6.Text = "X";
            button6.Enabled = false;
            arr[6] = "X";
            win();
            if (flag == false)
                moveComp();
            else refresch();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f = false;
            i = i + 1;
            button7.Text = "X";
            button7.Enabled = false;
            arr[7] = "X";
            win();
            if (flag == false)
                moveComp();
            else refresch();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           f = false;
            i = i + 1;
            button8.Text = "X";
            button8.Enabled = false;
            arr[8] = "X";
            win();
            if (flag == false)
                moveComp();
            else refresch();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           f = false;
            i = i + 1;
            button9.Text = "X";
            button9.Enabled = false;
            arr[9] = "X";
            win();
            if (flag == false)
                moveComp();
            else refresch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresch();
            button10.Text = "Новая игра";
            label3.Text = "X : O\n" + XWin.ToString() + " : " + OWin.ToString();
        }
    }
}
