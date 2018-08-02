namespace StardewValley_SaveBackup
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblBandizipCheck = new System.Windows.Forms.Label();
            this.btnAutoBackup = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnCustomBackup = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnInstallBandizip = new System.Windows.Forms.Button();
            this.btnAutoRestore = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDev = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "반디집 체크: ";
            // 
            // lblBandizipCheck
            // 
            this.lblBandizipCheck.AutoSize = true;
            this.lblBandizipCheck.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBandizipCheck.Location = new System.Drawing.Point(95, 9);
            this.lblBandizipCheck.Name = "lblBandizipCheck";
            this.lblBandizipCheck.Size = new System.Drawing.Size(37, 12);
            this.lblBandizipCheck.TabIndex = 1;
            this.lblBandizipCheck.Text = "none";
            // 
            // btnAutoBackup
            // 
            this.btnAutoBackup.Location = new System.Drawing.Point(12, 33);
            this.btnAutoBackup.Name = "btnAutoBackup";
            this.btnAutoBackup.Size = new System.Drawing.Size(147, 27);
            this.btnAutoBackup.TabIndex = 2;
            this.btnAutoBackup.Text = "세이브 자동 백업";
            this.btnAutoBackup.UseVisualStyleBackColor = true;
            this.btnAutoBackup.Click += new System.EventHandler(this.btnAutoBackup_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "저장할 파일 이름을 넣으세요.";
            // 
            // btnCustomBackup
            // 
            this.btnCustomBackup.Location = new System.Drawing.Point(12, 66);
            this.btnCustomBackup.Name = "btnCustomBackup";
            this.btnCustomBackup.Size = new System.Drawing.Size(147, 27);
            this.btnCustomBackup.TabIndex = 2;
            this.btnCustomBackup.Text = "세이브 수동 백업";
            this.btnCustomBackup.UseVisualStyleBackColor = true;
            this.btnCustomBackup.Click += new System.EventHandler(this.btnCustomBackup_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 135);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(265, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(99, 17);
            this.toolStripStatusLabel1.Text = "만든이 : Eskeptor";
            // 
            // btnInstallBandizip
            // 
            this.btnInstallBandizip.Location = new System.Drawing.Point(165, 33);
            this.btnInstallBandizip.Name = "btnInstallBandizip";
            this.btnInstallBandizip.Size = new System.Drawing.Size(88, 60);
            this.btnInstallBandizip.TabIndex = 2;
            this.btnInstallBandizip.Text = "반디집 설치";
            this.btnInstallBandizip.UseVisualStyleBackColor = true;
            // 
            // btnAutoRestore
            // 
            this.btnAutoRestore.Location = new System.Drawing.Point(12, 99);
            this.btnAutoRestore.Name = "btnAutoRestore";
            this.btnAutoRestore.Size = new System.Drawing.Size(147, 27);
            this.btnAutoRestore.TabIndex = 4;
            this.btnAutoRestore.Text = "세이브 자동 복원";
            this.btnAutoRestore.UseVisualStyleBackColor = true;
            this.btnAutoRestore.Click += new System.EventHandler(this.btnAutoRestore_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "백업파일을 선택하세요.";
            // 
            // btnDev
            // 
            this.btnDev.Location = new System.Drawing.Point(165, 99);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(88, 27);
            this.btnDev.TabIndex = 5;
            this.btnDev.Text = "개발자";
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.btnDev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 157);
            this.Controls.Add(this.btnDev);
            this.Controls.Add(this.btnAutoRestore);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnInstallBandizip);
            this.Controls.Add(this.btnCustomBackup);
            this.Controls.Add(this.btnAutoBackup);
            this.Controls.Add(this.lblBandizipCheck);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "StardewValley SaveBackup Tool V0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBandizipCheck;
        private System.Windows.Forms.Button btnAutoBackup;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnCustomBackup;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnInstallBandizip;
        private System.Windows.Forms.Button btnAutoRestore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDev;
    }
}

