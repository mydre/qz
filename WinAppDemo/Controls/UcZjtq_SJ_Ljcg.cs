﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDemo.Controls
{
    public partial class UcZjtq_SJ_Ljcg : UserControl
    {
        public UcZjtq_SJ_Ljcg()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AppContext.GetInstance().m_ucZjtq_sj.Controls.Clear();

            AppContext.GetInstance().m_ucZjtq_sj_qz1.Dock = DockStyle.Fill;
            AppContext.GetInstance().m_ucZjtq_sj.Controls.Clear();
            AppContext.GetInstance().m_ucZjtq_sj.Controls.Add(AppContext.GetInstance().m_ucZjtq_sj_qz1);
        }
    }
}
