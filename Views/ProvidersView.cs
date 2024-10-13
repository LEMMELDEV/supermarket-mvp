using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class ProvidersView : Form , IProvidersView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProvidersView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProvidersDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                tabPageProvidersDetail.Text = "Add New Provider";

            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersList);
                tabControl1.TabPages.Add(tabPageProvidersDetail);
                tabPageProvidersDetail.Text = "Edit Providers";

            };


            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Provider",
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful) // SI grabar fue exitoso
                {
                    tabControl1.TabPages.Remove(tabPageProvidersDetail);
                    tabControl1.TabPages.Add(tabPageProvidersList);
                }

                MessageBox.Show(Message);
            };


            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProvidersDetail);
                tabControl1.TabPages.Add(tabPageProvidersList);
            };
        }

        public string ProvidersId
        {
            get { return TxtProvidersId.Text; }
            set { TxtProvidersId.Text = value; }
        }
        public string ProvidersDocument
        {
            get { return TxtProvidersDocument.Text; }
            set { TxtProvidersDocument.Text = value; }
        }
        public string ProvidersFirstName
        {
            get { return TxtProvidersFirstName.Text; }
            set { TxtProvidersFirstName.Text = value; }
        }
        public string ProvidersLastName
        {
            get { return TxtProvidersLastName.Text; }
            set { TxtProvidersLastName.Text = value; }
        }
        public string ProvidersAddress
        {
            get { return TxtProvidersAddress.Text; }
            set { TxtProvidersAddress.Text = value; }
        }

        public string ProvidersBirthday
        {
            get { return TxtProvidersBirthday.Text; }
            set { TxtProvidersBirthday.Text = value; }
        }
        public string ProvidersPhone
        {
            get { return TxtProvidersPhone.Text; }
            set { TxtProvidersPhone.Text = value; }
        }
        public string ProvidersEmail
        {
            get { return TxtProvidersEmail.Text; }
            set { TxtProvidersEmail.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductListBildingSource(BindingSource providersList)
        {
            DgProviders.DataSource = providersList;
        }
    }
}
