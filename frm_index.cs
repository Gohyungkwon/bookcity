using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace bookcity
{
    public partial class frm_index : Form
    {
        public frm_index()
        {
            InitializeComponent();
        }

        private void 코드관리2단계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_code v_form = new frm_code();
            v_form.Show();
        }

        private void 코드관리3단계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_code2 v_form = new frm_code2();
            v_form.Show();
        }

        private void 우편번호관리ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_post v_form = new frm_post();
            v_form.Show();
        }
    }
}

