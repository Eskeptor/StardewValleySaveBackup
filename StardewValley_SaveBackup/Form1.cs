using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StardewValley_SaveBackup
{

    public partial class Form1 : Form
    {
        private static string STARDEWVALLEY_SAVEPATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StardewValley";
        private string BandizipPath;
        public Form1()
        {
            InitializeComponent();
        }

        private int RunProcess(String fileName, string args)
        {
            Process process = new Process();
            process.StartInfo.FileName = fileName;
            process.StartInfo.Arguments = args;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
            return process.ExitCode;
        }

        private int RunProcess(String fileName)
        {
            Process process = new Process();
            process.StartInfo.FileName = fileName;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.Start();
            process.WaitForExit();
            return process.ExitCode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Programs> list = InstalledPrograms.GetInstalledPrograms();
            Programs programs = list.Find(program => program.Name.Equals("반디집"));
            if (programs != null)
            {
                lblBandizipCheck.Text = "반디집 설치 확인";
                lblBandizipCheck.ForeColor = Color.Green;
                btnAutoBackup.Enabled = true;
                btnCustomBackup.Enabled = true;
                btnInstallBandizip.Enabled = false;
                BandizipPath = programs.Path;
            }
            else
            {
                lblBandizipCheck.Text = "반디집 설치 필요";
                lblBandizipCheck.ForeColor = Color.Red;
                btnAutoBackup.Enabled = false;
                btnCustomBackup.Enabled = true;
                btnInstallBandizip.Enabled = true;
            }
            btnAutoBackup.Focus();
        }

        private void btnAutoBackup_Click(object sender, EventArgs e)
        {
            const string BANDIZIP_COMMAND = "c {0} {1}";
            string autoSaveFromPath = STARDEWVALLEY_SAVEPATH + "\\Saves";
            string autoSaveToPath;
            saveFileDialog1.Filter = "Zip file|*.zip";
            saveFileDialog1.Title = "세이브 파일 저장하기";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    autoSaveToPath = saveFileDialog1.FileName;
                    if (RunProcess("bandizip.exe", string.Format(BANDIZIP_COMMAND, autoSaveToPath, autoSaveFromPath)) == 0)
                    {
                        MessageBox.Show("성공적으로 백업하였습니다.");
                    }
                    else
                    {
                        MessageBox.Show("백업에 실패하였습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("파일 이름이 비었습니다.");
                }
            }

            
        }

        private void btnCustomBackup_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(STARDEWVALLEY_SAVEPATH))
            {
                RunProcess("explorer.exe", STARDEWVALLEY_SAVEPATH);
                MessageBox.Show("[수동백업하는 법]\n1. Saves 폴더를 압축한다.\n2. 압축한 파일을 다른곳에 저장한다.");
            }

            else
                MessageBox.Show("스타듀밸리 세이브 경로가 존재하지 않습니다.");
        }

        private void btnAutoRestore_Click(object sender, EventArgs e)
        {
            const string BANDIZIP_COMMAND = "x -o:{0} {1}";
            string SAVE_PATH = STARDEWVALLEY_SAVEPATH + "\\Saves";
            string autoRestoreFilePath;
            string autoRestoreFileName;
            openFileDialog1.Filter = "Zip file|*.zip";
            openFileDialog1.Title = "세이브 파일 불러오기";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName != "")
                {
                    autoRestoreFilePath = openFileDialog1.FileName;
                    autoRestoreFileName = Path.GetFileNameWithoutExtension(autoRestoreFilePath);
                    if (RunProcess("bandizip.exe", string.Format(BANDIZIP_COMMAND, SAVE_PATH, autoRestoreFilePath)) == 0)
                    {
                        MessageBox.Show("성공적으로 복원하였습니다.");
                    }
                    else
                    {
                        MessageBox.Show("복원에 실패하였습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("파일 이름이 비었습니다.");
                }
            }
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            RunProcess("http://blog.naver.com/skyvvv624");
        }
    }

    class Programs
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Programs(string name = null, string path = null)
        {
            Name = name;
            Path = path;
        }
    }

    // InstalledPrograms by https://stackoverflow.com/questions/15524161/c-how-to-get-installing-programs-exactly-like-in-control-panel-programs-and-fe
    static class InstalledPrograms
    {
        const string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";

        public static List<Programs> GetInstalledPrograms()
        {
            var result = new List<Programs>();
            result.AddRange(GetInstalledProgramsFromRegistry(RegistryView.Registry32));
            result.AddRange(GetInstalledProgramsFromRegistry(RegistryView.Registry64));
            return result;
        }

        private static IEnumerable<Programs> GetInstalledProgramsFromRegistry(RegistryView registryView)
        {
            var result = new List<Programs>();

            using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView).OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        if (IsProgramVisible(subkey))
                        {
                            Programs programs = new Programs
                            {
                                Name = (string)subkey.GetValue("DisplayName"),
                                Path = (string)subkey.GetValue("Program Path")
                            };
                            result.Add(programs);
                        }
                    }
                }
            }

            return result;
        }

        private static bool IsProgramVisible(RegistryKey subkey)
        {
            var name = (string)subkey.GetValue("DisplayName");
            var releaseType = (string)subkey.GetValue("ReleaseType");
            //var unistallString = (string)subkey.GetValue("UninstallString");
            var systemComponent = subkey.GetValue("SystemComponent");
            var parentName = (string)subkey.GetValue("ParentDisplayName");

            return
                !string.IsNullOrEmpty(name)
                && string.IsNullOrEmpty(releaseType)
                && string.IsNullOrEmpty(parentName)
                && (systemComponent == null);
        }
    }
}
