
namespace MorzeConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toMrz = new System.Windows.Forms.Button();
            this.ruBox = new System.Windows.Forms.TextBox();
            this.mrzBox = new System.Windows.Forms.TextBox();
            this.toRu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxRu = new System.Windows.Forms.CheckBox();
            this.checkBoxMrz = new System.Windows.Forms.CheckBox();
            this.clearRuBtn = new System.Windows.Forms.Button();
            this.clearMrzBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Русский";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Морзянка";
            // 
            // toMrz
            // 
            this.toMrz.Location = new System.Drawing.Point(313, 9);
            this.toMrz.Name = "toMrz";
            this.toMrz.Size = new System.Drawing.Size(75, 23);
            this.toMrz.TabIndex = 2;
            this.toMrz.Text = "=>";
            this.toMrz.UseVisualStyleBackColor = true;
            this.toMrz.Click += new System.EventHandler(this.ToMrz_Click);
            // 
            // ruBox
            // 
            this.ruBox.Location = new System.Drawing.Point(12, 42);
            this.ruBox.Multiline = true;
            this.ruBox.Name = "ruBox";
            this.ruBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ruBox.Size = new System.Drawing.Size(376, 396);
            this.ruBox.TabIndex = 3;
            // 
            // mrzBox
            // 
            this.mrzBox.Location = new System.Drawing.Point(394, 42);
            this.mrzBox.Multiline = true;
            this.mrzBox.Name = "mrzBox";
            this.mrzBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mrzBox.Size = new System.Drawing.Size(394, 396);
            this.mrzBox.TabIndex = 4;
            // 
            // toRu
            // 
            this.toRu.Location = new System.Drawing.Point(394, 9);
            this.toRu.Name = "toRu";
            this.toRu.Size = new System.Drawing.Size(75, 23);
            this.toRu.TabIndex = 5;
            this.toRu.Text = "<=";
            this.toRu.UseVisualStyleBackColor = true;
            this.toRu.Click += new System.EventHandler(this.ToRu_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Скопировать текcт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RuCopy_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Скопировать код";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.MrzCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Created by Nik (2022)";
            // 
            // checkBoxRu
            // 
            this.checkBoxRu.AutoSize = true;
            this.checkBoxRu.Location = new System.Drawing.Point(64, 444);
            this.checkBoxRu.Name = "checkBoxRu";
            this.checkBoxRu.Size = new System.Drawing.Size(88, 17);
            this.checkBoxRu.TabIndex = 9;
            this.checkBoxRu.Text = "checkBoxRu";
            this.checkBoxRu.UseVisualStyleBackColor = true;
            // 
            // checkBoxMrz
            // 
            this.checkBoxMrz.AutoSize = true;
            this.checkBoxMrz.Location = new System.Drawing.Point(503, 444);
            this.checkBoxMrz.Name = "checkBoxMrz";
            this.checkBoxMrz.Size = new System.Drawing.Size(91, 17);
            this.checkBoxMrz.TabIndex = 10;
            this.checkBoxMrz.Text = "checkBoxMrz";
            this.checkBoxMrz.UseVisualStyleBackColor = true;
            // 
            // clearRuBtn
            // 
            this.clearRuBtn.Location = new System.Drawing.Point(147, 465);
            this.clearRuBtn.Name = "clearRuBtn";
            this.clearRuBtn.Size = new System.Drawing.Size(75, 23);
            this.clearRuBtn.TabIndex = 11;
            this.clearRuBtn.Text = "clearRuBtn";
            this.clearRuBtn.UseVisualStyleBackColor = true;
            this.clearRuBtn.Click += new System.EventHandler(this.clearRuBtn_Click);
            // 
            // clearMrzBtn
            // 
            this.clearMrzBtn.Location = new System.Drawing.Point(539, 465);
            this.clearMrzBtn.Name = "clearMrzBtn";
            this.clearMrzBtn.Size = new System.Drawing.Size(75, 23);
            this.clearMrzBtn.TabIndex = 12;
            this.clearMrzBtn.Text = "clearMrzBtn";
            this.clearMrzBtn.UseVisualStyleBackColor = true;
            this.clearMrzBtn.Click += new System.EventHandler(this.clearMrzBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.clearMrzBtn);
            this.Controls.Add(this.clearRuBtn);
            this.Controls.Add(this.checkBoxMrz);
            this.Controls.Add(this.checkBoxRu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toRu);
            this.Controls.Add(this.mrzBox);
            this.Controls.Add(this.ruBox);
            this.Controls.Add(this.toMrz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Конвертер в морзянку и обратно. v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toMrz;
        private System.Windows.Forms.TextBox ruBox;
        private System.Windows.Forms.TextBox mrzBox;
        private System.Windows.Forms.Button toRu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxRu;
        private System.Windows.Forms.CheckBox checkBoxMrz;
        private System.Windows.Forms.Button clearRuBtn;
        private System.Windows.Forms.Button clearMrzBtn;
    }
}

