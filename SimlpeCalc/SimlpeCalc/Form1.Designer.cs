namespace SimlpeCalc
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
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_BCKS = new System.Windows.Forms.Button();
            this.btn_dvs = new System.Windows.Forms.Button();
            this.btn_mlt = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_subt = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_eql = new System.Windows.Forms.Button();
            this.btn_dec = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_m_p = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_result
            // 
            this.lbl_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_result.Location = new System.Drawing.Point(12, 9);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(423, 145);
            this.lbl_result.TabIndex = 0;
            this.lbl_result.Text = "0";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btn_CE
            // 
            this.btn_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CE.Location = new System.Drawing.Point(12, 168);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(100, 50);
            this.btn_CE.TabIndex = 1;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_C
            // 
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_C.Location = new System.Drawing.Point(119, 168);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(100, 50);
            this.btn_C.TabIndex = 2;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_BCKS
            // 
            this.btn_BCKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_BCKS.Location = new System.Drawing.Point(227, 168);
            this.btn_BCKS.Name = "btn_BCKS";
            this.btn_BCKS.Size = new System.Drawing.Size(100, 50);
            this.btn_BCKS.TabIndex = 3;
            this.btn_BCKS.Text = "<<";
            this.btn_BCKS.UseVisualStyleBackColor = true;            
            this.btn_BCKS.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_dvs
            // 
            this.btn_dvs.FlatAppearance.BorderSize = 0;
            this.btn_dvs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_dvs.Location = new System.Drawing.Point(334, 168);
            this.btn_dvs.Name = "btn_dvs";
            this.btn_dvs.Size = new System.Drawing.Size(100, 50);
            this.btn_dvs.TabIndex = 4;
            this.btn_dvs.Text = "/";
            this.btn_dvs.UseVisualStyleBackColor = true;
            this.btn_dvs.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_mlt
            // 
            this.btn_mlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_mlt.Location = new System.Drawing.Point(334, 242);
            this.btn_mlt.Name = "btn_mlt";
            this.btn_mlt.Size = new System.Drawing.Size(100, 50);
            this.btn_mlt.TabIndex = 8;
            this.btn_mlt.Text = "X";
            this.btn_mlt.UseVisualStyleBackColor = true;
            this.btn_mlt.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_9.Location = new System.Drawing.Point(227, 242);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(100, 50);
            this.btn_9.TabIndex = 7;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_8.Location = new System.Drawing.Point(119, 242);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(100, 50);
            this.btn_8.TabIndex = 6;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_7.Location = new System.Drawing.Point(12, 242);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(100, 50);
            this.btn_7.TabIndex = 5;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_subt
            // 
            this.btn_subt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_subt.Location = new System.Drawing.Point(334, 315);
            this.btn_subt.Name = "btn_subt";
            this.btn_subt.Size = new System.Drawing.Size(100, 50);
            this.btn_subt.TabIndex = 12;
            this.btn_subt.Text = "-";
            this.btn_subt.UseVisualStyleBackColor = true;
            this.btn_subt.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_6.Location = new System.Drawing.Point(227, 315);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(100, 50);
            this.btn_6.TabIndex = 11;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_5.Location = new System.Drawing.Point(119, 315);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(100, 50);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_4.Location = new System.Drawing.Point(12, 315);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(100, 50);
            this.btn_4.TabIndex = 9;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Location = new System.Drawing.Point(335, 388);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 50);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_3.Location = new System.Drawing.Point(228, 388);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(100, 50);
            this.btn_3.TabIndex = 15;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_2.Location = new System.Drawing.Point(120, 388);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(100, 50);
            this.btn_2.TabIndex = 14;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_1.Location = new System.Drawing.Point(13, 388);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(100, 50);
            this.btn_1.TabIndex = 13;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_eql
            // 
            this.btn_eql.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_eql.Location = new System.Drawing.Point(335, 463);
            this.btn_eql.Name = "btn_eql";
            this.btn_eql.Size = new System.Drawing.Size(100, 50);
            this.btn_eql.TabIndex = 20;
            this.btn_eql.Text = "=";
            this.btn_eql.UseVisualStyleBackColor = true;
            this.btn_eql.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_dec
            // 
            this.btn_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_dec.Location = new System.Drawing.Point(228, 463);
            this.btn_dec.Name = "btn_dec";
            this.btn_dec.Size = new System.Drawing.Size(100, 50);
            this.btn_dec.TabIndex = 19;
            this.btn_dec.Text = ".";
            this.btn_dec.UseVisualStyleBackColor = true;
            this.btn_dec.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_0.Location = new System.Drawing.Point(120, 463);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(100, 50);
            this.btn_0.TabIndex = 18;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // btn_m_p
            // 
            this.btn_m_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_m_p.Location = new System.Drawing.Point(13, 463);
            this.btn_m_p.Name = "btn_m_p";
            this.btn_m_p.Size = new System.Drawing.Size(100, 50);
            this.btn_m_p.TabIndex = 17;
            this.btn_m_p.Text = "+/-";
            this.btn_m_p.UseVisualStyleBackColor = true;
            this.btn_m_p.Click += new System.EventHandler(this.btn_numb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 534);
            this.Controls.Add(this.btn_eql);
            this.Controls.Add(this.btn_dec);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_m_p);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_subt);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_mlt);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_dvs);
            this.Controls.Add(this.btn_BCKS);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.lbl_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_BCKS;
        private System.Windows.Forms.Button btn_dvs;
        private System.Windows.Forms.Button btn_mlt;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_subt;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_eql;
        private System.Windows.Forms.Button btn_dec;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_m_p;
    }
}

