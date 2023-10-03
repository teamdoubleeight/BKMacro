using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Point lastPoint;

        public Form1()
        {
            InitializeComponent();
        }

        




        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("그냥 개쓸데없지만 간지나는거 만들어봤어요\n근데 왜 버거킹은 이런거 안막아놨음?ㅋㅋ","DoubleEight#7184");
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
                Thread.Sleep(Delaysecond - 50);
                SendKeys.Send("콰트로 맥시멈 미트 포커스드 어메이징 얼티밋 그릴드 패티 오브 더 비기스트 포 슈퍼 미트 프릭");
                Thread.Sleep(50);
                SendKeys.Send("{Enter}");
                MessageBox.Show("입력 완료!");

         
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://burgerkingevent.com/");
        }

        private void flatLabel6_Click(object sender, EventArgs e)
        {

        }

        int Delaysecond = 100;
        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Delaysecond = guna2TrackBar1.Value * 100;
            flatLabel7.Text = Delaysecond.ToString() +  "ms";
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("아이고 가시게요?", "진짜류?", MessageBoxButtons.YesNo);
            bool flag = dialogResult == DialogResult.Yes;
            if (flag)
            {
                MessageBox.Show("근데 그거 알아요?\n니가 이걸 키는 동시에 니 컴퓨터에 바이러스가 깔리고 정보가 다 털린걸?\n가짜같으면 12시간만 기다려봐 ㅋ");
                MessageBox.Show("에후 순진한 놈 ㅋ\n세상은 아무나 믿으면 안되는거지");
                MessageBox.Show("라고할뻔 ㅋ", "근데 하면 재밌을듯");
                Application.Exit();
            }
            else
            {
                bool flag2 = dialogResult == DialogResult.No;
                if (flag2)
                {
                }
            }
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked == true)
            {
                this.Opacity = 0.6;
            }
            else
            {
                this.Opacity = 1;
            }
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.Opacity = 1;
            }
        }
    }
 }
