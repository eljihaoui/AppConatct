using System.Collections.Generic;
using System.Linq;

namespace AppConatct.WinForms.Models
{
    public static class DBContact
    {
        public static List<Contact> lstContacts;

        // Ajouter un contact à la liste des contacts
        public static int AddContact(Contact c)
        {
            if (lstContacts == null)
            {
                lstContacts = new List<Contact>();
            }
            c.Id = lstContacts.Any() ? lstContacts.Max(x => x.Id) + 1 : 100; // lambda Expressions
            lstContacts.Add(c);
            return c.Id;
        }
        // Récuperer  la liste des contacts
        public static  List<Contact> GetLsitContacts()
        {
            return lstContacts;
        }

        // supprimer un contact 
        public static void DeleteContact(int idContact)
        {
            int index = lstContacts.FindIndex(x => x.Id == idContact);
            lstContacts.RemoveAt(index);
        }

        //Modifier un contact
        public static void UpdateContact(Contact c)
        {
            Contact rech = lstContacts.FirstOrDefault(x => x.Id == c.Id);
            rech.NomComplet = c.NomComplet;
            rech.DateNaiss = c.DateNaiss;
            rech.Email = c.Email;
            rech.Genre = c.Genre;
            rech.Tel = c.Tel;
            rech.Photo = c.Photo;
        }
        //Chercher Par nom
        public static List<Contact> SearchConatct(string name)
        {
            List<Contact> res = lstContacts.Where(x => x.NomComplet.ToLower().Contains(name.ToLower())).ToList();
            return res;
        }
    }
}
