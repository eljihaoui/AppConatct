using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppConatct.WinForms.Models;

namespace AppConatct.WinForms
{
    public partial class frmAddContact : UserControl
    {
        public frmAddContact()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.NomComplet = txtNom.Text;
            c.DateNaiss = txtDateNaiss.Value.Date;
            c.Email = txtEmail.Text;
            c.Tel = txtTel.Text;
            c.Genre = txtGenre.Text;
            c.Photo = null;
            int res = DBContact.AddContact(c);
            MessageBox.Show(
                "Contact Bien Ajouté ID : " + res,
                "Ajout Contact",
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);


        }
    }
}
