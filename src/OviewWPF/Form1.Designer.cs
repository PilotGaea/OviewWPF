namespace OviewWPF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axPGTerrainView1 = new AxUniverseLiteLib.AxPGTerrainView();
            ((System.ComponentModel.ISupportInitialize)(this.axPGTerrainView1)).BeginInit();
            this.SuspendLayout();
            // 
            // axPGTerrainView1
            // 
            this.axPGTerrainView1.Enabled = true;
            this.axPGTerrainView1.Location = new System.Drawing.Point(131, 112);
            this.axPGTerrainView1.Name = "axPGTerrainView1";
            this.axPGTerrainView1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPGTerrainView1.OcxState")));
            this.axPGTerrainView1.Size = new System.Drawing.Size(121, 120);
            this.axPGTerrainView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.axPGTerrainView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axPGTerrainView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxUniverseLiteLib.AxPGTerrainView axPGTerrainView1;
    }
}