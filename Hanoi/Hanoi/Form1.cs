using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hanoi
{
    public partial class Form1 : Form
    {   Dictionary<int ,PictureBox> mp=new Dictionary<int ,PictureBox>();
        Stack<string> CallStack=new Stack<string>();
        int A_count = 0;
        int B_count = 0;
        int C_count = 0;
        int c = 1;
        int speed = 2000;
        int x=7;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.Wheat;
        }
        public void Stuff() {
            if (x == 1)
            {
                mp[1] = Disk7;
            }
            else if (x == 2)
            {
                mp[1] = Disk6;
                mp[2] = Disk7;
            }
            else if (x == 3)
            {
                mp[1] = Disk5;
                mp[2] = Disk6;
                mp[3] = Disk7;

            }
            else if (x == 4)
            {
                mp[1] = Disk4;
                mp[2] = Disk5;
                mp[3] = Disk6;
                mp[4] = Disk7;
            }
            else if (x == 5)
            {
                mp[1] = Disk3;
                mp[2] = Disk4;
                mp[3] = Disk5;
                mp[4] = Disk6;
                mp[5] = Disk7;
            }
            else if (x == 6)
            {
                mp[1] = Disk2;
                mp[2] = Disk3;
                mp[3] = Disk4;
                mp[4] = Disk5;
                mp[5] = Disk6;
                mp[6] = Disk7;
            }
            else {
                mp[1] = Disk1;
                mp[2] = Disk2;
                mp[3] = Disk3;
                mp[4] = Disk4;
                mp[5] = Disk5;
                mp[6] = Disk6;
                mp[7] = Disk7;
            }
        
        }
        public void MOVE(int n,char from,char to,ref int A, ref int B,ref int C) {
            int B_X = 311;
            int A_X = 19;
            int C_X = 594;
            int add = 10;
            if (to == 'A')
            {
                int total = (A * add) + (10 * A)+(add);
                total = 370 - total;
                mp[n].Location = new Point(A_X, total);
                if (mp[n] == Disk1)
                {
                    mp[n].Location = new Point(83, total);
                }
                else if (mp[n] == Disk2)
                {
                    mp[n].Location = new Point(69, total);
                }
                else if (mp[n] == Disk3)
                {
                    mp[n].Location = new Point(69, total);
                }
                else if (mp[n] == Disk4)
                {
                    mp[n].Location = new Point(58, total);
                }
                else if (mp[n] == Disk5)
                {
                    mp[n].Location = new Point(46, total);
                }
                else if (mp[n] == Disk6)
                {
                    mp[n].Location = new Point(32, total);
                }
                else {
                    mp[n].Location = new Point(19, total);
                }
                A++;
            }
            if (to == 'B')
            {
                int total = (B * add) + (10 * B) + (add);
                total = 370 - total;
                mp[n].Location = new Point(B_X, total);
                if (mp[n] == Disk1)
                {
                    mp[n].Location = new Point(375, total);
                }
                else if (mp[n] == Disk2)
                {
                    mp[n].Location = new Point(361, total);
                }
                else if (mp[n] == Disk3)
                {
                    mp[n].Location = new Point(361, total);
                }
                else if (mp[n] == Disk4)
                {
                    mp[n].Location = new Point(350, total);
                }
                else if (mp[n] == Disk5)
                {
                    mp[n].Location = new Point(338, total);
                }
                else if (mp[n] == Disk6)
                {
                    mp[n].Location = new Point(326, total);
                }
                else
                {
                    mp[n].Location = new Point(313, total);
                }
                B++;
            }
            if (to == 'C')
            {
                int total = (C * add) + (10 * C) + (add);
                total = 370 - total;
                mp[n].Location = new Point(C_X, total);
                if (mp[n] == Disk1)
                {
                    mp[n].Location = new Point(650, total);
                }
                else if (mp[n] == Disk2)
                {
                    mp[n].Location = new Point(636, total);
                }
                else if (mp[n] == Disk3)
                {
                    mp[n].Location = new Point(636, total);
                }
                else if (mp[n] == Disk4)
                {
                    mp[n].Location = new Point(625, total);
                }
                else if (mp[n] == Disk5)
                {
                    mp[n].Location = new Point(613, total);
                }
                else if (mp[n] == Disk6)
                {
                    mp[n].Location = new Point(601, total);
                }
                else
                {
                    mp[n].Location = new Point(589, total);
                }
                C++;
            }
            if (from == 'A') {
                A--;
            }
            if (from == 'B') {
                 B--;
            
            }
            if (from == 'C') {
                C--;
            }        
        }
        void towerOfHanoi(int n, char from, char to, char tmp,ref int A,ref int B,ref int C, Stack<string> callstack)
        {
            if (n == 1)
            {
                label5.Text = "";
                foreach (string item in callstack)
                {
                    label5.Text = label5.Text + item + "\n";
                }
                Thread.Sleep(speed);
                MOVE(n, from, to,ref A,ref B,ref C);
                return;
            }
            Thread.Sleep(speed);
            callstack.Push(c.ToString() + " -  towerOfHanoi(n - 1, from, tmp) ");
            c++;
            label5.Text = "";
            foreach (string item in callstack)
            {
                label5.Text = label5.Text + item + "\n";
            }
            towerOfHanoi(n - 1, from, tmp, to,ref A,ref B,ref C, callstack);
            callstack.Pop();
            c--;
            callstack.Push(c.ToString() + " - towerOfHanoi(n - 1, tmp, to, from) ");
            c++;
            Thread.Sleep(speed);
            MOVE(n, from, to,ref A, ref B, ref C);
            towerOfHanoi(n - 1, tmp, to, from,ref A,ref B,ref C, callstack);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
             x = int.Parse(NumofDisks.Text);
            if (!(NumofDisks.Text == "1" || NumofDisks.Text == "2" || NumofDisks.Text == "3" || NumofDisks.Text == "4" || NumofDisks.Text == "5" || NumofDisks.Text == "6" || NumofDisks.Text == "7")) 
            {
                throw new Exception("Enter a Valid Value Between 1 and 7");
            }
            A_count = x;
            B_count = 0;
            C_count = 0;
            for (int i = 1; i <=7-x; i++)
            {
                if (i == 1)
                {
                    Disk1.Visible = false;
                }
                else if (i == 2)
                {
                    Disk2.Visible = false;
                }
                else if (i == 3)
                {
                    Disk3.Visible = false;
                }
                else if (i == 4)
                {
                    Disk4.Visible = false;
                }
                else if (i == 5)
                {
                    Disk5.Visible = false;
                }
                else if (i == 6)
                {
                    Disk6.Visible = false;
                }
                else if (i == 7) {
                    Disk7.Visible = false;
                }
            }
            Stuff();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 7;
            A_count = 7;
            B_count = 0;
            C_count = 0;
            mp.Clear();
            label5.Text = ""; 
            CallStack.Clear();
            c = 1;
            speed = 1000;
            label5.Text = "";
            Disk1.Visible = true;
            Disk2.Visible = true;
            Disk3.Visible = true;
            Disk4.Visible = true;
            Disk5.Visible = true;
            Disk6.Visible = true;
            Disk7.Visible = true;
            Disk1.Location=new Point(83, 258);
            Disk2.Location=new Point(76, 274);
            Disk3.Location=new Point(69, 290);
            Disk4.Location=new Point(58, 306);
            Disk5.Location=new Point(46, 322);
            Disk6.Location=new Point(32, 338);
            Disk7.Location=new Point(19, 354);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => towerOfHanoi(x, 'A', 'C', 'B', ref A_count, ref B_count, ref C_count, CallStack));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            speed = 1000;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            speed = 800;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            speed = 200;
        }
    }
}
