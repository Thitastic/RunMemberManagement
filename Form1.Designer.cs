namespace RunMM
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenAPIRepo = new System.Windows.Forms.Button();
            this.btnOpenUIRepo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenAPIPath = new System.Windows.Forms.Button();
            this.txtAPIPath = new System.Windows.Forms.TextBox();
            this.labelAPIPath = new System.Windows.Forms.Label();
            this.labelUIControl = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpenUIFolder = new System.Windows.Forms.Button();
            this.txtUIFolderPath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.RichTextBox();
            this.MainLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.36765F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.63235F));
            this.MainLayout.Controls.Add(this.btnOpenAPIRepo, 1, 0);
            this.MainLayout.Controls.Add(this.btnOpenUIRepo, 0, 0);
            this.MainLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.MainLayout.Controls.Add(this.txtStatus, 1, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 2;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.30357F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.69643F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(544, 239);
            this.MainLayout.TabIndex = 0;
            // 
            // btnOpenAPIRepo
            // 
            this.btnOpenAPIRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOpenAPIRepo.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenAPIRepo.Image")));
            this.btnOpenAPIRepo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenAPIRepo.Location = new System.Drawing.Point(277, 3);
            this.btnOpenAPIRepo.Name = "btnOpenAPIRepo";
            this.btnOpenAPIRepo.Size = new System.Drawing.Size(264, 37);
            this.btnOpenAPIRepo.TabIndex = 1;
            this.btnOpenAPIRepo.Text = "Mở repo API";
            this.btnOpenAPIRepo.UseVisualStyleBackColor = true;
            this.btnOpenAPIRepo.Click += new System.EventHandler(this.btnOpenAPIRepo_Click);
            // 
            // btnOpenUIRepo
            // 
            this.btnOpenUIRepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOpenUIRepo.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenUIRepo.Image")));
            this.btnOpenUIRepo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenUIRepo.Location = new System.Drawing.Point(3, 3);
            this.btnOpenUIRepo.Name = "btnOpenUIRepo";
            this.btnOpenUIRepo.Size = new System.Drawing.Size(266, 37);
            this.btnOpenUIRepo.TabIndex = 0;
            this.btnOpenUIRepo.Text = "Mở repo UI";
            this.btnOpenUIRepo.UseVisualStyleBackColor = true;
            this.btnOpenUIRepo.Click += new System.EventHandler(this.btnOpenUIRepo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAPIPath, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelUIControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 190);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel3.Controls.Add(this.btnOpenAPIPath, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtAPIPath, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 98);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(262, 29);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnOpenAPIPath
            // 
            this.btnOpenAPIPath.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenAPIPath.Image")));
            this.btnOpenAPIPath.Location = new System.Drawing.Point(217, 3);
            this.btnOpenAPIPath.Name = "btnOpenAPIPath";
            this.btnOpenAPIPath.Size = new System.Drawing.Size(42, 22);
            this.btnOpenAPIPath.TabIndex = 0;
            this.btnOpenAPIPath.UseVisualStyleBackColor = true;
            this.btnOpenAPIPath.Click += new System.EventHandler(this.btnOpenAPIPath_Click);
            // 
            // txtAPIPath
            // 
            this.txtAPIPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAPIPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAPIPath.Location = new System.Drawing.Point(3, 3);
            this.txtAPIPath.Name = "txtAPIPath";
            this.txtAPIPath.Size = new System.Drawing.Size(208, 22);
            this.txtAPIPath.TabIndex = 1;
            // 
            // labelAPIPath
            // 
            this.labelAPIPath.AutoSize = true;
            this.labelAPIPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAPIPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelAPIPath.Location = new System.Drawing.Point(3, 65);
            this.labelAPIPath.Name = "labelAPIPath";
            this.labelAPIPath.Size = new System.Drawing.Size(262, 30);
            this.labelAPIPath.TabIndex = 2;
            this.labelAPIPath.Text = "Chọn đường dẫn đến API:";
            // 
            // labelUIControl
            // 
            this.labelUIControl.AutoSize = true;
            this.labelUIControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUIControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelUIControl.Location = new System.Drawing.Point(3, 0);
            this.labelUIControl.Name = "labelUIControl";
            this.labelUIControl.Size = new System.Drawing.Size(262, 30);
            this.labelUIControl.TabIndex = 0;
            this.labelUIControl.Text = "Chọn đường dẫn đến UI:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Controls.Add(this.btnOpenUIFolder, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtUIFolderPath, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnOpenUIFolder
            // 
            this.btnOpenUIFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenUIFolder.Image")));
            this.btnOpenUIFolder.Location = new System.Drawing.Point(217, 3);
            this.btnOpenUIFolder.Name = "btnOpenUIFolder";
            this.btnOpenUIFolder.Size = new System.Drawing.Size(42, 22);
            this.btnOpenUIFolder.TabIndex = 0;
            this.btnOpenUIFolder.UseVisualStyleBackColor = true;
            this.btnOpenUIFolder.Click += new System.EventHandler(this.btnOpenUIFolder_Click);
            // 
            // txtUIFolderPath
            // 
            this.txtUIFolderPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUIFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUIFolderPath.Location = new System.Drawing.Point(3, 3);
            this.txtUIFolderPath.Name = "txtUIFolderPath";
            this.txtUIFolderPath.Size = new System.Drawing.Size(208, 22);
            this.txtUIFolderPath.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnExit, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnStop, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnStart, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(262, 54);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(177, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 48);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Đóng";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStop.Location = new System.Drawing.Point(90, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(81, 48);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Dừng";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 48);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Khởi động";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Location = new System.Drawing.Point(277, 46);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(264, 190);
            this.txtStatus.TabIndex = 3;
            this.txtStatus.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 239);
            this.Controls.Add(this.MainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Quan ly thanh vien control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Button btnOpenUIRepo;
        private System.Windows.Forms.Button btnOpenAPIRepo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelUIControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOpenUIFolder;
        private System.Windows.Forms.TextBox txtUIFolderPath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnOpenAPIPath;
        private System.Windows.Forms.TextBox txtAPIPath;
        private System.Windows.Forms.Label labelAPIPath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox txtStatus;
    }
}

