namespace Reload
{
    partial class RestartAlert
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
            this.descripText = new System.Windows.Forms.Label();
            this.heyThere = new System.Windows.Forms.Label();
            this.aCloseButtonHere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descripText
            // 
            this.descripText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descripText.BackColor = System.Drawing.Color.Transparent;
            this.descripText.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripText.ForeColor = System.Drawing.Color.White;
            this.descripText.Location = new System.Drawing.Point(0, 166);
            this.descripText.Name = "descripText";
            this.descripText.Size = new System.Drawing.Size(365, 139);
            this.descripText.TabIndex = 7;
            this.descripText.Text = "Your passcode has been (or should have been, at least) set. To make sure these mo" +
    "difications are saved most efficiently, relaunch the program after hitting the \"" +
    "Close\" button after this text.";
            this.descripText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heyThere
            // 
            this.heyThere.AutoSize = true;
            this.heyThere.BackColor = System.Drawing.Color.Transparent;
            this.heyThere.Font = new System.Drawing.Font("Segoe UI Semilight", 19.75F);
            this.heyThere.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.heyThere.Location = new System.Drawing.Point(50, 103);
            this.heyThere.Name = "heyThere";
            this.heyThere.Size = new System.Drawing.Size(264, 37);
            this.heyThere.TabIndex = 6;
            this.heyThere.Text = "Restart to use Reload";
            // 
            // aCloseButtonHere
            // 
            this.aCloseButtonHere.BackColor = System.Drawing.Color.MidnightBlue;
            this.aCloseButtonHere.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.aCloseButtonHere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aCloseButtonHere.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.aCloseButtonHere.ForeColor = System.Drawing.Color.White;
            this.aCloseButtonHere.Location = new System.Drawing.Point(117, 355);
            this.aCloseButtonHere.Name = "aCloseButtonHere";
            this.aCloseButtonHere.Size = new System.Drawing.Size(131, 23);
            this.aCloseButtonHere.TabIndex = 11;
            this.aCloseButtonHere.Text = "Close";
            this.aCloseButtonHere.UseVisualStyleBackColor = false;
            this.aCloseButtonHere.Visible = false;
            this.aCloseButtonHere.Click += new System.EventHandler(this.aCloseButton_Click);
            // 
            // RestartAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(364, 409);
            this.Controls.Add(this.aCloseButtonHere);
            this.Controls.Add(this.descripText);
            this.Controls.Add(this.heyThere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestartAlert";
            this.Text = "RestartAlert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descripText;
        private System.Windows.Forms.Label heyThere;
        private System.Windows.Forms.Button aCloseButtonHere;
    }
}