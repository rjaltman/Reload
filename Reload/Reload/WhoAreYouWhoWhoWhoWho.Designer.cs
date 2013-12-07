namespace Reload
{
    partial class WhoAreYouWhoWhoWhoWho
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
            this.label1 = new System.Windows.Forms.Label();
            this.woahThere = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passcodeText = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.notifierText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "This might not be for your eyes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // woahThere
            // 
            this.woahThere.AutoSize = true;
            this.woahThere.BackColor = System.Drawing.Color.Maroon;
            this.woahThere.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woahThere.ForeColor = System.Drawing.Color.White;
            this.woahThere.Location = new System.Drawing.Point(600, 2);
            this.woahThere.Name = "woahThere";
            this.woahThere.Size = new System.Drawing.Size(27, 30);
            this.woahThere.TabIndex = 2;
            this.woahThere.Text = "X";
            this.woahThere.Click += new System.EventHandler(this.woahThere_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(173, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the admin password to\r\nlet you in";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passcodeText
            // 
            this.passcodeText.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.passcodeText.Location = new System.Drawing.Point(64, 179);
            this.passcodeText.Name = "passcodeText";
            this.passcodeText.Size = new System.Drawing.Size(497, 22);
            this.passcodeText.TabIndex = 4;
            this.passcodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passcodeText.UseSystemPasswordChar = true;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Maroon;
            this.submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(275, 207);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // notifierText
            // 
            this.notifierText.AutoSize = true;
            this.notifierText.Font = new System.Drawing.Font("Segoe UI Semilight", 8.75F);
            this.notifierText.ForeColor = System.Drawing.Color.IndianRed;
            this.notifierText.Location = new System.Drawing.Point(207, 270);
            this.notifierText.Name = "notifierText";
            this.notifierText.Size = new System.Drawing.Size(210, 15);
            this.notifierText.TabIndex = 6;
            this.notifierText.Text = "Sorry, but that didn\'t work...try it again.";
            this.notifierText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notifierText.Visible = false;
            // 
            // WhoAreYouWhoWhoWhoWho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(624, 294);
            this.Controls.Add(this.notifierText);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.passcodeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.woahThere);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WhoAreYouWhoWhoWhoWho";
            this.Text = "WhoAreYouWhoWhoWhoWho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label woahThere;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passcodeText;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label notifierText;
    }
}