namespace FIlm_festival_UI
{
    partial class AddFilmForm
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
            components = new System.ComponentModel.Container();
            Title_of_current_page = new Label();
            label_name = new Label();
            textBox_name = new TextBox();
            label_nomination = new Label();
            label_cost = new Label();
            numericUpDown_cost = new NumericUpDown();
            btn_add = new Button();
            button_cancel = new Button();
            comboBox_nomination = new ComboBox();
            errorProvider_name = new ErrorProvider(components);
            errorProvider_nomination = new ErrorProvider(components);
            errorProvider_cost = new ErrorProvider(components);
            errorProvider_rating = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_name).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_nomination).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_rating).BeginInit();
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
            Title_of_current_page.Size = new Size(375, 39);
            Title_of_current_page.TabIndex = 2;
            Title_of_current_page.Text = "Добавление фильма";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_name.ForeColor = Color.FromArgb(11, 16, 12);
            label_name.Location = new Point(137, 119);
            label_name.Name = "label_name";
            label_name.Size = new Size(99, 25);
            label_name.TabIndex = 3;
            label_name.Text = "Название";
            // 
            // textBox_name
            // 
            textBox_name.BackColor = Color.FromArgb(188, 166, 147);
            textBox_name.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_name.SetIconPadding(textBox_name, 10);
            textBox_name.Location = new Point(322, 113);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(328, 34);
            textBox_name.TabIndex = 4;
            textBox_name.Validating += textBox_name_Validating;
            // 
            // label_nomination
            // 
            label_nomination.AutoSize = true;
            label_nomination.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_nomination.ForeColor = Color.FromArgb(11, 16, 12);
            label_nomination.Location = new Point(137, 172);
            label_nomination.Name = "label_nomination";
            label_nomination.Size = new Size(119, 25);
            label_nomination.TabIndex = 5;
            label_nomination.Text = "Номинация";
            label_nomination.Click += label1_Click;
            // 
            // label_cost
            // 
            label_cost.AutoSize = true;
            label_cost.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_cost.ForeColor = Color.FromArgb(11, 16, 12);
            label_cost.Location = new Point(137, 235);
            label_cost.Name = "label_cost";
            label_cost.Size = new Size(130, 25);
            label_cost.TabIndex = 7;
            label_cost.Text = "Цена билета";
            // 
            // numericUpDown_cost
            // 
            numericUpDown_cost.BackColor = Color.FromArgb(188, 166, 147);
            numericUpDown_cost.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_cost.SetIconPadding(numericUpDown_cost, 10);
            numericUpDown_cost.Location = new Point(322, 230);
            numericUpDown_cost.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_cost.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown_cost.Name = "numericUpDown_cost";
            numericUpDown_cost.Size = new Size(328, 34);
            numericUpDown_cost.TabIndex = 8;
            numericUpDown_cost.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown_cost.Validating += numericUpDown_cost_Validating;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(29, 78, 23);
            btn_add.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(137, 348);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(199, 42);
            btn_add.TabIndex = 11;
            btn_add.Text = "Добавить фильм";
            btn_add.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.FromArgb(188, 1, 25);
            button_cancel.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cancel.ForeColor = Color.White;
            button_cancel.Location = new Point(451, 348);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(199, 42);
            button_cancel.TabIndex = 12;
            button_cancel.Text = "Отмена";
            button_cancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click;
            // 
            // comboBox_nomination
            // 
            comboBox_nomination.BackColor = Color.FromArgb(188, 166, 147);
            comboBox_nomination.FlatStyle = FlatStyle.Popup;
            comboBox_nomination.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_nomination.FormattingEnabled = true;
            errorProvider_nomination.SetIconPadding(comboBox_nomination, 10);
            comboBox_nomination.Items.AddRange(new object[] { "Самый романтичный", "Самый смешной", "Лучший боевик", "Самый страшный" });
            comboBox_nomination.Location = new Point(322, 166);
            comboBox_nomination.Name = "comboBox_nomination";
            comboBox_nomination.Size = new Size(328, 36);
            comboBox_nomination.TabIndex = 13;
            comboBox_nomination.Validating += comboBox_nomination_Validating;
            // 
            // errorProvider_name
            // 
            errorProvider_name.ContainerControl = this;
            // 
            // errorProvider_nomination
            // 
            errorProvider_nomination.ContainerControl = this;
            // 
            // errorProvider_cost
            // 
            errorProvider_cost.ContainerControl = this;
            // 
            // errorProvider_rating
            // 
            errorProvider_rating.ContainerControl = this;
            // 
            // AddFilmForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(199, 129, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_nomination);
            Controls.Add(button_cancel);
            Controls.Add(btn_add);
            Controls.Add(numericUpDown_cost);
            Controls.Add(label_cost);
            Controls.Add(label_nomination);
            Controls.Add(textBox_name);
            Controls.Add(label_name);
            Controls.Add(Title_of_current_page);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddFilmForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddFilmForm";
            TopMost = true;
            Load += AddFilmForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_name).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_nomination).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_rating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title_of_current_page;
        private Label label_name;
        private TextBox textBox_name;
        private Label label_nomination;
        private Label label_cost;
        private NumericUpDown numericUpDown_cost;
        private Button btn_add;
        private Button button_cancel;
        private ComboBox comboBox_nomination;
        private ErrorProvider errorProvider_name;
        private ErrorProvider errorProvider_nomination;
        private ErrorProvider errorProvider_cost;
        private ErrorProvider errorProvider_rating;
    }
}