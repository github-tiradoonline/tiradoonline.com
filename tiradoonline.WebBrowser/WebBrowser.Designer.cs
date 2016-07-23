namespace tiradoonline.WebBrowser
{
    partial class WebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowser));
            this.tiradoonlineWebBrowser = new Skybound.Gecko.GeckoWebBrowser();
            this.SuspendLayout();
            // 
            // tiradoonlineWebBrowser
            // 
            this.tiradoonlineWebBrowser.Location = new System.Drawing.Point(0, -1);
            this.tiradoonlineWebBrowser.Name = "tiradoonlineWebBrowser";
            this.tiradoonlineWebBrowser.Size = new System.Drawing.Size(1546, 867);
            this.tiradoonlineWebBrowser.TabIndex = 0;
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 865);
            this.Controls.Add(this.tiradoonlineWebBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WebBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "intranet.tiradoonline.com";
            this.Load += new System.EventHandler(this.WebBrowser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Skybound.Gecko.GeckoWebBrowser tiradoonlineWebBrowser;

    }
}

