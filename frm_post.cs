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
   
    public partial class frm_post : Form
    {
        DataSet v_ds = new DataSet("d_post");
        str_post v_str_post = new str_post();
        public frm_post()
        {
            InitializeComponent();
        }

        private void frm_post_Load(object sender, EventArgs e)
        {
            
            v_str_post.p_init();
            
            p_combo_insert();

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
                v_ret2 = cls_book.f_combo_additem(v_xml, this.cbo_sido);
            }
                   
        }
        private void p_bind_code(DataSet v_ds)
        {
            txt_zipcode.DataBindings.Clear();
            txt_zipcode_old.DataBindings.Clear();
            txt_road_nm.DataBindings.Clear();
            txt_road_cd.DataBindings.Clear();
            txt_roadkey.DataBindings.Clear();
            txt_landmark.DataBindings.Clear();
            txt_ji_2.DataBindings.Clear();
            txt_ji_1.DataBindings.Clear();
            txt_hang_nm.DataBindings.Clear();
            txt_ground.DataBindings.Clear();
            txt_em.DataBindings.Clear();
            txt_dong_nm.DataBindings.Clear();
            txt_dong_cd.DataBindings.Clear();
            txt_build_no.DataBindings.Clear();
            txt_build_2.DataBindings.Clear();
            txt_build_1.DataBindings.Clear();
            txt_addr_ro.DataBindings.Clear();
            txt_addr_ji.DataBindings.Clear();
            cbo_sido.DataBindings.Clear();
            cbo_sigun.DataBindings.Clear();

            txt_zipcode.DataBindings.Add("Text",v_ds.Tables[0],"zipcode");
            txt_zipcode_old.DataBindings.Add("Text",v_ds.Tables[0], "zipcode_old");
            txt_road_nm.DataBindings.Add("Text",v_ds.Tables[0], "road_nm");
            txt_road_cd.DataBindings.Add("Text",v_ds.Tables[0], "road_cd");
            txt_roadkey.DataBindings.Add("Text",v_ds.Tables[0], "road_key");
            txt_landmark.DataBindings.Add("Text",v_ds.Tables[0], "landmark");
            txt_ji_2.DataBindings.Add("Text",v_ds.Tables[0], "ji_2");
            txt_ji_1.DataBindings.Add("Text",v_ds.Tables[0], "ji_1");
            txt_hang_nm.DataBindings.Add("Text",v_ds.Tables[0], "hang_nm");
            txt_ground.DataBindings.Add("Text",v_ds.Tables[0], "ground");
            txt_em.DataBindings.Add("Text",v_ds.Tables[0], "em");
            txt_dong_nm.DataBindings.Add("Text",v_ds.Tables[0], "dong_nm");
            txt_dong_cd.DataBindings.Add("Text",v_ds.Tables[0], "dong_cd");
            txt_build_no.DataBindings.Add("Text",v_ds.Tables[0], "build_no");
            txt_build_2.DataBindings.Add("Text",v_ds.Tables[0], "build_2");
            txt_build_1.DataBindings.Add("Text",v_ds.Tables[0], "build_1");
            txt_addr_ro.DataBindings.Add("Text",v_ds.Tables[0], "addr_ro");
            txt_addr_ji.DataBindings.Add("Text",v_ds.Tables[0], "addr_ji");
            cbo_sido.DataBindings.Add("Text",v_ds.Tables[0], "sido");
            cbo_sigun.DataBindings.Add("Text",v_ds.Tables[0], "sigun");

           
        }
        private Boolean f_val()
        {
            if (txt_zipcode.Text == "")
            {
                MessageBox.Show("우편번호를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (cbo_sido.Text == "")
            {
                MessageBox.Show("시도를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (cbo_sigun.Text == "")
            {
                MessageBox.Show("시군을 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_em.Text == "")
            {
                MessageBox.Show("법정동을 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_road_cd.Text == "")
            {
                MessageBox.Show("도로번호를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_road_nm.Text == "")
            {
                MessageBox.Show("도로명을 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_ground.Text == "")
            {
                MessageBox.Show("그라운드를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_build_1.Text == "")
            {
                MessageBox.Show("빌딩번호1을 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_build_2.Text == "")
            {
                MessageBox.Show("빌딩번호2를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_roadkey.Text == "")
            {
                MessageBox.Show("로드키를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_build_no.Text == "")
            {
                MessageBox.Show("빌딩번호를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_landmark.Text == "")
            {
                MessageBox.Show("건물명을 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_dong_cd.Text == "")
            {
                MessageBox.Show("동번호를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_dong_nm.Text == "")
            {
                MessageBox.Show("동이름을 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_hang_nm.Text == "")
            {
                MessageBox.Show("행정동을 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_ji_1.Text == "")
            {
                MessageBox.Show("지번1을 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_ji_2.Text == "")
            {
                MessageBox.Show("지번2를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_zipcode_old.Text == "")
            {
                MessageBox.Show("구우편번호를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_addr_ji.Text == "")
            {
                MessageBox.Show("법정동주소를 입력하십시요!", "필수입력체크");
                return false;
            }

            if (txt_addr_ro.Text == "")
            {
                MessageBox.Show("도로명주소를 입력하십시요!", "필수입력체크");
                return false;
            }

            return true;
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
            else
            {
                v_ds.Clear();
                spr_post.DataBindings.Clear();
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

        private void cbo_sido_SelectedIndexChanged(object sender, EventArgs e)
        {
            string v_ret;
            string v_xml;
            Boolean v_ret2;
            v_xml = cls_book.f_select_area2(cbo_sido.Text, out v_ret);
            if (v_ret != "검색데이타 없음")
            {
                v_ret2 = cls_book.f_combo_additem(v_xml, this.cbo_sigun);
            }
        }

        private void spr_post_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmd_insert_post_Click(object sender, EventArgs e)
        {

        }
    }
}
