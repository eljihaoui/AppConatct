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
    public partial class frmListContact : UserControl
    {
        public frmListContact()
        {
            InitializeComponent();
        }

        private void frmListContact_Load(object sender, EventArgs e)
        {
            BindingList<Contact> lst = new BindingList<Contact>(DBContact.GetListContacts());
            dgvContacts.DataSource = lst;
            dgvContacts.AutoResizeColumns();
            dgvContacts.AllowUserToResizeColumns = true;
            dgvContacts.AllowUserToOrderColumns = true;
            dgvContacts.Columns["photo"].Visible = false;
            //dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContacts.AllowUserToAddRows = false;
            nbContact.Text = "Nombre Contact : " + dgvContacts.Rows.Count;


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                var lst = new BindingList<Contact>(DBContact.SearchConatct(txtSearch.Text));
                dgvContacts.DataSource = lst;
            }
            else
            {
                var lst = new BindingList<Contact>( DBContact.GetListContacts());
                dgvContacts.DataSource = lst;
            }
            nbContact.Text = "Nombre Contact :" + dgvContacts.Rows.Count;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                dgvContacts.Rows[index].Selected = true;
                txtID.Text = dgvContacts.Rows[index].Cells[0].Value.ToString();
                txtNom.Text = dgvContacts.Rows[index].Cells[1].Value.ToString();
                string txtdate = dgvContacts.Rows[index].Cells[2].Value.ToString();
                txtDateNaiss.Text = DateTime.Parse(txtdate).ToString("dd/MM/yyyy");
                txtEmail.Text= dgvContacts.Rows[index].Cells[3].Value.ToString();
                txtTel.Text = dgvContacts.Rows[index].Cells[4].Value.ToString();
                txtGenre.Text = dgvContacts.Rows[index].Cells[5].Value.ToString();
                byte[] img = (byte [])dgvContacts.Rows[index].Cells[6].Value;
                if (img != null)
                {
                    MemoryStream ms = new MemoryStream(img);
                    txtPictureContact.Image = Image.FromStream(ms);

                }
                else
                {
                    txtPictureContact.Image = null;
                }


            }
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

        private void btnUpdae_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                Contact c = new Contact();
                c.Id = Int32.Parse( txtID.Text);
                c.NomComplet = txtNom.Text;
                c.Email = txtEmail.Text;
                c.Genre = txtGenre.Text;
                c.Tel = txtTel.Text;
                c.DateNaiss = txtDateNaiss.Value.Date;
                MemoryStream ms = new MemoryStream();
                txtPictureContact.Image.Save(ms, txtPictureContact.Image.RawFormat);
                byte[] img = ms.ToArray();
                c.Photo = img;
                DBContact.UpdateContact(c);
                var lst = new BindingList<Contact>(DBContact.GetListContacts());
                dgvContacts.DataSource = lst;
                MessageBox.Show(
                    "Contact Bien Modifié",
                    "Modification", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );





            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                DialogResult res = MessageBox.Show(
                    "Voulez vous vraiment supprimer ce contact",
                    "supprisson",MessageBoxButtons.YesNo,MessageBoxIcon.Warning
                    );
                if (res == DialogResult.Yes)
                {
                    DBContact.DeleteContact(Int32.Parse(txtID.Text));
                    var lst = new BindingList<Contact>(DBContact.GetListContacts());
                    dgvContacts.DataSource = lst;
                }
                nbContact.Text = "Nombre Contact :" + dgvContacts.Rows.Count;
            }
        }
    }
}
