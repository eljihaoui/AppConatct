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
using System.IO;

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

            MemoryStream ms = new MemoryStream();
            txtPictureContact.Image.Save(ms, txtPictureContact.Image.RawFormat);
            byte[] bImage = ms.ToArray();
            c.Photo = bImage;

            int res = DBContact.AddContact(c);
            MessageBox.Show(
                "Contact Bien Ajouté ID : " + res,
                "Ajout Contact",
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            txtGenre.Text = "";
            txtPictureContact.Image = null;


        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files(*.jpg; *.gif; *.jpeg; *.bmp; *.png)| *.jpg; *.gif; *.jpeg; *.bmp; *.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtPictureContact.Image = new Bitmap(fd.FileName);
            }
        }
    }
}
