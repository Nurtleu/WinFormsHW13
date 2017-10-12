namespace WinFormsHW13
{
    partial class Explorer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewExplorerFile = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewExplorerFile
            // 
            this.treeViewExplorerFile.Location = new System.Drawing.Point(13, 13);
            this.treeViewExplorerFile.Name = "treeViewExplorerFile";
            this.treeViewExplorerFile.Size = new System.Drawing.Size(367, 379);
            this.treeViewExplorerFile.TabIndex = 0;
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 407);
            this.Controls.Add(this.treeViewExplorerFile);
            this.Name = "Explorer";
            this.Text = "Explorer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewExplorerFile;
    }
}

