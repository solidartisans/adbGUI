
namespace adbGUI.Forms
{
    partial class Scrcpy
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
            this.scrcpyDefaultLaunch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scrcpyfullScreenLaunch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrcpyDefaultLaunch
            // 
            this.scrcpyDefaultLaunch.Location = new System.Drawing.Point(0, 19);
            this.scrcpyDefaultLaunch.Name = "scrcpyDefaultLaunch";
            this.scrcpyDefaultLaunch.Size = new System.Drawing.Size(216, 23);
            this.scrcpyDefaultLaunch.TabIndex = 0;
            this.scrcpyDefaultLaunch.Text = "Default Launch";
            this.scrcpyDefaultLaunch.UseVisualStyleBackColor = true;
            this.scrcpyDefaultLaunch.Click += new System.EventHandler(this.scrcpyDefaultLaunch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scrcpyfullScreenLaunch);
            this.groupBox1.Controls.Add(this.scrcpyDefaultLaunch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Normal Useage";
            // 
            // scrcpyfullScreenLaunch
            // 
            this.scrcpyfullScreenLaunch.Location = new System.Drawing.Point(0, 48);
            this.scrcpyfullScreenLaunch.Name = "scrcpyfullScreenLaunch";
            this.scrcpyfullScreenLaunch.Size = new System.Drawing.Size(216, 23);
            this.scrcpyfullScreenLaunch.TabIndex = 1;
            this.scrcpyfullScreenLaunch.Text = "Full Screen Launch";
            this.scrcpyfullScreenLaunch.UseVisualStyleBackColor = true;
            this.scrcpyfullScreenLaunch.Click += new System.EventHandler(this.scrcpyfullScreenLaunch_Click);
            // 
            // Scrcpy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 229);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Scrcpy";
            this.Text = "Scrcpy";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scrcpyDefaultLaunch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button scrcpyfullScreenLaunch;
        

    }
}