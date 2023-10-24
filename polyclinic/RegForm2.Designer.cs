using System;

namespace polyclinic
{
    partial class RegForm2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataVUser = new System.Windows.Forms.DateTimePicker();
            this.AdressReg = new System.Windows.Forms.Label();
            this.AdressRegUser = new System.Windows.Forms.TextBox();
            this.WhoWidan = new System.Windows.Forms.Label();
            this.WhoWidanUser = new System.Windows.Forms.TextBox();
            this.KodPodr = new System.Windows.Forms.Label();
            this.KodPodrUser = new System.Windows.Forms.TextBox();
            this.DateV = new System.Windows.Forms.Label();
            this.NameLF = new System.Windows.Forms.Label();
            this.NameUser = new System.Windows.Forms.TextBox();
            this.NumberSeries = new System.Windows.Forms.Label();
            this.NumbSerisUser = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resume = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.avtorizaciya = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.DataVUser);
            this.panel1.Controls.Add(this.AdressReg);
            this.panel1.Controls.Add(this.AdressRegUser);
            this.panel1.Controls.Add(this.WhoWidan);
            this.panel1.Controls.Add(this.WhoWidanUser);
            this.panel1.Controls.Add(this.KodPodr);
            this.panel1.Controls.Add(this.KodPodrUser);
            this.panel1.Controls.Add(this.DateV);
            this.panel1.Controls.Add(this.NameLF);
            this.panel1.Controls.Add(this.NameUser);
            this.panel1.Controls.Add(this.NumberSeries);
            this.panel1.Controls.Add(this.NumbSerisUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.resume);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 1213);
            this.panel1.TabIndex = 1;
            // 
            // DataVUser
            // 
            this.DataVUser.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataVUser.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataVUser.Location = new System.Drawing.Point(333, 534);
            this.DataVUser.Name = "DataVUser";
            this.DataVUser.Size = new System.Drawing.Size(452, 31);
            this.DataVUser.TabIndex = 31;
            // 
            // AdressReg
            // 
            this.AdressReg.AutoSize = true;
            this.AdressReg.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressReg.ForeColor = System.Drawing.Color.White;
            this.AdressReg.Location = new System.Drawing.Point(21, 778);
            this.AdressReg.Name = "AdressReg";
            this.AdressReg.Size = new System.Drawing.Size(306, 38);
            this.AdressReg.TabIndex = 30;
            this.AdressReg.Text = "Адрес регистрации";
            // 
            // AdressRegUser
            // 
            this.AdressRegUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressRegUser.Location = new System.Drawing.Point(333, 778);
            this.AdressRegUser.Multiline = true;
            this.AdressRegUser.Name = "AdressRegUser";
            this.AdressRegUser.Size = new System.Drawing.Size(452, 51);
            this.AdressRegUser.TabIndex = 29;
            // 
            // WhoWidan
            // 
            this.WhoWidan.AutoSize = true;
            this.WhoWidan.Font = new System.Drawing.Font("Arial Nova", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhoWidan.ForeColor = System.Drawing.Color.White;
            this.WhoWidan.Location = new System.Drawing.Point(85, 695);
            this.WhoWidan.Name = "WhoWidan";
            this.WhoWidan.Size = new System.Drawing.Size(201, 44);
            this.WhoWidan.TabIndex = 28;
            this.WhoWidan.Text = "Кем выдан";
            // 
            // WhoWidanUser
            // 
            this.WhoWidanUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhoWidanUser.Location = new System.Drawing.Point(333, 695);
            this.WhoWidanUser.Multiline = true;
            this.WhoWidanUser.Name = "WhoWidanUser";
            this.WhoWidanUser.Size = new System.Drawing.Size(452, 51);
            this.WhoWidanUser.TabIndex = 27;
            // 
            // KodPodr
            // 
            this.KodPodr.AutoSize = true;
            this.KodPodr.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KodPodr.ForeColor = System.Drawing.Color.White;
            this.KodPodr.Location = new System.Drawing.Point(16, 622);
            this.KodPodr.Name = "KodPodr";
            this.KodPodr.Size = new System.Drawing.Size(310, 38);
            this.KodPodr.TabIndex = 26;
            this.KodPodr.Text = "Код подразделения";
            // 
            // KodPodrUser
            // 
            this.KodPodrUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KodPodrUser.Location = new System.Drawing.Point(333, 609);
            this.KodPodrUser.Multiline = true;
            this.KodPodrUser.Name = "KodPodrUser";
            this.KodPodrUser.Size = new System.Drawing.Size(452, 51);
            this.KodPodrUser.TabIndex = 25;
            this.KodPodrUser.Enter += new System.EventHandler(this.KodPodrUser_Enter);
            this.KodPodrUser.Leave += new System.EventHandler(this.KodPodrUser_Leave);
            // 
            // DateV
            // 
            this.DateV.AutoSize = true;
            this.DateV.Font = new System.Drawing.Font("Arial Nova", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateV.ForeColor = System.Drawing.Color.White;
            this.DateV.Location = new System.Drawing.Point(68, 522);
            this.DateV.Name = "DateV";
            this.DateV.Size = new System.Drawing.Size(235, 44);
            this.DateV.TabIndex = 24;
            this.DateV.Text = "Дата выдачи";
            // 
            // NameLF
            // 
            this.NameLF.AutoSize = true;
            this.NameLF.Font = new System.Drawing.Font("Arial Nova", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLF.ForeColor = System.Drawing.Color.White;
            this.NameLF.Location = new System.Drawing.Point(136, 344);
            this.NameLF.Name = "NameLF";
            this.NameLF.Size = new System.Drawing.Size(100, 44);
            this.NameLF.TabIndex = 22;
            this.NameLF.Text = "ФИО";
            // 
            // NameUser
            // 
            this.NameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameUser.Location = new System.Drawing.Point(333, 344);
            this.NameUser.Multiline = true;
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(452, 51);
            this.NameUser.TabIndex = 21;
            this.NameUser.Enter += new System.EventHandler(this.NameUser_Enter);
            this.NameUser.Leave += new System.EventHandler(this.NameUser_Leave);
            // 
            // NumberSeries
            // 
            this.NumberSeries.AutoSize = true;
            this.NumberSeries.Font = new System.Drawing.Font("Arial Nova", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberSeries.ForeColor = System.Drawing.Color.White;
            this.NumberSeries.Location = new System.Drawing.Point(54, 434);
            this.NumberSeries.Name = "NumberSeries";
            this.NumberSeries.Size = new System.Drawing.Size(272, 44);
            this.NumberSeries.TabIndex = 20;
            this.NumberSeries.Text = "Номер и серия";
            // 
            // NumbSerisUser
            // 
            this.NumbSerisUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumbSerisUser.Location = new System.Drawing.Point(333, 434);
            this.NumbSerisUser.Multiline = true;
            this.NumbSerisUser.Name = "NumbSerisUser";
            this.NumbSerisUser.Size = new System.Drawing.Size(452, 51);
            this.NumbSerisUser.TabIndex = 19;
            this.NumbSerisUser.Enter += new System.EventHandler(this.NumbSerisUser_Enter);
            this.NumbSerisUser.Leave += new System.EventHandler(this.NumbSerisUser_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::polyclinic.Properties.Resources._9054995_bx_user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(394, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // resume
            // 
            this.resume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.resume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resume.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.resume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(82)))), ((int)(((byte)(127)))));
            this.resume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(144)))), ((int)(((byte)(177)))));
            this.resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resume.Font = new System.Drawing.Font("Arial Nova", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resume.ForeColor = System.Drawing.Color.White;
            this.resume.Location = new System.Drawing.Point(287, 895);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(291, 74);
            this.resume.TabIndex = 5;
            this.resume.Text = "Продолжить";
            this.resume.UseVisualStyleBackColor = false;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(121)))), ((int)(((byte)(143)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.avtorizaciya);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 204);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.pictureBox2.Image = global::polyclinic.Properties.Resources._5724972_building_healthcare_hospital_medical_nursing_icon;
            this.pictureBox2.Location = new System.Drawing.Point(41, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(780, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(69, 55);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = " X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // avtorizaciya
            // 
            this.avtorizaciya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(153)))), ((int)(((byte)(168)))));
            this.avtorizaciya.Dock = System.Windows.Forms.DockStyle.Top;
            this.avtorizaciya.Font = new System.Drawing.Font("Arial Nova", 16.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avtorizaciya.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.avtorizaciya.Location = new System.Drawing.Point(0, 0);
            this.avtorizaciya.Name = "avtorizaciya";
            this.avtorizaciya.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.avtorizaciya.Size = new System.Drawing.Size(854, 204);
            this.avtorizaciya.TabIndex = 0;
            this.avtorizaciya.Text = "Регистрация клиента Паспортные данные";
            this.avtorizaciya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avtorizaciya.MouseDown += new System.Windows.Forms.MouseEventHandler(this.avtorizaciya_MouseDown);
            this.avtorizaciya.MouseMove += new System.Windows.Forms.MouseEventHandler(this.avtorizaciya_MouseMove);
            // 
            // RegForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 1120);
            this.Controls.Add(this.panel1);
            this.Name = "RegForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public String numberPolic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NumberSeries;
        private System.Windows.Forms.TextBox NumbSerisUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label avtorizaciya;
        private System.Windows.Forms.Label DateV;
        private System.Windows.Forms.Label NameLF;
        private System.Windows.Forms.TextBox NameUser;
        private System.Windows.Forms.Label AdressReg;
        private System.Windows.Forms.TextBox AdressRegUser;
        private System.Windows.Forms.Label WhoWidan;
        private System.Windows.Forms.TextBox WhoWidanUser;
        private System.Windows.Forms.Label KodPodr;
        private System.Windows.Forms.TextBox KodPodrUser;
        private System.Windows.Forms.DateTimePicker DataVUser;
    }
}