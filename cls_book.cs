using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using Microsoft.VisualBasic;
using System.Xml;
using System.IO;
using System.Reflection;

namespace bookcity
{
    public enum e_member_kind { 일반회원, 업소회원 };
    public enum e_prepay_yn { 불가능=0, 가능=1};
    public enum e_positon_now { 반경1키로, 반경2키로, 반경5키로, 반경10키로, 반경20키로, 반경50키로, 제한없음, 현위치읍면동, 현위치시군, 현위치시도 };
    public enum e_sort_yn { 설정안함=0, 설정=1};
    public enum e_agree_yn { 동의안함=0, 동의=1 };
    public enum e_out_yn { 탈퇴안함=0, 탈퇴=1};
    public enum e_employee_kind { 대표자, 직원 };
    public enum e_center_grade { 독자센터장, 경리, 배달직원, 영업직원 };
    public enum e_apply_yn { 신청, 처리완료 };
    public enum e_reserve_confirm_yn { 불필요=0, 필요=1};
    public enum e_ad_kind { 푸쉬 = 0, 이벤트 = 1 };
    public enum e_adsend_yn { 미발신=0, 발신=1 };
    public enum e_adreceive_yn { 미수신=0, 수신=1 };
    public enum e_adpay_kind { 카드, 무통장입금 };
    public enum e_pay_kind { 선불, 후불 };
    public enum e_confirm_yn { 미확인=0, 확인=1};
    public enum e_buy_yn { 비구매=0, 구매=1 };
    public enum e_buy_cancle_yn { 정상=0, 구매취소=1 };
    public enum e_cancle_kind { 회원, 업소 };
    public enum e_pay_device { 카드, 핸드폰결제 };
    public enum e_point_kind { 광고포인트받기_회원, 광고포인트받기_센터, 광고포인트받기_본사, 광고포인트받기_센터대신_본사,광고포인트주기_업소, 상품구매_선불, 상품구매_후불, 선물받기_회원, 선물받기_업소, 선물주기_회원, 선물주기_업소, 포인트로상품구매, 구독료대납, 충전, 환전_회원, 환전_업소, 환전_독자센터, 구매취소_회원, 구매취소_업소 };
    public enum e_point_money_yn { 미환전=0, 환전 =1};
    public enum e_item_kind { 동영상, 업소사진1, 업소사진2, 업소사진3, 상품사진1, 상품사진2, 상품사진3 };
    public enum e_tret_yn { 미처리=0, 처리 =1};
    public enum e_pay_yn { 미결제=0, 결제=1};
    public enum e_refund_yn { 미환불=0, 환불=1 };
    public enum e_end_yn { 미완료 = 0, 완료 = 1 };

    public struct str_company_kind
    {
        public int company_kindnum;
        public String company_kind;

        public void p_init()
        {
            this.company_kindnum = 0;
            this.company_kind = "";

        }

    }
    public struct str_company_info
    {
        public int company_num ;
        public String company_mobile ;
        public String company_id ;
        public String company_pw ;
        public String company_nm ;
        public String company_kind ;
        public String company_area1 ;
        public String company_area2 ;
        public String company_post ;
        public String company_address ;
        public String company_tel1 ;
        public String company_tel2 ;
        public DateTime company_insertdate ;
        public int company_insertnm ;
        public float company_gps_x ;
        public float company_gps_y ;
        public String company_file_path ;
        public String prepay_yn ;
        public int company_point;

        public void p_init()
        {
            this.company_num = 0;
            this.company_mobile = "";
            this.company_id = "";
            this.company_pw = "";
            this.company_nm = "";
            this.company_kind = "";
            this.company_area1 = "";
            this.company_area2 = "";
            this.company_post = "";
            this.company_address = "";
            this.company_tel1 = "";
            this.company_tel2 = "";
            this.company_insertdate = Convert.ToDateTime("1900-01-01");
            this.company_insertnm = 0;
            this.company_gps_x = 0;
            this.company_gps_y = 0;
            this.company_file_path = "";
            this.prepay_yn = "";
            this.company_point = 0;
        }

    }
    public struct str_company_select
    {
        public int company_num ;
        public String company_mobile ;
        public String company_id ;
        public String company_nm ;
        public String company_kind ;
        public String company_area1 ;
        public String company_area2 ;
        public String company_address ;
        public String center ;
        public DateTime company_insertdate1 ;
        public DateTime company_insertdate2 ;
        public int company_insertnm ;
        public String prepay_yn ;
        public String position ;
        public String goods ;
        public int review_count ;
        public int star_count ;
        public int ad_resieve_count ;
        public int sale_count ;
        public int reserve_count ;
        public int point_add_price ;
        public int ad_price ;
        public int ad_count ;
        public String sort_review ;
        public String sort_star ;
        public String sort_ad ;
        public String sort_sale ;


        public void p_init()
        {
            this.company_num = 0;
            this.company_mobile = "";
            this.company_id = "";
            this.company_nm = "";
            this.company_kind = "";
            this.company_area1 = "";
            this.company_area2 = "";
            this.company_address = "";
            this.center = "";
            this.company_insertdate1 = Convert.ToDateTime("1900-01-01");
            this.company_insertdate2 = Convert.ToDateTime("1900-01-01");
            this.company_insertnm = 0;
            this.prepay_yn = "";
            this.position = "";
            this.goods = "";
            this.review_count = 0;
            this.star_count = 0;
            this.sale_count = 0;
            this.reserve_count = 0;
            this.point_add_price = 0;
            this.ad_resieve_count = 0;
            this.ad_price = 0;
            this.ad_count = 0;
            this.sort_review = "";
            this.sort_star = "";
            this.sort_ad = "";
            this.sort_sale = "";
        }

    }
    public struct str_company_employee
    {
        public int company_num ;
        public String company_mobile ;
        public String company_id ;
        public String company_nm ;
        public String company_kind ;
        public int member_num ;
        public String member_id ;
        public String member_mobile ;
        public String company_employee_kind ;
        public String company_employee_apply ;


        public void p_init()
        {
            this.company_num = 0;
            this.company_mobile = "";
            this.company_id = "";
            this.company_nm = "";
            this.company_kind = "";
            this.member_num = 0;
            this.member_id = "";
            this.member_mobile = "";
            this.company_employee_kind = "";
            this.company_employee_apply = "";
        }

    }
    public struct str_company_promotion
    {
        public int company_num ;
        public int company_tempnum ;
        public String company_file_path ;

        public void p_init()
        {
            this.company_tempnum = 0;
            this.company_num = 0;
            this.company_file_path = "";
        }

    }
    public struct str_company_promotion_detail
    {
        public int item_num ;
        public int company_num ;
        public int company_tempnum ;
        public String item_kind ;
        public String item_desc ;
        public String item_fullpath ;
        public int position_top ;
        public int position_left ;
        public int width ;
        public int height ;
        public String company_file_path ;

        public void p_init()
        {
            this.item_num = 0;
            this.company_num = 0;
            this.company_tempnum = 0;
            this.item_kind = "";
            this.item_desc = "";
            this.item_fullpath = "";
            this.position_top = 0;
            this.position_left = 0;
            this.width = 0;
            this.height = 0;
            this.company_file_path = "";
        }

    }
    public struct str_company_ad_select
    {
        public int company_num ;
        public int ad_num ;
        public DateTime ad_send_date1 ;
        public DateTime ad_send_date2 ;

