namespace FIlm_festival_UI
{
    partial class AddGuestForm
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
            button_cancel = new Button();
            btn_add = new Button();
            label_number = new Label();
            numericUpDown_nubmer = new NumericUpDown();
            label_email = new Label();
            label_nomination = new Label();
            textBox_name = new TextBox();
            label_name = new Label();
            Title_of_current_page = new Label();
            textBox_surname = new TextBox();
            textBox_email = new TextBox();
            errorProvider_name = new ErrorProvider(components);
            errorProvider_surname = new ErrorProvider(components);
            errorProvider_email = new ErrorProvider(components);
            errorProvider_number = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nubmer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_name).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_surname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_email).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_number).BeginInit();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.FromArgb(188, 1, 25);
            button_cancel.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cancel.ForeColor = Color.White;
            button_cancel.Location = new Point(454, 350);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(199, 42);
            button_cancel.TabIndex = 23;
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
            btn_add.Location = new Point(140, 350);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(199, 42);
            btn_add.TabIndex = 22;
            btn_add.Text = "Добавить гостя";
            btn_add.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label_number
            // 
            label_number.AutoSize = true;
            label_number.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_number.ForeColor = Color.FromArgb(11, 16, 12);
            label_number.Location = new Point(140, 234);
            label_number.Name = "label_number";
            label_number.Size = new Size(140, 25);
            label_number.TabIndex = 20;
            label_number.Text = "Номер места";
            // 
            // numericUpDown_nubmer
            // 
            numericUpDown_nubmer.BackColor = Color.FromArgb(188, 166, 147);
            numericUpDown_nubmer.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_number.SetIconPadding(numericUpDown_nubmer, 10);
            numericUpDown_nubmer.Location = new Point(325, 229);
            numericUpDown_nubmer.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_nubmer.Name = "numericUpDown_nubmer";
            numericUpDown_nubmer.Size = new Size(328, 34);
            numericUpDown_nubmer.TabIndex = 19;
            numericUpDown_nubmer.Value = new decimal(new int[] { 18, 0, 0, 0 });
            numericUpDown_nubmer.Validating += numericUpDown_age_Validating;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_email.ForeColor = Color.FromArgb(11, 16, 12);
            label_email.Location = new Point(140, 178);
            label_email.Name = "label_email";
            label_email.Size = new Size(60, 25);
            label_email.TabIndex = 18;
            label_email.Text = "Email";
            // 
            // label_nomination
            // 
            label_nomination.AutoSize = true;
            label_nomination.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_nomination.ForeColor = Color.FromArgb(11, 16, 12);
            label_nomination.Location = new Point(140, 115);
            label_nomination.Name = "label_nomination";
            label_nomination.Size = new Size(103, 25);
            label_nomination.TabIndex = 17;
            label_nomination.Text = "Фамилия";
            // 
            // textBox_name
            // 
            textBox_name.BackColor = Color.FromArgb(188, 166, 147);
            textBox_name.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_name.SetIconPadding(textBox_name, 10);
            textBox_name.Location = new Point(325, 56);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(328, 34);
            textBox_name.TabIndex = 16;
            textBox_name.Validating += textBox_name_Validating;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_name.ForeColor = Color.FromArgb(11, 16, 12);
            label_name.Location = new Point(140, 62);
            label_name.Name = "label_name";
            label_name.Size = new Size(54, 25);
            label_name.TabIndex = 15;
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
            Title_of_current_page.Size = new Size(328, 39);
            Title_of_current_page.TabIndex = 14;
            Title_of_current_page.Text = "Добавление гостя";
            // 
            // textBox_surname
            // 
            textBox_surname.BackColor = Color.FromArgb(188, 166, 147);
            textBox_surname.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_surname.SetIconPadding(textBox_surname, 10);
            textBox_surname.Location = new Point(325, 109);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(328, 34);
            textBox_surname.TabIndex = 24;
            textBox_surname.Validating += textBox_surname_Validating;
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.FromArgb(188, 166, 147);
            textBox_email.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_email.SetIconPadding(textBox_email, 10);
            textBox_email.Location = new Point(325, 172);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(328, 34);
            textBox_email.TabIndex = 25;
            textBox_email.Validating += textBox_city_Validating;
            // 
            // errorProvider_name
            // 
            errorProvider_name.ContainerControl = this;
            // 
            // errorProvider_surname
            // 
            errorProvider_surname.ContainerControl = this;
            // 
            // errorProvider_email
            // 
            errorProvider_email.ContainerControl = this;
            // 
            // errorProvider_number
            // 
            errorProvider_number.ContainerControl = this;
            // 
            // AddGuestForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(199, 129, 74);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_email);
            Controls.Add(textBox_surname);
            Controls.Add(button_cancel);
            Controls.Add(btn_add);
            Controls.Add(label_number);
            Controls.Add(numericUpDown_nubmer);
            Controls.Add(label_email);
            Controls.Add(label_nomination);
            Controls.Add(textBox_name);
            Controls.Add(label_name);
            Controls.Add(Title_of_current_page);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddGuestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddParticipantForm";
            TopMost = true;
            Load += AddParticipantForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_nubmer).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_name).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_surname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_email).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_number).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox_nomination;
        private Button button_cancel;
        private Button btn_add;
        private Label label_number;
        private NumericUpDown numericUpDown_nubmer;
        private Label label_email;
        private Label label_nomination;
        private TextBox textBox_name;
        private Label label_name;
        private Label Title_of_current_page;
        private TextBox textBox_surname;
        private TextBox textBox_email;
        private ErrorProvider errorProvider_number;
        private ErrorProvider errorProvider_email;
        private ErrorProvider errorProvider_surname;
        private ErrorProvider errorProvider_name;
    }
}