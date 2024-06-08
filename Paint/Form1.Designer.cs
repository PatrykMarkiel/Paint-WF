﻿namespace Paint
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
            panel1 = new Panel();
            btn_line = new Button();
            btn_retangle = new Button();
            btn_elipse = new Button();
            btn_eraser = new Button();
            btn_pencil = new Button();
            btn_fill = new Button();
            btn_color = new Button();
            pic_color = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
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
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1627, 100);
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
            btn_line.Location = new Point(628, 21);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(27, 27);
            btn_line.TabIndex = 7;
            btn_line.UseVisualStyleBackColor = false;
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
            btn_retangle.Location = new Point(595, 54);
            btn_retangle.Name = "btn_retangle";
            btn_retangle.Size = new Size(27, 27);
            btn_retangle.TabIndex = 6;
            btn_retangle.UseVisualStyleBackColor = false;
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
            btn_elipse.Location = new Point(595, 21);
            btn_elipse.Name = "btn_elipse";
            btn_elipse.Size = new Size(27, 27);
            btn_elipse.TabIndex = 5;
            btn_elipse.UseVisualStyleBackColor = false;
            // 
            // btn_eraser
            // 
            btn_eraser.BackColor = Color.White;
            btn_eraser.Cursor = Cursors.Hand;
            btn_eraser.FlatAppearance.BorderColor = Color.Black;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.Location = new Point(529, 21);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(60, 60);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "eraser";
            btn_eraser.UseVisualStyleBackColor = false;
            // 
            // btn_pencil
            // 
            btn_pencil.BackColor = Color.White;
            btn_pencil.Cursor = Cursors.Hand;
            btn_pencil.FlatAppearance.BorderColor = Color.Black;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.Location = new Point(463, 21);
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
            btn_fill.Location = new Point(397, 21);
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
            btn_color.Location = new Point(331, 21);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(60, 60);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.UseVisualStyleBackColor = false;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(265, 21);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(60, 60);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            pic_color.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 987);
            panel2.Name = "panel2";
            panel2.Size = new Size(1627, 19);
            panel2.TabIndex = 1;
            // 
            // pic
            // 
            pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic.BackColor = SystemColors.ButtonHighlight;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(1627, 1006);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1627, 1006);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pic);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
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
    }
}
