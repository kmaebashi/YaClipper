
namespace YaClipper
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.clipToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.mainToolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNewToolStripMenuItem,
            this.FileOpenToolStripMenuItem,
            this.fileSaveToolStripMenuItem,
            this.fileSaveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // fileNewToolStripMenuItem
            // 
            this.fileNewToolStripMenuItem.Name = "fileNewToolStripMenuItem";
            this.fileNewToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fileNewToolStripMenuItem.Text = "新規作成(&N)";
            // 
            // FileOpenToolStripMenuItem
            // 
            this.FileOpenToolStripMenuItem.Name = "FileOpenToolStripMenuItem";
            this.FileOpenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.FileOpenToolStripMenuItem.Text = "開く(&O)";
            // 
            // fileSaveToolStripMenuItem
            // 
            this.fileSaveToolStripMenuItem.Name = "fileSaveToolStripMenuItem";
            this.fileSaveToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fileSaveToolStripMenuItem.Text = "上書き保存(&S)";
            // 
            // fileSaveAsToolStripMenuItem
            // 
            this.fileSaveAsToolStripMenuItem.Name = "fileSaveAsToolStripMenuItem";
            this.fileSaveAsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fileSaveAsToolStripMenuItem.Text = "名前を付けて保存(&A)";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUndoToolStripMenuItem,
            this.editRedoToolStripMenuItem,
            this.editCutToolStripMenuItem,
            this.editCopyToolStripMenuItem,
            this.editPasteToolStripMenuItem,
            this.editDeleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editToolStripMenuItem.Text = "編集(&E)";
            // 
            // editUndoToolStripMenuItem
            // 
            this.editUndoToolStripMenuItem.Name = "editUndoToolStripMenuItem";
            this.editUndoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editUndoToolStripMenuItem.Text = "元に戻す(&U)";
            // 
            // editRedoToolStripMenuItem
            // 
            this.editRedoToolStripMenuItem.Name = "editRedoToolStripMenuItem";
            this.editRedoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editRedoToolStripMenuItem.Text = "やり直し(&R)";
            // 
            // editCutToolStripMenuItem
            // 
            this.editCutToolStripMenuItem.Name = "editCutToolStripMenuItem";
            this.editCutToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editCutToolStripMenuItem.Text = "切り取り(&T)";
            // 
            // editCopyToolStripMenuItem
            // 
            this.editCopyToolStripMenuItem.Name = "editCopyToolStripMenuItem";
            this.editCopyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editCopyToolStripMenuItem.Text = "コピー(&C)";
            // 
            // editPasteToolStripMenuItem
            // 
            this.editPasteToolStripMenuItem.Name = "editPasteToolStripMenuItem";
            this.editPasteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editPasteToolStripMenuItem.Text = "貼り付け(&P)";
            // 
            // editDeleteToolStripMenuItem
            // 
            this.editDeleteToolStripMenuItem.Name = "editDeleteToolStripMenuItem";
            this.editDeleteToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editDeleteToolStripMenuItem.Text = "削除(&D)";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mainPanel.Controls.Add(this.mainPictureBox);
            this.mainPanel.Location = new System.Drawing.Point(0, 50);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 377);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.TabStop = true;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(0, 0);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clipToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(1, 25);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(35, 25);
            this.mainToolStrip.TabIndex = 2;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // clipToolStripButton
            // 
            this.clipToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clipToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clipToolStripButton.Image")));
            this.clipToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clipToolStripButton.Name = "clipToolStripButton";
            this.clipToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.clipToolStripButton.Text = "Clip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1,
            this.toolStripSpacer});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripSpacer
            // 
            this.toolStripSpacer.Name = "toolStripSpacer";
            this.toolStripSpacer.Size = new System.Drawing.Size(636, 17);
            this.toolStripSpacer.Spring = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "YaClipper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDeleteToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton clipToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripSpacer;
    }
}

