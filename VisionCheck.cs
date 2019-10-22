﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodVision
{
    public partial class VisionCheck : Form
    {
        public VisionCheck()
        {
            InitializeComponent();
        }

        private void BackFromVChButton_Click(object sender, EventArgs e)
        {
            MainMenu mMForm = new MainMenu();
            mMForm.Show();
            this.Hide();
        }

        private void SivtsevModeButton_Click(object sender, EventArgs e)
        {
          SivtsevCheckingPro sivCheck = new SivtsevCheckingPro();
            sivCheck.Show();
            this.Hide();
        }

        private void LandoltModeButton_Click(object sender, EventArgs e)
        {
            LandotCheckPro LanCheck = new LandotCheckPro();
            LanCheck.Show();
            this.Hide();
        }
    }
}
