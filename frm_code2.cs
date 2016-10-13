using System;
using System.Data;

using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace bookcity
{
    public partial class frm_code2 : Form
    {
        DataSet v_ds = new DataSet("d_code");
        str_code2 v_str_code = new str_code2();
        public frm_code2()
        {
            InitializeComponent();
        }

        private void frm_code2_Load(object sender, EventArgs e)
        {           
            p_select_code2();
        }
        private void p_bind_code(DataSet v_ds)
        {
            txt_code_nm.DataBindings.Clear();
            txt_datanum.DataBindings.Clear();
            txt_gubun_nm.DataBindings.Clear();
            txt_sort_order.DataBindings.Clear();
            txt_code.DataBindings.Clear();
            txt_gubun_code.DataBindings.Clear();
            chk_def_yn.DataBindings.Clear();
            chk_useyn.DataBindings.Clear();
            txt_middle_code.DataBindings.Clear();
            txt_middle_code_nm.DataBindings.Clear();

            txt_code_nm.DataBindings.Add("Text", v_ds.Tables[0], "code_nm");
            txt_datanum.DataBindings.Add("Text", v_ds.Tables[0], "datanum");
            txt_gubun_nm.DataBindings.Add("Text", v_ds.Tables[0], "gubun_nm");
            txt_sort_order.DataBindings.Add("Text", v_ds.Tables[0], "sort_order");
            txt_code.DataBindings.Add("Text", v_ds.Tables[0], "code");
            txt_gubun_code.DataBindings.Add("Text", v_ds.Tables[0], "gubun_code");
            chk_def_yn.DataBindings.Add("Checked", v_ds.Tables[0], "def_yn");
            chk_useyn.DataBindings.Add("Checked", v_ds.Tables[0], "useyn");
            txt_middle_code.DataBindings.Add("Text", v_ds.Tables[0], "middle_code");
            txt_middle_code_nm.DataBindings.Add("Text", v_ds.Tables[0], "middle_code_nm");
        }

        private Boolean f_val()
        {
            if (txt_gubun_nm.Text == "")
            {
                MessageBox.Show("구분명칭을 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_code_nm.Text == "")
            {
                MessageBox.Show("코드명를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_gubun_code.Text == "")
            {
                MessageBox.Show("구분코드를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_code.Text == "")
            {
                MessageBox.Show("코드를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_middle_code_nm.Text == "")
            {
                MessageBox.Show("중분류명를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_middle_code.Text == "")
            {
                MessageBox.Show("중분류코드를 입력하십시요!", "필수입력체크");
                return false;
            }
            if (txt_sort_order.Text == "")
            {
                MessageBox.Show("정렬순서를 입력하십시요!", "필수입력체크");
                return false;
            }
            return true;
        }
        private void p_select_code2()
        {
            string v_ret;
            string v_xml;
            v_xml = cls_book.f_select_code2(out v_ret);
            MessageBox.Show(v_ret);
            if (v_ret != "검색데이타 없음")
            {
               
                XmlReader v_xmlReader = XmlReader.Create(new StringReader(v_xml));
                v_ds.Clear();
                v_ds.ReadXml(v_xmlReader);
                spr_code.DataBindings.Clear();
                spr_code.DataSource = v_ds.Tables[0];
                v_xmlReader.Close();
                p_bind_code(v_ds);
            }
            else
            {
                spr_code.DataBindings.Clear();
                spr_code.Rows.Clear();
            }
        }

        private void cmd_insert_code_Click(object sender, EventArgs e)
        {
            string v_ret;
            if (f_val())
            {
                v_str_code.p_init();
                v_str_code.gubun_nm = txt_gubun_nm.Text;
                v_str_code.code_nm = txt_code_nm.Text;
                v_str_code.gubun_code = txt_gubun_code.Text;
                v_str_code.code = txt_code.Text;
                v_str_code.middle_code_nm = txt_middle_code_nm.Text;
                v_str_code.middle_code = txt_middle_code.Text;
                v_str_code.useyn = chk_useyn.Checked.ToString();
                v_str_code.def_yn = chk_def_yn.Checked.ToString();
                v_str_code.sort_order = Convert.ToInt32(txt_sort_order.Text);
                cls_book.f_insert_code2(v_str_code, out v_ret);
                MessageBox.Show(v_ret);
                p_select_code2();
            }

        }

        private void cmd_update_code_Click(object sender, EventArgs e)
        {
            string v_ret;
            if (txt_datanum.Text == "")
            {
                MessageBox.Show("수정하려면 먼저 코드를 선택하십시요!", "선택확인");
                return ;
            }

            if (f_val())
            {
                v_str_code.datanum = Convert.ToInt32(txt_datanum.Text);
                v_str_code.gubun_nm = txt_gubun_nm.Text;
                v_str_code.code_nm = txt_code_nm.Text;
                v_str_code.gubun_code = txt_gubun_code.Text;
                v_str_code.code = txt_code.Text;
                v_str_code.middle_code_nm = txt_middle_code_nm.Text;
                v_str_code.middle_code = txt_middle_code.Text;
                v_str_code.useyn = chk_useyn.Checked.ToString();
                v_str_code.def_yn = chk_def_yn.Checked.ToString();
                v_str_code.sort_order = Convert.ToInt32(txt_sort_order.Text);
                cls_book.f_update_code2(v_str_code, out v_ret);
                MessageBox.Show(v_ret);
                p_select_code2();

            }

        }

        private void cmd_delete_code_Click(object sender, EventArgs e)
        {
            string v_ret;
            if (txt_datanum.Text == "")
            {
                MessageBox.Show("삭제하려면 먼저 코드를 선택하십시요!", "선택확인");
                return;
            }

            v_str_code.datanum = Convert.ToInt32(txt_datanum.Text);
            cls_book.f_delete_code2(v_str_code, out v_ret);
            MessageBox.Show(v_ret);
            p_select_code2();
        }
    }
}   
