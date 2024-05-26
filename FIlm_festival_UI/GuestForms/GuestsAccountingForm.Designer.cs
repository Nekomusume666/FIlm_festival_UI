namespace FIlm_festival_UI
{
    partial class GuestsAccountingForm
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
            Title_of_current_page = new Label();
            panel_green = new Panel();
            nav_bar_panel = new Panel();
            btn_voting = new Button();
            filter_panel = new Panel();
            label_filter = new Label();
            textBox_filter = new TextBox();
            comboBox_filter = new ComboBox();
            btn_delete = new Button();
            btn_add = new Button();
            label_Count = new Label();
            dataGridView = new DataGridView();
            NameColunm = new DataGridViewTextBoxColumn();
            SurnameColumn = new DataGridViewTextBoxColumn();
            EmailColumn = new DataGridViewTextBoxColumn();
            NubmerColumn = new DataGridViewTextBoxColumn();
            VoteColumn = new DataGridViewTextBoxColumn();
            nav_bar_panel.SuspendLayout();
            filter_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Title_of_current_page
            // 
            Title_of_current_page.AutoSize = true;
            Title_of_current_page.Dock = DockStyle.Top;
            Title_of_current_page.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Title_of_current_page.ForeColor = Color.FromArgb(11, 16, 12);
            Title_of_current_page.Location = new Point(0, 0);
            Title_of_current_page.Name = "Title_of_current_page";
            Title_of_current_page.Size = new Size(218, 39);
            Title_of_current_page.TabIndex = 1;
            Title_of_current_page.Text = "Учёт гостей";
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
            // nav_bar_panel
            // 
            nav_bar_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nav_bar_panel.BackColor = Color.FromArgb(199, 129, 74);
            nav_bar_panel.Controls.Add(btn_voting);
            nav_bar_panel.Controls.Add(filter_panel);
            nav_bar_panel.Controls.Add(btn_delete);
            nav_bar_panel.Controls.Add(btn_add);
            nav_bar_panel.Controls.Add(label_Count);
            nav_bar_panel.Controls.Add(panel_green);
            nav_bar_panel.Controls.Add(Title_of_current_page);
            nav_bar_panel.Dock = DockStyle.Top;
            nav_bar_panel.Location = new Point(0, 0);
            nav_bar_panel.Name = "nav_bar_panel";
            nav_bar_panel.Size = new Size(1014, 144);
            nav_bar_panel.TabIndex = 5;
            nav_bar_panel.Paint += nav_bar_panel_Paint;
            // 
            // btn_voting
            // 
            btn_voting.BackColor = Color.FromArgb(0, 0, 192);
            btn_voting.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_voting.FlatStyle = FlatStyle.Flat;
            btn_voting.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_voting.ForeColor = Color.White;
            btn_voting.Location = new Point(525, 47);
            btn_voting.Name = "btn_voting";
            btn_voting.Size = new Size(238, 42);
            btn_voting.TabIndex = 11;
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
            filter_panel.Location = new Point(4, 95);
            filter_panel.Name = "filter_panel";
            filter_panel.Size = new Size(637, 43);
            filter_panel.TabIndex = 10;
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
            comboBox_filter.Items.AddRange(new object[] { "имени", "фамилии", "электронной почте", "номеру места", "отметке о голосовании" });
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
            btn_delete.Location = new Point(265, 47);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(238, 42);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Удалить гостя";
            btn_delete.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(29, 78, 23);
            btn_add.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(4, 47);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(238, 42);
            btn_add.TabIndex = 8;
            btn_add.Text = "Добавить гостя";
            btn_add.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label_Count
            // 
            label_Count.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_Count.AutoSize = true;
            label_Count.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_Count.ForeColor = Color.FromArgb(11, 16, 12);
            label_Count.Location = new Point(800, 47);
            label_Count.Name = "label_Count";
            label_Count.Size = new Size(202, 25);
            label_Count.TabIndex = 7;
            label_Count.Text = "Количество гостей: ";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColunm, SurnameColumn, EmailColumn, NubmerColumn, VoteColumn });
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
            dataGridView.Size = new Size(1014, 654);
            dataGridView.TabIndex = 6;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.CellMouseDoubleClick += participants_dataGridView_CellMouseDoubleClick;
            // 
            // NameColunm
            // 
            NameColunm.HeaderText = "Имя";
            NameColunm.MinimumWidth = 6;
            NameColunm.Name = "NameColunm";
            NameColunm.ReadOnly = true;
            // 
            // SurnameColumn
            // 
            SurnameColumn.HeaderText = "Фамилия";
            SurnameColumn.MinimumWidth = 6;
            SurnameColumn.Name = "SurnameColumn";
            SurnameColumn.ReadOnly = true;
            // 
            // EmailColumn
            // 
            EmailColumn.HeaderText = "Email";
            EmailColumn.MinimumWidth = 6;
            EmailColumn.Name = "EmailColumn";
            EmailColumn.ReadOnly = true;
            // 
            // NubmerColumn
            // 
            NubmerColumn.HeaderText = "Номер места";
            NubmerColumn.MinimumWidth = 6;
            NubmerColumn.Name = "NubmerColumn";
            NubmerColumn.ReadOnly = true;
            // 
            // VoteColumn
            // 
            VoteColumn.HeaderText = "Проголосовал?";
            VoteColumn.MinimumWidth = 6;
            VoteColumn.Name = "VoteColumn";
            VoteColumn.ReadOnly = true;
            // 
            // GuestsAccountingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 16, 12);
            ClientSize = new Size(1014, 800);
            Controls.Add(dataGridView);
            Controls.Add(nav_bar_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GuestsAccountingForm";
            Text = "ParticipantsAccountingForm";
            Load += ParticipantsAccountingForm_Load;
            nav_bar_panel.ResumeLayout(false);
            nav_bar_panel.PerformLayout();
            filter_panel.ResumeLayout(false);
            filter_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Title_of_current_page;
        private Panel panel_green;
        private Panel nav_bar_panel;
        private Panel filter_panel;
        private Label label_filter;
        private TextBox textBox_filter;
        private ComboBox comboBox_filter;
        private Button btn_delete;
        private Button btn_add;
        private Label label_Count;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn NameColunm;
        private DataGridViewTextBoxColumn SurnameColumn;
        private DataGridViewTextBoxColumn EmailColumn;
        private DataGridViewTextBoxColumn NubmerColumn;
        private DataGridViewTextBoxColumn VoteColumn;
        private Button btn_voting;
    }
}