
namespace ActiveDirectoryHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gb_domainInfo = new System.Windows.Forms.GroupBox();
            this.tb_domainInfo = new System.Windows.Forms.TextBox();
            this.gb_userDetail = new System.Windows.Forms.GroupBox();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.pb_userPhoto = new System.Windows.Forms.PictureBox();
            this.lb_memberOf = new System.Windows.Forms.ListBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.rtb_userDetail = new System.Windows.Forms.RichTextBox();
            this.gb_domainInfo.SuspendLayout();
            this.gb_userDetail.SuspendLayout();
            this.gb_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_domainInfo
            // 
            this.gb_domainInfo.Controls.Add(this.tb_domainInfo);
            this.gb_domainInfo.Location = new System.Drawing.Point(13, 13);
            this.gb_domainInfo.Name = "gb_domainInfo";
            this.gb_domainInfo.Size = new System.Drawing.Size(224, 105);
            this.gb_domainInfo.TabIndex = 0;
            this.gb_domainInfo.TabStop = false;
            this.gb_domainInfo.Text = "Domain Info";
            // 
            // tb_domainInfo
            // 
            this.tb_domainInfo.Location = new System.Drawing.Point(10, 40);
            this.tb_domainInfo.Name = "tb_domainInfo";
            this.tb_domainInfo.Size = new System.Drawing.Size(196, 20);
            this.tb_domainInfo.TabIndex = 1;
            // 
            // gb_userDetail
            // 
            this.gb_userDetail.Controls.Add(this.rtb_userDetail);
            this.gb_userDetail.Controls.Add(this.lb_memberOf);
            this.gb_userDetail.Controls.Add(this.pb_userPhoto);
            this.gb_userDetail.Location = new System.Drawing.Point(13, 124);
            this.gb_userDetail.Name = "gb_userDetail";
            this.gb_userDetail.Size = new System.Drawing.Size(876, 318);
            this.gb_userDetail.TabIndex = 1;
            this.gb_userDetail.TabStop = false;
            this.gb_userDetail.Text = "User Detail";
            // 
            // gb_search
            // 
            this.gb_search.Controls.Add(this.btn_search);
            this.gb_search.Controls.Add(this.tb_user);
            this.gb_search.Location = new System.Drawing.Point(243, 15);
            this.gb_search.Name = "gb_search";
            this.gb_search.Size = new System.Drawing.Size(646, 103);
            this.gb_search.TabIndex = 2;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "Search User";
            // 
            // pb_userPhoto
            // 
            this.pb_userPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_userPhoto.Location = new System.Drawing.Point(7, 20);
            this.pb_userPhoto.Name = "pb_userPhoto";
            this.pb_userPhoto.Padding = new System.Windows.Forms.Padding(5);
            this.pb_userPhoto.Size = new System.Drawing.Size(150, 150);
            this.pb_userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_userPhoto.TabIndex = 0;
            this.pb_userPhoto.TabStop = false;
            // 
            // lb_memberOf
            // 
            this.lb_memberOf.FormattingEnabled = true;
            this.lb_memberOf.HorizontalScrollbar = true;
            this.lb_memberOf.Location = new System.Drawing.Point(612, 20);
            this.lb_memberOf.Name = "lb_memberOf";
            this.lb_memberOf.Size = new System.Drawing.Size(258, 277);
            this.lb_memberOf.Sorted = true;
            this.lb_memberOf.TabIndex = 2;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(10, 40);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(196, 20);
            this.tb_user.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(210, 40);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 20);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rtb_userDetail
            // 
            this.rtb_userDetail.Location = new System.Drawing.Point(164, 20);
            this.rtb_userDetail.Name = "rtb_userDetail";
            this.rtb_userDetail.ReadOnly = true;
            this.rtb_userDetail.Size = new System.Drawing.Size(442, 277);
            this.rtb_userDetail.TabIndex = 3;
            this.rtb_userDetail.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 458);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.gb_userDetail);
            this.Controls.Add(this.gb_domainInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Active Directory Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_domainInfo.ResumeLayout(false);
            this.gb_domainInfo.PerformLayout();
            this.gb_userDetail.ResumeLayout(false);
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_domainInfo;
        private System.Windows.Forms.TextBox tb_domainInfo;
        private System.Windows.Forms.GroupBox gb_userDetail;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.PictureBox pb_userPhoto;
        private System.Windows.Forms.ListBox lb_memberOf;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.RichTextBox rtb_userDetail;
    }
}

