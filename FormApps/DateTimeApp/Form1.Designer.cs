namespace DateTimeApp {
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
            label1 = new Label();
            dtpDay = new DateTimePicker();
            btDateCount = new Button();
            tbDisp = new TextBox();
            nud = new NumericUpDown();
            btDayBefor = new Button();
            btDayAfter = new Button();
            btOld = new Button();
            ((System.ComponentModel.ISupportInitialize)nud).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(30, 31);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDay
            // 
            dtpDay.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDay.Location = new Point(170, 31);
            dtpDay.Name = "dtpDay";
            dtpDay.Size = new Size(200, 39);
            dtpDay.TabIndex = 1;
            // 
            // btDateCount
            // 
            btDateCount.Location = new Point(212, 88);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(158, 69);
            btDateCount.TabIndex = 2;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            btDateCount.Click += btDateCount_Click;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDisp.Location = new Point(20, 290);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(350, 39);
            tbDisp.TabIndex = 3;
            // 
            // nud
            // 
            nud.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nud.Location = new Point(30, 204);
            nud.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud.Name = "nud";
            nud.Size = new Size(120, 46);
            nud.TabIndex = 4;
            // 
            // btDayBefor
            // 
            btDayBefor.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDayBefor.Location = new Point(270, 175);
            btDayBefor.Name = "btDayBefor";
            btDayBefor.Size = new Size(100, 41);
            btDayBefor.TabIndex = 5;
            btDayBefor.Text = "日前";
            btDayBefor.UseVisualStyleBackColor = true;
            btDayBefor.Click += BtDaybefor_Click;
            // 
            // btDayAfter
            // 
            btDayAfter.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDayAfter.Location = new Point(270, 243);
            btDayAfter.Name = "btDayAfter";
            btDayAfter.Size = new Size(100, 41);
            btDayAfter.TabIndex = 5;
            btDayAfter.Text = "日後";
            btDayAfter.UseVisualStyleBackColor = true;
            btDayAfter.Click += btDayAfter_Click;
            // 
            // btOld
            // 
            btOld.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btOld.Location = new Point(398, 175);
            btOld.Name = "btOld";
            btOld.Size = new Size(94, 41);
            btOld.TabIndex = 6;
            btOld.Text = "年齢";
            btOld.UseVisualStyleBackColor = true;
            btOld.Click += btOld_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 442);
            Controls.Add(btOld);
            Controls.Add(btDayAfter);
            Controls.Add(btDayBefor);
            Controls.Add(nud);
            Controls.Add(tbDisp);
            Controls.Add(btDateCount);
            Controls.Add(dtpDay);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDay;
        private Button btDateCount;
        private TextBox tbDisp;
        private NumericUpDown nud;
        private Button btDayBefor;
        private Button btDayAfter;
        private Button btOld;
    }
}
