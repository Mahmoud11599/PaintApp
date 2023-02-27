
namespace PaintProjectMahmoud
{
    partial class Panel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShapesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.TrapezoidalButton = new System.Windows.Forms.Button();
            this.OvalButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.HexagonButton = new System.Windows.Forms.Button();
            this.DiamondButton = new System.Windows.Forms.Button();
            this.RightTriangleButton = new System.Windows.Forms.Button();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.DrawFillButton = new System.Windows.Forms.Button();
            this.ColorsGroupBox = new System.Windows.Forms.GroupBox();
            this.EditColorsLabel = new System.Windows.Forms.Label();
            this.ColorsButton = new System.Windows.Forms.Button();
            this.color7 = new System.Windows.Forms.Button();
            this.color8 = new System.Windows.Forms.Button();
            this.color9 = new System.Windows.Forms.Button();
            this.color4 = new System.Windows.Forms.Button();
            this.color5 = new System.Windows.Forms.Button();
            this.color6 = new System.Windows.Forms.Button();
            this.color3 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.Button();
            this.SizeGroupBox = new System.Windows.Forms.GroupBox();
            this.Size3 = new System.Windows.Forms.Button();
            this.Size2 = new System.Windows.Forms.Button();
            this.Size1 = new System.Windows.Forms.Button();
            this.ClipBoardGroupBox = new System.Windows.Forms.GroupBox();
            this.PasteButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.FillButton = new System.Windows.Forms.Button();
            this.TrashButton = new System.Windows.Forms.Button();
            this.ToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.EraseButton = new System.Windows.Forms.Button();
            this.PenButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.ShapesGroupBox.SuspendLayout();
            this.ColorsGroupBox.SuspendLayout();
            this.SizeGroupBox.SuspendLayout();
            this.ClipBoardGroupBox.SuspendLayout();
            this.ToolsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.BackgroundImage = global::PaintProjectMahmoud.Properties.Resources.download;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.openImageToolStripMenuItem,
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As Image";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // ShapesGroupBox
            // 
            this.ShapesGroupBox.Controls.Add(this.RectangleButton);
            this.ShapesGroupBox.Controls.Add(this.TrapezoidalButton);
            this.ShapesGroupBox.Controls.Add(this.OvalButton);
            this.ShapesGroupBox.Controls.Add(this.LineButton);
            this.ShapesGroupBox.Controls.Add(this.HexagonButton);
            this.ShapesGroupBox.Controls.Add(this.DiamondButton);
            this.ShapesGroupBox.Controls.Add(this.RightTriangleButton);
            this.ShapesGroupBox.Controls.Add(this.TriangleButton);
            this.ShapesGroupBox.Controls.Add(this.DrawFillButton);
            this.ShapesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShapesGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShapesGroupBox.Location = new System.Drawing.Point(12, 41);
            this.ShapesGroupBox.Name = "ShapesGroupBox";
            this.ShapesGroupBox.Size = new System.Drawing.Size(264, 157);
            this.ShapesGroupBox.TabIndex = 1;
            this.ShapesGroupBox.TabStop = false;
            this.ShapesGroupBox.Text = "Shapes";
            this.ShapesGroupBox.Enter += new System.EventHandler(this.ShapesGroupBox_Enter);
            // 
            // RectangleButton
            // 
            this.RectangleButton.BackColor = System.Drawing.Color.White;
            this.RectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("RectangleButton.Image")));
            this.RectangleButton.Location = new System.Drawing.Point(6, 19);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(59, 45);
            this.RectangleButton.TabIndex = 9;
            this.RectangleButton.UseVisualStyleBackColor = false;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // TrapezoidalButton
            // 
            this.TrapezoidalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrapezoidalButton.Location = new System.Drawing.Point(198, 69);
            this.TrapezoidalButton.Name = "TrapezoidalButton";
            this.TrapezoidalButton.Size = new System.Drawing.Size(59, 45);
            this.TrapezoidalButton.TabIndex = 8;
            this.TrapezoidalButton.UseVisualStyleBackColor = true;
            this.TrapezoidalButton.Click += new System.EventHandler(this.TrapezoidalButton_Click);
            // 
            // OvalButton
            // 
            this.OvalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OvalButton.Location = new System.Drawing.Point(134, 69);
            this.OvalButton.Name = "OvalButton";
            this.OvalButton.Size = new System.Drawing.Size(59, 45);
            this.OvalButton.TabIndex = 7;
            this.OvalButton.UseVisualStyleBackColor = true;
            this.OvalButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // LineButton
            // 
            this.LineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineButton.Location = new System.Drawing.Point(70, 69);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(59, 45);
            this.LineButton.TabIndex = 6;
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // HexagonButton
            // 
            this.HexagonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HexagonButton.Location = new System.Drawing.Point(6, 69);
            this.HexagonButton.Name = "HexagonButton";
            this.HexagonButton.Size = new System.Drawing.Size(59, 45);
            this.HexagonButton.TabIndex = 5;
            this.HexagonButton.UseVisualStyleBackColor = true;
            this.HexagonButton.Click += new System.EventHandler(this.HexagonButton_Click);
            // 
            // DiamondButton
            // 
            this.DiamondButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiamondButton.Location = new System.Drawing.Point(198, 19);
            this.DiamondButton.Name = "DiamondButton";
            this.DiamondButton.Size = new System.Drawing.Size(59, 45);
            this.DiamondButton.TabIndex = 4;
            this.DiamondButton.UseVisualStyleBackColor = true;
            this.DiamondButton.Click += new System.EventHandler(this.DiamondButton_Click);
            // 
            // RightTriangleButton
            // 
            this.RightTriangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightTriangleButton.Location = new System.Drawing.Point(134, 19);
            this.RightTriangleButton.Name = "RightTriangleButton";
            this.RightTriangleButton.Size = new System.Drawing.Size(59, 45);
            this.RightTriangleButton.TabIndex = 3;
            this.RightTriangleButton.UseVisualStyleBackColor = true;
            this.RightTriangleButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // TriangleButton
            // 
            this.TriangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TriangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TriangleButton.Location = new System.Drawing.Point(70, 19);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(59, 45);
            this.TriangleButton.TabIndex = 2;
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DrawFillButton
            // 
            this.DrawFillButton.BackColor = System.Drawing.SystemColors.Control;
            this.DrawFillButton.FlatAppearance.BorderSize = 3;
            this.DrawFillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.DrawFillButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DrawFillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawFillButton.Location = new System.Drawing.Point(6, 120);
            this.DrawFillButton.Name = "DrawFillButton";
            this.DrawFillButton.Size = new System.Drawing.Size(251, 31);
            this.DrawFillButton.TabIndex = 0;
            this.DrawFillButton.Text = "Draw Filled Shapes";
            this.DrawFillButton.UseVisualStyleBackColor = false;
            this.DrawFillButton.Click += new System.EventHandler(this.DrawFillButton_Click);
            // 
            // ColorsGroupBox
            // 
            this.ColorsGroupBox.Controls.Add(this.EditColorsLabel);
            this.ColorsGroupBox.Controls.Add(this.ColorsButton);
            this.ColorsGroupBox.Controls.Add(this.color7);
            this.ColorsGroupBox.Controls.Add(this.color8);
            this.ColorsGroupBox.Controls.Add(this.color9);
            this.ColorsGroupBox.Controls.Add(this.color4);
            this.ColorsGroupBox.Controls.Add(this.color5);
            this.ColorsGroupBox.Controls.Add(this.color6);
            this.ColorsGroupBox.Controls.Add(this.color3);
            this.ColorsGroupBox.Controls.Add(this.color2);
            this.ColorsGroupBox.Controls.Add(this.color1);
            this.ColorsGroupBox.Location = new System.Drawing.Point(282, 62);
            this.ColorsGroupBox.Name = "ColorsGroupBox";
            this.ColorsGroupBox.Size = new System.Drawing.Size(155, 118);
            this.ColorsGroupBox.TabIndex = 2;
            this.ColorsGroupBox.TabStop = false;
            this.ColorsGroupBox.Text = "Colors";
            // 
            // EditColorsLabel
            // 
            this.EditColorsLabel.AutoSize = true;
            this.EditColorsLabel.Location = new System.Drawing.Point(92, 94);
            this.EditColorsLabel.Name = "EditColorsLabel";
            this.EditColorsLabel.Size = new System.Drawing.Size(58, 13);
            this.EditColorsLabel.TabIndex = 10;
            this.EditColorsLabel.Text = "Edit Colors";
            // 
            // ColorsButton
            // 
            this.ColorsButton.FlatAppearance.BorderSize = 2;
            this.ColorsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ColorsButton.Image = ((System.Drawing.Image)(resources.GetObject("ColorsButton.Image")));
            this.ColorsButton.Location = new System.Drawing.Point(91, 30);
            this.ColorsButton.Name = "ColorsButton";
            this.ColorsButton.Size = new System.Drawing.Size(58, 58);
            this.ColorsButton.TabIndex = 9;
            this.ColorsButton.UseVisualStyleBackColor = true;
            this.ColorsButton.Click += new System.EventHandler(this.ColorsButton_Click);
            // 
            // color7
            // 
            this.color7.BackColor = System.Drawing.Color.Purple;
            this.color7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.color7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color7.Location = new System.Drawing.Point(63, 89);
            this.color7.Name = "color7";
            this.color7.Size = new System.Drawing.Size(22, 23);
            this.color7.TabIndex = 8;
            this.color7.UseVisualStyleBackColor = false;
            this.color7.Click += new System.EventHandler(this.color7_Click);
            // 
            // color8
            // 
            this.color8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.color8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.color8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color8.Location = new System.Drawing.Point(63, 54);
            this.color8.Name = "color8";
            this.color8.Size = new System.Drawing.Size(22, 23);
            this.color8.TabIndex = 7;
            this.color8.UseVisualStyleBackColor = false;
            this.color8.Click += new System.EventHandler(this.color8_Click);
            // 
            // color9
            // 
            this.color9.BackColor = System.Drawing.Color.Green;
            this.color9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.color9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color9.Location = new System.Drawing.Point(63, 19);
            this.color9.Name = "color9";
            this.color9.Size = new System.Drawing.Size(22, 23);
            this.color9.TabIndex = 6;
            this.color9.UseVisualStyleBackColor = false;
            this.color9.Click += new System.EventHandler(this.color9_Click);
            // 
            // color4
            // 
            this.color4.BackColor = System.Drawing.Color.Black;
            this.color4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.color4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color4.Location = new System.Drawing.Point(34, 89);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(22, 23);
            this.color4.TabIndex = 5;
            this.color4.UseVisualStyleBackColor = false;
            this.color4.Click += new System.EventHandler(this.color4_Click);
            // 
            // color5
            // 
            this.color5.BackColor = System.Drawing.Color.Magenta;
            this.color5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.color5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color5.Location = new System.Drawing.Point(34, 54);
            this.color5.Name = "color5";
            this.color5.Size = new System.Drawing.Size(22, 23);
            this.color5.TabIndex = 4;
            this.color5.UseVisualStyleBackColor = false;
            this.color5.Click += new System.EventHandler(this.color5_Click);
            // 
            // color6
            // 
            this.color6.BackColor = System.Drawing.Color.Red;
            this.color6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.color6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color6.Location = new System.Drawing.Point(34, 19);
            this.color6.Name = "color6";
            this.color6.Size = new System.Drawing.Size(22, 23);
            this.color6.TabIndex = 3;
            this.color6.UseVisualStyleBackColor = false;
            this.color6.Click += new System.EventHandler(this.color6_Click);
            // 
            // color3
            // 
            this.color3.BackColor = System.Drawing.Color.Aqua;
            this.color3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.color3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color3.Location = new System.Drawing.Point(6, 89);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(22, 23);
            this.color3.TabIndex = 2;
            this.color3.UseVisualStyleBackColor = false;
            this.color3.Click += new System.EventHandler(this.color3_Click);
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.Yellow;
            this.color2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color2.Location = new System.Drawing.Point(6, 54);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(22, 23);
            this.color2.TabIndex = 1;
            this.color2.UseVisualStyleBackColor = false;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.Blue;
            this.color1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color1.Location = new System.Drawing.Point(6, 19);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(22, 23);
            this.color1.TabIndex = 0;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // SizeGroupBox
            // 
            this.SizeGroupBox.Controls.Add(this.Size3);
            this.SizeGroupBox.Controls.Add(this.Size2);
            this.SizeGroupBox.Controls.Add(this.Size1);
            this.SizeGroupBox.Location = new System.Drawing.Point(443, 62);
            this.SizeGroupBox.Name = "SizeGroupBox";
            this.SizeGroupBox.Size = new System.Drawing.Size(98, 118);
            this.SizeGroupBox.TabIndex = 3;
            this.SizeGroupBox.TabStop = false;
            this.SizeGroupBox.Text = "Size";
            // 
            // Size3
            // 
            this.Size3.Location = new System.Drawing.Point(6, 84);
            this.Size3.Name = "Size3";
            this.Size3.Size = new System.Drawing.Size(86, 23);
            this.Size3.TabIndex = 2;
            this.Size3.UseVisualStyleBackColor = true;
            this.Size3.Click += new System.EventHandler(this.Size3_Click);
            // 
            // Size2
            // 
            this.Size2.Location = new System.Drawing.Point(6, 51);
            this.Size2.Name = "Size2";
            this.Size2.Size = new System.Drawing.Size(86, 23);
            this.Size2.TabIndex = 1;
            this.Size2.UseVisualStyleBackColor = true;
            this.Size2.Click += new System.EventHandler(this.Size2_Click);
            // 
            // Size1
            // 
            this.Size1.Location = new System.Drawing.Point(6, 19);
            this.Size1.Name = "Size1";
            this.Size1.Size = new System.Drawing.Size(86, 23);
            this.Size1.TabIndex = 0;
            this.Size1.UseVisualStyleBackColor = true;
            this.Size1.Click += new System.EventHandler(this.Size1_Click);
            // 
            // ClipBoardGroupBox
            // 
            this.ClipBoardGroupBox.Controls.Add(this.PasteButton);
            this.ClipBoardGroupBox.Controls.Add(this.MoveButton);
            this.ClipBoardGroupBox.Controls.Add(this.CopyButton);
            this.ClipBoardGroupBox.Controls.Add(this.ResizeButton);
            this.ClipBoardGroupBox.Controls.Add(this.ChangeColorButton);
            this.ClipBoardGroupBox.Controls.Add(this.FillButton);
            this.ClipBoardGroupBox.Controls.Add(this.TrashButton);
            this.ClipBoardGroupBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClipBoardGroupBox.Location = new System.Drawing.Point(547, 62);
            this.ClipBoardGroupBox.Name = "ClipBoardGroupBox";
            this.ClipBoardGroupBox.Size = new System.Drawing.Size(289, 118);
            this.ClipBoardGroupBox.TabIndex = 4;
            this.ClipBoardGroupBox.TabStop = false;
            this.ClipBoardGroupBox.Text = "Clip Board";
            this.ClipBoardGroupBox.Enter += new System.EventHandler(this.ClipBoardGroupBox_Enter);
            // 
            // PasteButton
            // 
            this.PasteButton.BackColor = System.Drawing.Color.Transparent;
            this.PasteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasteButton.Image = global::PaintProjectMahmoud.Properties.Resources.Paste;
            this.PasteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PasteButton.Location = new System.Drawing.Point(218, 48);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(65, 61);
            this.PasteButton.TabIndex = 6;
            this.PasteButton.Text = "Paste";
            this.PasteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PasteButton.UseVisualStyleBackColor = false;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveButton.Location = new System.Drawing.Point(147, 88);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(66, 23);
            this.MoveButton.TabIndex = 5;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.Transparent;
            this.CopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyButton.Location = new System.Drawing.Point(218, 19);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(65, 25);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "Copy";
            this.CopyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            this.CopyButton.MouseLeave += new System.EventHandler(this.CopyButton_MouseLeave);
            this.CopyButton.MouseHover += new System.EventHandler(this.CopyButton_MouseHover);
            // 
            // ResizeButton
            // 
            this.ResizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResizeButton.Location = new System.Drawing.Point(147, 58);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(66, 26);
            this.ResizeButton.TabIndex = 3;
            this.ResizeButton.Text = "Resize";
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeColorButton.Location = new System.Drawing.Point(147, 18);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(66, 37);
            this.ChangeColorButton.TabIndex = 2;
            this.ChangeColorButton.Text = "Change Color";
            this.ChangeColorButton.UseVisualStyleBackColor = true;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // FillButton
            // 
            this.FillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillButton.Image = global::PaintProjectMahmoud.Properties.Resources.Fill;
            this.FillButton.Location = new System.Drawing.Point(76, 19);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(66, 88);
            this.FillButton.TabIndex = 1;
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // TrashButton
            // 
            this.TrashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrashButton.Image = global::PaintProjectMahmoud.Properties.Resources.Trash;
            this.TrashButton.Location = new System.Drawing.Point(6, 19);
            this.TrashButton.Name = "TrashButton";
            this.TrashButton.Size = new System.Drawing.Size(66, 88);
            this.TrashButton.TabIndex = 0;
            this.TrashButton.UseVisualStyleBackColor = true;
            this.TrashButton.Click += new System.EventHandler(this.TrashButton_Click);
            // 
            // ToolsGroupBox
            // 
            this.ToolsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolsGroupBox.Controls.Add(this.EraseButton);
            this.ToolsGroupBox.Controls.Add(this.PenButton);
            this.ToolsGroupBox.Location = new System.Drawing.Point(841, 85);
            this.ToolsGroupBox.Name = "ToolsGroupBox";
            this.ToolsGroupBox.Size = new System.Drawing.Size(106, 76);
            this.ToolsGroupBox.TabIndex = 4;
            this.ToolsGroupBox.TabStop = false;
            this.ToolsGroupBox.Text = "Tools";
            // 
            // EraseButton
            // 
            this.EraseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EraseButton.Location = new System.Drawing.Point(56, 14);
            this.EraseButton.Name = "EraseButton";
            this.EraseButton.Size = new System.Drawing.Size(44, 56);
            this.EraseButton.TabIndex = 7;
            this.EraseButton.UseVisualStyleBackColor = true;
            this.EraseButton.Click += new System.EventHandler(this.EraseButton_Click);
            // 
            // PenButton
            // 
            this.PenButton.BackColor = System.Drawing.Color.White;
            this.PenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PenButton.Image = global::PaintProjectMahmoud.Properties.Resources.Pen;
            this.PenButton.Location = new System.Drawing.Point(6, 14);
            this.PenButton.Name = "PenButton";
            this.PenButton.Size = new System.Drawing.Size(44, 56);
            this.PenButton.TabIndex = 6;
            this.PenButton.UseVisualStyleBackColor = false;
            this.PenButton.Click += new System.EventHandler(this.PenButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(12, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 425);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PaintProjectMahmoud.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(964, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolsGroupBox);
            this.Controls.Add(this.ClipBoardGroupBox);
            this.Controls.Add(this.SizeGroupBox);
            this.Controls.Add(this.ColorsGroupBox);
            this.Controls.Add(this.ShapesGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(980, 680);
            this.MinimumSize = new System.Drawing.Size(980, 680);
            this.Name = "Panel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ShapesGroupBox.ResumeLayout(false);
            this.ColorsGroupBox.ResumeLayout(false);
            this.ColorsGroupBox.PerformLayout();
            this.SizeGroupBox.ResumeLayout(false);
            this.ClipBoardGroupBox.ResumeLayout(false);
            this.ToolsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox ShapesGroupBox;
        private System.Windows.Forms.GroupBox ColorsGroupBox;
        private System.Windows.Forms.GroupBox SizeGroupBox;
        private System.Windows.Forms.GroupBox ClipBoardGroupBox;
        private System.Windows.Forms.GroupBox ToolsGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DrawFillButton;
        private System.Windows.Forms.Button TrapezoidalButton;
        private System.Windows.Forms.Button OvalButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button HexagonButton;
        private System.Windows.Forms.Button DiamondButton;
        private System.Windows.Forms.Button RightTriangleButton;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button color7;
        private System.Windows.Forms.Button color8;
        private System.Windows.Forms.Button color9;
        private System.Windows.Forms.Button color4;
        private System.Windows.Forms.Button color5;
        private System.Windows.Forms.Button color6;
        private System.Windows.Forms.Button color3;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Label EditColorsLabel;
        private System.Windows.Forms.Button ColorsButton;
        private System.Windows.Forms.Button Size3;
        private System.Windows.Forms.Button Size2;
        private System.Windows.Forms.Button Size1;
        private System.Windows.Forms.Button TrashButton;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.Button ChangeColorButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Button EraseButton;
        private System.Windows.Forms.Button PenButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}

