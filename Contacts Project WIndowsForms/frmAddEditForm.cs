using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts_Project_WIndowsForms
{
    public partial class frmAddEditForm : Form
    {
        int ContactID = -1;
        Contacts contact;
        string _selectedImagePath = "";
        public delegate void DataSavedEventHandler();
        public event DataSavedEventHandler onContactSaved;

        enum enmode { addNew = 0, update = 1 };
        enmode Mode = enmode.addNew;
        public frmAddEditForm(int contactID)
        {
            InitializeComponent();
            ContactID = contactID;

            if (contactID == -1)
                Mode = enmode.addNew;   
            else
                Mode = enmode.update;
            
        }

        struct CountryItem
        {
            public string Text;
            public int Value;
            public CountryItem(string Text, int Value)
            {
                this.Text = Text;
                this.Value = Value;
            }
            public override string ToString()
            {
                return Text;
            }
        }

            private void _FillCountriesInComoboBox()
            {
                DataTable dtCountries = Countries.getAllCountries();

                foreach (DataRow row in dtCountries.Rows)
                {
                    cbCountries.Items.Add(new CountryItem((string)row["CountryName"], (int)row["CountryID"]));
                }

            }

        private void refreshForm()
        {
            _FillCountriesInComoboBox();
            pictureBox.ImageLocation = "";
            cbCountries.SelectedIndex = 0;

            if (Mode == enmode.addNew)
            {
                lbTitle.Text = "Add New Contact";
                lkRemove.Visible = false;
                contact = new Contacts();
                return;
            }
                contact = Contacts.Find(ContactID);

            if (contact == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + ContactID);
                this.Close();

                return;
            }
            
            fillFormWithContactDetails(contact);

        }
        private void fillFormWithContactDetails(Contacts contact)
        {
            lbTitle.Text = "Update Contact " + contact.ID;
            lbID.Text = contact.ID.ToString();
            tbFirstName.Text = contact.FirstName.ToString();
            tbLastName.Text = contact.LastName.ToString();
            tbEmail.Text = contact.Email.ToString();
            tbPhone.Text = contact.Phone.ToString();
            dtmDateOfBirth.Value = contact.DateOfBirth;

            foreach (CountryItem item in cbCountries.Items)
            {
                if (item.Value == contact.CountryID)
                {
                    cbCountries.SelectedItem = item; // Select it!
                    break; // Stop looking once we find it
                }
            }

            tbAddress.Text = contact.Address.ToString();

            if(contact.ImagePath !="")
            {
                _selectedImagePath = contact.ImagePath; // Remember the existing path
                lkRemove.Visible = true;
                pictureBox.Load(contact.ImagePath);
            }
            else
            {
                lkRemove.Visible = false;
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            contact.FirstName = tbFirstName.Text;
            contact.LastName = tbLastName.Text;
            contact.Email = tbEmail.Text;
            contact.Phone = tbPhone.Text;
            contact.Address = tbAddress.Text;

            contact.DateOfBirth = dtmDateOfBirth.Value;
            CountryItem selectedCountry = (CountryItem)cbCountries.SelectedItem;
            contact.CountryID = selectedCountry.Value;

            contact.ImagePath = _selectedImagePath;

            contact.saveContact();
            MessageBox.Show("Contact added successfuly!");
            lbID.Text = contact.ID.ToString();
            Mode = enmode.update;
            
            lbTitle.Text = "Update Contact " + contact.ID;

            onContactSaved?.Invoke();
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditForm_Load(object sender, EventArgs e)
        {
            tbFirstName.Focus();
            refreshForm();
        }

        private void lkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;

                pictureBox.Load(selectedFilePath);
                lkRemove.Visible = true;
                _selectedImagePath = selectedFilePath;
            }
        }

        private void lkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox.ImageLocation = null;
            pictureBox.Image = null;
            _selectedImagePath = "";
            lkRemove.Visible = false;
        }
    }
}
