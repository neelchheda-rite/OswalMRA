

using OswalMRA.MessageBox;

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

        private void button2_Click(object sender, EventArgs e)
        {
            {
                // Retrieve the clear confirmation message from the resource file
                string clearConfirmationMessage = Properties.Resources.ResourceManager.GetString("ClearMessageConfirmation");

                // Show confirmation dialog for Clear using optionMsgBox
                optionMsgBox confirmationBox = new optionMsgBox("Clear Confirmation", "clearConfirmationMessage");
                if (confirmationBox.ShowDialog() == DialogResult.Yes)
                {
                    // Perform the clear action
                    // Your code to clear data goes here
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
