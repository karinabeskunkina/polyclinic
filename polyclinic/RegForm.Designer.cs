using System.Runtime.CompilerServices;

namespace polyclinic
{
    partial class RegForm
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
            this.Polic = new System.Windows.Forms.Label();
            this.NumberPolic = new System.Windows.Forms.TextBox();
            this.dateBirthday = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.telephoneUser = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.Label();
            this.EmailUser = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.AdressfacktUser = new System.Windows.Forms.TextBox();
            this.AdressFackt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPass2 = new System.Windows.Forms.Label();
            this.passField2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resume = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.Polic);
            this.panel1.Controls.Add(this.NumberPolic);
            this.panel1.Controls.Add(this.dateBirthday);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.telephoneUser);
            this.panel1.Controls.Add(this.telephone);
            this.panel1.Controls.Add(this.EmailUser);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.AdressfacktUser);
            this.panel1.Controls.Add(this.AdressFackt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textPass2);
            this.panel1.Controls.Add(this.passField2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.resume);
            this.panel1.Controls.Add(this.passField);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 1200);
            this.panel1.TabIndex = 0;
            // 
            // Polic
            // 
            this.Polic.AutoSize = true;
            this.Polic.Font = new System.Drawing.Font("Arial Nova", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Polic.ForeColor = System.Drawing.Color.White;
            this.Polic.Location = new System.Drawing.Point(156, 315);
            this.Polic.Name = "Polic";
            this.Polic.Size = new System.Drawing.Size(147, 52);
            this.Polic.TabIndex = 20;
            this.Polic.Text = "Полис";
            // 
            // NumberPolic
            // 
            this.NumberPolic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberPolic.Location = new System.Drawing.Point(333, 307);
            this.NumberPolic.Multiline = true;
            this.NumberPolic.Name = "NumberPolic";
            this.NumberPolic.Size = new System.Drawing.Size(291, 60);
            this.NumberPolic.TabIndex = 19;
            this.NumberPolic.Enter += new System.EventHandler(this.NumberPolic_Enter);
            this.NumberPolic.Leave += new System.EventHandler(this.NumberPolic_Leave);
            // 
            // dateBirthday
            // 
            this.dateBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirthday.Location = new System.Drawing.Point(333, 585);
            this.dateBirthday.Name = "dateBirthday";
            this.dateBirthday.Size = new System.Drawing.Size(291, 31);
            this.dateBirthday.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(159, 957);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(508, 29);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Согласие на обработку персональных данных";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // telephoneUser
            // 
            this.telephoneUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephoneUser.Location = new System.Drawing.Point(333, 868);
            this.telephoneUser.Multiline = true;
            this.telephoneUser.Name = "telephoneUser";
            this.telephoneUser.Size = new System.Drawing.Size(291, 60);
            this.telephoneUser.TabIndex = 16;
            this.telephoneUser.Enter += new System.EventHandler(this.telephoneUser_Enter);
            this.telephoneUser.Leave += new System.EventHandler(this.telephoneUser_Leave);
            // 
            // telephone
            // 
            this.telephone.AutoSize = true;
            this.telephone.Font = new System.Drawing.Font("Arial Nova", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephone.ForeColor = System.Drawing.Color.White;
            this.telephone.Location = new System.Drawing.Point(104, 868);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(199, 52);
            this.telephone.TabIndex = 15;
            this.telephone.Text = "Телефон";
            // 
            // EmailUser
            // 
            this.EmailUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailUser.Location = new System.Drawing.Point(333, 770);
            this.EmailUser.Multiline = true;
            this.EmailUser.Name = "EmailUser";
            this.EmailUser.Size = new System.Drawing.Size(291, 60);
            this.EmailUser.TabIndex = 14;
            this.EmailUser.Enter += new System.EventHandler(this.EmailUser_Enter);
            this.EmailUser.Leave += new System.EventHandler(this.EmailUser_Leave);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial Nova", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(150, 778);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(140, 52);
            this.Email.TabIndex = 13;
            this.Email.Text = "E-mail";
            // 
            // AdressfacktUser
            // 
            this.AdressfacktUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressfacktUser.Location = new System.Drawing.Point(333, 663);
            this.AdressfacktUser.Multiline = true;
            this.AdressfacktUser.Name = "AdressfacktUser";
            this.AdressfacktUser.Size = new System.Drawing.Size(291, 65);
            this.AdressfacktUser.TabIndex = 12;
            this.AdressfacktUser.Enter += new System.EventHandler(this.AdressfacktUser_Enter);
            this.AdressfacktUser.Leave += new System.EventHandler(this.AdressfacktUser_Leave);
            // 
            // AdressFackt
            // 
            this.AdressFackt.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdressFackt.ForeColor = System.Drawing.Color.White;
            this.AdressFackt.Location = new System.Drawing.Point(48, 636);
            this.AdressFackt.Name = "AdressFackt";
            this.AdressFackt.Size = new System.Drawing.Size(287, 120);
            this.AdressFackt.TabIndex = 11;
            this.AdressFackt.Text = "Адрес фактического проживания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Nova", 14.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 573);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Дата рождения";
            // 
            // textPass2
            // 
            this.textPass2.AutoEllipsis = true;
            this.textPass2.Font = new System.Drawing.Font("Arial Nova", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPass2.ForeColor = System.Drawing.Color.White;
            this.textPass2.Location = new System.Drawing.Point(1, 487);
            this.textPass2.Name = "textPass2";
            this.textPass2.Size = new System.Drawing.Size(334, 60);
            this.textPass2.TabIndex = 8;
            this.textPass2.Text = "Повторить пароль";
            // 
            // passField2
            // 
            this.passField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField2.Location = new System.Drawing.Point(333, 487);
            this.passField2.Name = "passField2";
            this.passField2.Size = new System.Drawing.Size(291, 38);
            this.passField2.TabIndex = 7;
            this.passField2.UseSystemPasswordChar = true;
            this.passField2.Enter += new System.EventHandler(this.passField2_Enter);
            this.passField2.Leave += new System.EventHandler(this.passField2_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::polyclinic.Properties.Resources._9054995_bx_user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(362, 210);
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
            this.resume.Location = new System.Drawing.Point(280, 1010);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(291, 74);
            this.resume.TabIndex = 5;
            this.resume.Text = "Продолжить";
            this.resume.UseVisualStyleBackColor = false;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(333, 405);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(291, 38);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Nova", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(135, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 52);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пароль";
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
            this.panel2.Size = new System.Drawing.Size(845, 204);
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
            this.avtorizaciya.Font = new System.Drawing.Font("Imprint MT Shadow", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avtorizaciya.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.avtorizaciya.Location = new System.Drawing.Point(0, 0);
            this.avtorizaciya.Name = "avtorizaciya";
            this.avtorizaciya.Size = new System.Drawing.Size(845, 204);
            this.avtorizaciya.TabIndex = 0;
            this.avtorizaciya.Text = "Регистрация клиента";
            this.avtorizaciya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avtorizaciya.MouseDown += new System.Windows.Forms.MouseEventHandler(this.avtorizaciya_MouseDown);
            this.avtorizaciya.MouseMove += new System.Windows.Forms.MouseEventHandler(this.avtorizaciya_MouseMove);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(843, 1200);
            this.Controls.Add(this.panel1);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label avtorizaciya;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textPass2;
        private System.Windows.Forms.TextBox passField2;
        private System.Windows.Forms.TextBox AdressfacktUser;
        private System.Windows.Forms.Label AdressFackt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox telephoneUser;
        private System.Windows.Forms.Label telephone;
        private System.Windows.Forms.TextBox EmailUser;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.DateTimePicker dateBirthday;
        private System.Windows.Forms.Label Polic;
        public System.Windows.Forms.TextBox NumberPolic;
    }
}