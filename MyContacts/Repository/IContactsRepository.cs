using System.Data;

namespace MyContacts.Repository
{
    interface IContactsRepository
    {
        DataTable SelectAll();
        DataTable SelcetRow(int contactId);
        DataTable Search(string parameter);
        bool Insert(string name, string family, string mobile, string email, int age, string address);
        bool Update(int contactId, string name, string family, string mobile, string email, int age, string address);
        bool Delete(int contactId);
    }
}
