namespace adbGUI.Forms
{
    partial class ApkInfoForm
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
            this.apkInfoBrowse = new System.Windows.Forms.Button();
            this.fileApkPath = new System.Windows.Forms.TextBox();
            this.apkOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ApkFileSize = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nativeCode_label = new System.Windows.Forms.Label();
            this.nativeCode = new System.Windows.Forms.TextBox();
            this.versionCode_label = new System.Windows.Forms.Label();
            this.versionCode = new System.Windows.Forms.TextBox();
            this.targetSdkVersion_label = new System.Windows.Forms.Label();
            this.targetSdkVersion = new System.Windows.Forms.TextBox();
            this.sdkVersion_label = new System.Windows.Forms.Label();
            this.sdkVersion = new System.Windows.Forms.TextBox();
            this.packageName_label = new System.Windows.Forms.Label();
            this.packageName = new System.Windows.Forms.TextBox();
            this.versionName_label = new System.Windows.Forms.Label();
            this.versionName = new System.Windows.Forms.TextBox();
            this.apkName_label = new System.Windows.Forms.Label();
            this.apkName = new System.Windows.Forms.TextBox();
            this.ApkfFileSize_Label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // apkInfoBrowse
            // 
            this.apkInfoBrowse.BackColor = System.Drawing.Color.Indigo;
            this.apkInfoBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apkInfoBrowse.ForeColor = System.Drawing.Color.Chartreuse;
            this.apkInfoBrowse.Location = new System.Drawing.Point(22, 22);
            this.apkInfoBrowse.Name = "apkInfoBrowse";
            this.apkInfoBrowse.Size = new System.Drawing.Size(422, 51);
            this.apkInfoBrowse.TabIndex = 0;
            this.apkInfoBrowse.Text = "LOAD APK";
            this.apkInfoBrowse.UseVisualStyleBackColor = false;
            this.apkInfoBrowse.Click += new System.EventHandler(this.apkInfoBrowse_Click);
            // 
            // fileApkPath
            // 
            this.fileApkPath.Location = new System.Drawing.Point(22, 79);
            this.fileApkPath.Name = "fileApkPath";
            this.fileApkPath.Size = new System.Drawing.Size(422, 20);
            this.fileApkPath.TabIndex = 1;
            // 
            // apkOpenFileDialog
            // 
            this.apkOpenFileDialog.FileName = "apkOpenFileDialog";
            // 
            // ApkFileSize
            // 
            this.ApkFileSize.Location = new System.Drawing.Point(10, 40);
            this.ApkFileSize.Name = "ApkFileSize";
            this.ApkFileSize.Size = new System.Drawing.Size(422, 20);
            this.ApkFileSize.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nativeCode_label);
            this.groupBox1.Controls.Add(this.nativeCode);
            this.groupBox1.Controls.Add(this.versionCode_label);
            this.groupBox1.Controls.Add(this.versionCode);
            this.groupBox1.Controls.Add(this.targetSdkVersion_label);
            this.groupBox1.Controls.Add(this.targetSdkVersion);
            this.groupBox1.Controls.Add(this.sdkVersion_label);
            this.groupBox1.Controls.Add(this.sdkVersion);
            this.groupBox1.Controls.Add(this.packageName_label);
            this.groupBox1.Controls.Add(this.packageName);
            this.groupBox1.Controls.Add(this.versionName_label);
            this.groupBox1.Controls.Add(this.versionName);
            this.groupBox1.Controls.Add(this.apkName_label);
            this.groupBox1.Controls.Add(this.apkName);
            this.groupBox1.Controls.Add(this.ApkfFileSize_Label);
            this.groupBox1.Controls.Add(this.ApkFileSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 353);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "APK Info";
            // 
            // nativeCode_label
            // 
            this.nativeCode_label.AutoSize = true;
            this.nativeCode_label.Location = new System.Drawing.Point(7, 297);
            this.nativeCode_label.Name = "nativeCode_label";
            this.nativeCode_label.Size = new System.Drawing.Size(69, 13);
            this.nativeCode_label.TabIndex = 17;
            this.nativeCode_label.Text = "Native Code:";
            // 
            // nativeCode
            // 
            this.nativeCode.Location = new System.Drawing.Point(10, 313);
            this.nativeCode.Name = "nativeCode";
            this.nativeCode.Size = new System.Drawing.Size(422, 20);
            this.nativeCode.TabIndex = 16;
            // 
            // versionCode_label
            // 
            this.versionCode_label.AutoSize = true;
            this.versionCode_label.Location = new System.Drawing.Point(7, 258);
            this.versionCode_label.Name = "versionCode_label";
            this.versionCode_label.Size = new System.Drawing.Size(73, 13);
            this.versionCode_label.TabIndex = 15;
            this.versionCode_label.Text = "Version Code:";
            // 
            // versionCode
            // 
            this.versionCode.Location = new System.Drawing.Point(10, 274);
            this.versionCode.Name = "versionCode";
            this.versionCode.Size = new System.Drawing.Size(422, 20);
            this.versionCode.TabIndex = 14;
            // 
            // targetSdkVersion_label
            // 
            this.targetSdkVersion_label.AutoSize = true;
            this.targetSdkVersion_label.Location = new System.Drawing.Point(7, 219);
            this.targetSdkVersion_label.Name = "targetSdkVersion_label";
            this.targetSdkVersion_label.Size = new System.Drawing.Size(107, 13);
            this.targetSdkVersion_label.TabIndex = 13;
            this.targetSdkVersion_label.Text = "Taarget SDK Version";
            // 
            // targetSdkVersion
            // 
            this.targetSdkVersion.Location = new System.Drawing.Point(10, 235);
            this.targetSdkVersion.Name = "targetSdkVersion";
            this.targetSdkVersion.Size = new System.Drawing.Size(422, 20);
            this.targetSdkVersion.TabIndex = 12;
            // 
            // sdkVersion_label
            // 
            this.sdkVersion_label.AutoSize = true;
            this.sdkVersion_label.Location = new System.Drawing.Point(7, 180);
            this.sdkVersion_label.Name = "sdkVersion_label";
            this.sdkVersion_label.Size = new System.Drawing.Size(70, 13);
            this.sdkVersion_label.TabIndex = 11;
            this.sdkVersion_label.Text = "SDK Version:";
            // 
            // sdkVersion
            // 
            this.sdkVersion.Location = new System.Drawing.Point(10, 196);
            this.sdkVersion.Name = "sdkVersion";
            this.sdkVersion.Size = new System.Drawing.Size(422, 20);
            this.sdkVersion.TabIndex = 10;
            // 
            // packageName_label
            // 
            this.packageName_label.AutoSize = true;
            this.packageName_label.Location = new System.Drawing.Point(7, 141);
            this.packageName_label.Name = "packageName_label";
            this.packageName_label.Size = new System.Drawing.Size(84, 13);
            this.packageName_label.TabIndex = 9;
            this.packageName_label.Text = "Package Name:";
            // 
            // packageName
            // 
            this.packageName.Location = new System.Drawing.Point(10, 157);
            this.packageName.Name = "packageName";
            this.packageName.Size = new System.Drawing.Size(422, 20);
            this.packageName.TabIndex = 8;
            // 
            // versionName_label
            // 
            this.versionName_label.AutoSize = true;
            this.versionName_label.Location = new System.Drawing.Point(7, 102);
            this.versionName_label.Name = "versionName_label";
            this.versionName_label.Size = new System.Drawing.Size(76, 13);
            this.versionName_label.TabIndex = 7;
            this.versionName_label.Text = "Version Name:";
            // 
            // versionName
            // 
            this.versionName.Location = new System.Drawing.Point(10, 118);
            this.versionName.Name = "versionName";
            this.versionName.Size = new System.Drawing.Size(422, 20);
            this.versionName.TabIndex = 6;
            // 
            // apkName_label
            // 
            this.apkName_label.AutoSize = true;
            this.apkName_label.Location = new System.Drawing.Point(7, 63);
            this.apkName_label.Name = "apkName_label";
            this.apkName_label.Size = new System.Drawing.Size(62, 13);
            this.apkName_label.TabIndex = 5;
            this.apkName_label.Text = "APK Name:";
            // 
            // apkName
            // 
            this.apkName.Location = new System.Drawing.Point(10, 79);
            this.apkName.Name = "apkName";
            this.apkName.Size = new System.Drawing.Size(422, 20);
            this.apkName.TabIndex = 4;
            // 
            // ApkfFileSize_Label
            // 
            this.ApkfFileSize_Label.AutoSize = true;
            this.ApkfFileSize_Label.Location = new System.Drawing.Point(7, 19);
            this.ApkfFileSize_Label.Name = "ApkfFileSize_Label";
            this.ApkfFileSize_Label.Size = new System.Drawing.Size(49, 13);
            this.ApkfFileSize_Label.TabIndex = 3;
            this.ApkfFileSize_Label.Text = "File Size:";
            // 
            // ApkInfoForm
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(477, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileApkPath);
            this.Controls.Add(this.apkInfoBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ApkInfoForm";
            this.Text = "APK Info";
            this.Load += new System.EventHandler(this.ApkInfo_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ApkInfoForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ApkInfoForm_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button apkInfoBrowse;
        private System.Windows.Forms.TextBox fileApkPath;
        private System.Windows.Forms.OpenFileDialog apkOpenFileDialog;
        private System.Windows.Forms.TextBox ApkFileSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ApkfFileSize_Label;
        private System.Windows.Forms.Label apkName_label;
        private System.Windows.Forms.TextBox apkName;
        private System.Windows.Forms.Label packageName_label;
        private System.Windows.Forms.TextBox packageName;
        private System.Windows.Forms.Label versionName_label;
        private System.Windows.Forms.TextBox versionName;
        private System.Windows.Forms.Label targetSdkVersion_label;
        private System.Windows.Forms.TextBox targetSdkVersion;
        private System.Windows.Forms.Label sdkVersion_label;
        private System.Windows.Forms.TextBox sdkVersion;
        private System.Windows.Forms.Label nativeCode_label;
        private System.Windows.Forms.TextBox nativeCode;
        private System.Windows.Forms.Label versionCode_label;
        private System.Windows.Forms.TextBox versionCode;
    }
}