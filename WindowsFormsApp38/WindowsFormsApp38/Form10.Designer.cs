﻿namespace WindowsFormsApp38
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(43, 51);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(423, 34);
            this.txt.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(188, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить в список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 188);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button1;
    }
}