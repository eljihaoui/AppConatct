using System;

namespace AppConatct.WinForms.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string NomComplet { get; set; }
        public DateTime DateNaiss { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Genre { get; set; }
        public byte[] Photo { get; set; }

        public Contact(string nomComplet, DateTime dateNaiss, string email, string tel, string genre, byte[] Photo)
        {
            this.NomComplet = nomComplet;
            this.DateNaiss = dateNaiss;
            this.Email = email;
            this.Tel = tel;
            this.Genre = genre;
            this.Photo = Photo;
        }
        public Contact()
        {

        }
      
    }
}
