
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVerify = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnConfirmSign = new System.Windows.Forms.Button();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(242, 344);
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
            this.btnSignup.Location = new System.Drawing.Point(74, 344);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(142, 61);
            this.btnSignup.TabIndex = 1;
            this.btnSignup.Text = "註冊";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(96, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 41);
            this.txtEmail.TabIndex = 2;
            // 
            // btnForget
            // 
            this.btnForget.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForget.Location = new System.Drawing.Point(287, 416);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(97, 39);
            this.btnForget.TabIndex = 3;
            this.btnForget.Text = "忘記密碼";
            this.btnForget.UseVisualStyleBackColor = true;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(96, 141);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(223, 41);
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
            this.label2.Location = new System.Drawing.Point(25, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "密碼";
            // 
            // txtSignPW
            // 
            this.txtSignPW.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignPW.Location = new System.Drawing.Point(111, 97);
            this.txtSignPW.Name = "txtSignPW";
            this.txtSignPW.Size = new System.Drawing.Size(223, 41);
            this.txtSignPW.TabIndex = 7;
            // 
            // txtSignCheckPW
            // 
            this.txtSignCheckPW.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignCheckPW.Location = new System.Drawing.Point(111, 164);
            this.txtSignCheckPW.Name = "txtSignCheckPW";
            this.txtSignCheckPW.Size = new System.Drawing.Size(223, 41);
            this.txtSignCheckPW.TabIndex = 8;
            // 
            // txtSignLocation
            // 
            this.txtSignLocation.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignLocation.Location = new System.Drawing.Point(111, 231);
            this.txtSignLocation.Name = "txtSignLocation";
            this.txtSignLocation.Size = new System.Drawing.Size(223, 41);
            this.txtSignLocation.TabIndex = 9;
            // 
            // txtSignEmail
            // 
            this.txtSignEmail.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignEmail.Location = new System.Drawing.Point(111, 30);
            this.txtSignEmail.Name = "txtSignEmail";
            this.txtSignEmail.Size = new System.Drawing.Size(223, 41);
            this.txtSignEmail.TabIndex = 10;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.txtPW);
            this.groupBoxLogin.Controls.Add(this.txtEmail);
            this.groupBoxLogin.Controls.Add(this.label1);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Location = new System.Drawing.Point(50, 46);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(350, 237);
            this.groupBoxLogin.TabIndex = 11;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "會員登入";
            // 
            // groupBoxSignup
            // 
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
            this.groupBoxSignup.Location = new System.Drawing.Point(50, 12);
            this.groupBoxSignup.Name = "groupBoxSignup";
            this.groupBoxSignup.Size = new System.Drawing.Size(350, 355);
            this.groupBoxSignup.TabIndex = 7;
            this.groupBoxSignup.TabStop = false;
            this.groupBoxSignup.Text = "帳號註冊";
            this.groupBoxSignup.Visible = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "密碼";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "確認密碼";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "居住地區";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "認證碼";
            // 
            // txtVerify
            // 
            this.txtVerify.Font = new System.Drawing.Font("新宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerify.Location = new System.Drawing.Point(111, 298);
            this.txtVerify.Name = "txtVerify";
            this.txtVerify.Size = new System.Drawing.Size(98, 41);
            this.txtVerify.TabIndex = 16;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.Location = new System.Drawing.Point(74, 394);
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
            this.btnConfirmSign.Location = new System.Drawing.Point(242, 394);
            this.btnConfirmSign.Name = "btnConfirmSign";
            this.btnConfirmSign.Size = new System.Drawing.Size(142, 61);
            this.btnConfirmSign.TabIndex = 18;
            this.btnConfirmSign.Text = "確認註冊";
            this.btnConfirmSign.UseVisualStyleBackColor = true;
            this.btnConfirmSign.Visible = false;
            this.btnConfirmSign.Click += new System.EventHandler(this.btnConfirmSign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(458, 515);
            this.Controls.Add(this.groupBoxSignup);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.btnConfirmSign);
            this.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "會員登入";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxSignup.ResumeLayout(false);
            this.groupBoxSignup.PerformLayout();
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
    }
}

