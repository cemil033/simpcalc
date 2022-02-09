namespace WindowsFormsApp3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_m = new System.Windows.Forms.RadioButton();
            this.rb_f = new System.Windows.Forms.RadioButton();
            this.lbl_gnd = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.tb_phn = new System.Windows.Forms.MaskedTextBox();
            this.lbl_phn = new System.Windows.Forms.Label();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.tb_cout = new System.Windows.Forms.TextBox();
            this.lbl_cout = new System.Windows.Forms.Label();
            this.tb_fname = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.tb_sname = new System.Windows.Forms.TextBox();
            this.lbl_sname = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.rb_m);
            this.groupBox1.Controls.Add(this.rb_f);
            this.groupBox1.Controls.Add(this.lbl_gnd);
            this.groupBox1.Controls.Add(this.lbl_dob);
            this.groupBox1.Controls.Add(this.dtp_dob);
            this.groupBox1.Controls.Add(this.tb_phn);
            this.groupBox1.Controls.Add(this.lbl_phn);
            this.groupBox1.Controls.Add(this.tb_city);
            this.groupBox1.Controls.Add(this.lbl_city);
            this.groupBox1.Controls.Add(this.tb_cout);
            this.groupBox1.Controls.Add(this.lbl_cout);
            this.groupBox1.Controls.Add(this.tb_fname);
            this.groupBox1.Controls.Add(this.lbl_fname);
            this.groupBox1.Controls.Add(this.tb_sname);
            this.groupBox1.Controls.Add(this.lbl_sname);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Location = new System.Drawing.Point(28, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anket";
            // 
            // rb_m
            // 
            this.rb_m.AutoSize = true;
            this.rb_m.Location = new System.Drawing.Point(272, 298);
            this.rb_m.Name = "rb_m";
            this.rb_m.Size = new System.Drawing.Size(48, 17);
            this.rb_m.TabIndex = 16;
            this.rb_m.TabStop = true;
            this.rb_m.Text = "Male";
            this.rb_m.UseVisualStyleBackColor = true;
            // 
            // rb_f
            // 
            this.rb_f.AutoSize = true;
            this.rb_f.Location = new System.Drawing.Point(156, 298);
            this.rb_f.Name = "rb_f";
            this.rb_f.Size = new System.Drawing.Size(59, 17);
            this.rb_f.TabIndex = 15;
            this.rb_f.TabStop = true;
            this.rb_f.Text = "Female";
            this.rb_f.UseVisualStyleBackColor = true;
            // 
            // lbl_gnd
            // 
            this.lbl_gnd.AutoSize = true;
            this.lbl_gnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_gnd.Location = new System.Drawing.Point(9, 298);
            this.lbl_gnd.Name = "lbl_gnd";
            this.lbl_gnd.Size = new System.Drawing.Size(80, 24);
            this.lbl_gnd.TabIndex = 14;
            this.lbl_gnd.Text = "Gender";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_dob.Location = new System.Drawing.Point(9, 257);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(123, 24);
            this.lbl_dob.TabIndex = 13;
            this.lbl_dob.Text = "Date of Birth";
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(156, 259);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(215, 20);
            this.dtp_dob.TabIndex = 12;
            // 
            // tb_phn
            // 
            this.tb_phn.Location = new System.Drawing.Point(156, 215);
            this.tb_phn.Mask = "(999) 000-0000";
            this.tb_phn.Name = "tb_phn";
            this.tb_phn.Size = new System.Drawing.Size(113, 20);
            this.tb_phn.TabIndex = 11;
            // 
            // lbl_phn
            // 
            this.lbl_phn.AutoSize = true;
            this.lbl_phn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_phn.Location = new System.Drawing.Point(9, 215);
            this.lbl_phn.Name = "lbl_phn";
            this.lbl_phn.Size = new System.Drawing.Size(71, 24);
            this.lbl_phn.TabIndex = 10;
            this.lbl_phn.Text = "Phone";
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(156, 181);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(215, 20);
            this.tb_city.TabIndex = 9;
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_city.Location = new System.Drawing.Point(9, 179);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(44, 24);
            this.lbl_city.TabIndex = 8;
            this.lbl_city.Text = "City";
            // 
            // tb_cout
            // 
            this.tb_cout.Location = new System.Drawing.Point(156, 144);
            this.tb_cout.Name = "tb_cout";
            this.tb_cout.Size = new System.Drawing.Size(215, 20);
            this.tb_cout.TabIndex = 7;
            // 
            // lbl_cout
            // 
            this.lbl_cout.AutoSize = true;
            this.lbl_cout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_cout.Location = new System.Drawing.Point(9, 142);
            this.lbl_cout.Name = "lbl_cout";
            this.lbl_cout.Size = new System.Drawing.Size(82, 24);
            this.lbl_cout.TabIndex = 6;
            this.lbl_cout.Text = "Country";
            // 
            // tb_fname
            // 
            this.tb_fname.Location = new System.Drawing.Point(156, 104);
            this.tb_fname.Name = "tb_fname";
            this.tb_fname.Size = new System.Drawing.Size(215, 20);
            this.tb_fname.TabIndex = 5;
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_fname.Location = new System.Drawing.Point(9, 102);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(143, 24);
            this.lbl_fname.TabIndex = 4;
            this.lbl_fname.Text = "Father\'s name";
            // 
            // tb_sname
            // 
            this.tb_sname.Location = new System.Drawing.Point(156, 67);
            this.tb_sname.Name = "tb_sname";
            this.tb_sname.Size = new System.Drawing.Size(215, 20);
            this.tb_sname.TabIndex = 3;
            // 
            // lbl_sname
            // 
            this.lbl_sname.AutoSize = true;
            this.lbl_sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sname.Location = new System.Drawing.Point(9, 65);
            this.lbl_sname.Name = "lbl_sname";
            this.lbl_sname.Size = new System.Drawing.Size(94, 24);
            this.lbl_sname.TabIndex = 2;
            this.lbl_sname.Text = "Surname";
            this.lbl_sname.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(156, 31);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(215, 20);
            this.tb_name.TabIndex = 1;
            this.tb_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.Location = new System.Drawing.Point(9, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 24);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tb_filename
            // 
            this.tb_filename.Location = new System.Drawing.Point(184, 12);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.Size = new System.Drawing.Size(100, 20);
            this.tb_filename.TabIndex = 1;
            // 
            // btn_load
            // 
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_load.Location = new System.Drawing.Point(300, 11);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(28, 438);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(378, 38);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 504);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.tb_filename);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Anket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_sname;
        private System.Windows.Forms.Label lbl_sname;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.MaskedTextBox tb_phn;
        private System.Windows.Forms.Label lbl_phn;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox tb_cout;
        private System.Windows.Forms.Label lbl_cout;
        private System.Windows.Forms.TextBox tb_fname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.RadioButton rb_m;
        private System.Windows.Forms.RadioButton rb_f;
        private System.Windows.Forms.Label lbl_gnd;
        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
    }
}

