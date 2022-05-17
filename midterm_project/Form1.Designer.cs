
namespace midterm_project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnForget = new System.Windows.Forms.Button();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSignPW = new System.Windows.Forms.TextBox();
            this.txtSignCheckPW = new System.Windows.Forms.TextBox();
            this.txtSignLocation = new System.Windows.Forms.TextBox();
            this.txtSignEmail = new System.Windows.Forms.TextBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.groupBoxSignup = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSignPhone = new System.Windows.Forms.TextBox();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnConfirmSign = new System.Windows.Forms.Button();
            this.groupBoxForget = new System.Windows.Forms.GroupBox();
            this.txtForgetConfirmPW = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtForgetNewPW = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtForgetVerify = new System.Windows.Forms.TextBox();
            this.txtForgetEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnForgetChange = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxSignup.SuspendLayout();
            this.groupBoxForget.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(220, 479);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(142, 61);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(52, 479);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(142, 61);
            this.btnSignup.TabIndex = 1;
            this.btnSignup.Text = "註冊";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(96, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 31);
            this.txtEmail.TabIndex = 2;
            // 
            // btnForget
            // 
            this.btnForget.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForget.Location = new System.Drawing.Point(265, 551);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(97, 39);
            this.btnForget.TabIndex = 3;
            this.btnForget.Text = "忘記密碼";
            this.btnForget.UseVisualStyleBackColor = true;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(96, 267);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(223, 31);
            this.txtPW.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "信箱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "密碼";
            // 
            // txtSignPW
            // 
            this.txtSignPW.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignPW.Location = new System.Drawing.Point(111, 101);
            this.txtSignPW.Name = "txtSignPW";
            this.txtSignPW.PasswordChar = '*';
            this.txtSignPW.Size = new System.Drawing.Size(223, 31);
            this.txtSignPW.TabIndex = 7;
            // 
            // txtSignCheckPW
            // 
            this.txtSignCheckPW.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignCheckPW.Location = new System.Drawing.Point(111, 167);
            this.txtSignCheckPW.Name = "txtSignCheckPW";
            this.txtSignCheckPW.PasswordChar = '*';
            this.txtSignCheckPW.Size = new System.Drawing.Size(223, 31);
            this.txtSignCheckPW.TabIndex = 8;
            // 
            // txtSignLocation
            // 
            this.txtSignLocation.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignLocation.Location = new System.Drawing.Point(111, 299);
            this.txtSignLocation.Name = "txtSignLocation";
            this.txtSignLocation.Size = new System.Drawing.Size(223, 31);
            this.txtSignLocation.TabIndex = 9;
            // 
            // txtSignEmail
            // 
            this.txtSignEmail.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignEmail.Location = new System.Drawing.Point(111, 35);
            this.txtSignEmail.Name = "txtSignEmail";
            this.txtSignEmail.Size = new System.Drawing.Size(223, 31);
            this.txtSignEmail.TabIndex = 10;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxLogin.Controls.Add(this.txtPW);
            this.groupBoxLogin.Controls.Add(this.txtEmail);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Location = new System.Drawing.Point(23, 63);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(350, 357);
            this.groupBoxLogin.TabIndex = 11;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "會員登入";
            // 
            // groupBoxSignup
            // 
            this.groupBoxSignup.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSignup.Controls.Add(this.label12);
            this.groupBoxSignup.Controls.Add(this.txtSignPhone);
            this.groupBoxSignup.Controls.Add(this.txtVerify);
            this.groupBoxSignup.Controls.Add(this.label7);
            this.groupBoxSignup.Controls.Add(this.label6);
            this.groupBoxSignup.Controls.Add(this.label5);
            this.groupBoxSignup.Controls.Add(this.label4);
            this.groupBoxSignup.Controls.Add(this.label3);
            this.groupBoxSignup.Controls.Add(this.txtSignEmail);
            this.groupBoxSignup.Controls.Add(this.txtSignLocation);
            this.groupBoxSignup.Controls.Add(this.txtSignPW);
            this.groupBoxSignup.Controls.Add(this.txtSignCheckPW);
            this.groupBoxSignup.Location = new System.Drawing.Point(23, 29);
            this.groupBoxSignup.Name = "groupBoxSignup";
            this.groupBoxSignup.Size = new System.Drawing.Size(350, 417);
            this.groupBoxSignup.TabIndex = 7;
            this.groupBoxSignup.TabStop = false;
            this.groupBoxSignup.Text = "帳號註冊";
            this.groupBoxSignup.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 21);
            this.label12.TabIndex = 18;
            this.label12.Text = "手機號碼";
            // 
            // txtSignPhone
            // 
            this.txtSignPhone.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignPhone.Location = new System.Drawing.Point(111, 233);
            this.txtSignPhone.MaxLength = 10;
            this.txtSignPhone.Name = "txtSignPhone";
            this.txtSignPhone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSignPhone.Size = new System.Drawing.Size(223, 31);
            this.txtSignPhone.TabIndex = 17;
            // 
            // txtVerify
            // 
            this.txtVerify.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerify.Location = new System.Drawing.Point(111, 365);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(98, 31);
            this.txtVerify.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "認證碼";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "居住地區";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "確認密碼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "密碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "信箱";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.Location = new System.Drawing.Point(52, 529);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(142, 61);
            this.btnSendEmail.TabIndex = 17;
            this.btnSendEmail.Text = "發送Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Visible = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnConfirmSign
            // 
            this.btnConfirmSign.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmSign.Location = new System.Drawing.Point(220, 529);
            this.btnConfirmSign.Name = "btnConfirmSign";
            this.btnConfirmSign.Size = new System.Drawing.Size(142, 61);
            this.btnConfirmSign.TabIndex = 18;
            this.btnConfirmSign.Text = "確認註冊";
            this.btnConfirmSign.UseVisualStyleBackColor = true;
            this.btnConfirmSign.Visible = false;
            this.btnConfirmSign.Click += new System.EventHandler(this.btnConfirmSign_Click);
            // 
            // groupBoxForget
            // 
            this.groupBoxForget.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxForget.Controls.Add(this.txtForgetConfirmPW);
            this.groupBoxForget.Controls.Add(this.label11);
            this.groupBoxForget.Controls.Add(this.txtForgetNewPW);
            this.groupBoxForget.Controls.Add(this.label10);
            this.groupBoxForget.Controls.Add(this.txtForgetVerify);
            this.groupBoxForget.Controls.Add(this.txtForgetEmail);
            this.groupBoxForget.Controls.Add(this.label8);
            this.groupBoxForget.Controls.Add(this.label9);
            this.groupBoxForget.Location = new System.Drawing.Point(23, 64);
            this.groupBoxForget.Name = "groupBoxForget";
            this.groupBoxForget.Size = new System.Drawing.Size(350, 376);
            this.groupBoxForget.TabIndex = 12;
            this.groupBoxForget.TabStop = false;
            this.groupBoxForget.Text = "忘記密碼";
            this.groupBoxForget.Visible = false;
            // 
            // txtForgetConfirmPW
            // 
            this.txtForgetConfirmPW.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForgetConfirmPW.Location = new System.Drawing.Point(111, 217);
            this.txtForgetConfirmPW.Name = "txtForgetConfirmPW";
            this.txtForgetConfirmPW.PasswordChar = '*';
            this.txtForgetConfirmPW.Size = new System.Drawing.Size(223, 31);
            this.txtForgetConfirmPW.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "確認密碼";
            // 
            // txtForgetNewPW
            // 
            this.txtForgetNewPW.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForgetNewPW.Location = new System.Drawing.Point(111, 132);
            this.txtForgetNewPW.Name = "txtForgetNewPW";
            this.txtForgetNewPW.PasswordChar = '*';
            this.txtForgetNewPW.Size = new System.Drawing.Size(223, 31);
            this.txtForgetNewPW.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "新密碼";
            // 
            // txtForgetVerify
            // 
            this.txtForgetVerify.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForgetVerify.Location = new System.Drawing.Point(112, 302);
            this.txtForgetVerify.Name = "txtForgetVerify";
            this.txtForgetVerify.Size = new System.Drawing.Size(101, 31);
            this.txtForgetVerify.TabIndex = 4;
            // 
            // txtForgetEmail
            // 
            this.txtForgetEmail.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForgetEmail.Location = new System.Drawing.Point(112, 47);
            this.txtForgetEmail.Name = "txtForgetEmail";
            this.txtForgetEmail.Size = new System.Drawing.Size(223, 31);
            this.txtForgetEmail.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "驗證碼";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "信箱";
            // 
            // btnForgetChange
            // 
            this.btnForgetChange.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetChange.Location = new System.Drawing.Point(220, 529);
            this.btnForgetChange.Name = "btnForgetChange";
            this.btnForgetChange.Size = new System.Drawing.Size(142, 61);
            this.btnForgetChange.TabIndex = 20;
            this.btnForgetChange.Text = "確認變更";
            this.btnForgetChange.UseVisualStyleBackColor = true;
            this.btnForgetChange.Visible = false;
            this.btnForgetChange.Click += new System.EventHandler(this.btnForgetChange_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 705);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnForgetChange);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.btnConfirmSign);
            this.Controls.Add(this.groupBoxForget);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBoxSignup);
            this.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "會員登入";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxSignup.ResumeLayout(false);
            this.groupBoxSignup.PerformLayout();
            this.groupBoxForget.ResumeLayout(false);
            this.groupBoxForget.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnForget;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSignPW;
        private System.Windows.Forms.TextBox txtSignCheckPW;
        private System.Windows.Forms.TextBox txtSignLocation;
        private System.Windows.Forms.TextBox txtSignEmail;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxSignup;
        private System.Windows.Forms.TextBox txtVerify;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnConfirmSign;
        private System.Windows.Forms.GroupBox groupBoxForget;
        private System.Windows.Forms.TextBox txtForgetNewPW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtForgetVerify;
        private System.Windows.Forms.TextBox txtForgetEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtForgetConfirmPW;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnForgetChange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSignPhone;
        private System.Windows.Forms.Button button1;
    }
}

