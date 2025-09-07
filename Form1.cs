using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunMM
{
    public enum AppState
    {
        Run,     
        Stop     
    }
    public partial class FormMain : Form
    {
        private string _pathToUI = "";
        private string _pathToAPI = "";
        private AppState STATUS = AppState.Stop;
        private Process apiProcess;
        private Process uiProcess;
        private string consoleStatus = "";

        private string PATH_TO_UI
        {
            get => _pathToUI;
            set
            {
                _pathToUI = value;
                txtUIFolderPath.Text = value; // cập nhật TextBox khi biến thay đổi
            }
        }

        private string PATH_TO_API
        {
            get => _pathToAPI;
            set
            {
                _pathToAPI = value;
                txtAPIPath.Text = value; // cập nhật TextBox khi biến thay đổi
            }
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOpenUIRepo_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://github.com/Thitastic/rangdong-member-management-ui.git";
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenAPIRepo_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://github.com/Thitastic/rangdong-member-management-api.git";
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenUIFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Chọn folder bạn muốn";
                folderDialog.ShowNewFolderButton = true; // cho phép tạo folder mới

                // Open dialog
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;

                    // Set Path to UI
                    PATH_TO_UI = selectedPath;
                    txtUIFolderPath.Text = selectedPath;

                    try
                    {
                        // Đảm bảo thư mục "data" tồn tại
                        string dataFolder = Path.Combine(Application.StartupPath, "data");
                        if (!Directory.Exists(dataFolder))
                        {
                            Directory.CreateDirectory(dataFolder);
                        }

                        // Tạo file ui.dat nếu chưa có (hoặc ghi đè nếu đã tồn tại)
                        string filePath = Path.Combine(dataFolder, "ui.dat");
                        File.WriteAllText(filePath, selectedPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu path ui: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string dataFolder = Path.Combine(Application.StartupPath, "data");

                if (!Directory.Exists(dataFolder))
                {
                    Directory.CreateDirectory(dataFolder);
                    // Bạn có thể tạo file mặc định ở đây nếu muốn
                    File.WriteAllText(Path.Combine(dataFolder, "ui.dat"), "");
                    File.WriteAllText(Path.Combine(dataFolder, "api.dat"), "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo thư mục data: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadPaths();
            UpdateButtonStates();
        }

        private void LoadPaths()
        {
            string uiFile = Path.Combine(Application.StartupPath, "data", "ui.dat");
            string apiFile = Path.Combine(Application.StartupPath, "data", "api.dat");

            try
            {
                if (File.Exists(uiFile))
                {
                    string[] uiLines = File.ReadAllLines(uiFile);
                    if (uiLines.Length > 0)
                        PATH_TO_UI = uiLines[0]; // GÁN QUA PROPERTY
                }

                if (File.Exists(apiFile))
                {
                    string[] apiLines = File.ReadAllLines(apiFile);
                    if (apiLines.Length > 0)
                        PATH_TO_API = apiLines[0]; // GÁN QUA PROPERTY
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
            }
        }

        private void btnOpenAPIPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Chọn folder bạn muốn";
                folderDialog.ShowNewFolderButton = true; // cho phép tạo folder mới

                // Open dialog
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.SelectedPath;

                    // Set Path to UI
                    PATH_TO_API = selectedPath;
                    txtAPIPath.Text = selectedPath;

                    try
                    {
                        // Đảm bảo thư mục "data" tồn tại
                        string dataFolder = Path.Combine(Application.StartupPath, "data");
                        if (!Directory.Exists(dataFolder))
                        {
                            Directory.CreateDirectory(dataFolder);
                        }

                        // Tạo file ui.dat nếu chưa có (hoặc ghi đè nếu đã tồn tại)
                        string filePath = Path.Combine(dataFolder, "api.dat");
                        File.WriteAllText(filePath, selectedPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu path ui: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateButtonStates()
        {
            switch (STATUS)
            {
                case AppState.Run:
                    btnStart.Enabled = false;  // không thể Start khi đang Run
                    btnStop.Enabled = true;
                    btnExit.Enabled = false;  // không thể Close khi đang Run
                    break;

                case AppState.Stop:
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;   // Stop bị disable khi đã Stop
                    btnExit.Enabled = true;
                    break;
            }
        }

        private void RunAPIAndUI()
        {
            if (string.IsNullOrWhiteSpace(PATH_TO_API) || string.IsNullOrWhiteSpace(PATH_TO_UI))
            {
                MessageBox.Show("PATH_TO_API hoặc PATH_TO_UI chưa được thiết lập!");
                return;
            }

            if (!Directory.Exists(PATH_TO_API) || !Directory.Exists(PATH_TO_UI))
            {
                MessageBox.Show("Thư mục API hoặc UI không tồn tại!");
                return;
            }

            try
            {
                // Chạy API
                ProcessStartInfo apiStart = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = "run",
                    WorkingDirectory = PATH_TO_API,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                apiProcess = new Process();
                apiProcess.StartInfo = apiStart;
                apiProcess.OutputDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                        UpdateAppStatus($"[API] {e.Data}");
                };
                apiProcess.ErrorDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                        UpdateAppStatus($"[API-ERR] {e.Data}");
                };
                apiProcess.Start();
                apiProcess.BeginOutputReadLine();
                apiProcess.BeginErrorReadLine();

                // Chạy UI
                string npmPath = @"C:\Program Files\nodejs\npm.cmd"; // chỉnh theo máy bạn
                ProcessStartInfo uiStart = new ProcessStartInfo
                {
                    FileName = npmPath,
                    Arguments = "run dev",
                    WorkingDirectory = PATH_TO_UI,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                uiProcess = new Process();
                uiProcess.StartInfo = uiStart;
                uiProcess.OutputDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                        UpdateAppStatus($"[UI] {e.Data}");
                };
                uiProcess.ErrorDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                        UpdateAppStatus($"[UI-ERR] {e.Data}");
                };
                uiProcess.Start();
                uiProcess.BeginOutputReadLine();
                uiProcess.BeginErrorReadLine();

                // Mở dashboard sau vài giây cho UI khởi động
                Timer timer = new Timer();
                timer.Interval = 3000; // chờ 3 giây
                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    OpenDashboard();
                };
                timer.Start();

                STATUS = AppState.Run;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chạy API/UI: " + ex.Message);
            }
        }

        private void UpdateAppStatus(string message)
        {
            // Ghi vào biến appStatus
            consoleStatus += $"{DateTime.Now:HH:mm:ss} {message}\r\n";

            // Nếu bạn có TextBox để hiển thị log thì cập nhật luôn
            if (txtStatus.InvokeRequired)
            {
                txtStatus.Invoke(new Action(() => txtStatus.AppendText(consoleStatus)));
            }
            else
            {
                txtStatus.AppendText(consoleStatus);
            }
        }


        // Dừng 2 process
        private void StopAPIAndUI()
        {
            try
            {
                if (apiProcess != null && !apiProcess.HasExited)
                {
                    KillProcessAndChildren(apiProcess);
                }
            }
            catch { }

            try
            {
                if (uiProcess != null && !uiProcess.HasExited)
                {
                    KillProcessAndChildren(uiProcess);
                }
            }
            catch { }
        }

        private void KillProcessAndChildren(Process proc)
        {
            if (proc == null || proc.HasExited) return;

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "taskkill",
                    Arguments = $"/PID {proc.Id} /T /F",
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                Process.Start(psi).WaitForExit();
            }
            catch { }
        }


        private void OpenDashboard()
        {
            try
            {
                // URL của dashboard
                string url = "http://localhost:3000/dashboard";

                // Mở trình duyệt mặc định
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // bắt buộc để mở URL với trình duyệt mặc định
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở dashboard: " + ex.Message);
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            RunAPIAndUI();
            UpdateButtonStates();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopAPIAndUI();
            STATUS = AppState.Stop;
            UpdateButtonStates();
            UpdateAppStatus("==========PROCESS END==========");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (STATUS == AppState.Run)
            {
                MessageBox.Show("Ứng dụng đang chạy API/UI, vui lòng dừng trước khi thoát!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

    }
}
