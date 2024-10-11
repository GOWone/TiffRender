namespace TiffRender
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxTiff = new System.Windows.Forms.PictureBox();
            this.btnRender = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTiff)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxTiff
            // 
            this.pbxTiff.Location = new System.Drawing.Point(12, 28);
            this.pbxTiff.Name = "pbxTiff";
            this.pbxTiff.Size = new System.Drawing.Size(547, 399);
            this.pbxTiff.TabIndex = 0;
            this.pbxTiff.TabStop = false;
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(605, 28);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(143, 23);
            this.btnRender.TabIndex = 1;
            this.btnRender.Text = "Render";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ImageZoom";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.pbxTiff);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxTiff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxTiff;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.Button button1;
    }
}

