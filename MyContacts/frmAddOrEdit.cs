using MyContacts.Repository;
using MyContacts.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class frmAddOrEdit : Form
    {
        IContactsRepository repository;
        public int ContactID = 0;
        public frmAddOrEdit()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (ContactID == 0)
            {
                this.Text = "Add New person";
            }
            else
            {
                this.Text = "Edit Person";
                DataTable dt = repository.SelcetRow(ContactID);
                textName.Text = dt.Rows[0][1].ToString();
                textFamily.Text = dt.Rows[0][2].ToString();
                textMobile.Text = dt.Rows[0][3].ToString();
                textEmail.Text = dt.Rows[0][4].ToString();
                numAge.Text = dt.Rows[0][5].ToString();
                textAddress.Text = dt.Rows[0][6].ToString();
                btnSubmit.Text = "Edit";
            }

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
                bool isSuccess;
                if (ContactID == 0)
                {
                    isSuccess = repository.Insert(textName.Text, textFamily.Text, textMobile.Text, textEmail.Text, (int)numAge.Value, textAddress.Text);
                }
                else
                {
                    isSuccess = repository.Update(ContactID, textName.Text, textFamily.Text, textMobile.Text, textEmail.Text, (int)numAge.Value, textAddress.Text);
                }

                if (isSuccess == true)
                {
                    MessageBox.Show("The operation was successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Operation failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
