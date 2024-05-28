namespace FIlm_festival_UI
{
    partial class FIlmАccountingForm
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
            filter_panel = new Panel();
            label_filter = new Label();
            textBox_filter = new TextBox();
            comboBox_filter = new ComboBox();
            btn_delete = new Button();
            btn_add_film = new Button();
            label_CountOfFilms = new Label();
            panel_green = new Panel();
            Title_of_current_page = new Label();
            film_dataGridView = new DataGridView();
            NameOfFilm = new DataGridViewTextBoxColumn();
            NominationOfFilm = new DataGridViewTextBoxColumn();
            CostOfTicket = new DataGridViewTextBoxColumn();
            nav_bar_panel.SuspendLayout();
            filter_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)film_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // nav_bar_panel
            // 
            nav_bar_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nav_bar_panel.BackColor = Color.FromArgb(199, 129, 74);
            nav_bar_panel.Controls.Add(filter_panel);
            nav_bar_panel.Controls.Add(btn_delete);
            nav_bar_panel.Controls.Add(btn_add_film);
            nav_bar_panel.Controls.Add(label_CountOfFilms);
            nav_bar_panel.Controls.Add(panel_green);
            nav_bar_panel.Controls.Add(Title_of_current_page);
            nav_bar_panel.Dock = DockStyle.Top;
            nav_bar_panel.Location = new Point(0, 0);
            nav_bar_panel.Name = "nav_bar_panel";
            nav_bar_panel.Size = new Size(1014, 144);
            nav_bar_panel.TabIndex = 3;
            nav_bar_panel.Paint += nav_bar_panel_Paint;
            // 
            // filter_panel
            // 
            filter_panel.BackColor = Color.FromArgb(188, 166, 147);
            filter_panel.BorderStyle = BorderStyle.FixedSingle;
            filter_panel.Controls.Add(label_filter);
            filter_panel.Controls.Add(textBox_filter);
            filter_panel.Controls.Add(comboBox_filter);
            filter_panel.Location = new Point(3, 98);
            filter_panel.Name = "filter_panel";
            filter_panel.Size = new Size(637, 43);
            filter_panel.TabIndex = 6;
            // 
            // label_filter
            // 
            label_filter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_filter.AutoSize = true;
            label_filter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_filter.ForeColor = Color.FromArgb(11, 16, 12);
            label_filter.Location = new Point(1, 8);
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
            comboBox_filter.Items.AddRange(new object[] { "названию фильма", "номинации фильма", "цене билета", "оценке фильма" });
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
            btn_delete.Location = new Point(223, 50);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(186, 42);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Удалить фильм";
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
            btn_add_film.Location = new Point(3, 50);
            btn_add_film.Name = "btn_add_film";
            btn_add_film.Size = new Size(186, 42);
            btn_add_film.TabIndex = 4;
            btn_add_film.Text = "Добавить фильм";
            btn_add_film.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_add_film.UseVisualStyleBackColor = false;
            btn_add_film.Click += btn_add_film_Click;
            // 
            // label_CountOfFilms
            // 
            label_CountOfFilms.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_CountOfFilms.AutoSize = true;
            label_CountOfFilms.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_CountOfFilms.ForeColor = Color.FromArgb(11, 16, 12);
            label_CountOfFilms.Location = new Point(773, 47);
            label_CountOfFilms.Name = "label_CountOfFilms";
            label_CountOfFilms.Size = new Size(229, 25);
            label_CountOfFilms.TabIndex = 3;
            label_CountOfFilms.Text = "Количество фильмов: ";
            // 
            // panel_green
            // 
            panel_green.BackColor = Color.FromArgb(29, 78, 23);
            panel_green.Dock = DockStyle.Top;
            panel_green.Location = new Point(0, 39);
            panel_green.Name = "panel_green";
            panel_green.Size = new Size(1014, 5);
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
            Title_of_current_page.Size = new Size(264, 39);
            Title_of_current_page.TabIndex = 1;
            Title_of_current_page.Text = "Учёт фильмов";
            // 
            // film_dataGridView
            // 
            film_dataGridView.AllowUserToAddRows = false;
            film_dataGridView.AllowUserToDeleteRows = false;
            film_dataGridView.AllowUserToResizeColumns = false;
            film_dataGridView.AllowUserToResizeRows = false;
            film_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            film_dataGridView.BackgroundColor = Color.FromArgb(11, 16, 12);
            film_dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(188, 166, 147);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(188, 1, 25);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            film_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            film_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            film_dataGridView.Columns.AddRange(new DataGridViewColumn[] { NameOfFilm, NominationOfFilm, CostOfTicket });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 16, 12);
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(188, 1, 25);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            film_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            film_dataGridView.Dock = DockStyle.Top;
            film_dataGridView.GridColor = Color.FromArgb(29, 78, 23);
            film_dataGridView.Location = new Point(0, 144);
            film_dataGridView.MultiSelect = false;
            film_dataGridView.Name = "film_dataGridView";
            film_dataGridView.ReadOnly = true;
            film_dataGridView.RowHeadersVisible = false;
            film_dataGridView.RowHeadersWidth = 51;
            film_dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            film_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            film_dataGridView.Size = new Size(1014, 654);
            film_dataGridView.TabIndex = 4;
            film_dataGridView.CellContentClick += film_dataGridView_CellContentClick;
            film_dataGridView.CellMouseDoubleClick += film_dataGridView_CellMouseDoubleClick;
            // 
            // NameOfFilm
            // 
            NameOfFilm.HeaderText = "Название фильма";
            NameOfFilm.MinimumWidth = 6;
            NameOfFilm.Name = "NameOfFilm";
            NameOfFilm.ReadOnly = true;
            // 
            // NominationOfFilm
            // 
            NominationOfFilm.HeaderText = "Номинация фильма";
            NominationOfFilm.MinimumWidth = 6;
            NominationOfFilm.Name = "NominationOfFilm";
            NominationOfFilm.ReadOnly = true;
            // 
            // CostOfTicket
            // 
            CostOfTicket.HeaderText = "Цена билета";
            CostOfTicket.MinimumWidth = 6;
            CostOfTicket.Name = "CostOfTicket";
            CostOfTicket.ReadOnly = true;
            // 
            // FIlmАccountingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 16, 12);
            ClientSize = new Size(1014, 800);
            Controls.Add(film_dataGridView);
            Controls.Add(nav_bar_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FIlmАccountingForm";
            Text = "FIlmАccountingForm";
            Load += FIlmАccountingForm_Load;
            nav_bar_panel.ResumeLayout(false);
            nav_bar_panel.PerformLayout();
            filter_panel.ResumeLayout(false);
            filter_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)film_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel nav_bar_panel;
        private Label Title_of_current_page;
        private Panel panel_green;
        private DataGridView film_dataGridView;
        private Label label_CountOfFilms;
        private Button btn_add_film;
        private Button btn_delete;
        private Panel filter_panel;
        private ComboBox comboBox_filter;
        private TextBox textBox_filter;
        private Label label_filter;
        private DataGridViewTextBoxColumn NameOfFilm;
        private DataGridViewTextBoxColumn NominationOfFilm;
        private DataGridViewTextBoxColumn CostOfTicket;
    }
}