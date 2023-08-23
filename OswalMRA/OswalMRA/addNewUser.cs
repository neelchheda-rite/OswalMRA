

namespace OswalMRA
{
    public partial class addNewUser : Form
    {
        public addNewUser()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Worker");
            comboBox1.Items.Add("Supervisor");
            comboBox1.Items.Add("Admin");
        }
    }
}
