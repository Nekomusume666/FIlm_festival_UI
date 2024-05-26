namespace FIlm_festival_UI
{
    partial class ChangeGuestForm
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
            textBox_email = new TextBox();
            textBox_surname = new TextBox();
            button_cancel = new Button();
            btn_add = new Button();
            label_number = new Label();
            numericUpDown_number = new NumericUpDown();
            label_email = new Label();
            label_nomination = new Label();
            textBox_name = new TextBox();
            label_name = new Label();
            Title_of_current_page = new Label();
            errorProvider_name = new ErrorProvider(components);
            errorProvider_surname = new ErrorProvider(components);
            errorProvider_email = new ErrorProvider(components);
            errorProvider_number = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_number).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_name).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_surname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_email).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_number).BeginInit();
            SuspendLayout();
            // 
            // textBox_email
            // 
            textBox_email.BackColor = Color.FromArgb(188, 166, 147);
            textBox_email.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_email.SetIconPadding(textBox_email, 10);
            textBox_email.Location = new Point(325, 176);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(328, 34);
            textBox_email.TabIndex = 36;
            textBox_email.Validating += textBox_city_Validating;
            // 
            // textBox_surname
            // 
            textBox_surname.BackColor = Color.FromArgb(188, 166, 147);
            textBox_surname.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_surname.SetIconPadding(textBox_surname, 10);
            textBox_surname.Location = new Point(325, 113);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(328, 34);
            textBox_surname.TabIndex = 35;
            textBox_surname.Validating += textBox_surname_Validating;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.FromArgb(188, 1, 25);
            button_cancel.FlatAppearance.BorderColor = Color.FromArgb(11, 16, 12);
            button_cancel.FlatStyle = FlatStyle.Flat;
            button_cancel.Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_cancel.ForeColor = Color.White;
            button_cancel.Location = new Point(454, 354);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(199, 42);
            button_cancel.TabIndex = 34;
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
            btn_add.Location = new Point(140, 354);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(199, 42);
            btn_add.TabIndex = 33;
            btn_add.Text = "Изменить";
            btn_add.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label_number
            // 
            label_number.AutoSize = true;
            label_number.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_number.ForeColor = Color.FromArgb(11, 16, 12);
            label_number.Location = new Point(140, 238);
            label_number.Name = "label_number";
            label_number.Size = new Size(140, 25);
            label_number.TabIndex = 32;
            label_number.Text = "Номер места";
            // 
            // numericUpDown_number
            // 
            numericUpDown_number.BackColor = Color.FromArgb(188, 166, 147);
            numericUpDown_number.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_number.SetIconPadding(numericUpDown_number, 10);
            numericUpDown_number.Location = new Point(325, 233);
            numericUpDown_number.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown_number.Name = "numericUpDown_number";
            numericUpDown_number.Size = new Size(328, 34);
            numericUpDown_number.TabIndex = 31;
            numericUpDown_number.Value = new decimal(new int[] { 18, 0, 0, 0 });
            numericUpDown_number.Validating += numericUpDown_age_Validating;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_email.ForeColor = Color.FromArgb(11, 16, 12);
            label_email.Location = new Point(140, 182);
            label_email.Name = "label_email";
            label_email.Size = new Size(60, 25);
            label_email.TabIndex = 30;
            label_email.Text = "Email";
            // 
            // label_nomination
            // 
            label_nomination.AutoSize = true;
            label_nomination.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_nomination.ForeColor = Color.FromArgb(11, 16, 12);
            label_nomination.Location = new Point(140, 119);
            label_nomination.Name = "label_nomination";
            label_nomination.Size = new Size(103, 25);
            label_nomination.TabIndex = 29;
            label_nomination.Text = "Фамилия";
            // 
            // textBox_name
            // 
            textBox_name.BackColor = Color.FromArgb(188, 166, 147);
            textBox_name.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorProvider_name.SetIconPadding(textBox_name, 10);
            textBox_name.Location = new Point(325, 60);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(328, 34);
            textBox_name.TabIndex = 28;
            textBox_name.Validating += textBox_name_Validating;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_name.ForeColor = Color.FromArgb(11, 16, 12);
            label_name.Location = new Point(140, 66);
            label_name.Name = "label_name";
            label_name.Size = new Size(54, 25);
            label_name.TabIndex = 27;
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
            Title_of_current_page.Size = new Size(269, 39);
            Title_of_current_page.TabIndex = 26;
            Title_of_current_page.Text = "Измение гостя";
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
            // ChangeGuestForm
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
            Controls.Add(numericUpDown_number);
            Controls.Add(label_email);
            Controls.Add(label_nomination);
            Controls.Add(textBox_name);
            Controls.Add(label_name);
            Controls.Add(Title_of_current_page);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangeGuestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeParticipantForm";
            Load += ChangeParticipantForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_number).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_name).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_surname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_email).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider_number).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_email;
        private TextBox textBox_surname;
        private Button button_cancel;
        private Button btn_add;
        private Label label_number;
        private NumericUpDown numericUpDown_number;
        private Label label_email;
        private Label label_nomination;
        private TextBox textBox_name;
        private Label label_name;
        private Label Title_of_current_page;
        private ErrorProvider errorProvider_email;
        private ErrorProvider errorProvider_surname;
        private ErrorProvider errorProvider_number;
        private ErrorProvider errorProvider_name;
    }
}