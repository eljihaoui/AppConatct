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
    }
}