        public void p_init()
        {
            this.company_num = 0;
            this.ad_num = 0;
            this.ad_send_date1 = Convert.ToDateTime("1900-01-01");
            this.ad_send_date2 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_company_ad_person_select
    {
        public int company_num ;
        public int ad_num ;
        public String ad_send_yn ;
        public DateTime ad_send_date1 ;
        public DateTime ad_send_date2 ;
        public String ad_receive_yn ;
        public DateTime ad_receive_date1 ;
        public DateTime ad_receive_date2 ;

        public void p_init()
        {
            this.company_num = 0;
            this.ad_num = 0;
            this.ad_send_yn = "";
            this.ad_send_date1 = Convert.ToDateTime("1900-01-01");
            this.ad_send_date2 = Convert.ToDateTime("1900-01-01");
            this.ad_receive_yn = "";
            this.ad_receive_date1 = Convert.ToDateTime("1900-01-01");
            this.ad_receive_date2 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_company_ad
    {
        public int company_num ;
        public int ad_num ;
        public String ad_kind ;
        public DateTime ad_start_date ;
        public DateTime ad_end_date ;
        public String ad_selectsql ;
        public int ad_receive_ok_date ;
        public DateTime ad_req_date ;
        public DateTime ad_make_date ;
        public String ad_maker ;
        public int ad_make_price ;
        public String ad_price_kind ;
        public String ad_price_yn ;
        public String ad_price_confirm_nm ;
        public DateTime ad_price_confirm_date ;
        public String ad_paper_path ;
        public String ad_design_ok;
        public DateTime ad_design_ok_date;
        public int ad_point_price ;
        public float ad_gps_righttop_x ;
        public float ad_gps_rightbottom_x ;
        public float ad_gps_lefttop_x ;
        public float ad_gps_leftbottom_x ;
        public float ad_gps_righttop_y ;
        public float ad_gps_rightbottom_y ;
        public float ad_gps_lefttop_y ;
        public float ad_gps_leftbottom_y ;

        public void p_init()
        {
            this.company_num = 0;
            this.ad_num = 0;
            this.ad_kind = "";
            this.ad_start_date = Convert.ToDateTime("1900-01-01");
            this.ad_end_date = Convert.ToDateTime("1900-01-01");
            this.ad_selectsql = "";
            this.ad_receive_ok_date = 0;
            this.ad_req_date = Convert.ToDateTime("1900-01-01");
            this.ad_make_date = Convert.ToDateTime("1900-01-01");
            this.ad_maker = "";
            this.ad_make_price = 0;
            this.ad_price_kind = "";
            this.ad_price_yn = "";
            this.ad_price_confirm_nm = "";
            this.ad_price_confirm_date = Convert.ToDateTime("1900-01-01");
            this.ad_paper_path = "";
            this.ad_design_ok = "";
            this.ad_design_ok_date = Convert.ToDateTime("1900-01-01");
            this.ad_point_price = 0;
            this.ad_gps_righttop_x = 0;
            this.ad_gps_rightbottom_x = 0;
            this.ad_gps_lefttop_x = 0;
            this.ad_gps_leftbottom_x = 0;
            this.ad_gps_righttop_y = 0;
            this.ad_gps_rightbottom_y = 0;
            this.ad_gps_lefttop_y = 0;
            this.ad_gps_leftbottom_y = 0;
        }
    }
    public struct str_ad_person
    {
        public int company_num ;
        public int ad_num ;
        public int member_num ;
        public String ad_send_yn ;
        public DateTime ad_send_date ;
        public String ad_receive_yn ;
        public DateTime ad_receive_date ;
        public DateTime ad_receive_ok_date ;

        public void p_init()
        {
            this.company_num = 0;
            this.ad_num = 0;
            this.member_num = 0;
            this.ad_send_date = Convert.ToDateTime("1900-01-01");
            this.ad_send_yn = "";
            this.ad_receive_date = Convert.ToDateTime("1900-01-01");
            this.ad_receive_ok_date = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_ad_rate
    {
        public int company_num ;
        public int ad_num ;
        public int target_count ;
        public int send_count ;
        public int receive_count ;
        public int used_point ;
        public int not_count ;
        public int able_point ;

        public void p_init()
        {
            this.company_num = 0;
            this.ad_num = 0;
            this.target_count = 0;
            this.send_count = 0;
            this.receive_count = 0;
            this.used_point = 0;
            this.not_count = 0;
            this.able_point = 0;
        }
    }
    public struct str_company_cust
    {
        public int company_cust_num ;
        public int company_num ;
        public String company_custname ;
        public String company_custmobile ;
        public DateTime company_custbirth ;
        public DateTime company_custmerry ;
        public String company_etcdate_nm ;
        public DateTime company_etcdate ;
        public DateTime insertdate ;
        public String insertnm ;

        public void p_init()
        {
            this.company_num = 0;
            this.company_cust_num = 0;
            this.company_custname = "";
            this.company_custmobile = "";
            this.company_custbirth = Convert.ToDateTime("1900-01-01");
            this.company_custmerry = Convert.ToDateTime("1900-01-01");
            this.company_etcdate_nm = "";
            this.company_etcdate = Convert.ToDateTime("1900-01-01");
            this.insertdate = Convert.ToDateTime("1900-01-01");
            this.insertnm = "";
        }
    }
    public struct str_company_cust_select
    {
        public String company_custname ;
        public String company_custmobile ;
        public String company_custdate_nm;
        public DateTime company_custdate1 ;
        public DateTime company_custdate2 ;
        public String company_custgroup ;

        public void p_init()
        {
            this.company_custname = "";
            this.company_custmobile = "";
            this.company_custdate_nm = "";
            this.company_custdate1 = Convert.ToDateTime("1900-01-01");
            this.company_custdate2 = Convert.ToDateTime("1900-01-01");
            this.company_custgroup = "";
        }
    }
    public struct str_company_group
    {
        public int com_group_num ;
        public int company_num ;
        public String com_group_name ;
        public String com_group_text ;

        public void p_init()
        {
            this.com_group_num = 0;
            this.company_num = 0;
            this.com_group_name = "";
            this.com_group_text = "";
        }
    }
    public struct str_company_groupping
    {
        public int com_group_num ;
        public int company_num ;
        public int company_cust_num ;
        public String com_group_name ;
        public String com_group_text ;

        public void p_init()
        {
            this.com_group_num = 0;
            this.company_num = 0;
            this.company_cust_num = 0;
            this.com_group_name = "";
            this.com_group_text = "";
        }
    }
    public struct str_sms_cust_select
    {
        public String company_custname ;
        public String company_custmobile ;
        public DateTime company_custdate1 ;
        public DateTime company_custdate2 ;
        public DateTime sms_date1 ;
        public DateTime sms_date2 ;
        public String company_custgroup ;

        public void p_init()
        {
            this.company_custname = "";
            this.company_custmobile = "";
            this.company_custdate1 = Convert.ToDateTime("1900-01-01");
            this.company_custdate2 = Convert.ToDateTime("1900-01-01");
            this.sms_date1 = Convert.ToDateTime("1900-01-01");
            this.sms_date2 = Convert.ToDateTime("1900-01-01");
            this.company_custgroup = "";
        }
    }
    public struct str_sms_cust
    {
        public int company_cust_num ;
        public String company_custname ;
        public String company_custmobile ;
        public String sms_text ;
        public DateTime sms_date ;

        public void p_init()
        {
            this.company_cust_num = 0;
            this.company_custname = "";
            this.company_custmobile = "";
            this.sms_text = "";
            this.sms_date = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_ad_cust_select
    {
        public String company_custname ;
        public String company_custmobile ;
        public DateTime company_custdate1 ;
        public DateTime company_custdate2 ;
        public DateTime ad_send_date1 ;
        public DateTime ad_send_date2 ;
        public String company_custgroup ;

        public void p_init()
        {
            this.company_custname = "";
            this.company_custmobile = "";
            this.company_custdate1 = Convert.ToDateTime("1900-01-01");
            this.company_custdate2 = Convert.ToDateTime("1900-01-01");
            this.ad_send_date1 = Convert.ToDateTime("1900-01-01");
            this.ad_send_date2 = Convert.ToDateTime("1900-01-01");
            this.company_custgroup = "";
        }
    }
    public struct str_ad_cust
    {
        public int company_cust_num ;
        public String company_custname ;
        public String company_custmobile ;
        public int cust_ad_num ;
        public String ad_paper_path ;
        public String sms_text ;
        public String ad_send_yn ;
        public DateTime ad_send_date ;

        public void p_init()
        {
            this.company_cust_num = 0;
            this.company_custname = "";
            this.company_custmobile = "";
            this.cust_ad_num = 0;
            this.ad_paper_path = "";
            this.sms_text = "";
            this.ad_send_yn = "";
            this.ad_send_date = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_company_ad_cust
    {
        public int company_num ;
        public int cust_ad_num ;
        public DateTime ad_req_date ;
        public DateTime ad_make_date ;
        public String ad_maker ;
        public int ad_make_price ;
        public String ad_price_kind ;
        public String ad_price_yn ;
        public String ad_price_confirm_nm ;
        public DateTime ad_price_confirm_date ;
        public String ad_paper_path ;

        public void p_init()
        {
            this.company_num = 0;
            this.cust_ad_num = 0;
            this.ad_req_date = Convert.ToDateTime("1900-01-01");
            this.ad_make_date = Convert.ToDateTime("1900-01-01");
            this.ad_maker = "";
            this.ad_make_price = 0;
            this.ad_price_kind = "";
            this.ad_price_yn = "";
            this.ad_price_confirm_nm = "";
            this.ad_price_confirm_date = Convert.ToDateTime("1900-01-01");
            this.ad_paper_path = "";
        }
    }
    public struct str_member_info
    {
        public int member_num ;
        public String member_mobile ;
        public String member_id ;
        public String member_pw ;
        public String member_nm ;
        public String member_ali ;
        public String member_area1 ;
        public String member_area2 ;
        public DateTime member_insertdate ;
        public String member_sex ;
        public String member_age ;
        public String member_email ;
        public String member_kind ;
        public String member_out_yn ;
        public DateTime member_out_date ;
        public float member_gps_x ;
        public float member_gps_y ;
        public String contract_agree_yn ;
        public DateTime contract_agree_date ;
        public String private_agree_yn ;
        public DateTime private_agree_date ;
        public String sms_agree_yn ;
        public DateTime sms_agree_date ;
        public String email_agree_yn ;
        public DateTime email_agree_date ;
        public String push_agree_yn ;
        public DateTime push_agree_date ;
        public String map_agree_yn ;
        public DateTime map_agree_date ;
        public String auto_login_agree_yn ;
        public DateTime auto_login_agree_date ;
        public int member_num_receive ;
        public DateTime gift_setdate ;
        public int company_num ;
        public String company_employee_kind ;
        public int delivery_num ;
        public int center_code ;
        public String center_grade ;
        public DateTime center_insertdate ;
        public int member_point;

        public void p_init()
        {
            this.member_num = 0;
            this.member_point = 0;
            this.member_mobile = "";
            this.member_id = "";
            this.member_pw = "";
            this.member_nm = "";
            this.member_ali = "";
            this.member_area1 = "";
            this.member_area2 = "";
            this.member_sex = "";
            this.member_age = "";
            this.member_email = "";
            this.member_insertdate = Convert.ToDateTime("1900-01-01");
            this.member_kind = "";
            this.member_out_yn = "";
            this.member_out_date = Convert.ToDateTime("1900-01-01");
            this.member_gps_x = 0;
            this.member_gps_y = 0;
            this.contract_agree_yn = "";
            this.contract_agree_date = Convert.ToDateTime("1900-01-01");
            this.private_agree_yn = "";
            this.private_agree_date = Convert.ToDateTime("1900-01-01");
            this.sms_agree_yn = "";
            this.sms_agree_date = Convert.ToDateTime("1900-01-01");
            this.email_agree_yn = "";
            this.email_agree_date = Convert.ToDateTime("1900-01-01");
            this.push_agree_yn = "";
            this.push_agree_date = Convert.ToDateTime("1900-01-01");
            this.map_agree_yn = "";
            this.map_agree_date = Convert.ToDateTime("1900-01-01");
            this.auto_login_agree_yn = "";
            this.auto_login_agree_date = Convert.ToDateTime("1900-01-01");
            this.member_num_receive = 0;
            this.gift_setdate = Convert.ToDateTime("1900-01-01");
            this.company_num = 0;
            this.company_employee_kind = "";
            this.delivery_num = 0;
            this.center_code = 0;
            this.center_grade = "";
            this.center_insertdate = Convert.ToDateTime("1900-01-01");
        }

    }
    public struct str_member_select
    {
        public int member_num ;
        public String member_kind;
        public String member_mobile ;
        public String member_id ;
        public String member_area1 ;
        public String member_area2 ;
        public String member_sex ;
        public String member_age ;
        public String member_email ;
        public DateTime member_insertdate1 ;
        public DateTime member_insertdate2 ;
        public String member_out_yn ;
        public DateTime member_out_date1 ;
        public DateTime member_out_date2 ;
        public String position ;
        public String member_cart ;
        public int review_count ;
        public int star_count ;
        public int ad_resieve_count ;
        public int sale_count ;
        public int reserve_count ;
        public String sort_review ;
        public String sort_star ;
        public String sort_ad ;
        public String sort_sale ;

        public void p_init()
        {
            this.member_num = 0;
            this.member_kind = "";
            this.member_mobile = "";
            this.member_id = "";
            this.member_sex = "";
            this.member_age = "";
            this.member_area1 = "";
            this.member_area2 = "";
            this.member_email = "";
            this.member_out_yn = "";
            this.member_insertdate1 = Convert.ToDateTime("1900-01-01");
            this.member_insertdate2 = Convert.ToDateTime("1900-01-01");
            this.member_out_date1 = Convert.ToDateTime("1900-01-01");
            this.member_out_date2 = Convert.ToDateTime("1900-01-01");
            this.position = "";
            this.member_cart = "";
            this.review_count = 0;
            this.star_count = 0;
            this.sale_count = 0;
            this.reserve_count = 0;
            this.sort_review = "";
            this.sort_star = "";
            this.sort_ad = "";
            this.sort_sale = "";
        }
    }
    public struct str_simple
    {
        public String mobile ;
        public DateTime connect_date ;
        public int connect_count ;
        public void p_init()
        {
            this.mobile = "";
            this.connect_date = Convert.ToDateTime("1900-01-01");
            this.connect_count = 0;
        }
    }
    public struct str_simple_select
    {
        public String mobile ;
        public DateTime connect_date1 ;
        public DateTime connect_date2 ;
        public int connect_count ;

        public void p_init()
        {
            this.mobile = "";
            this.connect_date1 = Convert.ToDateTime("1900-01-01");
            this.connect_date2 = Convert.ToDateTime("1900-01-01");
            this.connect_count = 0;
        }
    }
    public struct str_ad_member_select
    {
        public String member_mobile ;
        public String member_id ;
        public String company_nm ;
        public String company_mobile ;
        public String ad_kind ;
        public DateTime ad_receive_date1 ;
        public DateTime ad_receive_date2 ;

        public void p_init()
        {
            this.member_mobile = "";
            this.member_id = "";
            this.company_nm = "";
            this.company_mobile = "";
            this.ad_kind = "";
            this.ad_receive_date1 = Convert.ToDateTime("1900-01-01");
            this.ad_receive_date2 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_goods
    {
        public int company_num ;
        public String company_nm ;
        public String company_mobile ;
        public String company_kind ;
        public String company_area1 ;
        public String company_area2 ;
        public String company_address ;
        public String company_tel1 ;
        public String company_tel2 ;
        public int goods_num ;
        public String goods_nm ;
        public String goods_desc ;
        public String goods_image ;
        public String confirm_need_yn ;
        public int goods_point_1 ;
        public int goods_point_2 ;
        public int goods_price_1 ;
        public int goods_price_2 ;

        public void p_init()
        {
            this.company_num = 0;
            this.company_mobile = "";
            this.company_nm = "";
            this.company_kind = "";
            this.company_area1 = "";
            this.company_area2 = "";
            this.company_address = "";
            this.company_tel1 = "";
            this.company_tel2 = "";
            this.goods_num = 0;
            this.goods_nm = "";
            this.goods_desc = "";
            this.goods_image = "";
            this.confirm_need_yn = "";
            this.goods_point_1 = 0;
            this.goods_point_2 = 0;
            this.goods_price_1 = 0;
            this.goods_price_2 = 0;
        }
    }
    public struct str_goods_temp
    {
        public int company_tempnum;
        public int temp_num;
        public String item_kind;
        public String goods_nm;
        public String goods_desc;
        public String goods_image;
        public int goods_point_1;
        public int goods_point_2;
        public int goods_price_1;
        public int goods_price_2;

        public void p_init()
        {
            this.company_tempnum = 0;
            this.temp_num = 0;
            this.item_kind = "";
            this.goods_nm = "";
            this.goods_desc = "";
            this.goods_image = "";
            this.goods_point_1 = 0;
            this.goods_point_2 = 0;
            this.goods_price_1 = 0;
            this.goods_price_2 = 0;
        }
    }
    public struct str_member_goods
    {
        public int member_num ;
        public String member_mobile ;
        public int company_num ;
        public String company_nm ;
        public int goods_num ;
        public String goods_nm ;
        public String conferm_need_yn ;
        public int goods_point_1 ;
        public int goods_point_2 ;
        public int goods_price_1 ;
        public int goods_price_2 ;
        public String push_agree_yn ;
        public DateTime cart_date ;
        public DateTime reserve_date ;
        public String reserve_confirm_yn ;
        public int confirm_member_num ;
        public String buy_yn ;
        public String buy_cancle_yn ;
        public String cancle_kind ;
        public DateTime cancle_date ;
        public String cancle_confirm_yn ;
        public int cancle_confirm_member_num ;
        public int buy_num ;
        public String pay_kind ;
        public DateTime buy_date ;
        public DateTime buy_cancle_date ;
        public String buy_cancle_confirm_yn ;
        public int buy_cancle_confirm_member_num ;
        public String pay_yn ;
        public String pay_device ;
        public DateTime buy_pay_date ;
        public String buy_pay_confirm_yn ;
        public int buy_pay_confirm_member_num ;
        public String buy_refund_yn ;
        public DateTime buy_refund_date ;
        public String buy_refund_confirm_yn ;
        public int buy_refund_confirm_member_num ;
        public String company_review_text ;
        public int recommend_value ;
        public String end_yn;

        public void p_init()
        {
            this.member_num = 0;
            this.member_mobile = "";
            this.company_num = 0;
            this.company_nm = "";
            this.goods_num = 0;
            this.goods_nm = "";
            this.conferm_need_yn = "";
            this.goods_point_1 = 0;
            this.goods_point_2 = 0;
            this.goods_price_1 = 0;
            this.goods_price_2 = 0;
            this.push_agree_yn = "";
            this.cart_date = Convert.ToDateTime("1900-01-01");
            this.reserve_date = Convert.ToDateTime("1900-01-01");
            this.reserve_confirm_yn = "";
            this.confirm_member_num = 0;
            this.buy_yn = "";
            this.buy_cancle_yn = "";
            this.cancle_kind = "";
            this.cancle_date = Convert.ToDateTime("1900-01-01");
            this.cancle_confirm_yn = "";
            this.cancle_confirm_member_num = 0;
            this.buy_num = 0;
            this.pay_kind = "";
            this.buy_date = Convert.ToDateTime("1900-01-01");
            this.buy_cancle_date = Convert.ToDateTime("1900-01-01");
            this.buy_cancle_confirm_yn = "";
            this.buy_cancle_confirm_member_num = 0;
            this.pay_yn = "";
            this.pay_device = "";
            this.buy_pay_date = Convert.ToDateTime("1900-01-01");
            this.buy_pay_confirm_yn = "";
            this.buy_pay_confirm_member_num = 0;
            this.buy_refund_yn = "";
            this.buy_refund_date = Convert.ToDateTime("1900-01-01");
            this.buy_refund_confirm_yn = "";
            this.buy_refund_confirm_member_num = 0;
            this.company_review_text = "";
            this.recommend_value = 0;
            this.end_yn = e_end_yn.미완료.ToString();
        }
    }
    public struct str_cart_select
    {
        public String member_mobile ;
        public String member_id ;
        public String company_nm ;
        public String company_mobile ;
        public DateTime cart_date1 ;
        public DateTime cart_date2 ;

        public void p_init()
        {
            this.member_mobile = "";
            this.member_id = "";
            this.company_nm = "";
            this.company_mobile = "";
            this.cart_date1 = Convert.ToDateTime("1900-01-01");
            this.cart_date2 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_reserve_select
    {
        public String member_mobile ;
        public String member_id ;
        public String company_nm ;
        public String company_mobile ;
        public DateTime reserve_date1 ;
        public DateTime reserve_date2 ;
        public String buy_yn;
        public String reserve_confirm_yn;

        public void p_init()
        {
            this.member_mobile = "";
            this.member_id = "";
            this.company_nm = "";
            this.company_mobile = "";
            this.reserve_date1 = Convert.ToDateTime("1900-01-01");
            this.reserve_date2 = Convert.ToDateTime("1900-01-01");
            this.buy_yn = "";
            this.reserve_confirm_yn = "";
        }
    }
    public struct str_reserve_cancle_select
    {
        public String member_mobile ;
        public String member_id ;
        public String company_nm ;
        public String company_mobile ;
        public DateTime reserve_cancle_date1 ;
        public DateTime reserve_cancle_date2 ;
        public String cancle_confirm_yn;

        public void p_init()
        {
            this.member_mobile = "";
            this.member_id = "";
            this.company_nm = "";
            this.company_mobile = "";
            this.reserve_cancle_date1 = Convert.ToDateTime("1900-01-01");
            this.reserve_cancle_date2 = Convert.ToDateTime("1900-01-01");
            this.cancle_confirm_yn = "";
        }
    }
    public struct str_pay_select
    {
        public String member_mobile;
        public String member_id;
        public String company_nm;
        public String company_mobile;
        public String pay_yn;
        public String pay_confirm_yn;
        public String buy_cancle_yn;
        public DateTime buy_date1;
        public DateTime buy_date2;
        public DateTime buy_pay_date1;
        public DateTime buy_pay_date2;

        public void p_init()
        {
            this.member_mobile = "";
            this.member_id = "";
            this.company_nm = "";
            this.company_mobile = "";
            this.pay_yn = "";
            this.pay_confirm_yn = "";
            this.buy_cancle_yn = "";
            this.buy_date1 = Convert.ToDateTime("1900-01-01");
            this.buy_date2 = Convert.ToDateTime("1900-01-01");
            this.buy_pay_date1 = Convert.ToDateTime("1900-01-01");
            this.buy_pay_date2 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_pay_cancle_select
    {
        public String member_mobile;
        public String member_id;
        public String company_nm;
        public String company_mobile;
        public String buy_cancle_confirm_yn;
        public String buy_refund_confirm_yn;
        public String buy_refund_yn;
        public DateTime buy_cancle_date1;
        public DateTime buy_cancle_date2;
        public DateTime buy_refund_date1;
        public DateTime buy_refund_date2;

        public void p_init()
        {
            this.member_mobile = "";
            this.member_id = "";
            this.company_nm = "";
            this.company_mobile = "";
            this.buy_cancle_confirm_yn = "";
            this.buy_refund_confirm_yn = "";
            this.buy_refund_yn = "";
            this.buy_cancle_date1 = Convert.ToDateTime("1900-01-01");
            this.buy_cancle_date2 = Convert.ToDateTime("1900-01-01");
            this.buy_refund_date1 = Convert.ToDateTime("1900-01-01");
            this.buy_refund_date2 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_point_system
    {
        public int bunrate_member ;
        public int bunrate_center ;
        public int bunrate_bonsa ;
        public int minpoint_push ;
        public int minpoint_event ;
        public int abledate_use ;
        public int minpoint_use ;
        public int minpoint_money ;

        public void p_init()
        {
            this.bunrate_member = 0;
            this.bunrate_center = 0;
            this.bunrate_bonsa = 0;
            this.minpoint_push = 0;
            this.minpoint_event = 0;
            this.abledate_use = 0;
            this.minpoint_use = 0;
            this.minpoint_money = 0;
        }
    }
    public struct str_point
    {
        public int point_num;
        public int company_num ;
        public String company_nm ;
        public String company_mobile;
        public int member_num ;
        public String member_mobile ;
        public String member_id ;
        public String point_kind;
        public int point_price;
        public DateTime point_date;
        public int ad_num ;
        public String ad_kind ;
        public int buy_num ;
        public String goods_nm ;
        public int member_num_send;

        public void p_init()
        {
            this.point_num = 0;
            this.company_num = 0;
            this.company_nm = "";
            this.company_mobile = "";
            this.member_num = 0;
            this.member_mobile = "";
            this.member_id = "";
            this.point_kind = "";
            this.point_price = 0;
            this.point_date = Convert.ToDateTime("1900-01-01");
            this.ad_num = 0;
            this.ad_kind = "";
            this.buy_num = 0;
            this.goods_nm = "";
            this.member_num_send = 0;
        }
    }
    public struct str_point_select
    {
        public String member_mobile ;
        public String member_id ;
        public String company_nm ;
        public String company_mobile ;
        public DateTime point_date1 ;
        public DateTime point_date2 ;

        public void p_init()
        {
            this.member_mobile = "";
            this.member_id = "";
            this.company_nm = "";
            this.company_mobile = "";
            this.point_date1 = Convert.ToDateTime("1900-01-01");
            this.point_date2 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_point_select_add
    {
        public int company_num;
        public String company_nm;
        public String company_mobile;
        public DateTime point_date1;
        public DateTime point_date2;

        public void p_init()
        {
            this.company_num = 0;
            this.company_nm = "";
            this.company_mobile = "";
            this.point_date1 = Convert.ToDateTime("1900-01-01");
            this.point_date2 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_point_add
    {
        public int point_num;
        public int company_num;      
        public int point_add_price;
        public String point_add_price_kind;
        public String point_add_price_yn;
        public String point_add_price_confirm_nm;
        public DateTime point_add_price_confirm_date;

        public void p_init()
        {
            this.point_num = 0;
            this.company_num = 0;          
            this.point_add_price = 0;
            this.point_add_price_kind = "";
            this.point_add_price_yn = "";
            this.point_add_price_confirm_nm = "";
            this.point_add_price_confirm_date = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_point_select_gift
    {
        public String member_mobile;
        public String member_id;
        public String company_nm;
        public String company_mobile;
        public DateTime gift_set_date1;
        public DateTime gift_set_date2;

        public void p_init()
        {
            this.member_mobile = "";
            this.member_id = "";
            this.company_nm = "";
            this.company_mobile = "";
            this.gift_set_date1 = Convert.ToDateTime("1900-01-01");
            this.gift_set_date2 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_point_select_exchange
    {
        public String member_mobile;
        public String member_id;
        public String company_nm;
        public String company_mobile;
 
        public void p_init()
        {
            this.member_mobile = "";
            this.member_id = "";
            this.company_nm = "";
            this.company_mobile = "";
        }
    }
    public struct str_point_exchange_company
    {
        public int point_num;
        public int company_num;
        public int company_money_price;
        public String company_money_account;
        public String company_money_price_yn;
        public String company_money_price_confirm_nm;
        public DateTime company_money_price_confirm_date;
        public String company_money_account_name;
        public String company_money_account_bank;

        public void p_init()
        {
            this.point_num = 0;
            this.company_num = 0;
            this.company_money_price = 0;
            this.company_money_account = "";
            this.company_money_price_yn = "";
            this.company_money_price_confirm_nm = "";
            this.company_money_price_confirm_date = Convert.ToDateTime("1900-01-01");
            this.company_money_account_name = "";
            this.company_money_account_bank = "";

        }
    }
    public struct str_point_exchange_member
    {
        public int point_num;
        public int member_num;
        public int member_money_price;
        public String member_money_account;
        public String member_money_price_yn;
        public String member_money_price_confirm_nm;
        public DateTime member_money_price_confirm_date;
        public String member_money_account_name;
        public String member_money_account_bank;

        public void p_init()
        {
            this.point_num = 0;
            this.member_num = 0;
            this.member_money_price = 0;
            this.member_money_account = "";
            this.member_money_price_yn = "";
            this.member_money_price_confirm_nm = "";
            this.member_money_price_confirm_date = Convert.ToDateTime("1900-01-01");
            this.member_money_account_name = "";
            this.member_money_account_bank = "";

        }
    }

    public struct str_point_sum_member
    {
        public int member_num ;
        public String member_mobile ;
        public String member_id ;
        public int tot_count ;
        public int used_count ;
        public int exchange_count ;
        public int buy_count ;
        public int ad_push_count ;
        public int ad_event_count ;
        public int able_count ;
        public int exchange_able_count ;
        public int buy_able_count ;

        public void p_init()
        {
            this.member_num = 0;
            this.member_mobile = "";
            this.member_id = "";
            this.tot_count = 0;
            this.used_count = 0;
            this.exchange_count = 0;
            this.buy_count = 0;
            this.ad_push_count = 0;
            this.ad_event_count = 0;
            this.able_count = 0;
            this.exchange_able_count = 0;
            this.buy_able_count = 0;
        }
    }
    public struct str_point_sum_company
    {
        public int company_num ;
        public String company_mobile ;
        public String company_nm ;
        public int tot_count ;
        public int used_count ;
        public int exchange_count ;
        public int buy_count ;
        public int ad_push_count ;
        public int ad_event_count ;
        public int able_count ;
        public int exchange_able_count ;
        public int buy_able_count ;
        public int reuse_able_count ;
        public int add_count ;

        public void p_init()
        {
            this.company_num = 0;
            this.company_mobile = "";
            this.company_nm = "";
            this.tot_count = 0;
            this.used_count = 0;
            this.exchange_count = 0;
            this.buy_count = 0;
            this.ad_push_count = 0;
            this.ad_event_count = 0;
            this.able_count = 0;
            this.exchange_able_count = 0;
            this.buy_able_count = 0;
            this.reuse_able_count = 0;
            this.add_count = 0;
        }
    }
    
    public struct str_map_info
    {
        public String address ;
        public int gps_x ;
        public int gps_y ;

        public void p_init()
        {
            this.address = "";
            this.gps_x = 0;
            this.gps_y = 0;
        }
    }
    public struct str_login_member
    {
        public String member_id ;
        public String member_pw ;

        public void p_init()
        {
            this.member_id = "";
            this.member_pw = "";
        }
    }
    public struct str_manager_select
    {
        public String manager_id ;
        public String manager_name;
        public String manager_mobile ;

        public void p_init()
        {
            this.manager_id = "";
            this.manager_name = "";
            this.manager_mobile = "";
        }
    }
    public struct str_manager
    {
        public int manager_num ;
        public String manager_id ;
        public String manager_pw ;
        public String manager_name ;
        public String manager_mobile ;
        public String manager_ip ;
        public String manager_mac ;
        public String manager_secu_key ;
        public String manager_secu_key_path ;
        public String manager_grade ;
        public DateTime manager_insertdate ;
        public String insert_nm ;


        public void p_init()
        {
            this.manager_num = 0;
            this.manager_id = "";
            this.manager_pw = "";
            this.manager_name = "";
            this.manager_mobile = "";
            this.manager_ip = "";
            this.manager_mac = "";
            this.manager_secu_key = "";
            this.manager_secu_key_path = "";
            this.manager_grade = "";
            this.manager_insertdate = Convert.ToDateTime("1900-01-01");
            this.insert_nm = "";
        }
    }
    public struct str_history_select
    {
        public String member_mobile1 ;
        public String member_id1 ;
        public String company_mobile ;
        public String company_nm ;
        public String member_mobile2 ;
        public String member_id2 ;
        public String manager_id ;
        public String manager_name ;
        public String manager_mobile ;
        public DateTime login_date1 ;
        public DateTime login_date2 ;

        public void p_init()
        {
            this.member_mobile1 = "";
            this.member_id1 = "";
            this.company_mobile = "";
            this.company_nm = "";
            this.member_mobile2 = "";
            this.member_id2 = "";
            this.manager_id = "";
            this.manager_name = "";
            this.manager_mobile = "";
            this.login_date1 = Convert.ToDateTime("1900-01-01");
            this.login_date2 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_history
    {
        public String member_mobile1 ;
        public String member_id1 ;
        public String company_mobile ;
        public DateTime login_date1 ;

        public void p_init()
        {
            this.member_mobile1 = "";
            this.member_id1 = "";
            this.company_mobile = "";
            this.login_date1 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_post_select
    {
        public String SIDO ;
        public String SIGUN ;
        public String EM ;
        public String ROAD_NM ;
        public String LANDMARK ;

        public void p_init()
        {
            this.SIDO = "";
            this.SIGUN = "";
            this.EM = "";
            this.ROAD_NM = "";
            this.LANDMARK = "";
        }
    }
    public struct str_post
    {
        public String ZIPCODE ;
        public String SIDO ;
        public String SIGUN ;
        public String EM ;
        public String ROAD_CD ;
        public String ROAD_NM ;
        public String GROUND ;
        public String BUILD_1 ;
        public String BUILD_2 ;
        public String ROAD_KEY ;
        public String BUILD_NO ;
        public String LANDMARK ;
        public String DONG_CD ;
        public String DONG_NM ;
        public String HANG_NM ;
        public String JI_1 ;
        public String JI_2 ;
        public String ZIPCODE_OLD ;
        public String addr_ji ;
        public String addr_ro ;
        public String donga_center ;

        public void p_init()
        {
            this.ZIPCODE = "";
            this.SIDO = "";
            this.SIGUN = "";
            this.EM = "";
            this.ROAD_CD = "";
            this.ROAD_NM = "";
            this.GROUND = "";
            this.BUILD_1 = "";
            this.BUILD_2 = "";
            this.ROAD_KEY = "";
            this.BUILD_NO = "";
            this.LANDMARK = "";
            this.DONG_CD = "";
            this.DONG_NM = "";
            this.HANG_NM = "";
            this.JI_1 = "";
            this.JI_2 = "";
            this.ZIPCODE_OLD = "";
            this.addr_ji = "";
            this.addr_ro = "";
            this.donga_center = "";
        }
    }

    public struct str_code
    {
        public int datanum;
        public String gubun_nm;
        public String code_nm;
        public String gubun_code;
        public String code;
        public String useyn;
        public String def_yn;
        public int sort_order;

        public void p_init()
        {
            this.datanum = 0;
            this.gubun_nm = "";
            this.code_nm = "";
            this.gubun_code = "";
            this.code = "";
            this.useyn = "";
            this.def_yn = "";
            this.sort_order = 0;
        }
    }
    public struct str_code2
    {
        public int datanum;
        public String gubun_nm;
        public String code_nm;
        public String gubun_code;
        public String code;
        public String middle_code_nm;
        public String middle_code;
        public String useyn;
        public String def_yn;
        public int sort_order;

        public void p_init()
        {
            this.datanum = 0;
            this.gubun_nm = "";
            this.code_nm = "";
            this.gubun_code = "";
            this.code = "";
            this.middle_code_nm = "";
            this.middle_code = "";
            this.useyn = "";
            this.def_yn = "";
            this.sort_order = 0;
        }
    }
    public struct str_counsel
    {
        public int req_num ;
        public int member_num ;
        public String member_mobile ;
        public String counsel_kind ;
        public String counsel_memo ;
        public DateTime counsel_date ;
        public String tret_yn ;
        public String tret_nm ;
        public DateTime tret_date ;

        public void p_init()
        {
            this.req_num = 0;
            this.member_num = 0;
            this.counsel_kind = "";
            this.member_mobile = "";
            this.counsel_memo = "";
            this.counsel_date = Convert.ToDateTime("1900-01-01");
            this.tret_yn = "";
            this.tret_nm = "";
            this.tret_date = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_paper_money
    {
        public int req_num ;
        public int member_num ;
        public String member_mobile ;
        public int point_price ;
        public String memo ;
        public DateTime req_date ;
        public String tret_yn ;
        public String tret_nm ;
        public DateTime tret_date ;

        public void p_init()
        {
            this.req_num = 0;
            this.member_num = 0;
            this.point_price = 0;
            this.member_mobile = "";
            this.memo = "";
            this.req_date = Convert.ToDateTime("1900-01-01");
            this.tret_yn = "";
            this.tret_nm = "";
            this.tret_date = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_center_select
    {
        public int center_code ;
        public String center_nm ;
        public String center_cap ;
        public String center_address ;

        public void p_init()
        {
            this.center_nm = "";
            this.center_cap = "";
            this.center_address = "";
            this.center_code = 0;
        }
    }
    public struct str_center
    {
        public String center_nm ;
        public String center_cap ;
        public String center_address ;
        public String member_mobile ;

        public void p_init()
        {
            this.center_nm = "";
            this.center_cap = "";
            this.center_address = "";
            this.member_mobile = "";
        }
    }
    public struct str_center_user_select
    {
        public int center_code ;
        public String center_nm ;
        public String center_cap ;
        public String center_address ;

        public void p_init()
        {
            this.center_nm = "";
            this.center_cap = "";
            this.center_address = "";
            this.center_code = 0;
        }
    }
    public struct str_center_user
    {
        public int delivery_num ;
        public int member_num ;
        public int center_code ;
        public String center_nm ;
        public String center_cap ;
        public String center_mobile ;
        public String center_grade ;
        public DateTime center_insertdate ;
        public String insert_nm ;

        public void p_init()
        {
            this.delivery_num = 0;
            this.member_num = 0;
            this.center_code = 0;
            this.center_nm = "";
            this.center_cap = "";
            this.center_mobile = "";
            this.center_grade = "";
            this.center_insertdate = Convert.ToDateTime("1900-01-01");
            this.insert_nm = "";
        }
    }
    public struct str_center_area_select
    {
        public String center_nm ;
        public String road_nm ;
        public String landmark ;
        public String em ;

        public void p_init()
        {
            this.center_nm = "";
            this.road_nm = "";
            this.landmark = "";
            this.em = "";
        }
    }
    public struct str_center_area
    {
        public int center_code ;
        public String ZIPCODE ;
        public String ROAD_NM ;
        public String LANDMARK ;
        public String EM ;
        public String addr_ji ;
        public String addr_ro ;
        public String ROAD_CD ;
        public String ROAD_KEY ;

        public void p_init()
        {
            this.center_code = 0;
            this.ZIPCODE = "";
            this.EM = "";
            this.ROAD_CD = "";
            this.ROAD_NM = "";
            this.LANDMARK = "";
            this.addr_ji = "";
            this.addr_ro = "";
        }
    }
    public struct str_center_cust_select
    {
        public String center_nm ;
        public String center_custnm ;
        public String center_custmobile ;
        public String center_custaddress ;
        public String center_custpress ;
        public String center_custpart ;
        public int center_custpart_num1 ;
        public int center_custpart_num2 ;
        public int center_custtot_num1 ;
        public int center_custtot_num2 ;
        public String center_custdeli_yn ;
        public DateTime getmoney_date ;
        public DateTime getmoney_date1 ;
        public DateTime getmoney_date2 ;
        public String tret_yn ;
        public DateTime tret_date1 ;
        public DateTime tret_date2 ;
        public DateTime sms_date1 ;
        public DateTime sms_date2 ;

        public void p_init()
        {
            this.center_nm = "";
            this.center_custnm = "";
            this.center_custmobile = "";
            this.center_custaddress = "";
            this.center_custpress = "";
            this.center_custpart = "";
            this.center_custpart_num1 = 0;
            this.center_custpart_num2 = 0;
            this.center_custtot_num1 = 0;
            this.center_custtot_num2 = 0;
            this.center_custdeli_yn = "";
            this.getmoney_date = Convert.ToDateTime("1900-01-01");
            this.getmoney_date1 = Convert.ToDateTime("1900-01-01");
            this.getmoney_date2 = Convert.ToDateTime("1900-01-01");
            this.tret_yn = "";
            this.tret_date1 = Convert.ToDateTime("1900-01-01");
            this.tret_date2 = Convert.ToDateTime("1900-01-01");
            this.sms_date1 = Convert.ToDateTime("1900-01-01");
            this.sms_date2 = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_center_cust
    {
        public int center_custnum ;
        public int center_code ;
        public String center_custnm ;
        public String center_custmobile ;
        public String center_custaddress ;
        public String center_custpress ;
        public String center_custmemo ;
        public String center_custpart ;
        public int center_custpart_num ;
        public int center_custtot_num ;
        public String center_custdeli_yn ;
        public DateTime getmoney_date ;
        public int getmoney_price ;

        public void p_init()
        {
            this.center_custnum = 0;
            this.center_code = 0;
            this.center_custnm = "";
            this.center_custmobile = "";
            this.center_custaddress = "";
            this.center_custpress = "";
            this.center_custmemo = "";
            this.center_custpart = "";
            this.center_custpart_num = 0;
            this.center_custtot_num = 0;
            this.center_custdeli_yn = "";
            this.getmoney_date = Convert.ToDateTime("1900-01-01");
            this.getmoney_price = 0;
        }
    }
    public struct str_center_money
    {
        public int center_custnum ;
        public String getmoney_press ;
        public DateTime getmoney_date ;
        public int getmoney_price ;
        public String tret_yn ;
        public String tret_nm ;
        public DateTime tret_date ;

        public void p_init()
        {
            this.center_custnum = 0;
            this.getmoney_press = "";
            this.tret_yn = "";
            this.tret_nm = "";
            this.getmoney_price = 0;
            this.getmoney_date = Convert.ToDateTime("1900-01-01");
            this.tret_date = Convert.ToDateTime("1900-01-01");
        }
    }
    public struct str_center_smshitory
    {
        public int center_custnum ;
        public String center_custnm ;
        public String center_nm ;
        public String sms_text ;
        public DateTime tret_date ;

        public void p_init()
        {
            this.center_custnum = 0;
            this.center_custnm = "";
            this.center_nm = "";
            this.sms_text = "";
            this.tret_date = Convert.ToDateTime("1900-01-01");
        }
    }


    public static class cls_book
    {
        public static String g_user_nm = "고형권";
        public static String g_user_id = "1";
        public static Int32 g_user_num = 99;

        
        public static SqlConnection g_connection;
        public static String f_connectionString()
        {
            String v_connectionString;
            v_connectionString = "Data Source=210.114.221.45;Initial Catalog=bookcitycall;Persist Security Info=True;User ID=bookcitycall;Password=qnrtlxl$!@#45";
            return v_connectionString;
        }
       
        public static Boolean f_connect_database(String v_connectionString)
        {
            Boolean v_con_ok;


            try
            {
                g_connection = new SqlConnection(v_connectionString);
                g_connection.Open();
                MessageBox.Show("디비접속성공");
                v_con_ok = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("디비접속에러");
                v_con_ok = false;
                throw;
            }
            finally
            {
                g_connection.Close();
            }

            return v_con_ok;
        }
        public static Boolean f_connect_database()
        {
            Boolean v_con_ok;


            try
            {
                String v_st = f_connectionString();
                g_connection = new SqlConnection(v_st);
                g_connection.Open();
                MessageBox.Show("디비접속성공");
                v_con_ok = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("디비접속에러");
                v_con_ok = false;

            }
            finally
            {
                g_connection.Close();
            }

            return v_con_ok;
        }
        public static String f_select(String v_sql, out String v_result)
        {


            DataSet g_dataset = new DataSet();
            String v_xmltext = "";

            try
            {
                String v_st = f_connectionString();
                g_connection = new SqlConnection(v_st);

                SqlDataAdapter g_sqlcommand = new SqlDataAdapter(v_sql, g_connection);
                g_sqlcommand.Fill(g_dataset);
                DataTable g_table;
                g_table = g_dataset.Tables[0];
                if (g_table.Rows.Count == 0)
                {
                    v_result = "검색데이타 없음";
                    v_xmltext = "";
                    return v_xmltext;
                }
                else
                {
                    v_result = "검색데이타 : " + Convert.ToString(g_table.Rows.Count) + " 건";
                    v_xmltext = g_dataset.GetXml();
                    return v_xmltext;
                }


            }
            catch (Exception e)
            {
                v_result = e.Message;
                v_xmltext = "";
                return v_xmltext;
            }
            finally
            {
                g_connection.Close();
            }

        }
        public static String f_select_sql(String v_sql, out String v_result)
        {
            String v_xml;
            v_xml = f_select(v_sql, out v_result);
            return v_xml;
        }
        public static int f_select_count(String v_sql)
        {


            try
            {
                String v_st = f_connectionString();
                g_connection = new SqlConnection(v_st);
                SqlCommand g_command = new SqlCommand(v_sql, g_connection);
                g_connection.Open();
                SqlDataReader g_reader = g_command.ExecuteReader();
                if (g_reader.HasRows == true)
                {
                    g_reader.Close();
                    return 1;
                }
                else
                {
                    g_reader.Close();
                    return 0;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
            finally
            {
                g_connection.Close();
            }

        }
        public static int f_identity()
        {

            try
            {
                String v_st = f_connectionString();
                int v_data = 0;
                g_connection = new SqlConnection(v_st);
                SqlCommand g_command = new SqlCommand("insert into t_identity(name) values('111'); select @@IDENTITY ", g_connection);
                g_connection.Open();
                SqlDataReader g_reader = g_command.ExecuteReader();
                if (g_reader.HasRows == true)
                {
                    while (g_reader.Read())
                    {
                        v_data = Convert.ToInt32(g_reader.GetValue(0));
                    }
                    g_reader.Close();
                    return v_data;
                }
                else
                {
                    g_reader.Close();
                    return 0;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
            finally
            {
                g_connection.Close();
            }

        }
        public static String f_sql_insert(String v_sql)
        {

            String v_xmltext = "";
            SqlTransaction g_sqltran;
            int v_count;
            v_count = 0;

            try
            {
                String v_st = f_connectionString();
                g_connection = new SqlConnection(v_st);
                g_connection.Open();
                SqlCommand g_sqlcommand = new SqlCommand(v_sql, g_connection);
                g_sqlcommand.CommandTimeout = 0;
                g_sqltran = g_connection.BeginTransaction();
                g_sqlcommand.Transaction = g_sqltran;
                v_count = g_sqlcommand.ExecuteNonQuery();
                g_sqltran.Commit();
                if (v_count == 0)
                {
                    v_xmltext = "입력실패";
                    return v_xmltext;
                }
                else
                {
                    v_xmltext = "입력성공";
                    return v_xmltext;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                v_xmltext = "error";
                return v_xmltext;
            }
            finally
            {
                g_connection.Close();
            }

        }
        public static String f_sql_update(String v_sql)
        {

            String v_xmltext = "";
            SqlTransaction g_sqltran;
            int v_count;
            v_count = 0;

            try
            {
                String v_st = f_connectionString();
                g_connection = new SqlConnection(v_st);
                g_connection.Open();
                SqlCommand g_sqlcommand = new SqlCommand(v_sql, g_connection);
                g_sqlcommand.CommandTimeout = 0;
                g_sqltran = g_connection.BeginTransaction();
                g_sqlcommand.Transaction = g_sqltran;
                v_count = g_sqlcommand.ExecuteNonQuery();
                g_sqltran.Commit();
                if (v_count == 0)
                {
                    v_xmltext = "수정실패";
                    return v_xmltext;
                }
                else
                {
                    v_xmltext = "수정성공";
                    return v_xmltext;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                v_xmltext = "error";
                return v_xmltext;
            }
            finally
            {
                g_connection.Close();
            }

        }
        public static String f_sql_delete(String v_sql)
        {

            String v_xmltext = "";
            SqlTransaction g_sqltran;
            int v_count;
            v_count = 0;

            try
            {
                String v_st = f_connectionString();
                g_connection = new SqlConnection(v_st);
                g_connection.Open();
                SqlCommand g_sqlcommand = new SqlCommand(v_sql, g_connection);
                g_sqlcommand.CommandTimeout = 0;
                g_sqltran = g_connection.BeginTransaction();
                g_sqlcommand.Transaction = g_sqltran;
                v_count = g_sqlcommand.ExecuteNonQuery();
                g_sqltran.Commit();
                if (v_count == 0)
                {
                    v_xmltext = "삭제실패";
                    return v_xmltext;
                }
                else
                {
                    v_xmltext = "삭제성공";
                    return v_xmltext;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                v_xmltext = "error";
                return v_xmltext;
            }
            finally
            {
                g_connection.Close();
            }

        }

        public static String f_id_check(String v_id)
        {
            String v_ret;
            v_ret = "ok";
            //여기에 체크모듈 기술

            return v_ret;
        }
        public static String f_pw_check(String v_pw)
        {
            String v_ret;
            v_ret = "ok";
            //여기에 체크모듈 기술

            return v_ret;
        }
        public static String f_ali_check(String v_ali)
        {
            String v_ret;
            v_ret = "ok";
            //여기에 체크모듈 기술

            return v_ret;
        }
       
        public static String f_return_xmlnod(String v_xml, String v_find_nod)
        {
            String v_xmlnod = "";
            XmlDocument xml = new XmlDocument(); // XmlDocument 생성
            xml.LoadXml(v_xml);
            XmlNodeList xnList = xml.GetElementsByTagName("Table"); //접근할 노드

            foreach (XmlNode xn in xnList)
            {
                v_xmlnod = xn[v_find_nod].InnerText;
            }

            return v_xmlnod;
        }
        public static void f_mapping_xml_structure(String v_xml, ref object v_struc_before)
        {
            String v_ret;
            Type t = v_struc_before.GetType();

            FieldInfo[] fields = t.GetFields(BindingFlags.Instance | BindingFlags.Public);
            foreach (FieldInfo f in fields)
            {

                if (f.FieldType == typeof(Int32))
                {
                    v_ret = f_return_xmlnod(v_xml, f.Name);
                    f.SetValue(v_struc_before, Convert.ToInt32(v_ret));
                    continue;
                }
                if (f.FieldType == typeof(DateTime))
                {
                    v_ret = f_return_xmlnod(v_xml, f.Name);
                    f.SetValue(v_struc_before, Convert.ToDateTime(v_ret));
                    continue;
                }
                if (f.FieldType == typeof(String))
                {
                    v_ret = f_return_xmlnod(v_xml, f.Name);
                    f.SetValue(v_struc_before, Convert.ToString(v_ret));
                    continue;
                }
            }
            
            return;
        }
        public static Boolean f_combo_additem(string v_xml, ComboBox v_combo)
        {
            try
            {
                v_combo.Items.Clear();
                XmlReader v_xmlReader = XmlReader.Create(new StringReader(v_xml));
                while (v_xmlReader.Read())
                {
                    switch (v_xmlReader.NodeType)
                    {

                        case XmlNodeType.Text:
                            v_combo.Items.Add(v_xmlReader.Value);
                            break;
                    }
                }
                v_combo.Text = "";
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public static void f_combo_xmlnod(ComboBox v_combo, string v_xml, string v_kind)
        {
            string v_xmlnod;
            XmlDocument xml = new XmlDocument(); // XmlDocument 생성
            xml.LoadXml(v_xml);
            XmlNodeList xnList = xml.GetElementsByTagName("Table");

            foreach (XmlNode xn in xnList)
            {
                v_xmlnod = xn[v_kind].InnerText;
                v_combo.Items.Add(v_xmlnod);
            }

            return;
        }
        public static String f_select_area1(out String v_result)
        {
            String v_xml;
            v_xml = f_select("select sido  from t_find_post group by sido order by sido", out v_result);
            return v_xml;
        }
        public static String f_select_area2(String v_area1, out String v_result)
        {
            String v_xml;
            v_xml = f_select("select sigun  from t_find_post where sido='" + v_area1 + "' order by sigun", out v_result);
            return v_xml;
        }

        public static String f_select_code(out String v_result)
        {
            String v_xml;
            v_xml = f_select("select datanum,gubun_nm,code_nm,code,gubun_code,useyn,sort_order,def_yn  from t_code_info order by gubun_nm,sort_order", out v_result);
            return v_xml;
        }
        public static void f_insert_code(str_code v_str_code, out String v_result)
        {
            String v_sql;

            v_sql = "insert into t_code_info(";
            v_sql = v_sql + "datanum,";
            v_sql = v_sql + "gubun_nm,";
            v_sql = v_sql + "code_nm,";
            v_sql = v_sql + "gubun_code,";
            v_sql = v_sql + "code,";
            v_sql = v_sql + "useyn,";
            v_sql = v_sql + "def_yn,";
            v_sql = v_sql + "sort_order)";

            v_sql = v_sql + " values(";
            v_sql = v_sql + "" + Convert.ToString(f_identity()) + ",";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.gubun_nm) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.code_nm) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.gubun_code) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.code) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.useyn) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.def_yn) + "', ";
            v_sql = v_sql + "" + Convert.ToString(v_str_code.sort_order) + ") ";
            v_result = f_sql_insert(v_sql);

        }
        public static void f_update_code(str_code v_str_code, out String v_result)
        {
            String v_sql;

            v_sql = "update t_code_info set ";
            v_sql = v_sql + "gubun_nm=" + "'" + Convert.ToString(v_str_code.gubun_nm) + "',";
            v_sql = v_sql + "code_nm=" + "'" + Convert.ToString(v_str_code.code_nm) + "', ";
            v_sql = v_sql + "gubun_code=" + "'" + Convert.ToString(v_str_code.gubun_code) + "',";
            v_sql = v_sql + "code=" + "'" + Convert.ToString(v_str_code.code) + "', ";
            v_sql = v_sql + "useyn=" + "'" + Convert.ToString(v_str_code.useyn) + "',";
            v_sql = v_sql + "def_yn=" + "'" + Convert.ToString(v_str_code.def_yn) + "', ";
            v_sql = v_sql + "sort_order=" + "" + Convert.ToString(v_str_code.sort_order) + " ";
            v_sql = v_sql + " where datanum=" + "" + Convert.ToString(v_str_code.datanum) + " ";
            v_result = f_sql_update(v_sql);

        }
        public static void f_delete_code(str_code v_str_code, out String v_result)
        {
            String v_sql;

            v_sql = "delete from t_code_info ";
            v_sql = v_sql + " where datanum=" + "" + Convert.ToString(v_str_code.datanum) + " ";
            v_result = f_sql_delete(v_sql);

        }
        public static String f_select_code2(out String v_result)
        {
            String v_xml;
            v_xml = f_select("select datanum,gubun_nm,code_nm,code,gubun_code,middle_code_nm,middle_code,useyn,sort_order,def_yn  from t_code_info2 order by gubun_nm,middle_code_nm,sort_order", out v_result);
            return v_xml;
        }
        public static void f_insert_code2(str_code2 v_str_code, out String v_result)
        {
            String v_sql;

            v_sql = "insert into t_code_info2(";
            v_sql = v_sql + "datanum,";
            v_sql = v_sql + "gubun_nm,";
            v_sql = v_sql + "code_nm,";
            v_sql = v_sql + "gubun_code,";
            v_sql = v_sql + "code,";
            v_sql = v_sql + "middle_code_nm,";
            v_sql = v_sql + "middle_code,";
            v_sql = v_sql + "useyn,";
            v_sql = v_sql + "def_yn,";
            v_sql = v_sql + "sort_order)";

            v_sql = v_sql + " values(";
            v_sql = v_sql + "" + Convert.ToString(f_identity()) + ",";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.gubun_nm) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.code_nm) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.gubun_code) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.code) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.middle_code_nm) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.middle_code) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.useyn) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_code.def_yn) + "', ";
            v_sql = v_sql + "" + Convert.ToString(v_str_code.sort_order) + ") ";
            v_result = f_sql_insert(v_sql);

        }
        public static void f_update_code2(str_code2 v_str_code, out String v_result)
        {
            String v_sql;

            v_sql = "update t_code_info set ";
            v_sql = v_sql + "gubun_nm=" + "'" + Convert.ToString(v_str_code.gubun_nm) + "',";
            v_sql = v_sql + "code_nm=" + "'" + Convert.ToString(v_str_code.code_nm) + "', ";
            v_sql = v_sql + "gubun_code=" + "'" + Convert.ToString(v_str_code.gubun_code) + "',";
            v_sql = v_sql + "code=" + "'" + Convert.ToString(v_str_code.code) + "', ";
            v_sql = v_sql + "middle_code_nm=" + "'" + Convert.ToString(v_str_code.middle_code_nm) + "',";
            v_sql = v_sql + "middle_code=" + "'" + Convert.ToString(v_str_code.middle_code) + "', ";
            v_sql = v_sql + "useyn=" + "'" + Convert.ToString(v_str_code.useyn) + "',";
            v_sql = v_sql + "def_yn=" + "'" + Convert.ToString(v_str_code.def_yn) + "', ";
            v_sql = v_sql + "sort_order=" + "" + Convert.ToString(v_str_code.sort_order) + " ";
            v_sql = v_sql + " where datanum=" + "" + Convert.ToString(v_str_code.datanum) + " ";
            v_result = f_sql_update(v_sql);

        }
        public static void f_delete_code2(str_code2 v_str_code, out String v_result)
        {
            String v_sql;

            v_sql = "delete from t_code_info2 ";
            v_sql = v_sql + " where datanum=" + "" + Convert.ToString(v_str_code.datanum) + " ";
            v_result = f_sql_delete(v_sql);

        }
        public static String f_select_post(str_post_select v_str_select_post, out String v_result)
        {
            String v_xml;
            String v_sql;

            v_sql = "select top 1000 *  from t_zipcode_new where 1=1 ";
            if (v_str_select_post.SIDO != "")
            {
                v_sql = v_sql + " and sido='" + v_str_select_post.SIDO + "'";
            }
            if (v_str_select_post.SIGUN != "")
            {
                v_sql = v_sql + " and sigun='" + v_str_select_post.SIGUN + "'";
            }
            if (v_str_select_post.EM != "")
            {
                v_sql = v_sql + " and em='" + v_str_select_post.EM + "'";
            }
            if (v_str_select_post.ROAD_NM != "")
            {
                v_sql = v_sql + " and road_nm='" + v_str_select_post.ROAD_NM + "'";
            }
            if (v_str_select_post.LANDMARK != "")
            {
                v_sql = v_sql + " and landmark='" + v_str_select_post.LANDMARK + "'";
            }

            v_xml = f_select(v_sql, out v_result);
            return v_xml;
        }
        public static void f_insert_post(str_post v_str_post, out String v_result)
        {
            String v_sql;

            v_sql = "insert into t_zipcode_new(";
            v_sql = v_sql + "zipcode,";
            v_sql = v_sql + "sido,";
            v_sql = v_sql + "sigun,";
            v_sql = v_sql + "em,";
            v_sql = v_sql + "road_cd,";
            v_sql = v_sql + "road_nm,";
            v_sql = v_sql + "ground,";
            v_sql = v_sql + "build_1,";
            v_sql = v_sql + "build_2,";
            v_sql = v_sql + "road_key,";
            v_sql = v_sql + "build_no,";
            v_sql = v_sql + "landmark,";
            v_sql = v_sql + "dong_cd,";
            v_sql = v_sql + "dong_nm,";
            v_sql = v_sql + "hang_nm,";
            v_sql = v_sql + "ji_1,";
            v_sql = v_sql + "ji_2,";
            v_sql = v_sql + "zipcode_old,";
            v_sql = v_sql + "addr_ji,";
            v_sql = v_sql + "addr_ro,";
            v_sql = v_sql + "donga_center)";
            v_sql = v_sql + " values(";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.ZIPCODE) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.SIDO) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.SIGUN) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.EM) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.ROAD_CD) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.ROAD_NM) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.GROUND) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.BUILD_1) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.BUILD_2) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.ROAD_KEY) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.BUILD_NO) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.LANDMARK) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.DONG_CD) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.DONG_NM) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.HANG_NM) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.JI_1) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.JI_2) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.ZIPCODE_OLD) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.addr_ji) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.addr_ro) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_str_post.donga_center) + "') ";

            v_result = f_sql_insert(v_sql);

        }
        public static void f_update_post(str_post v_str_post, out String v_result)
        {
            String v_sql;

            v_sql = "update t_zipcode_new set ";
            v_sql = v_sql + "zipcode=" + "'" + Convert.ToString(v_str_post.ZIPCODE) + "',";
            v_sql = v_sql + "sido=" + "'" + Convert.ToString(v_str_post.SIDO) + "', ";
            v_sql = v_sql + "sigun=" + "'" + Convert.ToString(v_str_post.SIGUN) + "',";
            v_sql = v_sql + "em=" + "'" + Convert.ToString(v_str_post.EM) + "', ";
            v_sql = v_sql + "road_cd=" + "'" + Convert.ToString(v_str_post.ROAD_CD) + "',";
            v_sql = v_sql + "road_nm=" + "'" + Convert.ToString(v_str_post.ROAD_NM) + "', ";
            v_sql = v_sql + "ground=" + "'" + Convert.ToString(v_str_post.GROUND) + "',";
            v_sql = v_sql + "build_1=" + "'" + Convert.ToString(v_str_post.BUILD_1) + "', ";
            v_sql = v_sql + "build_2=" + "'" + Convert.ToString(v_str_post.BUILD_2) + "',";
            v_sql = v_sql + "road_key=" + "'" + Convert.ToString(v_str_post.ROAD_KEY) + "', ";
            v_sql = v_sql + "donga_center=" + "'" + Convert.ToString(v_str_post.donga_center) + "',";
            v_sql = v_sql + "landmark=" + "'" + Convert.ToString(v_str_post.LANDMARK) + "', ";
            v_sql = v_sql + "dong_cd=" + "'" + Convert.ToString(v_str_post.DONG_CD) + "',";
            v_sql = v_sql + "dong_nm=" + "'" + Convert.ToString(v_str_post.DONG_NM) + "', ";
            v_sql = v_sql + "hang_nm=" + "'" + Convert.ToString(v_str_post.HANG_NM) + "',";
            v_sql = v_sql + "ji_1=" + "'" + Convert.ToString(v_str_post.JI_1) + "', ";
            v_sql = v_sql + "ji_2=" + "'" + Convert.ToString(v_str_post.JI_2) + "',";
            v_sql = v_sql + "zipcode_old=" + "'" + Convert.ToString(v_str_post.ZIPCODE_OLD) + "', ";
            v_sql = v_sql + "addr_ji=" + "'" + Convert.ToString(v_str_post.addr_ji) + "',";
            v_sql = v_sql + "addr_ro=" + "'" + Convert.ToString(v_str_post.addr_ro) + "'  ";
            v_sql = v_sql + " where build_no=" + "'" + Convert.ToString(v_str_post.BUILD_NO) + "' ";
            v_result = f_sql_update(v_sql);

        }
        public static void f_delete_post(str_post v_str_post, out String v_result)
        {
            String v_sql;

            v_sql = "delete from t_zipcode_new ";
            v_sql = v_sql + " where build_no=" + "'" + Convert.ToString(v_str_post.BUILD_NO) + "' ";
            v_result = f_sql_delete(v_sql);

        }
        public static String f_select_manager(str_manager_select v_manager_select, out String v_result)
        {
            String v_xml;
            String v_sql;

            v_sql = "select top 1000 *  from t_manager where 1=1 ";
            if (v_manager_select.manager_mobile != "")
            {
                v_sql = v_sql + " and manager_mobile='" + v_manager_select.manager_mobile + "'";
            }
            if (v_manager_select.manager_id != "")
            {
                v_sql = v_sql + " and manager_id='" + v_manager_select.manager_id + "'";
            }
            if (v_manager_select.manager_name != "")
            {
                v_sql = v_sql + " and manager_name='" + v_manager_select.manager_name + "'";
            }
           
            v_xml = f_select(v_sql, out v_result);
            return v_xml;
        }
        public static void f_insert_manager(str_manager v_manager, out String v_result)
        {
            String v_sql;
            v_manager.manager_num = f_identity();
            v_manager.manager_insertdate = DateTime.Now;

            v_sql = "insert into t_manager(";
            v_sql = v_sql + "manager_num,";
            v_sql = v_sql + "manager_id,";
            v_sql = v_sql + "manager_pw,";
            v_sql = v_sql + "manager_name,";
            v_sql = v_sql + "manager_mobile,";
            v_sql = v_sql + "manager_ip,";
            v_sql = v_sql + "manager_mac,";
            v_sql = v_sql + "manager_secu_key,";
            v_sql = v_sql + "manager_secu_key_path,";
            v_sql = v_sql + "manager_grade,";
            v_sql = v_sql + "manager_insertdate,";
            v_sql = v_sql + "insert_nm)";
            v_sql = v_sql + " values(";
            v_sql = v_sql + "" + Convert.ToString(v_manager.manager_num) + ", ";
            v_sql = v_sql + "'" + Convert.ToString(v_manager.manager_id) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_manager.manager_pw) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_manager.manager_name) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_manager.manager_mobile) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_manager.manager_ip) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_manager.manager_mac) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_manager.manager_secu_key) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_manager.manager_secu_key_path) + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_manager.manager_grade) + "', ";
            v_sql = v_sql + "'" + v_manager.manager_insertdate.ToString("yyyy-MM-dd") + "', ";
            v_sql = v_sql + "'" + Convert.ToString(v_manager.insert_nm) + "') ";
            v_result = f_sql_insert(v_sql);

        }
        public static void f_update_manager(str_manager v_manager, out String v_result)
        {
            String v_sql;

            v_sql = "update t_manager set ";
            v_sql = v_sql + "manager_id=" + "'" + Convert.ToString(v_manager.manager_id) + "',";
            v_sql = v_sql + "manager_pw=" + "'" + Convert.ToString(v_manager.manager_pw) + "', ";
            v_sql = v_sql + "manager_name=" + "'" + Convert.ToString(v_manager.manager_name) + "',";
            v_sql = v_sql + "manager_mobile=" + "'" + Convert.ToString(v_manager.manager_mobile) + "', ";
            v_sql = v_sql + "manager_ip=" + "'" + Convert.ToString(v_manager.manager_ip) + "',";
            v_sql = v_sql + "manager_mac=" + "'" + Convert.ToString(v_manager.manager_mac) + "', ";
            v_sql = v_sql + "manager_secu_key=" + "'" + Convert.ToString(v_manager.manager_secu_key) + "',";
            v_sql = v_sql + "manager_secu_key_path=" + "'" + Convert.ToString(v_manager.manager_secu_key_path) + "', ";
            v_sql = v_sql + "manager_grade=" + "'" + Convert.ToString(v_manager.manager_grade) + "' ";
            v_sql = v_sql + " where manager_num=" + "" + Convert.ToString(v_manager.manager_num) + " ";
            v_result = f_sql_update(v_sql);

        }
        public static void f_delete_manager(str_manager v_manager, out String v_result)
        {
            String v_sql;

            v_sql = "delete from t_manager ";
            v_sql = v_sql + " where manager_num=" + " " + Convert.ToString(v_manager.manager_num) + " ";
            v_result = f_sql_delete(v_sql);
        }


        public static String f_tret_simple_smssend(String v_mobile)
        {
            String v_xml;
            v_xml = "전송성공";
            return v_xml;
        }
        public static String f_tret_dial(String v_mobile)
        {
            String v_xml;
            v_xml = "통화성공";
            return v_xml;
        }
        
        //여기가 클라스의 끝

    }

    //여기가 네임스페이스의 끝
}


