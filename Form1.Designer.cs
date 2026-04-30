namespace SimplePaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAppName = new System.Windows.Forms.Label();
            this.GroupBox_one = new System.Windows.Forms.GroupBox();
            this.GroupBox_two = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnline = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.trbLineWidth = new System.Windows.Forms.TrackBar();
            this.GroupBox_one.SuspendLayout();
            this.GroupBox_two.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAppName.ForeColor = System.Drawing.Color.Blue;
            this.lblAppName.Location = new System.Drawing.Point(30, 26);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(422, 86);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Simple Paint";
            // 
            // GroupBox_one
            // 
            this.GroupBox_one.Controls.Add(this.btnCircle);
            this.GroupBox_one.Controls.Add(this.btnRectangle);
            this.GroupBox_one.Controls.Add(this.btnline);
            this.GroupBox_one.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GroupBox_one.Location = new System.Drawing.Point(45, 146);
            this.GroupBox_one.Name = "GroupBox_one";
            this.GroupBox_one.Size = new System.Drawing.Size(464, 166);
            this.GroupBox_one.TabIndex = 1;
            this.GroupBox_one.TabStop = false;
            this.GroupBox_one.Text = "도형 선택";
            // 
            // GroupBox_two
            // 
            this.GroupBox_two.Controls.Add(this.cmbColor);
            this.GroupBox_two.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GroupBox_two.Location = new System.Drawing.Point(528, 147);
            this.GroupBox_two.Name = "GroupBox_two";
            this.GroupBox_two.Size = new System.Drawing.Size(198, 165);
            this.GroupBox_two.TabIndex = 2;
            this.GroupBox_two.TabStop = false;
            this.GroupBox_two.Text = "색 선택";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trbLineWidth);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(752, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "굵기 선택";
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCanvas.Location = new System.Drawing.Point(50, 338);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1227, 456);
            this.picCanvas.TabIndex = 3;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOpenFile.Font = new System.Drawing.Font("맑은 고딕", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOpenFile.Location = new System.Drawing.Point(1011, 195);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(138, 115);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "열기";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSaveFile.Font = new System.Drawing.Font("맑은 고딕", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSaveFile.Location = new System.Drawing.Point(1164, 195);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(138, 115);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "저장";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.Button_open_Click);
            // 
            // btnline
            // 
            this.btnline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnline.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnline.Image = ((System.Drawing.Image)(resources.GetObject("btnline.Image")));
            this.btnline.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnline.Location = new System.Drawing.Point(27, 49);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(115, 104);
            this.btnline.TabIndex = 0;
            this.btnline.Text = "직선";
            this.btnline.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnline.UseVisualStyleBackColor = true;
            this.btnline.Click += new System.EventHandler(this.btnline_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRectangle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRectangle.Location = new System.Drawing.Point(181, 49);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(115, 104);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.Text = "사각형";
            this.btnRectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCircle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCircle.Image = ((System.Drawing.Image)(resources.GetObject("btnCircle.Image")));
            this.btnCircle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCircle.Location = new System.Drawing.Point(331, 49);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(115, 104);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "원";
            this.btnCircle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Black 검정",
            "Red 빨강",
            "Blue 파랑",
            "Green 녹색"});
            this.cmbColor.Location = new System.Drawing.Point(11, 75);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(177, 40);
            this.cmbColor.TabIndex = 0;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // trbLineWidth
            // 
            this.trbLineWidth.Location = new System.Drawing.Point(6, 66);
            this.trbLineWidth.Name = "trbLineWidth";
            this.trbLineWidth.Size = new System.Drawing.Size(228, 90);
            this.trbLineWidth.TabIndex = 0;
            this.trbLineWidth.ValueChanged += new System.EventHandler(this.trbLineWidth_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 823);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox_two);
            this.Controls.Add(this.GroupBox_one);
            this.Controls.Add(this.lblAppName);
            this.Name = "Form1";
            this.Text = "Simple Paint v1.0";
            this.GroupBox_one.ResumeLayout(false);
            this.GroupBox_two.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLineWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.GroupBox GroupBox_one;
        private System.Windows.Forms.GroupBox GroupBox_two;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.TrackBar trbLineWidth;
    }
}

