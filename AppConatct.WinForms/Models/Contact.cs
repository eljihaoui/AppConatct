using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string UrlPhoto { get; set; }

        public Contact(string nomComplet, DateTime dateNaiss, string email, string tel, string genre, string urlPhoto)
        {
            this.NomComplet = nomComplet;
            this.DateNaiss = dateNaiss;
            this.Email = email;
            this.Tel = tel;
            this.Genre = genre;
            this.UrlPhoto = urlPhoto;
        }
        public Contact()
        {

        }
        public Contact( DateTime dateNaiss, string email, string tel, string genre, string urlPhoto)
        {
            this.DateNaiss = dateNaiss;
            this.Email = email;
            this.Tel = tel;
            this.Genre = genre;
            this.UrlPhoto = urlPhoto;
        }

    }
}
