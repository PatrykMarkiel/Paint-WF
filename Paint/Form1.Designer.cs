namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btn_line = new Button();
            btn_retangle = new Button();
            btn_elipse = new Button();
            btn_eraser = new Button();
            btn_pencil = new Button();
            btn_fill = new Button();
            btn_color = new Button();
            pic_color = new Button();
            menuStrip1 = new MenuStrip();
            filleToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            pic = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btn_line);
            panel1.Controls.Add(btn_retangle);
            panel1.Controls.Add(btn_elipse);
            panel1.Controls.Add(btn_eraser);
            panel1.Controls.Add(btn_pencil);
            panel1.Controls.Add(btn_fill);
            panel1.Controls.Add(btn_color);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1695, 122);
            panel1.TabIndex = 0;
            // 
            // btn_line
            // 
            btn_line.BackColor = Color.White;
            btn_line.Cursor = Cursors.Hand;
            btn_line.FlatAppearance.BorderColor = Color.Black;
            btn_line.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_line.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 1, true);
            btn_line.Location = new Point(1167, 46);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(27, 27);
            btn_line.TabIndex = 7;
            btn_line.Text = "\\";
            btn_line.UseVisualStyleBackColor = false;
            btn_line.Click += btn_line_Click;
            // 
            // btn_retangle
            // 
            btn_retangle.BackColor = Color.White;
            btn_retangle.Cursor = Cursors.Hand;
            btn_retangle.FlatAppearance.BorderColor = Color.Black;
            btn_retangle.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_retangle.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_retangle.FlatStyle = FlatStyle.Flat;
            btn_retangle.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 1, true);
            btn_retangle.Location = new Point(1134, 46);
            btn_retangle.Name = "btn_retangle";
            btn_retangle.Size = new Size(27, 27);
            btn_retangle.TabIndex = 6;
            btn_retangle.Text = "R";
            btn_retangle.UseVisualStyleBackColor = false;
            btn_retangle.Click += btn_retangle_Click;
            // 
            // btn_elipse
            // 
            btn_elipse.BackColor = Color.White;
            btn_elipse.Cursor = Cursors.Hand;
            btn_elipse.FlatAppearance.BorderColor = Color.Black;
            btn_elipse.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_elipse.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_elipse.FlatStyle = FlatStyle.Flat;
            btn_elipse.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 1, true);
            btn_elipse.Location = new Point(1101, 46);
            btn_elipse.Name = "btn_elipse";
            btn_elipse.Size = new Size(27, 27);
            btn_elipse.TabIndex = 5;
            btn_elipse.Text = "E";
            btn_elipse.UseVisualStyleBackColor = false;
            btn_elipse.Click += btn_elipse_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.BackColor = Color.White;
            btn_eraser.Cursor = Cursors.Hand;
            btn_eraser.FlatAppearance.BorderColor = Color.Black;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.Location = new Point(1035, 46);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(60, 60);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "eraser";
            btn_eraser.UseVisualStyleBackColor = false;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.BackColor = Color.White;
            btn_pencil.Cursor = Cursors.Hand;
            btn_pencil.FlatAppearance.BorderColor = Color.Black;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.Location = new Point(969, 46);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(60, 60);
            btn_pencil.TabIndex = 3;
            btn_pencil.Text = "pencil";
            btn_pencil.UseVisualStyleBackColor = false;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_fill
            // 
            btn_fill.BackColor = Color.White;
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.FlatAppearance.BorderColor = Color.Black;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.Location = new Point(903, 46);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(60, 60);
            btn_fill.TabIndex = 2;
            btn_fill.Text = "Fill";
            btn_fill.UseVisualStyleBackColor = false;
            // 
            // btn_color
            // 
            btn_color.BackColor = Color.White;
            btn_color.Cursor = Cursors.Hand;
            btn_color.FlatAppearance.BorderColor = Color.Black;
            btn_color.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_color.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.Location = new Point(837, 46);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(60, 60);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.UseVisualStyleBackColor = false;
            btn_color.Click += btn_color_Click;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.Black;
            pic_color.Location = new Point(771, 46);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(60, 60);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            pic_color.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { filleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1695, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // filleToolStripMenuItem
            // 
            filleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, newToolStripMenuItem, openToolStripMenuItem, clearToolStripMenuItem });
            filleToolStripMenuItem.Name = "filleToolStripMenuItem";
            filleToolStripMenuItem.Size = new Size(40, 20);
            filleToolStripMenuItem.Text = "Fille";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(103, 22);
            newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(103, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 1016);
            panel2.Name = "panel2";
            panel2.Size = new Size(1695, 19);
            panel2.TabIndex = 1;
            // 
            // pic
            // 
            pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic.BackColor = SystemColors.ButtonHighlight;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(1695, 1035);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, -91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(753, 210);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1695, 1035);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pic);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button pic_color;
        private Panel panel2;
        private PictureBox pic;
        private Button btn_color;
        private Button btn_fill;
        private Button btn_pencil;
        private Button btn_eraser;
        private Button btn_elipse;
        private Button btn_retangle;
        private Button btn_line;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filleToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}
