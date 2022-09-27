namespace Forms_Jogo_21
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gp_Principal = new System.Windows.Forms.GroupBox();
            this.txb_Principal = new System.Windows.Forms.TextBox();
            this.gp_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 578);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // gp_Principal
            // 
            this.gp_Principal.Controls.Add(this.txb_Principal);
            this.gp_Principal.Location = new System.Drawing.Point(0, 0);
            this.gp_Principal.Name = "gp_Principal";
            this.gp_Principal.Size = new System.Drawing.Size(1069, 374);
            this.gp_Principal.TabIndex = 1;
            this.gp_Principal.TabStop = false;
            this.gp_Principal.Text = "groupBox1";
            // 
            // txb_Principal
            // 
            this.txb_Principal.Location = new System.Drawing.Point(6, 26);
            this.txb_Principal.Multiline = true;
            this.txb_Principal.Name = "txb_Principal";
            this.txb_Principal.Size = new System.Drawing.Size(566, 342);
            this.txb_Principal.TabIndex = 0;
            this.txb_Principal.TextChanged += new System.EventHandler(this.txb_Principal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 578);
            this.Controls.Add(this.gp_Principal);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gp_Principal.ResumeLayout(false);
            this.gp_Principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Splitter splitter1;
        private GroupBox gp_Principal;
        private TextBox txb_Principal;
    }
}