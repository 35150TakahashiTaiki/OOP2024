﻿namespace Exercise01 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btEX8_1 = new Button();
            tbDisp = new TextBox();
            btEX8_2 = new Button();
            tbDisp2 = new TextBox();
            btEx8_3 = new Button();
            tbDisp3 = new TextBox();
            SuspendLayout();
            // 
            // btEX8_1
            // 
            btEX8_1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btEX8_1.Location = new Point(41, 31);
            btEX8_1.Name = "btEX8_1";
            btEX8_1.Size = new Size(177, 71);
            btEX8_1.TabIndex = 0;
            btEX8_1.Text = "問題8.1";
            btEX8_1.UseVisualStyleBackColor = true;
            btEX8_1.Click += btEX8_1_Click;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDisp.Location = new Point(41, 108);
            tbDisp.Multiline = true;
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(356, 123);
            tbDisp.TabIndex = 1;
            // 
            // btEX8_2
            // 
            btEX8_2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btEX8_2.Location = new Point(506, 31);
            btEX8_2.Name = "btEX8_2";
            btEX8_2.Size = new Size(177, 71);
            btEX8_2.TabIndex = 2;
            btEX8_2.Text = "問題8.2";
            btEX8_2.UseVisualStyleBackColor = true;
            btEX8_2.Click += btEX8_2_Click;
            // 
            // tbDisp2
            // 
            tbDisp2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDisp2.Location = new Point(467, 108);
            tbDisp2.Multiline = true;
            tbDisp2.Name = "tbDisp2";
            tbDisp2.Size = new Size(394, 221);
            tbDisp2.TabIndex = 3;
            // 
            // btEx8_3
            // 
            btEx8_3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btEx8_3.Location = new Point(929, 31);
            btEx8_3.Name = "btEx8_3";
            btEx8_3.Size = new Size(169, 71);
            btEx8_3.TabIndex = 4;
            btEx8_3.Text = "問題8.3";
            btEx8_3.UseVisualStyleBackColor = true;
            btEx8_3.Click += btEx8_3_Click;
            // 
            // tbDisp3
            // 
            tbDisp3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDisp3.Location = new Point(929, 108);
            tbDisp3.Multiline = true;
            tbDisp3.Name = "tbDisp3";
            tbDisp3.Size = new Size(169, 136);
            tbDisp3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 620);
            Controls.Add(tbDisp3);
            Controls.Add(btEx8_3);
            Controls.Add(tbDisp2);
            Controls.Add(btEX8_2);
            Controls.Add(tbDisp);
            Controls.Add(btEX8_1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btEX8_1;
        private TextBox tbDisp;
        private Button btEX8_2;
        private TextBox tbDisp2;
        private Button btEx8_3;
        private TextBox tbDisp3;
    }
}
