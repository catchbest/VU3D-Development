﻿namespace KSJGigeVision3D_CSharpDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_DEVICE_LIST = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CSnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.RSnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TYPEnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.YnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PreviewcheckBox = new System.Windows.Forms.CheckBox();
            this.PictureBox_PREVIEWWND = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LownumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HighnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SavecheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CSnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TYPEnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PREVIEWWND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LownumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_DEVICE_LIST
            // 
            this.comboBox_DEVICE_LIST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DEVICE_LIST.FormattingEnabled = true;
            this.comboBox_DEVICE_LIST.Location = new System.Drawing.Point(466, 24);
            this.comboBox_DEVICE_LIST.Name = "comboBox_DEVICE_LIST";
            this.comboBox_DEVICE_LIST.Size = new System.Drawing.Size(301, 20);
            this.comboBox_DEVICE_LIST.TabIndex = 0;
            this.comboBox_DEVICE_LIST.SelectedIndexChanged += new System.EventHandler(this.comboBox_DEVICE_LIST_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device Num:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Col Size:";
            // 
            // CSnumericUpDown
            // 
            this.CSnumericUpDown.Location = new System.Drawing.Point(91, 99);
            this.CSnumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.CSnumericUpDown.Name = "CSnumericUpDown";
            this.CSnumericUpDown.Size = new System.Drawing.Size(91, 21);
            this.CSnumericUpDown.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Row Size:";
            // 
            // RSnumericUpDown
            // 
            this.RSnumericUpDown.Location = new System.Drawing.Point(91, 145);
            this.RSnumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.RSnumericUpDown.Name = "RSnumericUpDown";
            this.RSnumericUpDown.Size = new System.Drawing.Size(91, 21);
            this.RSnumericUpDown.TabIndex = 5;
            // 
            // TYPEnumericUpDown
            // 
            this.TYPEnumericUpDown.Location = new System.Drawing.Point(91, 198);
            this.TYPEnumericUpDown.Name = "TYPEnumericUpDown";
            this.TYPEnumericUpDown.Size = new System.Drawing.Size(91, 21);
            this.TYPEnumericUpDown.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y:";
            // 
            // YnumericUpDown
            // 
            this.YnumericUpDown.DecimalPlaces = 2;
            this.YnumericUpDown.Location = new System.Drawing.Point(91, 243);
            this.YnumericUpDown.Name = "YnumericUpDown";
            this.YnumericUpDown.Size = new System.Drawing.Size(91, 21);
            this.YnumericUpDown.TabIndex = 8;
            // 
            // PreviewcheckBox
            // 
            this.PreviewcheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PreviewcheckBox.Location = new System.Drawing.Point(34, 27);
            this.PreviewcheckBox.Name = "PreviewcheckBox";
            this.PreviewcheckBox.Size = new System.Drawing.Size(101, 27);
            this.PreviewcheckBox.TabIndex = 10;
            this.PreviewcheckBox.Text = "预览";
            this.PreviewcheckBox.UseVisualStyleBackColor = true;
            this.PreviewcheckBox.CheckedChanged += new System.EventHandler(this.PreviewcheckBox_CheckedChanged);
            // 
            // PictureBox_PREVIEWWND
            // 
            this.PictureBox_PREVIEWWND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_PREVIEWWND.Location = new System.Drawing.Point(196, 65);
            this.PictureBox_PREVIEWWND.Name = "PictureBox_PREVIEWWND";
            this.PictureBox_PREVIEWWND.Size = new System.Drawing.Size(760, 416);
            this.PictureBox_PREVIEWWND.TabIndex = 12;
            this.PictureBox_PREVIEWWND.TabStop = false;
            this.PictureBox_PREVIEWWND.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_PREVIEWWND_Paint);
            this.PictureBox_PREVIEWWND.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_PREVIEWWND_MouseDown);
            this.PictureBox_PREVIEWWND.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_PREVIEWWND_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "ZmapLow:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "ZmapHigh:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LownumericUpDown
            // 
            this.LownumericUpDown.Location = new System.Drawing.Point(91, 286);
            this.LownumericUpDown.Name = "LownumericUpDown";
            this.LownumericUpDown.Size = new System.Drawing.Size(91, 21);
            this.LownumericUpDown.TabIndex = 24;
            // 
            // HighnumericUpDown
            // 
            this.HighnumericUpDown.Location = new System.Drawing.Point(91, 334);
            this.HighnumericUpDown.Name = "HighnumericUpDown";
            this.HighnumericUpDown.Size = new System.Drawing.Size(91, 21);
            this.HighnumericUpDown.TabIndex = 25;
            // 
            // SavecheckBox
            // 
            this.SavecheckBox.AutoSize = true;
            this.SavecheckBox.Location = new System.Drawing.Point(908, 28);
            this.SavecheckBox.Name = "SavecheckBox";
            this.SavecheckBox.Size = new System.Drawing.Size(48, 16);
            this.SavecheckBox.TabIndex = 26;
            this.SavecheckBox.Text = "save";
            this.SavecheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 521);
            this.Controls.Add(this.SavecheckBox);
            this.Controls.Add(this.HighnumericUpDown);
            this.Controls.Add(this.LownumericUpDown);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PictureBox_PREVIEWWND);
            this.Controls.Add(this.PreviewcheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.YnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TYPEnumericUpDown);
            this.Controls.Add(this.RSnumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CSnumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_DEVICE_LIST);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.CSnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RSnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TYPEnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_PREVIEWWND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LownumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_DEVICE_LIST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CSnumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown RSnumericUpDown;
        private System.Windows.Forms.NumericUpDown TYPEnumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown YnumericUpDown;
        private System.Windows.Forms.CheckBox PreviewcheckBox;
        private System.Windows.Forms.PictureBox PictureBox_PREVIEWWND;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown LownumericUpDown;
        private System.Windows.Forms.NumericUpDown HighnumericUpDown;
        private System.Windows.Forms.CheckBox SavecheckBox;
    }
}

