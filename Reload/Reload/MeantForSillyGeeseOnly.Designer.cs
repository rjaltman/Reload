namespace Reload
{
    partial class MeantForSillyGeeseOnly
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.savePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pathToLoad = new System.Windows.Forms.TextBox();
            this.browseForItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nowColor = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.animatorTimer = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.enableReloadSolo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // savePath
            // 
            this.savePath.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.savePath.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.savePath.FlatAppearance.BorderSize = 2;
            this.savePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePath.ForeColor = System.Drawing.Color.White;
            this.savePath.Location = new System.Drawing.Point(679, 335);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(104, 35);
            this.savePath.TabIndex = 1;
            this.savePath.Text = "Exit";
            this.savePath.UseVisualStyleBackColor = false;
            this.savePath.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "What should load on start?";
            // 
            // pathToLoad
            // 
            this.pathToLoad.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathToLoad.Location = new System.Drawing.Point(17, 117);
            this.pathToLoad.Name = "pathToLoad";
            this.pathToLoad.Size = new System.Drawing.Size(211, 22);
            this.pathToLoad.TabIndex = 3;
            // 
            // browseForItem
            // 
            this.browseForItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.browseForItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.browseForItem.FlatAppearance.BorderSize = 2;
            this.browseForItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseForItem.Font = new System.Drawing.Font("Segoe UI", 5.25F, System.Drawing.FontStyle.Bold);
            this.browseForItem.ForeColor = System.Drawing.Color.White;
            this.browseForItem.Location = new System.Drawing.Point(234, 117);
            this.browseForItem.Name = "browseForItem";
            this.browseForItem.Size = new System.Drawing.Size(27, 22);
            this.browseForItem.TabIndex = 4;
            this.browseForItem.Text = "...";
            this.browseForItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.browseForItem.UseVisualStyleBackColor = false;
            this.browseForItem.Click += new System.EventHandler(this.browseForItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(328, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Miscellaneous Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(12, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "What color is the back?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Is currently";
            // 
            // nowColor
            // 
            this.nowColor.BackColor = System.Drawing.Color.Red;
            this.nowColor.Location = new System.Drawing.Point(93, 322);
            this.nowColor.Name = "nowColor";
            this.nowColor.Size = new System.Drawing.Size(19, 19);
            this.nowColor.TabIndex = 12;
            this.nowColor.Click += new System.EventHandler(this.nowColor_Click);
            this.nowColor.Paint += new System.Windows.Forms.PaintEventHandler(this.nowColor_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Type in a site, path, or browse:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 40);
            this.label8.TabIndex = 14;
            this.label8.Text = "Click on the box to change.\r\n(it will apply immediately)";
            // 
            // animatorTimer
            // 
            this.animatorTimer.Enabled = true;
            this.animatorTimer.Interval = 10;
            this.animatorTimer.Tick += new System.EventHandler(this.animatorTimer_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semilight", 10.75F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Any name will do.";
            // 
            // taskName
            // 
            this.taskName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(17, 233);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(211, 22);
            this.taskName.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(12, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 30);
            this.label10.TabIndex = 15;
            this.label10.Text = "What is the task called?";
            // 
            // enableReloadSolo
            // 
            this.enableReloadSolo.AutoSize = true;
            this.enableReloadSolo.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableReloadSolo.ForeColor = System.Drawing.Color.White;
            this.enableReloadSolo.Location = new System.Drawing.Point(333, 107);
            this.enableReloadSolo.Name = "enableReloadSolo";
            this.enableReloadSolo.Size = new System.Drawing.Size(135, 21);
            this.enableReloadSolo.TabIndex = 19;
            this.enableReloadSolo.Text = "Enable Reload Solo";
            this.enableReloadSolo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(352, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 61);
            this.label4.TabIndex = 20;
            this.label4.Text = "When this is enabled, Windows Explorer will be closed and normal navigation for a" +
    " user will be denied. The only way to re-enable Explorer is to run Task Manager " +
    "and ultimately reenable it.";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(414, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(369, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "To see your changes, you will need to click Refresh on the main form.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MeantForSillyGeeseOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(795, 402);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enableReloadSolo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.taskName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nowColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.browseForItem);
            this.Controls.Add(this.pathToLoad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.savePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeantForSillyGeeseOnly";
            this.Text = "MeantForSillyGeeseOnly";
            this.Load += new System.EventHandler(this.MeantForSillyGeeseOnly_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pathToLoad;
        private System.Windows.Forms.Button browseForItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel nowColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer animatorTimer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox taskName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox enableReloadSolo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
    }
}