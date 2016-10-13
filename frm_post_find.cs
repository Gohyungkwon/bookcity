using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace bookcity
{
   
    public partial class frm_post_find : Form
    {


        DataSet v_ds = new DataSet("d_post");
        str_post v_str_post=new str_post();

        private TextBox txt_address;

        public TextBox set_address
        {
            set { txt_address = value; }
        }
        private TextBox txt_post;

        public TextBox set_post
        {
            set { txt_post = value; }
        }


        public frm_post_find()
        {
            InitializeComponent();
        }

        private void p_combo_insert()
        {
            string v_ret;
            string v_xml;
            Boolean v_ret2;
            v_xml = cls_book.f_select_area1(out v_ret);
            if (v_ret != "검색데이타 없음")
            {
                v_ret2 = cls_book.f_combo_additem(v_xml, this.cbo_find_sido);
            }
                   
        }
        private void p_bind_code(DataSet v_ds)
        {
            txt_zipcode.DataBindings.Clear();
            txt_addr_ro.DataBindings.Clear();
            txt_addr_ji.DataBindings.Clear();

            txt_zipcode.DataBindings.Add("Text",v_ds.Tables[0],"zipcode");
            txt_addr_ro.DataBindings.Add("Text",v_ds.Tables[0], "addr_ro");
            txt_addr_ji.DataBindings.Add("Text",v_ds.Tables[0], "addr_ji");

        }
  
        private void p_select_post()
        {
            string v_ret;
            string v_xml;
            str_post_select v_str_post_select = new str_post_select();
            v_str_post_select.p_init();
            v_str_post_select = p_select_set(v_str_post_select);

            v_xml = cls_book.f_select_post(v_str_post_select, out v_ret);
            MessageBox.Show(v_ret);
            if (v_ret != "검색데이타 없음")
            {
                XmlReader v_xmlReader = XmlReader.Create(new StringReader(v_xml));
                v_ds.Clear();
                v_ds.ReadXml(v_xmlReader);
                spr_post.DataBindings.Clear();
                spr_post.DataSource = v_ds.Tables[0];
                v_xmlReader.Close();
                p_bind_code(v_ds);
            }
        }

        private str_post_select p_select_set(str_post_select v_str_post_select)
        {
            if (opt_find_em.Checked && (txt_find_text.Text != ""))
            {
                v_str_post_select.EM = txt_find_text.Text;
            }
            if (opt_find_landmark.Checked && (txt_find_text.Text != ""))
            {
                v_str_post_select.LANDMARK = txt_find_text.Text;
            }
            if (opt_find_road_nm.Checked && (txt_find_text.Text != ""))
            {
                v_str_post_select.ROAD_NM = txt_find_text.Text;
            }
            if (cbo_find_sido.Text != "")
            {
                v_str_post_select.SIDO = cbo_find_sido.Text;
            }
            if (cbo_find_sido.Text != "")
            {
                v_str_post_select.SIGUN = cbo_find_sigun.Text;
            }

            return v_str_post_select;
        }

        private void cmd_select_post_Click(object sender, EventArgs e)
        {
            p_select_post();
        }

        private void cbo_find_sido_SelectedIndexChanged(object sender, EventArgs e)
        {
            string v_ret;
            string v_xml;
            Boolean v_ret2;
            v_xml = cls_book.f_select_area2(cbo_find_sido.Text, out v_ret);
            if (v_ret != "검색데이타 없음")
            {
                v_ret2 = cls_book.f_combo_additem(v_xml, this.cbo_find_sigun);
            }
        }


        private void frm_post_find_Load(object sender, EventArgs e)
        {
            str_post v_str_post = new str_post();
            v_str_post.p_init();

            p_combo_insert();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_address.Text = txt_addr_ro.Text;
            txt_post.Text = txt_zipcode.Text;
            this.Close();
        }
    }
}
