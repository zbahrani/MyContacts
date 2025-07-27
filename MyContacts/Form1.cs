using MyContacts.Repository;
using MyContacts.Services;
using System;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class Form1 : Form
    {
        IContactsRepository repository;
        public Form1()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgcontacts.AutoGenerateColumns = false;
            dgcontacts.Columns[0].Visible = false;
            dgcontacts.DataSource = repository.SelectAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnNewContact_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frm = new frmAddOrEdit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgcontacts.CurrentRow != null)
            {
                string name = dgcontacts.CurrentRow.Cells[1].Value.ToString();
                string family = dgcontacts.CurrentRow.Cells[2].Value.ToString();
                string fullName = name + " " + family;
                if (MessageBox.Show($"Are you sure you want to {fullName} delete?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ContactID = int.Parse(dgcontacts.CurrentRow.Cells[0].Value.ToString());
                    repository.Delete(ContactID);
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a person from the list.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgcontacts.CurrentRow != null)
            {
                int contactId = int.Parse(dgcontacts.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdit frm = new frmAddOrEdit();
                frm.ContactID = contactId;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void Search_Enter(object sender, EventArgs e)
        {
            
        }

        private void textSerch_TextChanged(object sender, EventArgs e)
        {
            dgcontacts.DataSource = repository.Search(textSearch.Text);

        }
    }
}
