namespace Macro
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.CursorPositionLabel = new System.Windows.Forms.Label();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.xPosTextBox = new System.Windows.Forms.TextBox();
            this.yPosTextBox = new System.Windows.Forms.TextBox();
            this.ClickButton = new System.Windows.Forms.Button();
            this.DoubleClickButton = new System.Windows.Forms.Button();
            this.ProcedureListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RightClickButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PressButton = new System.Windows.Forms.Button();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.eachCheckBox = new System.Windows.Forms.CheckBox();
            this.WaitButton = new System.Windows.Forms.Button();
            this.WaitTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRoutineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedMacroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoutineSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.RoutineOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CursorPositionLabel
            // 
            this.CursorPositionLabel.AutoSize = true;
            this.CursorPositionLabel.Location = new System.Drawing.Point(537, 187);
            this.CursorPositionLabel.Name = "CursorPositionLabel";
            this.CursorPositionLabel.Size = new System.Drawing.Size(35, 12);
            this.CursorPositionLabel.TabIndex = 0;
            this.CursorPositionLabel.Text = "(0, 0)";
            // 
            // tick
            // 
            this.tick.Interval = 10;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // xPosTextBox
            // 
            this.xPosTextBox.Location = new System.Drawing.Point(11, 20);
            this.xPosTextBox.Name = "xPosTextBox";
            this.xPosTextBox.Size = new System.Drawing.Size(48, 21);
            this.xPosTextBox.TabIndex = 1;
            // 
            // yPosTextBox
            // 
            this.yPosTextBox.Location = new System.Drawing.Point(65, 20);
            this.yPosTextBox.Name = "yPosTextBox";
            this.yPosTextBox.Size = new System.Drawing.Size(48, 21);
            this.yPosTextBox.TabIndex = 2;
            // 
            // ClickButton
            // 
            this.ClickButton.Location = new System.Drawing.Point(119, 20);
            this.ClickButton.Name = "ClickButton";
            this.ClickButton.Size = new System.Drawing.Size(92, 21);
            this.ClickButton.TabIndex = 3;
            this.ClickButton.Text = "Click";
            this.ClickButton.UseVisualStyleBackColor = true;
            this.ClickButton.Click += new System.EventHandler(this.ClickButton_Click);
            // 
            // DoubleClickButton
            // 
            this.DoubleClickButton.Location = new System.Drawing.Point(217, 20);
            this.DoubleClickButton.Name = "DoubleClickButton";
            this.DoubleClickButton.Size = new System.Drawing.Size(92, 21);
            this.DoubleClickButton.TabIndex = 4;
            this.DoubleClickButton.Text = "Double Click";
            this.DoubleClickButton.UseVisualStyleBackColor = true;
            this.DoubleClickButton.Click += new System.EventHandler(this.DoubleClickButton_Click);
            // 
            // ProcedureListBox
            // 
            this.ProcedureListBox.FormattingEnabled = true;
            this.ProcedureListBox.ItemHeight = 12;
            this.ProcedureListBox.Location = new System.Drawing.Point(12, 27);
            this.ProcedureListBox.Name = "ProcedureListBox";
            this.ProcedureListBox.Size = new System.Drawing.Size(170, 184);
            this.ProcedureListBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RightClickButton);
            this.groupBox1.Controls.Add(this.ClickButton);
            this.groupBox1.Controls.Add(this.xPosTextBox);
            this.groupBox1.Controls.Add(this.DoubleClickButton);
            this.groupBox1.Controls.Add(this.yPosTextBox);
            this.groupBox1.Location = new System.Drawing.Point(188, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mouse";
            // 
            // RightClickButton
            // 
            this.RightClickButton.Location = new System.Drawing.Point(315, 20);
            this.RightClickButton.Name = "RightClickButton";
            this.RightClickButton.Size = new System.Drawing.Size(92, 21);
            this.RightClickButton.TabIndex = 5;
            this.RightClickButton.Text = "Right Click";
            this.RightClickButton.UseVisualStyleBackColor = true;
            this.RightClickButton.Click += new System.EventHandler(this.RightClickButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PressButton);
            this.groupBox2.Controls.Add(this.KeyTextBox);
            this.groupBox2.Location = new System.Drawing.Point(188, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 50);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keyboard";
            // 
            // PressButton
            // 
            this.PressButton.Location = new System.Drawing.Point(217, 20);
            this.PressButton.Name = "PressButton";
            this.PressButton.Size = new System.Drawing.Size(92, 21);
            this.PressButton.TabIndex = 6;
            this.PressButton.Text = "Press";
            this.PressButton.UseVisualStyleBackColor = true;
            this.PressButton.Click += new System.EventHandler(this.PressButton_Click);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(11, 20);
            this.KeyTextBox.MaxLength = 1;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.ReadOnly = true;
            this.KeyTextBox.Size = new System.Drawing.Size(200, 21);
            this.KeyTextBox.TabIndex = 3;
            this.KeyTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyTextBox_PreviewKeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.eachCheckBox);
            this.groupBox3.Controls.Add(this.WaitButton);
            this.groupBox3.Controls.Add(this.WaitTextBox);
            this.groupBox3.Location = new System.Drawing.Point(188, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time";
            // 
            // eachCheckBox
            // 
            this.eachCheckBox.AutoSize = true;
            this.eachCheckBox.Location = new System.Drawing.Point(163, 22);
            this.eachCheckBox.Name = "eachCheckBox";
            this.eachCheckBox.Size = new System.Drawing.Size(53, 16);
            this.eachCheckBox.TabIndex = 7;
            this.eachCheckBox.Text = "Each";
            this.eachCheckBox.UseVisualStyleBackColor = true;
            // 
            // WaitButton
            // 
            this.WaitButton.Location = new System.Drawing.Point(65, 19);
            this.WaitButton.Name = "WaitButton";
            this.WaitButton.Size = new System.Drawing.Size(92, 21);
            this.WaitButton.TabIndex = 6;
            this.WaitButton.Text = "Wait";
            this.WaitButton.UseVisualStyleBackColor = true;
            this.WaitButton.Click += new System.EventHandler(this.WaitButton_Click);
            // 
            // WaitTextBox
            // 
            this.WaitTextBox.Location = new System.Drawing.Point(11, 20);
            this.WaitTextBox.Name = "WaitTextBox";
            this.WaitTextBox.Size = new System.Drawing.Size(48, 21);
            this.WaitTextBox.TabIndex = 4;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(188, 192);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(63, 42);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 213);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(170, 21);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewRoutineToolStripMenuItem,
            this.toolStripSeparator1,
            this.LoadToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.EndToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // NewRoutineToolStripMenuItem
            // 
            this.NewRoutineToolStripMenuItem.Name = "NewRoutineToolStripMenuItem";
            this.NewRoutineToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.NewRoutineToolStripMenuItem.Text = "New Routine";
            this.NewRoutineToolStripMenuItem.Click += new System.EventHandler(this.NewRoutineToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.SaveAsToolStripMenuItem.Text = "Save as";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // EndToolStripMenuItem
            // 
            this.EndToolStripMenuItem.Name = "EndToolStripMenuItem";
            this.EndToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.EndToolStripMenuItem.Text = "End";
            this.EndToolStripMenuItem.Click += new System.EventHandler(this.EndToolStripMenuItem_Click);
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.SettingToolStripMenuItem.Text = "Setting";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speedMacroToolStripMenuItem});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // speedMacroToolStripMenuItem
            // 
            this.speedMacroToolStripMenuItem.Name = "speedMacroToolStripMenuItem";
            this.speedMacroToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.speedMacroToolStripMenuItem.Text = "Speed Macro";
            this.speedMacroToolStripMenuItem.Click += new System.EventHandler(this.speedMacroToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 246);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProcedureListBox);
            this.Controls.Add(this.CursorPositionLabel);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Speed Macro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CursorPositionLabel;
        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.TextBox xPosTextBox;
        private System.Windows.Forms.TextBox yPosTextBox;
        private System.Windows.Forms.Button ClickButton;
        private System.Windows.Forms.Button DoubleClickButton;
        private System.Windows.Forms.ListBox ProcedureListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RightClickButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button PressButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button WaitButton;
        private System.Windows.Forms.TextBox WaitTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewRoutineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speedMacroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog RoutineSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog RoutineOpenFileDialog;
        private System.Windows.Forms.CheckBox eachCheckBox;
    }
}

