namespace FIlm_festival_UI.GuestForms
{
    partial class VotingGuestForm
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
            button_cancel = new Button();
            btn_add = new Button();
            Title_of_current_page = new Label();
            dataGridView = new DataGridView();
            NameColunm = new DataGridViewTextBoxColumn();
            VoteColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.FromArgb(188, 1, 25);
            button_cancel.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cancel.ForeColor = Color.White;
            button_cancel.Location = new Point(589, 546);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(199, 42);
            button_cancel.TabIndex = 24;
            button_cancel.Text = "Отмена";
            button_cancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(29, 78, 23);
            btn_add.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(12, 546);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(199, 42);
            btn_add.TabIndex = 25;
            btn_add.Text = "Сохранить";
            btn_add.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // Title_of_current_page
            // 
            Title_of_current_page.AutoSize = true;
            Title_of_current_page.Dock = DockStyle.Top;
            Title_of_current_page.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Title_of_current_page.ForeColor = Color.FromArgb(11, 16, 12);
            Title_of_current_page.Location = new Point(0, 0);
            Title_of_current_page.Name = "Title_of_current_page";
            Title_of_current_page.Size = new Size(399, 39);
            Title_of_current_page.TabIndex = 26;
            Title_of_current_page.Text = "Выставление голосов ";
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColunm, VoteColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 16, 12);
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(188, 1, 25);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.GridColor = Color.FromArgb(29, 78, 23);
            dataGridView.Location = new Point(11, 42);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(777, 487);
            dataGridView.TabIndex = 27;
            // 
            // NameColunm
            // 
            NameColunm.HeaderText = "Название фильма";
            NameColunm.MinimumWidth = 6;
            NameColunm.Name = "NameColunm";
            NameColunm.ReadOnly = true;
            NameColunm.Resizable = DataGridViewTriState.False;
            // 
            // VoteColumn
            // 
            VoteColumn.FillWeight = 20F;
            VoteColumn.HeaderText = "Баллы";
            VoteColumn.MinimumWidth = 6;
            VoteColumn.Name = "VoteColumn";
            VoteColumn.Resizable = DataGridViewTriState.False;
            // 
            // VotingGuestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(199, 129, 74);
            ClientSize = new Size(800, 600);
            Controls.Add(dataGridView);
            Controls.Add(Title_of_current_page);
            Controls.Add(btn_add);
            Controls.Add(button_cancel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VotingGuestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VotingGuestForm";
            Load += VotingGuestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancel;
        private Button btn_add;
        private Label Title_of_current_page;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn NameColunm;
        private DataGridViewTextBoxColumn VoteColumn;
    }
}