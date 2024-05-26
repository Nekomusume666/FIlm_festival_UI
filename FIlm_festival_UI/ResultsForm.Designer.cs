namespace FIlm_festival_UI
{
    partial class ResultsForm
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
            nav_bar_panel = new Panel();
            panel_green = new Panel();
            Title_of_current_page = new Label();
            label1 = new Label();
            nav_bar_panel.SuspendLayout();
            SuspendLayout();
            // 
            // nav_bar_panel
            // 
            nav_bar_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nav_bar_panel.BackColor = Color.FromArgb(199, 129, 74);
            nav_bar_panel.Controls.Add(panel_green);
            nav_bar_panel.Controls.Add(Title_of_current_page);
            nav_bar_panel.Dock = DockStyle.Top;
            nav_bar_panel.Location = new Point(0, 0);
            nav_bar_panel.Name = "nav_bar_panel";
            nav_bar_panel.Size = new Size(996, 144);
            nav_bar_panel.TabIndex = 7;
            // 
            // panel_green
            // 
            panel_green.BackColor = Color.FromArgb(29, 78, 23);
            panel_green.Dock = DockStyle.Top;
            panel_green.Location = new Point(0, 39);
            panel_green.Name = "panel_green";
            panel_green.Size = new Size(996, 5);
            panel_green.TabIndex = 2;
            // 
            // Title_of_current_page
            // 
            Title_of_current_page.AutoSize = true;
            Title_of_current_page.Dock = DockStyle.Top;
            Title_of_current_page.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Title_of_current_page.ForeColor = Color.FromArgb(11, 16, 12);
            Title_of_current_page.Location = new Point(0, 0);
            Title_of_current_page.Name = "Title_of_current_page";
            Title_of_current_page.Size = new Size(219, 39);
            Title_of_current_page.TabIndex = 1;
            Title_of_current_page.Text = "Результаты";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(387, 549);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 6;
            label1.Text = "учет гостей";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 16, 12);
            ClientSize = new Size(996, 753);
            Controls.Add(nav_bar_panel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultsForm";
            Text = "GuestAccountingForm";
            nav_bar_panel.ResumeLayout(false);
            nav_bar_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel nav_bar_panel;
        private Panel panel_green;
        private Label Title_of_current_page;
        private Label label1;
    }
}