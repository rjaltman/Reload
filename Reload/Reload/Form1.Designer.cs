namespace Reload
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
            this.goAhead = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshThis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goAhead
            // 
            this.goAhead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goAhead.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.goAhead.ForeColor = System.Drawing.Color.White;
            this.goAhead.Location = new System.Drawing.Point(3, 211);
            this.goAhead.Name = "goAhead";
            this.goAhead.Size = new System.Drawing.Size(829, 89);
            this.goAhead.TabIndex = 0;
            this.goAhead.Text = "[click the screen anywhere to launch THE LIBRARY COLLECTION]";
            this.goAhead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goAhead.Click += new System.EventHandler(this.goAhead_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(12, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "access admin settings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(649, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "2013 | made by pentelec";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // refreshThis
            // 
            this.refreshThis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshThis.AutoSize = true;
            this.refreshThis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshThis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.refreshThis.Location = new System.Drawing.Point(12, 465);
            this.refreshThis.Name = "refreshThis";
            this.refreshThis.Size = new System.Drawing.Size(97, 21);
            this.refreshThis.TabIndex = 3;
            this.refreshThis.Text = "refresh form";
            this.refreshThis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshThis.Click += new System.EventHandler(this.refreshThis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(834, 510);
            this.Controls.Add(this.refreshThis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goAhead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Woot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Draw);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goAhead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label refreshThis;
    }
}

