using AppConatct.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConatct.WinForms
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DBContact.AddContact(new Contact("Mohamed ali", DateTime.Parse("12/03/2000"), "mohamed@gmail.com", "06 06 06 06 06", "M", null));
            DBContact.AddContact(new Contact("mohamed jhaoui", DateTime.Parse("12/01/1984"), "jhaoui@gmail.com", "06 60 00 06 01","M",  null));
            DBContact.AddContact(new Contact("jamila jamal", DateTime.Parse("13/03/1980"), "jamila@gmail.com", "06 60 00 06 01", "F",  null));
            DBContact.AddContact(new Contact("zinab alami", DateTime.Parse("06/02/1984"), "zinab@gmail.com", "06 60 00 06 01", "F",  null));
            DBContact.AddContact(new Contact("khafid jawi", DateTime.Parse("05/03/2000"), "khafid@gmail.com", "06 60 00 06 01", "M",  null));
            DBContact.AddContact(new Contact("mustapha jamal", DateTime.Parse("13/06/1984"), "mustapha@gmail.com", "06 60 00 06 01", "M", null));
            DBContact.AddContact(new Contact("sanae lwali", DateTime.Parse("13/12/2000"), "sanae@gmail.com", "06 60 00 06 01", "F",  null));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }
    }
}
