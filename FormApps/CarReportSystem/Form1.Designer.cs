namespace CarReportSystem {
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            cbAuther = new ComboBox();
            cbCarName = new ComboBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            rbAther = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            tbCarReport = new TextBox();
            label6 = new Label();
            btPicOpen = new Button();
            btPicDelete = new Button();
            pbPicture = new PictureBox();
            btAddReport = new Button();
            btModifyReport = new Button();
            btDeleteReport = new Button();
            label7 = new Label();
            dvgCarReport = new DataGridView();
            btReportOpen = new Button();
            btReportSave = new Button();
            button8 = new Button();
            rbInport = new RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgCarReport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(34, 49);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 1;
            label2.Text = "記録者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(35, 89);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 2;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(43, 129);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 3;
            label4.Text = "車名";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(119, 3);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 33);
            dtpDate.TabIndex = 4;
            // 
            // cbAuther
            // 
            cbAuther.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuther.FormattingEnabled = true;
            cbAuther.Location = new Point(119, 46);
            cbAuther.Name = "cbAuther";
            cbAuther.Size = new Size(200, 33);
            cbAuther.TabIndex = 5;
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(119, 126);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(200, 33);
            cbCarName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(35, 169);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 8;
            label5.Text = "レポート";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbInport);
            groupBox1.Controls.Add(rbAther);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(119, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 37);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // rbAther
            // 
            rbAther.AutoSize = true;
            rbAther.Location = new Point(302, 12);
            rbAther.Name = "rbAther";
            rbAther.Size = new Size(56, 19);
            rbAther.TabIndex = 0;
            rbAther.TabStop = true;
            rbAther.Text = "その他";
            rbAther.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(179, 12);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 0;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(123, 12);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 0;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(67, 12);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 0;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(11, 12);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 0;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // tbCarReport
            // 
            tbCarReport.Location = new Point(119, 174);
            tbCarReport.Multiline = true;
            tbCarReport.Name = "tbCarReport";
            tbCarReport.Size = new Size(322, 170);
            tbCarReport.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(525, 11);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 11;
            label6.Text = "画像";
            // 
            // btPicOpen
            // 
            btPicOpen.Location = new Point(597, 19);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(75, 23);
            btPicOpen.TabIndex = 12;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = true;
            // 
            // btPicDelete
            // 
            btPicDelete.Location = new Point(735, 19);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 23);
            btPicDelete.TabIndex = 13;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.FromArgb(192, 255, 255);
            pbPicture.Location = new Point(525, 48);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(338, 236);
            pbPicture.TabIndex = 14;
            pbPicture.TabStop = false;
            // 
            // btAddReport
            // 
            btAddReport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAddReport.Location = new Point(538, 308);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(75, 38);
            btAddReport.TabIndex = 15;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = true;
            // 
            // btModifyReport
            // 
            btModifyReport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btModifyReport.Location = new Point(663, 308);
            btModifyReport.Name = "btModifyReport";
            btModifyReport.Size = new Size(75, 38);
            btModifyReport.TabIndex = 16;
            btModifyReport.Text = "修正";
            btModifyReport.UseVisualStyleBackColor = true;
            // 
            // btDeleteReport
            // 
            btDeleteReport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeleteReport.Location = new Point(788, 308);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(75, 38);
            btDeleteReport.TabIndex = 17;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(15, 376);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 18;
            label7.Text = "記事一覧";
            // 
            // dvgCarReport
            // 
            dvgCarReport.AllowUserToAddRows = false;
            dvgCarReport.AllowUserToDeleteRows = false;
            dvgCarReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCarReport.Location = new Point(119, 376);
            dvgCarReport.Name = "dvgCarReport";
            dvgCarReport.ReadOnly = true;
            dvgCarReport.Size = new Size(744, 224);
            dvgCarReport.TabIndex = 19;
            // 
            // btReportOpen
            // 
            btReportOpen.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btReportOpen.Location = new Point(23, 437);
            btReportOpen.Name = "btReportOpen";
            btReportOpen.Size = new Size(75, 40);
            btReportOpen.TabIndex = 20;
            btReportOpen.Text = "開く";
            btReportOpen.UseVisualStyleBackColor = true;
            // 
            // btReportSave
            // 
            btReportSave.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btReportSave.Location = new Point(23, 502);
            btReportSave.Name = "btReportSave";
            btReportSave.Size = new Size(75, 39);
            btReportSave.TabIndex = 21;
            btReportSave.Text = "保存";
            btReportSave.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(788, 618);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 22;
            button8.Text = "終了";
            button8.UseVisualStyleBackColor = true;
            // 
            // rbInport
            // 
            rbInport.AutoSize = true;
            rbInport.Location = new Point(235, 12);
            rbInport.Name = "rbInport";
            rbInport.Size = new Size(61, 19);
            rbInport.TabIndex = 1;
            rbInport.TabStop = true;
            rbInport.Text = "輸入車";
            rbInport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 667);
            Controls.Add(button8);
            Controls.Add(btReportSave);
            Controls.Add(btReportOpen);
            Controls.Add(dvgCarReport);
            Controls.Add(label7);
            Controls.Add(btDeleteReport);
            Controls.Add(btModifyReport);
            Controls.Add(btAddReport);
            Controls.Add(pbPicture);
            Controls.Add(btPicDelete);
            Controls.Add(btPicOpen);
            Controls.Add(label6);
            Controls.Add(tbCarReport);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(cbCarName);
            Controls.Add(cbAuther);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "試乗レポート管理システム";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgCarReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpDate;
        private ComboBox cbAuther;
        private ComboBox cbCarName;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rbAther;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private TextBox tbCarReport;
        private Label label6;
        private Button btPicOpen;
        private Button btPicDelete;
        private PictureBox pbPicture;
        private Button btAddReport;
        private Button btModifyReport;
        private Button btDeleteReport;
        private Label label7;
        private DataGridView dvgCarReport;
        private Button btReportOpen;
        private Button btReportSave;
        private Button button8;
        private RadioButton rbInport;
    }
}
