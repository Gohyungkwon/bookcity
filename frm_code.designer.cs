namespace bookcity
{
    partial class frm_code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_code));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmd_delete_code = new System.Windows.Forms.Button();
            this.cmd_update_code = new System.Windows.Forms.Button();
            this.cmd_insert_code = new System.Windows.Forms.Button();
            this.spr_code = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_sort_order = new System.Windows.Forms.TextBox();
            this.txt_code_nm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gubun_nm = new System.Windows.Forms.TextBox();
            this.txt_datanum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gubun_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.chk_useyn = new System.Windows.Forms.CheckBox();
            this.chk_def_yn = new System.Windows.Forms.CheckBox();
            this.datanum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gubun_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gubun_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sort_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useyn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.def_yn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spr_code)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.LightGray;
            this.textBox2.Location = new System.Drawing.Point(116, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 21);
            this.textBox2.TabIndex = 83;
            this.textBox2.Tag = "tb_team";
            this.textBox2.Text = "소속팀";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(16, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 21);
            this.textBox1.TabIndex = 82;
            this.textBox1.Tag = "tb_name";
            this.textBox1.Text = "홍길동";
            // 
            // cmd_delete_code
            // 
            this.cmd_delete_code.Location = new System.Drawing.Point(395, 584);
            this.cmd_delete_code.Name = "cmd_delete_code";
            this.cmd_delete_code.Size = new System.Drawing.Size(63, 27);
            this.cmd_delete_code.TabIndex = 87;
            this.cmd_delete_code.Tag = "b_delete";
            this.cmd_delete_code.Text = "삭제";
            this.cmd_delete_code.UseVisualStyleBackColor = true;
            this.cmd_delete_code.Click += new System.EventHandler(this.cmd_delete_code_Click);
            // 
            // cmd_update_code
            // 
            this.cmd_update_code.Location = new System.Drawing.Point(326, 584);
            this.cmd_update_code.Name = "cmd_update_code";
            this.cmd_update_code.Size = new System.Drawing.Size(63, 27);
            this.cmd_update_code.TabIndex = 87;
            this.cmd_update_code.Tag = "b_modify";
            this.cmd_update_code.Text = "수정";
            this.cmd_update_code.UseVisualStyleBackColor = true;
            this.cmd_update_code.Click += new System.EventHandler(this.cmd_update_code_Click);
            // 
            // cmd_insert_code
            // 
            this.cmd_insert_code.Location = new System.Drawing.Point(257, 584);
            this.cmd_insert_code.Name = "cmd_insert_code";
            this.cmd_insert_code.Size = new System.Drawing.Size(63, 27);
            this.cmd_insert_code.TabIndex = 87;
            this.cmd_insert_code.Tag = "b_register";
            this.cmd_insert_code.Text = "등록";
            this.cmd_insert_code.UseVisualStyleBackColor = true;
            this.cmd_insert_code.Click += new System.EventHandler(this.cmd_insert_code_Click);
            // 
            // spr_code
            // 
            this.spr_code.AllowUserToAddRows = false;
            this.spr_code.AllowUserToDeleteRows = false;
            this.spr_code.AllowUserToOrderColumns = true;
            this.spr_code.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spr_code.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datanum,
            this.gubun_nm,
            this.gubun_code,
            this.code_nm,
            this.code,
            this.sort_order,
            this.useyn,
            this.def_yn});
            this.spr_code.Location = new System.Drawing.Point(12, 190);
            this.spr_code.Name = "spr_code";
            this.spr_code.ReadOnly = true;
            this.spr_code.RowTemplate.Height = 23;
            this.spr_code.Size = new System.Drawing.Size(451, 379);
            this.spr_code.TabIndex = 90;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.chk_def_yn);
            this.panel4.Controls.Add(this.chk_useyn);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_code);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txt_gubun_code);
            this.panel4.Controls.Add(this.txt_sort_order);
            this.panel4.Controls.Add(this.txt_code_nm);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txt_gubun_nm);
            this.panel4.Controls.Add(this.txt_datanum);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 134);
            this.panel4.TabIndex = 91;
            // 
            // txt_sort_order
            // 
            this.txt_sort_order.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_sort_order.Location = new System.Drawing.Point(281, 68);
            this.txt_sort_order.Name = "txt_sort_order";
            this.txt_sort_order.Size = new System.Drawing.Size(67, 21);
            this.txt_sort_order.TabIndex = 4;
            // 
            // txt_code_nm
            // 
            this.txt_code_nm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_code_nm.Location = new System.Drawing.Point(281, 14);
            this.txt_code_nm.Name = "txt_code_nm";
            this.txt_code_nm.Size = new System.Drawing.Size(154, 21);
            this.txt_code_nm.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "정렬순서";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "코드명";
            // 
            // txt_gubun_nm
            // 
            this.txt_gubun_nm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_gubun_nm.Location = new System.Drawing.Point(104, 40);
            this.txt_gubun_nm.Name = "txt_gubun_nm";
            this.txt_gubun_nm.Size = new System.Drawing.Size(110, 21);
            this.txt_gubun_nm.TabIndex = 1;
            // 
            // txt_datanum
            // 
            this.txt_datanum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_datanum.Location = new System.Drawing.Point(104, 12);
            this.txt_datanum.Name = "txt_datanum";
            this.txt_datanum.Size = new System.Drawing.Size(110, 21);
            this.txt_datanum.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "분류";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "코드일련번호";
            // 
            // txt_gubun_code
            // 
            this.txt_gubun_code.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_gubun_code.Location = new System.Drawing.Point(104, 67);
            this.txt_gubun_code.Name = "txt_gubun_code";
            this.txt_gubun_code.Size = new System.Drawing.Size(110, 21);
            this.txt_gubun_code.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "분류코드";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "코드";
            // 
            // txt_code
            // 
            this.txt_code.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_code.Location = new System.Drawing.Point(281, 41);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(110, 21);
            this.txt_code.TabIndex = 8;
            // 
            // chk_useyn
            // 
            this.chk_useyn.AutoSize = true;
            this.chk_useyn.Location = new System.Drawing.Point(104, 103);
            this.chk_useyn.Name = "chk_useyn";
            this.chk_useyn.Size = new System.Drawing.Size(72, 16);
            this.chk_useyn.TabIndex = 10;
            this.chk_useyn.Text = "사용여부";
            this.chk_useyn.UseVisualStyleBackColor = true;
            // 
            // chk_def_yn
            // 
            this.chk_def_yn.AutoSize = true;
            this.chk_def_yn.Location = new System.Drawing.Point(281, 103);
            this.chk_def_yn.Name = "chk_def_yn";
            this.chk_def_yn.Size = new System.Drawing.Size(84, 16);
            this.chk_def_yn.TabIndex = 11;
            this.chk_def_yn.Text = "기본값세팅";
            this.chk_def_yn.UseVisualStyleBackColor = true;
            // 
            // datanum
            // 
            this.datanum.DataPropertyName = "datanum";
            this.datanum.HeaderText = "코드일련번호";
            this.datanum.Name = "datanum";
            this.datanum.ReadOnly = true;
            this.datanum.Visible = false;
            // 
            // gubun_nm
            // 
            this.gubun_nm.DataPropertyName = "gubun_nm";
            this.gubun_nm.HeaderText = "분류";
            this.gubun_nm.Name = "gubun_nm";
            this.gubun_nm.ReadOnly = true;
            // 
            // gubun_code
            // 
            this.gubun_code.DataPropertyName = "gubun_code";
            this.gubun_code.HeaderText = "구분코드";
            this.gubun_code.Name = "gubun_code";
            this.gubun_code.ReadOnly = true;
            this.gubun_code.Visible = false;
            // 
            // code_nm
            // 
            this.code_nm.DataPropertyName = "code_nm";
            this.code_nm.HeaderText = "코드명";
            this.code_nm.Name = "code_nm";
            this.code_nm.ReadOnly = true;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "코드";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Visible = false;
            // 
            // sort_order
            // 
            this.sort_order.DataPropertyName = "sort_order";
            this.sort_order.HeaderText = "정렬순서";
            this.sort_order.Name = "sort_order";
            this.sort_order.ReadOnly = true;
            // 
            // useyn
            // 
            this.useyn.DataPropertyName = "useyn";
            this.useyn.HeaderText = "사용여부";
            this.useyn.Name = "useyn";
            this.useyn.ReadOnly = true;
            this.useyn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.useyn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // def_yn
            // 
            this.def_yn.DataPropertyName = "def_yn";
            this.def_yn.HeaderText = "기본값";
            this.def_yn.Name = "def_yn";
            this.def_yn.ReadOnly = true;
            this.def_yn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.def_yn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frm_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 623);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.spr_code);
            this.Controls.Add(this.cmd_insert_code);
            this.Controls.Add(this.cmd_update_code);
            this.Controls.Add(this.cmd_delete_code);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "코드관리프로그램(2단계)";
            this.Load += new System.EventHandler(this.frm_code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr_code)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmd_delete_code;
        private System.Windows.Forms.Button cmd_update_code;
        private System.Windows.Forms.Button cmd_insert_code;
        private System.Windows.Forms.DataGridView spr_code;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_gubun_nm;
        private System.Windows.Forms.TextBox txt_datanum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sort_order;
        private System.Windows.Forms.TextBox txt_code_nm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gubun_code;
        private System.Windows.Forms.CheckBox chk_def_yn;
        private System.Windows.Forms.CheckBox chk_useyn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gubun_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn gubun_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn sort_order;
        private System.Windows.Forms.DataGridViewCheckBoxColumn useyn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn def_yn;
    }
}