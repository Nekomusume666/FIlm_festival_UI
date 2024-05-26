namespace FIlm_festival_UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            nav_panel = new Panel();
            btn_exit = new Button();
            btn_results = new Button();
            btn_jury_accounting = new Button();
            btn_guests_accounting = new Button();
            btn_fIlm_accounting = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            form_loader_panel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(188, 166, 147);
            panel1.Controls.Add(nav_panel);
            panel1.Controls.Add(btn_exit);
            panel1.Controls.Add(btn_results);
            panel1.Controls.Add(btn_jury_accounting);
            panel1.Controls.Add(btn_guests_accounting);
            panel1.Controls.Add(btn_fIlm_accounting);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 800);
            panel1.TabIndex = 0;
            // 
            // nav_panel
            // 
            nav_panel.BackColor = Color.FromArgb(29, 78, 23);
            nav_panel.Location = new Point(0, 193);
            nav_panel.Name = "nav_panel";
            nav_panel.Size = new Size(7, 100);
            nav_panel.TabIndex = 1;
            // 
            // btn_exit
            // 
            btn_exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_exit.Dock = DockStyle.Bottom;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.FromArgb(11, 16, 12);
            btn_exit.Location = new Point(0, 758);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(186, 42);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "Выйти";
            btn_exit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            btn_exit.Leave += btn_exit_Leave;
            // 
            // btn_results
            // 
            btn_results.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_results.Dock = DockStyle.Top;
            btn_results.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_results.FlatAppearance.BorderSize = 0;
            btn_results.FlatStyle = FlatStyle.Flat;
            btn_results.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_results.ForeColor = Color.FromArgb(11, 16, 12);
            btn_results.Location = new Point(0, 270);
            btn_results.Name = "btn_results";
            btn_results.Size = new Size(186, 42);
            btn_results.TabIndex = 1;
            btn_results.Text = "Результаты";
            btn_results.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_results.UseVisualStyleBackColor = true;
            btn_results.Click += btn_guest_accounting_Click;
            btn_results.Leave += btn_guest_accounting_Leave;
            // 
            // btn_jury_accounting
            // 
            btn_jury_accounting.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_jury_accounting.Dock = DockStyle.Top;
            btn_jury_accounting.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_jury_accounting.FlatAppearance.BorderSize = 0;
            btn_jury_accounting.FlatStyle = FlatStyle.Flat;
            btn_jury_accounting.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_jury_accounting.ForeColor = Color.FromArgb(11, 16, 12);
            btn_jury_accounting.Location = new Point(0, 228);
            btn_jury_accounting.Name = "btn_jury_accounting";
            btn_jury_accounting.Size = new Size(186, 42);
            btn_jury_accounting.TabIndex = 1;
            btn_jury_accounting.Text = "Учёт жюри";
            btn_jury_accounting.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_jury_accounting.UseVisualStyleBackColor = true;
            btn_jury_accounting.Click += btn_jury_accounting_Click;
            btn_jury_accounting.Leave += btn_jury_accounting_Leave;
            // 
            // btn_guests_accounting
            // 
            btn_guests_accounting.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_guests_accounting.Dock = DockStyle.Top;
            btn_guests_accounting.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_guests_accounting.FlatAppearance.BorderSize = 0;
            btn_guests_accounting.FlatStyle = FlatStyle.Flat;
            btn_guests_accounting.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guests_accounting.ForeColor = Color.FromArgb(11, 16, 12);
            btn_guests_accounting.Location = new Point(0, 186);
            btn_guests_accounting.Name = "btn_guests_accounting";
            btn_guests_accounting.Size = new Size(186, 42);
            btn_guests_accounting.TabIndex = 1;
            btn_guests_accounting.Text = "Учёт гостей";
            btn_guests_accounting.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_guests_accounting.UseVisualStyleBackColor = true;
            btn_guests_accounting.Click += btn_participants_accounting_Click;
            btn_guests_accounting.Leave += btn_participants_accounting_Leave;
            // 
            // btn_fIlm_accounting
            // 
            btn_fIlm_accounting.Dock = DockStyle.Top;
            btn_fIlm_accounting.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_fIlm_accounting.FlatAppearance.BorderSize = 0;
            btn_fIlm_accounting.FlatStyle = FlatStyle.Flat;
            btn_fIlm_accounting.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_fIlm_accounting.ForeColor = Color.FromArgb(11, 16, 12);
            btn_fIlm_accounting.Location = new Point(0, 144);
            btn_fIlm_accounting.Name = "btn_fIlm_accounting";
            btn_fIlm_accounting.Size = new Size(186, 42);
            btn_fIlm_accounting.TabIndex = 1;
            btn_fIlm_accounting.Text = "Учёт фильмов";
            btn_fIlm_accounting.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_fIlm_accounting.UseVisualStyleBackColor = true;
            btn_fIlm_accounting.Click += btn_fIlm_accounting_Click;
            btn_fIlm_accounting.Leave += btn_fIlm_accounting_Leave;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(186, 144);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // form_loader_panel
            // 
            form_loader_panel.BackColor = Color.FromArgb(11, 16, 12);
            form_loader_panel.Dock = DockStyle.Fill;
            form_loader_panel.Location = new Point(186, 0);
            form_loader_panel.Name = "form_loader_panel";
            form_loader_panel.Size = new Size(1014, 800);
            form_loader_panel.TabIndex = 3;
            form_loader_panel.Paint += form_loader_panel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(11, 16, 12);
            ClientSize = new Size(1200, 800);
            Controls.Add(form_loader_panel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_fIlm_accounting;
        private Button btn_results;
        private Button btn_jury_accounting;
        private Button btn_guests_accounting;
        private Button btn_exit;
        private Panel nav_panel;
        private PictureBox pictureBox1;
        private Panel form_loader_panel;
    }
}
