using MyContacts.Repository;
using MyContacts.Services;
using System;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class frmAddOrEdit : Form
    {
        IContactsRepository repository;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Person";

        }
        bool ValidateInputs()
        {


            if (textName.Text == "")
            {

                MessageBox.Show("Please Enter Name", "Warinig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textEmail.Text == "")
            {
                MessageBox.Show("Please Enter Email", "Warinig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textFamily.Text == "")
            {
                MessageBox.Show("Please Enter Family", "Warinig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numAge.Value == 0)
            {
                MessageBox.Show("Please Enter Age", "Warinig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textMobile.Text == "")
            {
                MessageBox.Show("Please Enter Mobile", "Warinig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool isSuccess = repository.Insert(textName.Text, textFamily.Text, textMobile.Text, textEmail.Text, (int)numAge.Value, textAddress.Text);

                if (isSuccess == true)
                {
                    MessageBox.Show("Contact successfully registered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("An error has occurred.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
