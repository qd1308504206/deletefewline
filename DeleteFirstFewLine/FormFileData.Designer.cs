namespace DeleteFirstFewLine
{
    partial class FormFileData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileData));
            this.labelFilePath = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.btnConform = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.labelFileType = new System.Windows.Forms.Label();
            this.labelFileCountZiShu = new System.Windows.Forms.Label();
            this.labelFileCountLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(23, 22);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(65, 12);
            this.labelFilePath.TabIndex = 0;
            this.labelFilePath.Text = "文件路径：";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(35, 48);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(53, 12);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "文件名：";
            // 
            // btnConform
            // 
            this.btnConform.Location = new System.Drawing.Point(84, 149);
            this.btnConform.Name = "btnConform";
            this.btnConform.Size = new System.Drawing.Size(53, 32);
            this.btnConform.TabIndex = 2;
            this.btnConform.Text = "确定";
            this.btnConform.UseVisualStyleBackColor = true;
            this.btnConform.Click += new System.EventHandler(this.btnConform_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(53, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 5;
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(23, 80);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(65, 12);
            this.labelFileSize.TabIndex = 6;
            this.labelFileSize.Text = "文件大小：";
            // 
            // labelFileType
            // 
            this.labelFileType.AutoSize = true;
            this.labelFileType.Location = new System.Drawing.Point(176, 80);
            this.labelFileType.Name = "labelFileType";
            this.labelFileType.Size = new System.Drawing.Size(65, 12);
            this.labelFileType.TabIndex = 7;
            this.labelFileType.Text = "文件类型：";
            // 
            // labelFileCountZiShu
            // 
            this.labelFileCountZiShu.AutoSize = true;
            this.labelFileCountZiShu.Location = new System.Drawing.Point(23, 109);
            this.labelFileCountZiShu.Name = "labelFileCountZiShu";
            this.labelFileCountZiShu.Size = new System.Drawing.Size(65, 12);
            this.labelFileCountZiShu.TabIndex = 8;
            this.labelFileCountZiShu.Text = "文件字数：";
            // 
            // labelFileCountLine
            // 
            this.labelFileCountLine.AutoSize = true;
            this.labelFileCountLine.Location = new System.Drawing.Point(176, 109);
            this.labelFileCountLine.Name = "labelFileCountLine";
            this.labelFileCountLine.Size = new System.Drawing.Size(65, 12);
            this.labelFileCountLine.TabIndex = 9;
            this.labelFileCountLine.Text = "文件行数：";
            // 
            // FormFileData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 193);
            this.Controls.Add(this.labelFileCountLine);
            this.Controls.Add(this.labelFileCountZiShu);
            this.Controls.Add(this.labelFileType);
            this.Controls.Add(this.labelFileSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConform);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.labelFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFileData";
            this.Text = "文件信息";
            this.Load += new System.EventHandler(this.FormFileData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button btnConform;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.Label labelFileType;
        private System.Windows.Forms.Label labelFileCountZiShu;
        private System.Windows.Forms.Label labelFileCountLine;
    }
}