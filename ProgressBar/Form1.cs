using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        int num = 0; // 진행 숫자
        string Orgstr = ""; // 상태 저장
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Orgstr = this.lblStatus.Text;
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.num++;
            if(this.num>100)
            {
                this.Timer.Enabled = false;
                return;
            }
            this.pbStatus.Value = this.num;
            this.lblStatus.Text = this.Orgstr + this.num + "%";

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.num = 0;
            this.pbStatus.Value = 0;
            this.lblStatus.Text = this.Orgstr;
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = false;
        }
    }
}
