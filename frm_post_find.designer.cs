namespace bookcity
{
    partial class frm_post_find
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_post_find));
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_addr_ro = new System.Windows.Forms.TextBox();
            this.txt_addr_ji = new System.Windows.Forms.TextBox();
            this.txt_zipcode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spr_post = new System.Windows.Forms.DataGridView();
            this.zipcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.road_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.road_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ground = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.build_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.build_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.road_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.build_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.landmark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dong_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dong_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hang_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ji_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ji_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcode_old = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr_ji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr_ro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donga_center = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbo_find_sigun = new System.Windows.Forms.ComboBox();
            this.cbo_find_sido = new System.Windows.Forms.ComboBox();
            this.opt_find_em = new System.Windows.Forms.RadioButton();
            this.cmd_select_post = new System.Windows.Forms.Button();
            this.txt_find_text = new System.Windows.Forms.TextBox();
            this.opt_find_landmark = new System.Windows.Forms.RadioButton();
            this.opt_find_road_nm = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr_post)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.txt_addr_ro);
            this.panel4.Controls.Add(this.txt_addr_ji);
            this.panel4.Controls.Add(this.txt_zipcode);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(11, 480);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(619, 108);
            this.panel4.TabIndex = 90;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 92;
            this.button1.Tag = "b_register";
            this.button1.Text = "이 주소를 선택함";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_addr_ro
            // 
            this.txt_addr_ro.Location = new System.Drawing.Point(100, 69);
            this.txt_addr_ro.Name = "txt_addr_ro";
            this.txt_addr_ro.Size = new System.Drawing.Size(359, 21);
            this.txt_addr_ro.TabIndex = 1;
            // 
            // txt_addr_ji
            // 
            this.txt_addr_ji.Location = new System.Drawing.Point(100, 39);
            this.txt_addr_ji.Name = "txt_addr_ji";
            this.txt_addr_ji.Size = new System.Drawing.Size(359, 21);
            this.txt_addr_ji.TabIndex = 1;
            // 
            // txt_zipcode
            // 
            this.txt_zipcode.Location = new System.Drawing.Point(100, 12);
            this.txt_zipcode.Name = "txt_zipcode";
            this.txt_zipcode.Size = new System.Drawing.Size(90, 21);
            this.txt_zipcode.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 0;
            this.label17.Text = "도로명주소";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "지번주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "우편번호";
            // 
            // spr_post
            // 
            this.spr_post.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spr_post.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zipcode,
            this.sido,
            this.sigun,
            this.em,
            this.road_cd,
            this.road_nm,
            this.ground,
            this.build_1,
            this.build_2,
            this.road_key,
            this.build_no,
            this.landmark,
            this.dong_cd,
            this.dong_nm,
            this.hang_nm,
            this.ji_1,
            this.ji_2,
            this.zipcode_old,
            this.addr_ji,
            this.addr_ro,
            this.donga_center});
            this.spr_post.Location = new System.Drawing.Point(11, 174);
            this.spr_post.Name = "spr_post";
            this.spr_post.RowTemplate.Height = 23;
            this.spr_post.Size = new System.Drawing.Size(1146, 300);
            this.spr_post.TabIndex = 89;
            // 
            // zipcode
            // 
            this.zipcode.DataPropertyName = "zipcode";
            this.zipcode.HeaderText = "우편번호";
            this.zipcode.Name = "zipcode";
            // 
            // sido
            // 
            this.sido.DataPropertyName = "sido";
            this.sido.HeaderText = "시도";
            this.sido.Name = "sido";
            // 
            // sigun
            // 
            this.sigun.DataPropertyName = "sigun";
            this.sigun.HeaderText = "시군";
            this.sigun.Name = "sigun";
            // 
            // em
            // 
            this.em.DataPropertyName = "em";
            this.em.HeaderText = "법정동";
            this.em.Name = "em";
            // 
            // road_cd
            // 
            this.road_cd.DataPropertyName = "road_cd";
            this.road_cd.HeaderText = "ROAD_CD";
            this.road_cd.Name = "road_cd";
            this.road_cd.Visible = false;
            // 
            // road_nm
            // 
            this.road_nm.DataPropertyName = "road_nm";
            this.road_nm.HeaderText = "도로명";
            this.road_nm.Name = "road_nm";
            // 
            // ground
            // 
            this.ground.DataPropertyName = "ground";
            this.ground.HeaderText = "GROUND";
            this.ground.Name = "ground";
            // 
            // build_1
            // 
            this.build_1.DataPropertyName = "build_1";
            this.build_1.HeaderText = "건물번지1";
            this.build_1.Name = "build_1";
            // 
            // build_2
            // 
            this.build_2.DataPropertyName = "build_2";
            this.build_2.HeaderText = "건물번지2";
            this.build_2.Name = "build_2";
            // 
            // road_key
            // 
            this.road_key.DataPropertyName = "road_key";
            this.road_key.HeaderText = "ROAD_KEY";
            this.road_key.Name = "road_key";
            this.road_key.Visible = false;
            // 
            // build_no
            // 
            this.build_no.DataPropertyName = "build_no";
            this.build_no.HeaderText = "건물번호";
            this.build_no.Name = "build_no";
            this.build_no.Visible = false;
            // 
            // landmark
            // 
            this.landmark.DataPropertyName = "landmark";
            this.landmark.HeaderText = "건물명";
            this.landmark.Name = "landmark";
            // 
            // dong_cd
            // 
            this.dong_cd.DataPropertyName = "dong_cd";
            this.dong_cd.HeaderText = "DONG_CD";
            this.dong_cd.Name = "dong_cd";
            this.dong_cd.Visible = false;
            // 
            // dong_nm
            // 
            this.dong_nm.DataPropertyName = "dong_nm";
            this.dong_nm.HeaderText = "DONG_NM";
            this.dong_nm.Name = "dong_nm";
            this.dong_nm.Visible = false;
            // 
            // hang_nm
            // 
            this.hang_nm.DataPropertyName = "hang_nm";
            this.hang_nm.HeaderText = "행정동";
            this.hang_nm.Name = "hang_nm";
            this.hang_nm.Visible = false;
            // 
            // ji_1
            // 
            this.ji_1.DataPropertyName = "ji_1";
            this.ji_1.HeaderText = "지번1";
            this.ji_1.Name = "ji_1";
            this.ji_1.Visible = false;
            // 
            // ji_2
            // 
            this.ji_2.DataPropertyName = "ji_2";
            this.ji_2.HeaderText = "지번2";
            this.ji_2.Name = "ji_2";
            this.ji_2.Visible = false;
            // 
            // zipcode_old
            // 
            this.zipcode_old.DataPropertyName = "zipcode_old";
            this.zipcode_old.HeaderText = "구우편번호";
            this.zipcode_old.Name = "zipcode_old";
            this.zipcode_old.Visible = false;
            // 
            // addr_ji
            // 
            this.addr_ji.DataPropertyName = "addr_ji";
            this.addr_ji.HeaderText = "지번주소";
            this.addr_ji.Name = "addr_ji";
            // 
            // addr_ro
            // 
            this.addr_ro.DataPropertyName = "addr_ro";
            this.addr_ro.HeaderText = "도로명주소";
            this.addr_ro.Name = "addr_ro";
            // 
            // donga_center
            // 
            this.donga_center.DataPropertyName = "donga_center";
            this.donga_center.HeaderText = "동아독자센터";
            this.donga_center.Name = "donga_center";
            this.donga_center.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.opt_find_em);
            this.panel2.Controls.Add(this.cmd_select_post);
            this.panel2.Controls.Add(this.txt_find_text);
            this.panel2.Controls.Add(this.opt_find_landmark);
            this.panel2.Controls.Add(this.opt_find_road_nm);
            this.panel2.Location = new System.Drawing.Point(12, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 111);
            this.panel2.TabIndex = 88;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbo_find_sigun);
            this.groupBox3.Controls.Add(this.cbo_find_sido);
            this.groupBox3.Location = new System.Drawing.Point(16, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 49);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "지역선택";
            // 
            // cbo_find_sigun
            // 
            this.cbo_find_sigun.FormattingEnabled = true;
            this.cbo_find_sigun.Location = new System.Drawing.Point(127, 20);
            this.cbo_find_sigun.Name = "cbo_find_sigun";
            this.cbo_find_sigun.Size = new System.Drawing.Size(115, 20);
            this.cbo_find_sigun.TabIndex = 2;
            this.cbo_find_sigun.Text = "시/군/구";
            // 
            // cbo_find_sido
            // 
            this.cbo_find_sido.FormattingEnabled = true;
            this.cbo_find_sido.Location = new System.Drawing.Point(6, 20);
            this.cbo_find_sido.Name = "cbo_find_sido";
            this.cbo_find_sido.Size = new System.Drawing.Size(115, 20);
            this.cbo_find_sido.TabIndex = 1;
            this.cbo_find_sido.Text = "시/도";
            this.cbo_find_sido.SelectedIndexChanged += new System.EventHandler(this.cbo_find_sido_SelectedIndexChanged);
            // 
            // opt_find_em
            // 
            this.opt_find_em.AutoSize = true;
            this.opt_find_em.Location = new System.Drawing.Point(446, 44);
            this.opt_find_em.Name = "opt_find_em";
            this.opt_find_em.Size = new System.Drawing.Size(59, 16);
            this.opt_find_em.TabIndex = 22;
            this.opt_find_em.Text = "법정동";
            this.opt_find_em.UseVisualStyleBackColor = true;
            // 
            // cmd_select_post
            // 
            this.cmd_select_post.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.cmd_select_post.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.cmd_select_post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_select_post.Font = new System.Drawing.Font("돋움", 9F);
            this.cmd_select_post.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmd_select_post.Location = new System.Drawing.Point(519, 44);
            this.cmd_select_post.Name = "cmd_select_post";
            this.cmd_select_post.Size = new System.Drawing.Size(84, 55);
            this.cmd_select_post.TabIndex = 21;
            this.cmd_select_post.Tag = "b_search";
            this.cmd_select_post.Text = "조회하기    ";
            this.cmd_select_post.UseVisualStyleBackColor = false;
            this.cmd_select_post.Click += new System.EventHandler(this.cmd_select_post_Click);
            // 
            // txt_find_text
            // 
            this.txt_find_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_find_text.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_find_text.ForeColor = System.Drawing.Color.Black;
            this.txt_find_text.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_find_text.Location = new System.Drawing.Point(305, 66);
            this.txt_find_text.Name = "txt_find_text";
            this.txt_find_text.Size = new System.Drawing.Size(200, 22);
            this.txt_find_text.TabIndex = 2;
            // 
            // opt_find_landmark
            // 
            this.opt_find_landmark.AutoSize = true;
            this.opt_find_landmark.Location = new System.Drawing.Point(376, 44);
            this.opt_find_landmark.Name = "opt_find_landmark";
            this.opt_find_landmark.Size = new System.Drawing.Size(59, 16);
            this.opt_find_landmark.TabIndex = 1;
            this.opt_find_landmark.Text = "건물명";
            this.opt_find_landmark.UseVisualStyleBackColor = true;
            // 
            // opt_find_road_nm
            // 
            this.opt_find_road_nm.AutoSize = true;
            this.opt_find_road_nm.Location = new System.Drawing.Point(306, 44);
            this.opt_find_road_nm.Name = "opt_find_road_nm";
            this.opt_find_road_nm.Size = new System.Drawing.Size(59, 16);
            this.opt_find_road_nm.TabIndex = 1;
            this.opt_find_road_nm.Text = "도로명";
            this.opt_find_road_nm.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Font = new System.Drawing.Font("돋움", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.textBox1.Location = new System.Drawing.Point(111, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 24);
            this.textBox1.TabIndex = 99;
            this.textBox1.Tag = "tb_team";
            this.textBox1.Text = "소속팀";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("돋움", 9F);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.textBox2.Location = new System.Drawing.Point(11, 14);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 15, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 24);
            this.textBox2.TabIndex = 98;
            this.textBox2.Tag = "tb_name";
            this.textBox2.Text = "홍길동";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 32);
            this.panel1.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Tag = "l_title2";
            this.label1.Text = "주소검색";
            // 
            // frm_post_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1163, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.spr_post);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_post_find";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "주소찾기 화면";
            this.Load += new System.EventHandler(this.frm_post_find_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr_post)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView spr_post;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmd_select_post;
        private System.Windows.Forms.TextBox txt_find_text;
        private System.Windows.Forms.RadioButton opt_find_landmark;
        private System.Windows.Forms.RadioButton opt_find_road_nm;
        private System.Windows.Forms.TextBox txt_addr_ro;
        private System.Windows.Forms.TextBox txt_addr_ji;
        private System.Windows.Forms.TextBox txt_zipcode;
        private System.Windows.Forms.RadioButton opt_find_em;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbo_find_sigun;
        private System.Windows.Forms.ComboBox cbo_find_sido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn sido;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigun;
        private System.Windows.Forms.DataGridViewTextBoxColumn em;
        private System.Windows.Forms.DataGridViewTextBoxColumn road_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn road_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ground;
        private System.Windows.Forms.DataGridViewTextBoxColumn build_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn build_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn road_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn build_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn landmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn dong_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dong_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn hang_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ji_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ji_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcode_old;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr_ji;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr_ro;
        private System.Windows.Forms.DataGridViewTextBoxColumn donga_center;
    }
}