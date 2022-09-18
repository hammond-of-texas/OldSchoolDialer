using System.Media;
using OldSchoolDialer.Properties;

namespace OldSchoolDialer
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            Hide();
           //connectBtn.Enabled = false;
            var form = new dialingFrm();
            //form.Visible = true;
            form.Show();
            
           // form.BringToFront();

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
           Connector.DisconnectInternet();

        }

        
    }
}