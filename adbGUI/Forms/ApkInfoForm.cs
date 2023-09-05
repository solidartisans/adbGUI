namespace adbGUI.Forms
{
	using adbGUI.Methods;
	using System;
    using System.Windows.Forms;
    using sjd.apk.reader;


    public partial class ApkInfoForm : ExtForm
    {
        public ApkInfoForm()
        {
            InitializeComponent();
        }

        private void ApkInfo_Load(object sender, EventArgs e)
        {

        }

        private void apkInfoBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog apkInfoBrowse = new OpenFileDialog
            {
                
                Title = "Browse APK Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "apk",
                Filter = "APK files (*.apk)|*.apk",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (apkInfoBrowse.ShowDialog() == DialogResult.OK)
            {
                fileApkPath.Text = apkInfoBrowse.FileName;
                InitApkInfo(fileApkPath.Text);

            }

        }

        private void ApkInfoForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = ((string[])e.Data.GetData(DataFormats.FileDrop));
            fileApkPath.Text = files[0];
            InitApkInfo(fileApkPath.Text);
        }

        private void ApkInfoForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void InitApkInfo(string e)
        {
            if (string.IsNullOrEmpty(e))
            {
                throw new ArgumentException($"'{nameof(e)}' cannot be null or empty.", nameof(e));
            }

            var readApk = new Apk_Reader();
            string FileName = string.Format(fileApkPath.Text);

            ApkFileSize.Text = readApk.showFileSize(FileName);
            ApkInfo file_info = readApk.Get_File_Info(FileName);

            apkName.Text = file_info.apkName;
            versionName.Text = file_info.versionName;
            packageName.Text = file_info.packageName;
            sdkVersion.Text = file_info.sdkVersion;
            targetSdkVersion.Text = file_info.targetSdkVersion;
            versionCode.Text = file_info.versionCode;
            nativeCode.Text = file_info.nativeCode;
        }



    }
}