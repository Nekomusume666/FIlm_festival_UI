namespace FIlm_festival_UI
{
    partial class ChangeJuryForm
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
            textBox_surname = new TextBox();
            button_cancel = new Button();
            btn_add = new Button();
            label_cost = new Label();
            label_nomination = new Label();
            textBox_name = new TextBox();
            label_name = new Label();
            Title_of_current_page = new Label();
            comboBox_post = new ComboBox();
            errorProvider_name = new ErrorProvider(components);
            errorProvider_surname = new ErrorProvider(components);
            errorProvider_post = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider_name).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_surname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_post).BeginInit();
            SuspendLayout();
            // 
            // textBox_surname
            // 
            textBox_surname.BackColor = Color.FromArgb(188, 166, 147);
            textBox_surname.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_surname.SetIconPadding(textBox_surname, 10);
            textBox_surname.Location = new Point(322, 115);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(328, 34);
            textBox_surname.TabIndex = 46;
            textBox_surname.Validating += textBox_surname_Validating;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.FromArgb(188, 1, 25);
            button_cancel.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cancel.ForeColor = Color.White;
            button_cancel.Location = new Point(451, 356);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(199, 42);
            button_cancel.TabIndex = 45;
            button_cancel.Text = "Отмена";
            button_cancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            button_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(29, 78, 23);
            btn_add.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(137, 356);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(199, 42);
            btn_add.TabIndex = 44;
            btn_add.Text = "Изменить";
            btn_add.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label_cost
            // 
            label_cost.AutoSize = true;
            label_cost.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_cost.ForeColor = Color.FromArgb(11, 16, 12);
            label_cost.Location = new Point(137, 184);
            label_cost.Name = "label_cost";
            label_cost.Size = new Size(123, 25);
            label_cost.TabIndex = 41;
            label_cost.Text = "Должность";
            // 
            // label_nomination
            // 
            label_nomination.AutoSize = true;
            label_nomination.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_nomination.ForeColor = Color.FromArgb(11, 16, 12);
            label_nomination.Location = new Point(137, 121);
            label_nomination.Name = "label_nomination";
            label_nomination.Size = new Size(103, 25);
            label_nomination.TabIndex = 40;
            label_nomination.Text = "Фамилия";
            // 
            // textBox_name
            // 
            textBox_name.BackColor = Color.FromArgb(188, 166, 147);
            textBox_name.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_name.SetIconPadding(textBox_name, 10);
            textBox_name.Location = new Point(322, 62);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(328, 34);
            textBox_name.TabIndex = 39;
            textBox_name.Validating += textBox_name_Validating;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_name.ForeColor = Color.FromArgb(11, 16, 12);
            label_name.Location = new Point(137, 68);
            label_name.Name = "label_name";
            label_name.Size = new Size(54, 25);
            label_name.TabIndex = 38;
            label_name.Text = "Имя";
            // 
            // Title_of_current_page
            // 
            Title_of_current_page.AutoSize = true;
            Title_of_current_page.Dock = DockStyle.Top;
            Title_of_current_page.Font = new Font("Microsoft Sans Serif", 21F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Title_of_current_page.ForeColor = Color.FromArgb(11, 16, 12);
            Title_of_current_page.Location = new Point(0, 0);
            Title_of_current_page.Name = "Title_of_current_page";
            Title_of_current_page.Size = new Size(384, 39);
            Title_of_current_page.TabIndex = 37;
            Title_of_current_page.Text = "Измение члена жюри";
            // 
            // comboBox_post
            // 
            comboBox_post.BackColor = Color.FromArgb(188, 166, 147);
            comboBox_post.FlatStyle = FlatStyle.Popup;
            comboBox_post.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_post.FormattingEnabled = true;
            errorProvider_post.SetIconPadding(comboBox_post, 10);
            comboBox_post.Items.AddRange(new object[] { "Актёр", "Продюсер", "Режисёр" });
            comboBox_post.Location = new Point(322, 178);
            comboBox_post.Name = "comboBox_post";
            comboBox_post.Size = new Size(328, 36);
            comboBox_post.TabIndex = 47;
            comboBox_post.Validating += comboBox_post_Validating;
            // 
            // errorProvider_name
            // 
            errorProvider_name.ContainerControl = this;
            // 
            // errorProvider_surname
            // 
            errorProvider_surname.ContainerControl = this;
            // 
            // errorProvider_post
            // 
            errorProvider_post.ContainerControl = this;
            // 
            // ChangeJuryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(199, 129, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_post);
            Controls.Add(textBox_surname);
            Controls.Add(button_cancel);
            Controls.Add(btn_add);
            Controls.Add(label_cost);
            Controls.Add(label_nomination);
            Controls.Add(textBox_name);
            Controls.Add(label_name);
            Controls.Add(Title_of_current_page);
            Font = new Font("Nirmala UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangeJuryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeJuryFilm";
            Load += ChangeJuryFilm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider_name).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_surname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_post).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox_surname;
        private Button button_cancel;
        private Button btn_add;
        private Label label_cost;
        private Label label_nomination;
        private TextBox textBox_name;
        private Label label_name;
        private Label Title_of_current_page;
        private ComboBox comboBox_post;
        private ErrorProvider errorProvider_name;
        private ErrorProvider errorProvider_surname;
        private ErrorProvider errorProvider_post;
    }
}