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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            nav_bar_panel = new Panel();
            panel_green = new Panel();
            Title_of_current_page = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label_guest_name = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label_jury_name = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView = new DataGridView();
            NameColunm = new DataGridViewTextBoxColumn();
            JuryColumn = new DataGridViewTextBoxColumn();
            GuestColumn = new DataGridViewTextBoxColumn();
            nav_bar_panel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
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
            nav_bar_panel.Paint += nav_bar_panel_Paint;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 144);
            tableLayoutPanel1.MinimumSize = new Size(500, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(500, 609);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(199, 129, 74);
            panel2.Controls.Add(label_guest_name);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(16, 320);
            panel2.Margin = new Padding(15);
            panel2.Name = "panel2";
            panel2.Size = new Size(468, 273);
            panel2.TabIndex = 9;
            // 
            // label_guest_name
            // 
            label_guest_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_guest_name.AutoSize = true;
            label_guest_name.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_guest_name.ForeColor = Color.FromArgb(11, 16, 12);
            label_guest_name.Location = new Point(0, 127);
            label_guest_name.Name = "label_guest_name";
            label_guest_name.Size = new Size(131, 39);
            label_guest_name.TabIndex = 4;
            label_guest_name.Text = "Фильм";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(99, 37);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Size = new Size(267, 32);
            label4.TabIndex = 3;
            label4.Text = "по мнению гостей";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(11, 16, 12);
            label5.Location = new Point(49, 0);
            label5.Name = "label5";
            label5.Size = new Size(353, 32);
            label5.TabIndex = 2;
            label5.Text = "Победитель фестиваля ";
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(199, 129, 74);
            panel1.Controls.Add(label_jury_name);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(16, 16);
            panel1.Margin = new Padding(15);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 273);
            panel1.TabIndex = 8;
            // 
            // label_jury_name
            // 
            label_jury_name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_jury_name.AutoSize = true;
            label_jury_name.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_jury_name.ForeColor = Color.FromArgb(11, 16, 12);
            label_jury_name.Location = new Point(0, 127);
            label_jury_name.Name = "label_jury_name";
            label_jury_name.Size = new Size(131, 39);
            label_jury_name.TabIndex = 4;
            label_jury_name.Text = "Фильм";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(99, 37);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(252, 32);
            label2.TabIndex = 3;
            label2.Text = "по мнению жюри";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(11, 16, 12);
            label1.Location = new Point(49, 0);
            label1.Name = "label1";
            label1.Size = new Size(353, 32);
            label1.TabIndex = 2;
            label1.Text = "Победитель фестиваля ";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataGridView, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(500, 144);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(496, 609);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(11, 16, 12);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(188, 166, 147);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(188, 1, 25);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColunm, JuryColumn, GuestColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 16, 12);
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(188, 1, 25);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Top;
            dataGridView.GridColor = Color.FromArgb(29, 78, 23);
            dataGridView.Location = new Point(4, 4);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(488, 601);
            dataGridView.TabIndex = 7;
            // 
            // NameColunm
            // 
            NameColunm.HeaderText = "Название";
            NameColunm.MinimumWidth = 6;
            NameColunm.Name = "NameColunm";
            NameColunm.ReadOnly = true;
            // 
            // JuryColumn
            // 
            JuryColumn.FillWeight = 15F;
            JuryColumn.HeaderText = "Ср. кол-во баллов от жюри";
            JuryColumn.MinimumWidth = 6;
            JuryColumn.Name = "JuryColumn";
            JuryColumn.ReadOnly = true;
            // 
            // GuestColumn
            // 
            GuestColumn.FillWeight = 15F;
            GuestColumn.HeaderText = "Ср. кол-во баллов от гостей";
            GuestColumn.MinimumWidth = 6;
            GuestColumn.Name = "GuestColumn";
            GuestColumn.ReadOnly = true;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 16, 12);
            ClientSize = new Size(996, 753);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(nav_bar_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResultsForm";
            Text = "GuestAccountingForm";
            Load += ResultsForm_Load;
            nav_bar_panel.ResumeLayout(false);
            nav_bar_panel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel nav_bar_panel;
        private Panel panel_green;
        private Label Title_of_current_page;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label label1;
        private Label label_jury_name;
        private Label label2;
        private Panel panel2;
        private Label label_guest_name;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn NameColunm;
        private DataGridViewTextBoxColumn JuryColumn;
        private DataGridViewTextBoxColumn GuestColumn;
    }
}