
namespace midterm_project
{
    partial class Publish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publish));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.txt搜尋 = new System.Windows.Forms.TextBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.btn借入 = new System.Windows.Forms.Button();
            this.btn借出 = new System.Windows.Forms.Button();
            this.btn移除所選 = new System.Windows.Forms.Button();
            this.btn清除全部 = new System.Windows.Forms.Button();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.chk面交 = new System.Windows.Forms.CheckBox();
            this.chk郵寄 = new System.Windows.Forms.CheckBox();
            this.btn套用 = new System.Windows.Forms.Button();
            this.listBox借出 = new System.Windows.Forms.ListBox();
            this.listBox借入 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(125, 200);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 12);
            this.listView1.Margin = new System.Windows.Forms.Padding(6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(697, 458);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // txt搜尋
            // 
            this.txt搜尋.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt搜尋.ForeColor = System.Drawing.Color.DarkGray;
            this.txt搜尋.Location = new System.Drawing.Point(57, 515);
            this.txt搜尋.Name = "txt搜尋";
            this.txt搜尋.Size = new System.Drawing.Size(207, 35);
            this.txt搜尋.TabIndex = 1;
            this.txt搜尋.Text = "搜尋";
            this.txt搜尋.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt搜尋.Click += new System.EventHandler(this.txt搜尋_Click);
            this.txt搜尋.TextChanged += new System.EventHandler(this.txt搜尋_TextChanged);
            // 
            // btn搜尋
            // 
            this.btn搜尋.Font = new System.Drawing.Font("新宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn搜尋.Image = ((System.Drawing.Image)(resources.GetObject("btn搜尋.Image")));
            this.btn搜尋.Location = new System.Drawing.Point(268, 515);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(65, 35);
            this.btn搜尋.TabIndex = 2;
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // btn借入
            // 
            this.btn借入.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn借入.Location = new System.Drawing.Point(545, 503);
            this.btn借入.Name = "btn借入";
            this.btn借入.Size = new System.Drawing.Size(136, 55);
            this.btn借入.TabIndex = 1;
            this.btn借入.Text = "換入管理";
            this.btn借入.UseVisualStyleBackColor = true;
            this.btn借入.Click += new System.EventHandler(this.btn借入_Click);
            // 
            // btn借出
            // 
            this.btn借出.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn借出.Location = new System.Drawing.Point(381, 503);
            this.btn借出.Name = "btn借出";
            this.btn借出.Size = new System.Drawing.Size(136, 55);
            this.btn借出.TabIndex = 0;
            this.btn借出.Text = "換出管理";
            this.btn借出.UseVisualStyleBackColor = true;
            this.btn借出.Click += new System.EventHandler(this.btn借出_Click);
            // 
            // btn移除所選
            // 
            this.btn移除所選.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn移除所選.Location = new System.Drawing.Point(206, 59);
            this.btn移除所選.Name = "btn移除所選";
            this.btn移除所選.Size = new System.Drawing.Size(98, 40);
            this.btn移除所選.TabIndex = 3;
            this.btn移除所選.Text = "移除所選";
            this.btn移除所選.UseVisualStyleBackColor = true;
            this.btn移除所選.Click += new System.EventHandler(this.btn移除所選_Click);
            // 
            // btn清除全部
            // 
            this.btn清除全部.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn清除全部.ForeColor = System.Drawing.Color.Red;
            this.btn清除全部.Location = new System.Drawing.Point(206, 105);
            this.btn清除全部.Name = "btn清除全部";
            this.btn清除全部.Size = new System.Drawing.Size(98, 40);
            this.btn清除全部.TabIndex = 4;
            this.btn清除全部.Text = "清除全部";
            this.btn清除全部.UseVisualStyleBackColor = true;
            this.btn清除全部.Click += new System.EventHandler(this.btn清除全部_Click);
            // 
            // panelBtn
            // 
            this.panelBtn.BackColor = System.Drawing.Color.Transparent;
            this.panelBtn.Controls.Add(this.chk面交);
            this.panelBtn.Controls.Add(this.chk郵寄);
            this.panelBtn.Controls.Add(this.btn套用);
            this.panelBtn.Controls.Add(this.btn清除全部);
            this.panelBtn.Controls.Add(this.btn移除所選);
            this.panelBtn.Location = new System.Drawing.Point(721, 136);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(304, 149);
            this.panelBtn.TabIndex = 5;
            this.panelBtn.Visible = false;
            // 
            // chk面交
            // 
            this.chk面交.AutoSize = true;
            this.chk面交.BackColor = System.Drawing.Color.Transparent;
            this.chk面交.Checked = true;
            this.chk面交.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk面交.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk面交.ForeColor = System.Drawing.Color.Black;
            this.chk面交.Location = new System.Drawing.Point(86, 3);
            this.chk面交.Name = "chk面交";
            this.chk面交.Size = new System.Drawing.Size(68, 23);
            this.chk面交.TabIndex = 12;
            this.chk面交.Text = "面交";
            this.chk面交.UseVisualStyleBackColor = false;
            this.chk面交.CheckedChanged += new System.EventHandler(this.chk面交_CheckedChanged);
            // 
            // chk郵寄
            // 
            this.chk郵寄.AutoSize = true;
            this.chk郵寄.BackColor = System.Drawing.Color.Transparent;
            this.chk郵寄.Checked = true;
            this.chk郵寄.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk郵寄.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk郵寄.Location = new System.Drawing.Point(86, 27);
            this.chk郵寄.Name = "chk郵寄";
            this.chk郵寄.Size = new System.Drawing.Size(68, 23);
            this.chk郵寄.TabIndex = 13;
            this.chk郵寄.Text = "郵寄";
            this.chk郵寄.UseVisualStyleBackColor = false;
            this.chk郵寄.CheckedChanged += new System.EventHandler(this.chk郵寄_CheckedChanged);
            // 
            // btn套用
            // 
            this.btn套用.Font = new System.Drawing.Font("新宋体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn套用.Location = new System.Drawing.Point(170, 1);
            this.btn套用.Name = "btn套用";
            this.btn套用.Size = new System.Drawing.Size(134, 52);
            this.btn套用.TabIndex = 5;
            this.btn套用.Text = "套用變更";
            this.btn套用.UseVisualStyleBackColor = true;
            this.btn套用.Click += new System.EventHandler(this.btn套用_Click);
            // 
            // listBox借出
            // 
            this.listBox借出.BackColor = System.Drawing.Color.White;
            this.listBox借出.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox借出.FormattingEnabled = true;
            this.listBox借出.ItemHeight = 20;
            this.listBox借出.Location = new System.Drawing.Point(807, 12);
            this.listBox借出.Name = "listBox借出";
            this.listBox借出.Size = new System.Drawing.Size(218, 104);
            this.listBox借出.TabIndex = 6;
            this.listBox借出.Visible = false;
            this.listBox借出.SelectedIndexChanged += new System.EventHandler(this.listBox借出_SelectedIndexChanged);
            // 
            // listBox借入
            // 
            this.listBox借入.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox借入.FormattingEnabled = true;
            this.listBox借入.ItemHeight = 20;
            this.listBox借入.Location = new System.Drawing.Point(807, 12);
            this.listBox借入.Name = "listBox借入";
            this.listBox借入.Size = new System.Drawing.Size(218, 104);
            this.listBox借入.TabIndex = 7;
            this.listBox借入.Visible = false;
            this.listBox借入.SelectedIndexChanged += new System.EventHandler(this.listBox借入_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(721, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(807, 116);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(218, 20);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(971, 507);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 62);
            this.btnBack.TabIndex = 11;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Publish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1037, 581);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox借出);
            this.Controls.Add(this.btn借入);
            this.Controls.Add(this.btn借出);
            this.Controls.Add(this.btn搜尋);
            this.Controls.Add(this.txt搜尋);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox借入);
            this.Controls.Add(this.panelBtn);
            this.Font = new System.Drawing.Font("新宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Publish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publish";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Publish_FormClosing);
            this.Load += new System.EventHandler(this.Publish_Load);
            this.panelBtn.ResumeLayout(false);
            this.panelBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txt搜尋;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Button btn借入;
        private System.Windows.Forms.Button btn借出;
        private System.Windows.Forms.Button btn移除所選;
        private System.Windows.Forms.Button btn清除全部;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.ListBox listBox借出;
        private System.Windows.Forms.ListBox listBox借入;
        private System.Windows.Forms.Button btn套用;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chk面交;
        private System.Windows.Forms.CheckBox chk郵寄;
    }
}