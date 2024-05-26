using System.Runtime.InteropServices;

namespace FIlm_festival_UI
{
    public partial class MainForm : Form
    {
        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,
        //    int nTopRect,
        //    int nRightRect,
        //    int nBottomRect,
        //    int nWidthEllipse,
        //    int nHeightEllipse
        //);

        private Color _activeColor = Color.FromArgb(/*188, 1, 25*/199, 129, 74);
        private Color _defaultColor = Color.FromArgb(188, 166, 147);


        public MainForm()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Load_fIlm_accounting(sender, e);
        }

        private void Load_fIlm_accounting(object sender, EventArgs e)
        {
            this.form_loader_panel.Controls.Clear();
            FIlm¿ccountingForm fIlm¿ccountingForm = new FIlm¿ccountingForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            fIlm¿ccountingForm.FormBorderStyle = FormBorderStyle.None;
            this.form_loader_panel.Controls.Add(fIlm¿ccountingForm);
            fIlm¿ccountingForm.Show();

            btn_participants_accounting_Leave(sender, e);
            btn_jury_accounting_Leave(sender, e);
            btn_guest_accounting_Leave(sender, e);

            ChangeBtnToActive(btn_fIlm_accounting);
        }

        private void ChangeBtnToActive(Button button)
        {
            nav_panel.Height = button.Height;
            nav_panel.Width = 3;
            nav_panel.Top = button.Top;
            nav_panel.Left = button.Left;
            button.BackColor = _activeColor;
        }

        private void btn_fIlm_accounting_Click(object sender, EventArgs e)
        {
            Load_fIlm_accounting(sender, e);
        }

        private void btn_participants_accounting_Click(object sender, EventArgs e)
        {
            this.form_loader_panel.Controls.Clear();
            GuestsAccountingForm participantsAccountingForm = new GuestsAccountingForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            participantsAccountingForm.FormBorderStyle = FormBorderStyle.None;
            this.form_loader_panel.Controls.Add(participantsAccountingForm);
            participantsAccountingForm.Show();

            btn_fIlm_accounting_Leave(sender, e);
            btn_jury_accounting_Leave(sender, e);
            btn_guest_accounting_Leave(sender, e);

            ChangeBtnToActive(btn_guests_accounting);
        }

        private void btn_jury_accounting_Click(object sender, EventArgs e)
        {
            this.form_loader_panel.Controls.Clear();
            JuryAccountingForm juryAccountingForm = new JuryAccountingForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            juryAccountingForm.FormBorderStyle = FormBorderStyle.None;
            this.form_loader_panel.Controls.Add(juryAccountingForm);
            juryAccountingForm.Show();

            btn_fIlm_accounting_Leave(sender, e);
            btn_participants_accounting_Leave(sender, e);
            btn_guest_accounting_Leave(sender, e);

            nav_panel.Height = btn_jury_accounting.Height;
            nav_panel.Width = 3;
            nav_panel.Top = btn_jury_accounting.Top;
            btn_jury_accounting.BackColor = _activeColor;
        }

        private void btn_guest_accounting_Click(object sender, EventArgs e)
        {
            this.form_loader_panel.Controls.Clear();
            ResultsForm guestAccountingForm = new ResultsForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            guestAccountingForm.FormBorderStyle = FormBorderStyle.None;
            this.form_loader_panel.Controls.Add(guestAccountingForm);
            guestAccountingForm.Show();

            btn_fIlm_accounting_Leave(sender, e);
            btn_jury_accounting_Leave(sender, e);
            btn_participants_accounting_Leave(sender, e);

            ChangeBtnToActive(btn_results);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //btn_fIlm_accounting_Leave(sender, e);

            //nav_panel.Height = btn_exit.Height;
            //nav_panel.Width = 3;
            //nav_panel.Top = btn_exit.Top;
            //btn_exit.BackColor = _activeColor;

            Application.Exit();
        }

        private void btn_fIlm_accounting_Leave(object sender, EventArgs e)
        {
            btn_fIlm_accounting.BackColor = _defaultColor;
        }

        private void btn_participants_accounting_Leave(object sender, EventArgs e)
        {
            btn_guests_accounting.BackColor = _defaultColor;
        }

        private void btn_jury_accounting_Leave(object sender, EventArgs e)
        {
            btn_jury_accounting.BackColor = _defaultColor;
        }

        private void btn_guest_accounting_Leave(object sender, EventArgs e)
        {
            btn_results.BackColor = _defaultColor;
        }

        private void btn_exit_Leave(object sender, EventArgs e)
        {
            //btn_exit.BackColor = _defaultColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void form_loader_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
