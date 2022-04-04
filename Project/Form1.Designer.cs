namespace Project
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_CallImage = new System.Windows.Forms.Button();
            this.btn_Mirror = new System.Windows.Forms.Button();
            this.btn_Rotate = new System.Windows.Forms.Button();
            this.btn_Black = new System.Windows.Forms.Button();
            this.btn_Red = new System.Windows.Forms.Button();
            this.btn_Green = new System.Windows.Forms.Button();
            this.btn_Blue = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Original = new System.Windows.Forms.Button();
            this.btn_Lotate = new System.Windows.Forms.Button();
            this.btn_Gray = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(421, 322);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 322);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_CallImage
            // 
            this.btn_CallImage.Location = new System.Drawing.Point(459, 12);
            this.btn_CallImage.Name = "btn_CallImage";
            this.btn_CallImage.Size = new System.Drawing.Size(113, 44);
            this.btn_CallImage.TabIndex = 1;
            this.btn_CallImage.Text = "이미지 불러오기";
            this.btn_CallImage.UseVisualStyleBackColor = true;
            this.btn_CallImage.Click += new System.EventHandler(this.btn_CallImage_Click);
            // 
            // btn_Mirror
            // 
            this.btn_Mirror.Location = new System.Drawing.Point(459, 62);
            this.btn_Mirror.Name = "btn_Mirror";
            this.btn_Mirror.Size = new System.Drawing.Size(113, 44);
            this.btn_Mirror.TabIndex = 2;
            this.btn_Mirror.Text = "이미지 미러링";
            this.btn_Mirror.UseVisualStyleBackColor = true;
            this.btn_Mirror.Click += new System.EventHandler(this.btn_Mirror_Click);
            // 
            // btn_Rotate
            // 
            this.btn_Rotate.Location = new System.Drawing.Point(619, 112);
            this.btn_Rotate.Name = "btn_Rotate";
            this.btn_Rotate.Size = new System.Drawing.Size(113, 44);
            this.btn_Rotate.TabIndex = 3;
            this.btn_Rotate.Text = "이미지 우회전";
            this.btn_Rotate.UseVisualStyleBackColor = true;
            this.btn_Rotate.Click += new System.EventHandler(this.btn_Rotate_Click);
            // 
            // btn_Black
            // 
            this.btn_Black.Location = new System.Drawing.Point(459, 162);
            this.btn_Black.Name = "btn_Black";
            this.btn_Black.Size = new System.Drawing.Size(113, 44);
            this.btn_Black.TabIndex = 4;
            this.btn_Black.Text = "흑백";
            this.btn_Black.UseVisualStyleBackColor = true;
            this.btn_Black.Click += new System.EventHandler(this.btn_Black_Click);
            // 
            // btn_Red
            // 
            this.btn_Red.Location = new System.Drawing.Point(459, 212);
            this.btn_Red.Name = "btn_Red";
            this.btn_Red.Size = new System.Drawing.Size(113, 44);
            this.btn_Red.TabIndex = 5;
            this.btn_Red.Text = "RED";
            this.btn_Red.UseVisualStyleBackColor = true;
            this.btn_Red.Click += new System.EventHandler(this.btn_Red_Click);
            // 
            // btn_Green
            // 
            this.btn_Green.Location = new System.Drawing.Point(459, 262);
            this.btn_Green.Name = "btn_Green";
            this.btn_Green.Size = new System.Drawing.Size(113, 44);
            this.btn_Green.TabIndex = 6;
            this.btn_Green.Text = "GREEN";
            this.btn_Green.UseVisualStyleBackColor = true;
            this.btn_Green.Click += new System.EventHandler(this.btn_Green_Click);
            // 
            // btn_Blue
            // 
            this.btn_Blue.Location = new System.Drawing.Point(619, 212);
            this.btn_Blue.Name = "btn_Blue";
            this.btn_Blue.Size = new System.Drawing.Size(113, 44);
            this.btn_Blue.TabIndex = 7;
            this.btn_Blue.Text = "BLUE";
            this.btn_Blue.UseVisualStyleBackColor = true;
            this.btn_Blue.Click += new System.EventHandler(this.btn_Blue_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(619, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(113, 44);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "종료";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Original
            // 
            this.btn_Original.Location = new System.Drawing.Point(619, 62);
            this.btn_Original.Name = "btn_Original";
            this.btn_Original.Size = new System.Drawing.Size(113, 44);
            this.btn_Original.TabIndex = 10;
            this.btn_Original.Text = "원상복구";
            this.btn_Original.UseVisualStyleBackColor = true;
            this.btn_Original.Click += new System.EventHandler(this.btn_Original_Click);
            // 
            // btn_Lotate
            // 
            this.btn_Lotate.Location = new System.Drawing.Point(459, 112);
            this.btn_Lotate.Name = "btn_Lotate";
            this.btn_Lotate.Size = new System.Drawing.Size(113, 44);
            this.btn_Lotate.TabIndex = 11;
            this.btn_Lotate.Text = "이미지 좌회전";
            this.btn_Lotate.UseVisualStyleBackColor = true;
            this.btn_Lotate.Click += new System.EventHandler(this.btn_Lotate_Click);
            // 
            // btn_Gray
            // 
            this.btn_Gray.Location = new System.Drawing.Point(619, 162);
            this.btn_Gray.Name = "btn_Gray";
            this.btn_Gray.Size = new System.Drawing.Size(113, 44);
            this.btn_Gray.TabIndex = 12;
            this.btn_Gray.Text = "회색";
            this.btn_Gray.UseVisualStyleBackColor = true;
            this.btn_Gray.Click += new System.EventHandler(this.btn_Gray_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 377);
            this.Controls.Add(this.btn_Gray);
            this.Controls.Add(this.btn_Lotate);
            this.Controls.Add(this.btn_Original);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Blue);
            this.Controls.Add(this.btn_Green);
            this.Controls.Add(this.btn_Red);
            this.Controls.Add(this.btn_Black);
            this.Controls.Add(this.btn_Rotate);
            this.Controls.Add(this.btn_Mirror);
            this.Controls.Add(this.btn_CallImage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_CallImage;
        private System.Windows.Forms.Button btn_Mirror;
        private System.Windows.Forms.Button btn_Rotate;
        private System.Windows.Forms.Button btn_Black;
        private System.Windows.Forms.Button btn_Red;
        private System.Windows.Forms.Button btn_Green;
        private System.Windows.Forms.Button btn_Blue;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Original;
        private System.Windows.Forms.Button btn_Lotate;
        private System.Windows.Forms.Button btn_Gray;
    }
}

