namespace CarReportSystem {
    partial class FmVersion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmVersion));
            btVersionOk = new Button();
            label1 = new Label();
            labelver = new Label();
            pbCar = new PictureBox();
            labelText = new Label();
            ((System.ComponentModel.ISupportInitialize)pbCar).BeginInit();
            SuspendLayout();
            // 
            // btVersionOk
            // 
            btVersionOk.Location = new Point(289, 159);
            btVersionOk.Name = "btVersionOk";
            btVersionOk.Size = new Size(75, 23);
            btVersionOk.TabIndex = 0;
            btVersionOk.Text = "OK";
            btVersionOk.UseVisualStyleBackColor = true;
            btVersionOk.Click += btVersionOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 13);
            label1.Name = "label1";
            label1.Size = new Size(284, 31);
            label1.TabIndex = 1;
            label1.Text = "CarReportSystem";
            // 
            // labelver
            // 
            labelver.AutoSize = true;
            labelver.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            labelver.Location = new Point(138, 47);
            labelver.Name = "labelver";
            labelver.Size = new Size(70, 20);
            labelver.TabIndex = 2;
            labelver.Text = "ver0.0.0.0";
            // 
            // pbCar
            // 
            pbCar.Image = (Image)resources.GetObject("pbCar.Image");
            pbCar.Location = new Point(30, 47);
            pbCar.Name = "pbCar";
            pbCar.Size = new Size(54, 50);
            pbCar.SizeMode = PictureBoxSizeMode.Zoom;
            pbCar.TabIndex = 3;
            pbCar.TabStop = false;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(113, 82);
            labelText.Name = "labelText";
            labelText.Size = new Size(31, 15);
            labelText.TabIndex = 4;
            labelText.Text = "0000";
            // 
            // FmVersion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 238);
            Controls.Add(labelText);
            Controls.Add(pbCar);
            Controls.Add(labelver);
            Controls.Add(label1);
            Controls.Add(btVersionOk);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FmVersion";
            Text = "FmVersion";
            Load += FmVersion_Load;
            ((System.ComponentModel.ISupportInitialize)pbCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVersionOk;
        private Label label1;
        private Label labelver;
        private PictureBox pbCar;
        private Label labelText;
    }
}