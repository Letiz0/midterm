
namespace midterm_project
{
    partial class btn提交申請
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn提交申請));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView自己 = new System.Windows.Forms.ListView();
            this.listView對方 = new System.Windows.Forms.ListView();
            this.radioButton面交 = new System.Windows.Forms.RadioButton();
            this.radioButton郵寄 = new System.Windows.Forms.RadioButton();
            this.radioButton不限 = new System.Windows.Forms.RadioButton();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.txt搜尋 = new System.Windows.Forms.TextBox();
            this.panel交換 = new System.Windows.Forms.Panel();
            this.btn備註 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button提交申請 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel交換.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(12, 472);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 59);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(651, 367);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(88, 140);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView自己
            // 
            this.listView自己.BackColor = System.Drawing.SystemColors.Control;
            this.listView自己.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView自己.HideSelection = false;
            this.listView自己.LargeImageList = this.imageList1;
            this.listView自己.Location = new System.Drawing.Point(3, 289);
            this.listView自己.Name = "listView自己";
            this.listView自己.Size = new System.Drawing.Size(673, 197);
            this.listView自己.TabIndex = 14;
            this.listView自己.UseCompatibleStateImageBehavior = false;
            // 
            // listView對方
            // 
            this.listView對方.BackColor = System.Drawing.SystemColors.Control;
            this.listView對方.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView對方.HideSelection = false;
            this.listView對方.LargeImageList = this.imageList1;
            this.listView對方.Location = new System.Drawing.Point(3, 10);
            this.listView對方.Name = "listView對方";
            this.listView對方.Size = new System.Drawing.Size(673, 197);
            this.listView對方.TabIndex = 15;
            this.listView對方.UseCompatibleStateImageBehavior = false;
            // 
            // radioButton面交
            // 
            this.radioButton面交.AutoSize = true;
            this.radioButton面交.BackColor = System.Drawing.Color.Transparent;
            this.radioButton面交.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton面交.ForeColor = System.Drawing.Color.Red;
            this.radioButton面交.Location = new System.Drawing.Point(29, 387);
            this.radioButton面交.Name = "radioButton面交";
            this.radioButton面交.Size = new System.Drawing.Size(93, 30);
            this.radioButton面交.TabIndex = 16;
            this.radioButton面交.Text = "限面交";
            this.radioButton面交.UseVisualStyleBackColor = false;
            this.radioButton面交.CheckedChanged += new System.EventHandler(this.radioButton面交_CheckedChanged);
            // 
            // radioButton郵寄
            // 
            this.radioButton郵寄.AutoSize = true;
            this.radioButton郵寄.BackColor = System.Drawing.Color.Transparent;
            this.radioButton郵寄.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton郵寄.ForeColor = System.Drawing.Color.Red;
            this.radioButton郵寄.Location = new System.Drawing.Point(135, 387);
            this.radioButton郵寄.Name = "radioButton郵寄";
            this.radioButton郵寄.Size = new System.Drawing.Size(93, 30);
            this.radioButton郵寄.TabIndex = 17;
            this.radioButton郵寄.Text = "限郵寄";
            this.radioButton郵寄.UseVisualStyleBackColor = false;
            this.radioButton郵寄.CheckedChanged += new System.EventHandler(this.radioButton郵寄_CheckedChanged);
            // 
            // radioButton不限
            // 
            this.radioButton不限.AutoSize = true;
            this.radioButton不限.BackColor = System.Drawing.Color.Transparent;
            this.radioButton不限.Checked = true;
            this.radioButton不限.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton不限.ForeColor = System.Drawing.Color.Red;
            this.radioButton不限.Location = new System.Drawing.Point(241, 387);
            this.radioButton不限.Name = "radioButton不限";
            this.radioButton不限.Size = new System.Drawing.Size(72, 30);
            this.radioButton不限.TabIndex = 18;
            this.radioButton不限.TabStop = true;
            this.radioButton不限.Text = "不限";
            this.radioButton不限.UseVisualStyleBackColor = false;
            this.radioButton不限.CheckedChanged += new System.EventHandler(this.radioButton不限_CheckedChanged);
            // 
            // btn搜尋
            // 
            this.btn搜尋.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn搜尋.Image = ((System.Drawing.Image)(resources.GetObject("btn搜尋.Image")));
            this.btn搜尋.Location = new System.Drawing.Point(598, 385);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(65, 35);
            this.btn搜尋.TabIndex = 19;
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // txt搜尋
            // 
            this.txt搜尋.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt搜尋.ForeColor = System.Drawing.Color.DarkGray;
            this.txt搜尋.Location = new System.Drawing.Point(414, 385);
            this.txt搜尋.Name = "txt搜尋";
            this.txt搜尋.Size = new System.Drawing.Size(178, 35);
            this.txt搜尋.TabIndex = 20;
            this.txt搜尋.Text = "依地區搜尋";
            this.txt搜尋.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt搜尋.Click += new System.EventHandler(this.txt搜尋_Click);
            this.txt搜尋.TextChanged += new System.EventHandler(this.txt搜尋_TextChanged);
            // 
            // panel交換
            // 
            this.panel交換.BackColor = System.Drawing.Color.Transparent;
            this.panel交換.Controls.Add(this.btn備註);
            this.panel交換.Controls.Add(this.label1);
            this.panel交換.Controls.Add(this.label3);
            this.panel交換.Controls.Add(this.button提交申請);
            this.panel交換.Controls.Add(this.listView自己);
            this.panel交換.Controls.Add(this.listView對方);
            this.panel交換.Location = new System.Drawing.Point(670, 2);
            this.panel交換.Name = "panel交換";
            this.panel交換.Size = new System.Drawing.Size(686, 526);
            this.panel交換.TabIndex = 25;
            this.panel交換.Visible = false;
            // 
            // btn備註
            // 
            this.btn備註.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn備註.Location = new System.Drawing.Point(166, 226);
            this.btn備註.Name = "btn備註";
            this.btn備註.Size = new System.Drawing.Size(130, 47);
            this.btn備註.TabIndex = 29;
            this.btn備註.Text = "輸入備註";
            this.btn備註.UseVisualStyleBackColor = true;
            this.btn備註.Click += new System.EventHandler(this.btn備註_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(549, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "你的換出清單";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(530, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "對方的換出清單";
            // 
            // button提交申請
            // 
            this.button提交申請.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button提交申請.Location = new System.Drawing.Point(12, 226);
            this.button提交申請.Name = "button提交申請";
            this.button提交申請.Size = new System.Drawing.Size(130, 47);
            this.button提交申請.TabIndex = 26;
            this.button提交申請.Text = "提交邀請";
            this.button提交申請.UseVisualStyleBackColor = true;
            this.button提交申請.Click += new System.EventHandler(this.button提交申請_Click);
            // 
            // btn提交申請
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(675, 542);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel交換);
            this.Controls.Add(this.txt搜尋);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.radioButton不限);
            this.Controls.Add(this.radioButton郵寄);
            this.Controls.Add(this.radioButton面交);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "btn提交申請";
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_FormClosing);
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel交換.ResumeLayout(false);
            this.panel交換.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView自己;
        private System.Windows.Forms.ListView listView對方;
        private System.Windows.Forms.RadioButton radioButton面交;
        private System.Windows.Forms.RadioButton radioButton郵寄;
        private System.Windows.Forms.RadioButton radioButton不限;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.TextBox txt搜尋;
        private System.Windows.Forms.Panel panel交換;
        private System.Windows.Forms.Button button提交申請;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn備註;
    }
}