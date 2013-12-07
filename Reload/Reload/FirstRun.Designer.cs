namespace Reload
{
    partial class FirstRun
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
            this.woahThere = new System.Windows.Forms.Label();
            this.heyThere = new System.Windows.Forms.Label();
            this.descripText = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.setAdminText = new System.Windows.Forms.Label();
            this.passcodeToSet = new System.Windows.Forms.TextBox();
            this.postPasscodeStatement = new System.Windows.Forms.Label();
            this.submitAndStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // woahThere
            // 
            this.woahThere.AutoSize = true;
            this.woahThere.BackColor = System.Drawing.Color.Transparent;
            this.woahThere.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woahThere.ForeColor = System.Drawing.Color.White;
            this.woahThere.Location = new System.Drawing.Point(325, 9);
            this.woahThere.Name = "woahThere";
            this.woahThere.Size = new System.Drawing.Size(27, 30);
            this.woahThere.TabIndex = 3;
            this.woahThere.Text = "X";
            this.woahThere.Click += new System.EventHandler(this.woahThere_Click);
            // 
            // heyThere
            // 
            this.heyThere.AutoSize = true;
            this.heyThere.BackColor = System.Drawing.Color.Transparent;
            this.heyThere.Font = new System.Drawing.Font("Segoe UI Semilight", 19.75F);
            this.heyThere.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.heyThere.Location = new System.Drawing.Point(114, 119);
            this.heyThere.Name = "heyThere";
            this.heyThere.Size = new System.Drawing.Size(139, 37);
            this.heyThere.TabIndex = 4;
            this.heyThere.Text = "Hey there!";
            // 
            // descripText
            // 
            this.descripText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descripText.BackColor = System.Drawing.Color.Transparent;
            this.descripText.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripText.ForeColor = System.Drawing.Color.White;
            this.descripText.Location = new System.Drawing.Point(0, 182);
            this.descripText.Name = "descripText";
            this.descripText.Size = new System.Drawing.Size(365, 139);
            this.descripText.TabIndex = 5;
            this.descripText.Text = "We see you haven\'t set a password before in Reload, which means Robert messed up," +
    " or this is your first time running this program.\r\n\r\nIf it is indeed the latter," +
    " we need to get that set up!";
            this.descripText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.MidnightBlue;
            this.submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(117, 354);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(131, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Okay, keep going.";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // setAdminText
            // 
            this.setAdminText.AutoSize = true;
            this.setAdminText.BackColor = System.Drawing.Color.Transparent;
            this.setAdminText.Font = new System.Drawing.Font("Segoe UI Semilight", 19.75F);
            this.setAdminText.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.setAdminText.Location = new System.Drawing.Point(27, 145);
            this.setAdminText.Name = "setAdminText";
            this.setAdminText.Size = new System.Drawing.Size(311, 37);
            this.setAdminText.TabIndex = 7;
            this.setAdminText.Text = "Set your admin password";
            this.setAdminText.Visible = false;
            // 
            // passcodeToSet
            // 
            this.passcodeToSet.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.passcodeToSet.Location = new System.Drawing.Point(73, 203);
            this.passcodeToSet.Name = "passcodeToSet";
            this.passcodeToSet.Size = new System.Drawing.Size(219, 22);
            this.passcodeToSet.TabIndex = 8;
            this.passcodeToSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passcodeToSet.UseSystemPasswordChar = true;
            this.passcodeToSet.Visible = false;
            // 
            // postPasscodeStatement
            // 
            this.postPasscodeStatement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.postPasscodeStatement.BackColor = System.Drawing.Color.Transparent;
            this.postPasscodeStatement.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postPasscodeStatement.ForeColor = System.Drawing.Color.White;
            this.postPasscodeStatement.Location = new System.Drawing.Point(0, 228);
            this.postPasscodeStatement.Name = "postPasscodeStatement";
            this.postPasscodeStatement.Size = new System.Drawing.Size(365, 123);
            this.postPasscodeStatement.TabIndex = 9;
            this.postPasscodeStatement.Text = "Don\'t share this password with anybody who shouldn\'t have access to it.\r\n\r\n(No, r" +
    "eally?!? I had no idea!)";
            this.postPasscodeStatement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.postPasscodeStatement.Visible = false;
            // 
            // submitAndStart
            // 
            this.submitAndStart.BackColor = System.Drawing.Color.MidnightBlue;
            this.submitAndStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submitAndStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitAndStart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.submitAndStart.ForeColor = System.Drawing.Color.White;
            this.submitAndStart.Location = new System.Drawing.Point(117, 354);
            this.submitAndStart.Name = "submitAndStart";
            this.submitAndStart.Size = new System.Drawing.Size(131, 23);
            this.submitAndStart.TabIndex = 10;
            this.submitAndStart.Text = "Submit and Start";
            this.submitAndStart.UseVisualStyleBackColor = false;
            this.submitAndStart.Visible = false;
            this.submitAndStart.Click += new System.EventHandler(this.submitAndStart_Click);
            // 
            // FirstRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(364, 409);
            this.Controls.Add(this.submitAndStart);
            this.Controls.Add(this.postPasscodeStatement);
            this.Controls.Add(this.passcodeToSet);
            this.Controls.Add(this.setAdminText);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.descripText);
            this.Controls.Add(this.heyThere);
            this.Controls.Add(this.woahThere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstRun";
            this.Text = "FirstRun";
            this.Load += new System.EventHandler(this.FirstRun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label woahThere;
        private System.Windows.Forms.Label heyThere;
        private System.Windows.Forms.Label descripText;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label setAdminText;
        private System.Windows.Forms.TextBox passcodeToSet;
        private System.Windows.Forms.Label postPasscodeStatement;
        private System.Windows.Forms.Button submitAndStart;
    }
}