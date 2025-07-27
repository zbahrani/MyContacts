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
            dgcontacts.AutoGenerateColumns = false;
            dgcontacts.DataSource = repository.SelectAll();
        }
    }
}
