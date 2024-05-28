namespace FIlm_festival_UI
{
    partial class JuryAccountingForm
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
            btn_voting = new Button();
            filter_panel = new Panel();
            label_filter = new Label();
            textBox_filter = new TextBox();
            comboBox_filter = new ComboBox();
            btn_delete = new Button();
            btn_add_film = new Button();
            label_Count = new Label();
            panel_green = new Panel();
            Title_of_current_page = new Label();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            VoteColumn = new DataGridViewTextBoxColumn();
            nav_bar_panel.SuspendLayout();
            filter_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // nav_bar_panel
            // 
            nav_bar_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nav_bar_panel.BackColor = Color.FromArgb(199, 129, 74);
            nav_bar_panel.Controls.Add(btn_voting);
            nav_bar_panel.Controls.Add(filter_panel);
            nav_bar_panel.Controls.Add(btn_delete);
            nav_bar_panel.Controls.Add(btn_add_film);
            nav_bar_panel.Controls.Add(label_Count);
            nav_bar_panel.Controls.Add(panel_green);
            nav_bar_panel.Controls.Add(Title_of_current_page);
            nav_bar_panel.Dock = DockStyle.Top;
            nav_bar_panel.Location = new Point(0, 0);
            nav_bar_panel.Name = "nav_bar_panel";
            nav_bar_panel.Size = new Size(996, 144);
            nav_bar_panel.TabIndex = 7;
            // 
            // btn_voting
            // 
            btn_voting.BackColor = Color.FromArgb(0, 0, 192);
            btn_voting.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_voting.FlatStyle = FlatStyle.Flat;
            btn_voting.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_voting.ForeColor = Color.White;
            btn_voting.Location = new Point(438, 49);
            btn_voting.Name = "btn_voting";
            btn_voting.Size = new Size(238, 42);
            btn_voting.TabIndex = 12;
            btn_voting.Text = "Голосование";
            btn_voting.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_voting.UseVisualStyleBackColor = false;
            btn_voting.Click += btn_voting_Click;
            // 
            // filter_panel
            // 
            filter_panel.BackColor = Color.FromArgb(188, 166, 147);
            filter_panel.BorderStyle = BorderStyle.FixedSingle;
            filter_panel.Controls.Add(label_filter);
            filter_panel.Controls.Add(textBox_filter);
            filter_panel.Controls.Add(comboBox_filter);
            filter_panel.Location = new Point(3, 97);
            filter_panel.Name = "filter_panel";
            filter_panel.Size = new Size(637, 43);
            filter_panel.TabIndex = 12;
            // 
            // label_filter
            // 
            label_filter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_filter.AutoSize = true;
            label_filter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_filter.ForeColor = Color.FromArgb(11, 16, 12);
            label_filter.Location = new Point(3, 8);
            label_filter.Name = "label_filter";
            label_filter.Size = new Size(199, 25);
            label_filter.TabIndex = 4;
            label_filter.Text = "Отфильтровать по ";
            // 
            // textBox_filter
            // 
            textBox_filter.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_filter.Location = new Point(434, 7);
            textBox_filter.Name = "textBox_filter";
            textBox_filter.Size = new Size(186, 30);
            textBox_filter.TabIndex = 1;
            textBox_filter.TextChanged += textBox_filter_TextChanged;
            textBox_filter.Enter += textBox_filter_Enter;
            // 
            // comboBox_filter
            // 
            comboBox_filter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_filter.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_filter.FormattingEnabled = true;
            comboBox_filter.Items.AddRange(new object[] { "имени члена жюри", "фамилии члена жюри", "должности члена жюри", "отметке о голосовании" });
            comboBox_filter.Location = new Point(219, 7);
            comboBox_filter.Name = "comboBox_filter";
            comboBox_filter.Size = new Size(186, 31);
            comboBox_filter.TabIndex = 0;
            comboBox_filter.SelectedIndexChanged += comboBox_filter_SelectedIndexChanged;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(188, 1, 25);
            btn_delete.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(223, 49);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(186, 42);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "Удалить жюри";
            btn_delete.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add_film
            // 
            btn_add_film.BackColor = Color.FromArgb(29, 78, 23);
            btn_add_film.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_add_film.FlatStyle = FlatStyle.Flat;
            btn_add_film.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add_film.ForeColor = Color.White;
            btn_add_film.Location = new Point(3, 49);
            btn_add_film.Name = "btn_add_film";
            btn_add_film.Size = new Size(186, 42);
            btn_add_film.TabIndex = 10;
            btn_add_film.Text = "Добавить жюри";
            btn_add_film.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_add_film.UseVisualStyleBackColor = false;
            btn_add_film.Click += btn_add_film_Click;
            // 
            // label_Count
            // 
            label_Count.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_Count.AutoSize = true;
            label_Count.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_Count.ForeColor = Color.FromArgb(11, 16, 12);
            label_Count.Location = new Point(770, 49);
            label_Count.Name = "label_Count";
            label_Count.Size = new Size(193, 25);
            label_Count.TabIndex = 9;
            label_Count.Text = "Количество жюри: ";
            // 
            // panel_green
            // 
            panel_green.BackColor = Color.FromArgb(29, 78, 23);
            panel_green.Dock = DockStyle.Top;
            panel_green.Location = new Point(0, 39);
            panel_green.Name = "panel_green";
            panel_green.Size = new Size(996, 5);
            panel_green.TabIndex = 8;
            // 
            // Title_of_current_page
            // 
            Title_of_current_page.AutoSize = true;
            Title_of_current_page.Dock = DockStyle.Top;
            Title_of_current_page.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Title_of_current_page.ForeColor = Color.FromArgb(11, 16, 12);
            Title_of_current_page.Location = new Point(0, 0);
            Title_of_current_page.Name = "Title_of_current_page";
            Title_of_current_page.Size = new Size(201, 39);
            Title_of_current_page.TabIndex = 7;
            Title_of_current_page.Text = "Учёт жюри";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, VoteColumn });
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
            dataGridView.Location = new Point(0, 144);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(996, 654);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += film_dataGridView_CellContentClick;
            dataGridView.CellMouseDoubleClick += dataGridView_CellMouseDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Имя члена жюри";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Фамилия члена жюри";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Должность члена жюри";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // VoteColumn
            // 
            VoteColumn.HeaderText = "Проголосовал?";
            VoteColumn.MinimumWidth = 6;
            VoteColumn.Name = "VoteColumn";
            VoteColumn.ReadOnly = true;
            // 
            // JuryAccountingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 16, 12);
            ClientSize = new Size(996, 753);
            Controls.Add(dataGridView);
            Controls.Add(nav_bar_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "JuryAccountingForm";
            Text = "JuryAccountingForm";
            Load += JuryAccountingForm_Load;
            nav_bar_panel.ResumeLayout(false);
            nav_bar_panel.PerformLayout();
            filter_panel.ResumeLayout(false);
            filter_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel nav_bar_panel;
        private Panel filter_panel;
        private Label label_filter;
        private TextBox textBox_filter;
        private ComboBox comboBox_filter;
        private Button btn_delete;
        private Button btn_add_film;
        private Label label_Count;
        private Panel panel_green;
        private Label Title_of_current_page;
        private DataGridView dataGridView;
        private Button btn_voting;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn VoteColumn;
    }
}