﻿namespace ganjoor
{
    partial class AboutForm
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
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.lnkGanjoorOnSFNet = new System.Windows.Forms.LinkLabel();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkIcons = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Location = new System.Drawing.Point(73, 21);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(69, 13);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "گنجور رومیزی";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.Location = new System.Drawing.Point(78, 46);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(59, 13);
            this.lblAppVersion.TabIndex = 2;
            this.lblAppVersion.Text = "ویرایش 0.0";
            // 
            // lnkGanjoorOnSFNet
            // 
            this.lnkGanjoorOnSFNet.AutoSize = true;
            this.lnkGanjoorOnSFNet.Location = new System.Drawing.Point(44, 96);
            this.lnkGanjoorOnSFNet.Name = "lnkGanjoorOnSFNet";
            this.lnkGanjoorOnSFNet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lnkGanjoorOnSFNet.Size = new System.Drawing.Size(126, 13);
            this.lnkGanjoorOnSFNet.TabIndex = 4;
            this.lnkGanjoorOnSFNet.TabStop = true;
            this.lnkGanjoorOnSFNet.Text = "ganjoor.sourceforge.net";
            this.lnkGanjoorOnSFNet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGanjoorOnSFNet_LinkClicked);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(70, 147);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "باشد";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "88/05/02";
            // 
            // lnkIcons
            // 
            this.lnkIcons.AutoSize = true;
            this.lnkIcons.Location = new System.Drawing.Point(58, 120);
            this.lnkIcons.Name = "lnkIcons";
            this.lnkIcons.Size = new System.Drawing.Size(98, 13);
            this.lnkIcons.TabIndex = 5;
            this.lnkIcons.TabStop = true;
            this.lnkIcons.Text = "منبع آیکونهای برنامه";
            this.lnkIcons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkIcons_LinkClicked);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(215, 182);
            this.Controls.Add(this.lnkIcons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lnkGanjoorOnSFNet);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.lblAppTitle);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "دربارۀ گنجور رومیزی";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.LinkLabel lnkGanjoorOnSFNet;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkIcons;
    }
}