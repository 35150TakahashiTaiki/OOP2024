namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btToroku = new System.Windows.Forms.Button();
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(761, 16);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 143);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(266, 592);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(284, 143);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(998, 599);
            this.webView21.TabIndex = 4;
            this.webView21.ZoomFactor = 1D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL又はお気に入り名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "お気に入り名称：";
            // 
            // btToroku
            // 
            this.btToroku.Location = new System.Drawing.Point(761, 52);
            this.btToroku.Name = "btToroku";
            this.btToroku.Size = new System.Drawing.Size(75, 23);
            this.btToroku.TabIndex = 8;
            this.btToroku.Text = "登録";
            this.btToroku.UseVisualStyleBackColor = true;
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(160, 18);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(586, 20);
            this.cbRssUrl.TabIndex = 9;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(160, 55);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(586, 20);
            this.cbName.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 769);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.btToroku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btToroku;
        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.ComboBox cbName;
    }
}

