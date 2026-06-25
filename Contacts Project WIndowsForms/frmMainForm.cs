using System;
using ContactsBusinessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_Project_WIndowsForms
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshContacts();
        }

        private void refreshContacts()
        {
            dgvListContacts.DataSource = Contacts.getAllContacts();
        }


        private void btnAddContact_Click(object sender, EventArgs e)
        {
            frmAddEditForm form = new frmAddEditForm(-1);
            form.onContactSaved += refreshContacts;
            form.ShowDialog();
            

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditForm form = new frmAddEditForm((int)dgvListContacts.CurrentRow.Cells[0].Value);
            form.ShowDialog();
            refreshContacts();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedID = (int)dgvListContacts.CurrentRow.Cells[0].Value;
            Contacts.deleteContact(SelectedID);
            refreshContacts();
        }
    }
}
