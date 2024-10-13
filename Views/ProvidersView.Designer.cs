namespace Supermarket_mvp.Views
{
    partial class ProvidersView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProvidersView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProvidersList = new TabPage();
            DgProviders = new DataGridView();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProvidersDetail = new TabPage();
            TxtProvidersAddress = new TextBox();
            label10 = new Label();
            TxtProvidersEmail = new TextBox();
            label7 = new Label();
            TxtProvidersPhone = new TextBox();
            label8 = new Label();
            TxtProvidersBirthday = new TextBox();
            label9 = new Label();
            TxtProvidersLastName = new TextBox();
            label6 = new Label();
            TxtProvidersFirstName = new TextBox();
            label5 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProvidersDocument = new TextBox();
            label4 = new Label();
            TxtProvidersId = new TextBox();
            label3 = new Label();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProvidersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            tabPageProvidersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 110);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(23, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 35);
            label1.Name = "label1";
            label1.Size = new Size(232, 49);
            label1.TabIndex = 1;
            label1.Text = "PROVIDERS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProvidersList);
            tabControl1.Controls.Add(tabPageProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 110);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 418);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProvidersList
            // 
            tabPageProvidersList.Controls.Add(BtnClose);
            tabPageProvidersList.Controls.Add(BtnDelete);
            tabPageProvidersList.Controls.Add(BtnEdit);
            tabPageProvidersList.Controls.Add(BtnNew);
            tabPageProvidersList.Controls.Add(BtnSearch);
            tabPageProvidersList.Controls.Add(DgProviders);
            tabPageProvidersList.Controls.Add(TxtSearch);
            tabPageProvidersList.Controls.Add(label2);
            tabPageProvidersList.Location = new Point(4, 29);
            tabPageProvidersList.Name = "tabPageProvidersList";
            tabPageProvidersList.Padding = new Padding(3);
            tabPageProvidersList.Size = new Size(792, 385);
            tabPageProvidersList.TabIndex = 0;
            tabPageProvidersList.Text = "Providers List";
            tabPageProvidersList.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.AllowUserToAddRows = false;
            DgProviders.AllowUserToDeleteRows = false;
            DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(19, 89);
            DgProviders.Name = "DgProviders";
            DgProviders.ReadOnly = true;
            DgProviders.RowHeadersWidth = 51;
            DgProviders.Size = new Size(603, 288);
            DgProviders.TabIndex = 15;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(21, 38);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "DATA TO SEARCH";
            TxtSearch.Size = new Size(603, 27);
            TxtSearch.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 15);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 12;
            label2.Text = "Search Provider";
            // 
            // tabPageProvidersDetail
            // 
            tabPageProvidersDetail.Controls.Add(TxtProvidersAddress);
            tabPageProvidersDetail.Controls.Add(label10);
            tabPageProvidersDetail.Controls.Add(TxtProvidersEmail);
            tabPageProvidersDetail.Controls.Add(label7);
            tabPageProvidersDetail.Controls.Add(TxtProvidersPhone);
            tabPageProvidersDetail.Controls.Add(label8);
            tabPageProvidersDetail.Controls.Add(TxtProvidersBirthday);
            tabPageProvidersDetail.Controls.Add(label9);
            tabPageProvidersDetail.Controls.Add(TxtProvidersLastName);
            tabPageProvidersDetail.Controls.Add(label6);
            tabPageProvidersDetail.Controls.Add(TxtProvidersFirstName);
            tabPageProvidersDetail.Controls.Add(label5);
            tabPageProvidersDetail.Controls.Add(BtnCancel);
            tabPageProvidersDetail.Controls.Add(BtnSave);
            tabPageProvidersDetail.Controls.Add(TxtProvidersDocument);
            tabPageProvidersDetail.Controls.Add(label4);
            tabPageProvidersDetail.Controls.Add(TxtProvidersId);
            tabPageProvidersDetail.Controls.Add(label3);
            tabPageProvidersDetail.Location = new Point(4, 29);
            tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            tabPageProvidersDetail.Padding = new Padding(3);
            tabPageProvidersDetail.Size = new Size(792, 385);
            tabPageProvidersDetail.TabIndex = 1;
            tabPageProvidersDetail.Text = "Providers Detail";
            tabPageProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProvidersAddress
            // 
            TxtProvidersAddress.Location = new Point(344, 48);
            TxtProvidersAddress.Name = "TxtProvidersAddress";
            TxtProvidersAddress.Size = new Size(249, 27);
            TxtProvidersAddress.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(344, 25);
            label10.Name = "label10";
            label10.Size = new Size(121, 20);
            label10.TabIndex = 32;
            label10.Text = "Provider Address";
            // 
            // TxtProvidersEmail
            // 
            TxtProvidersEmail.Location = new Point(344, 251);
            TxtProvidersEmail.Name = "TxtProvidersEmail";
            TxtProvidersEmail.Size = new Size(249, 27);
            TxtProvidersEmail.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(344, 228);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 30;
            label7.Text = "Provider Email";
            // 
            // TxtProvidersPhone
            // 
            TxtProvidersPhone.Location = new Point(344, 180);
            TxtProvidersPhone.Name = "TxtProvidersPhone";
            TxtProvidersPhone.Size = new Size(249, 27);
            TxtProvidersPhone.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(344, 157);
            label8.Name = "label8";
            label8.Size = new Size(167, 20);
            label8.TabIndex = 28;
            label8.Text = "Provider Phone Number";
            // 
            // TxtProvidersBirthday
            // 
            TxtProvidersBirthday.Location = new Point(344, 113);
            TxtProvidersBirthday.Name = "TxtProvidersBirthday";
            TxtProvidersBirthday.Size = new Size(249, 27);
            TxtProvidersBirthday.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(344, 90);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 26;
            label9.Text = "Provider Birthday";
            // 
            // TxtProvidersLastName
            // 
            TxtProvidersLastName.Location = new Point(19, 251);
            TxtProvidersLastName.Name = "TxtProvidersLastName";
            TxtProvidersLastName.Size = new Size(249, 27);
            TxtProvidersLastName.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 228);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 24;
            label6.Text = "Provider Last Name";
            // 
            // TxtProvidersFirstName
            // 
            TxtProvidersFirstName.Location = new Point(19, 180);
            TxtProvidersFirstName.Name = "TxtProvidersFirstName";
            TxtProvidersFirstName.Size = new Size(249, 27);
            TxtProvidersFirstName.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 157);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 22;
            label5.Text = "Provider First Name";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(143, 304);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(118, 48);
            BtnCancel.TabIndex = 21;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(19, 304);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(118, 48);
            BtnSave.TabIndex = 20;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProvidersDocument
            // 
            TxtProvidersDocument.Location = new Point(19, 113);
            TxtProvidersDocument.Name = "TxtProvidersDocument";
            TxtProvidersDocument.Size = new Size(249, 27);
            TxtProvidersDocument.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 90);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 18;
            label4.Text = "Provider Document";
            // 
            // TxtProvidersId
            // 
            TxtProvidersId.Location = new Point(19, 48);
            TxtProvidersId.Name = "TxtProvidersId";
            TxtProvidersId.ReadOnly = true;
            TxtProvidersId.Size = new Size(163, 27);
            TxtProvidersId.TabIndex = 17;
            TxtProvidersId.Text = "0";
            TxtProvidersId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 25);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 16;
            label3.Text = "Provider ID";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.AutoSize = true;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(644, 284);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(130, 59);
            BtnClose.TabIndex = 20;
            BtnClose.TextAlign = ContentAlignment.BottomCenter;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.AutoSize = true;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(644, 219);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(130, 59);
            BtnDelete.TabIndex = 19;
            BtnDelete.TextAlign = ContentAlignment.BottomCenter;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.AutoSize = true;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(644, 154);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(130, 59);
            BtnEdit.TabIndex = 18;
            BtnEdit.TextAlign = ContentAlignment.BottomCenter;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.AutoSize = true;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(644, 89);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(130, 59);
            BtnNew.TabIndex = 17;
            BtnNew.TextAlign = ContentAlignment.BottomCenter;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.AutoSize = true;
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.Location = new Point(644, 15);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(48, 50);
            BtnSearch.TabIndex = 16;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "Providers Management";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProvidersList.ResumeLayout(false);
            tabPageProvidersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            tabPageProvidersDetail.ResumeLayout(false);
            tabPageProvidersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProvidersList;
        private TabPage tabPageProvidersDetail;
        private DataGridView DgProviders;
        private TextBox TxtSearch;
        private Label label2;
        private TextBox TxtProvidersAddress;
        private Label label10;
        private TextBox TxtProvidersEmail;
        private Label label7;
        private TextBox TxtProvidersPhone;
        private Label label8;
        private TextBox TxtProvidersBirthday;
        private Label label9;
        private TextBox TxtProvidersLastName;
        private Label label6;
        private TextBox TxtProvidersFirstName;
        private Label label5;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProvidersDocument;
        private Label label4;
        private TextBox TxtProvidersId;
        private Label label3;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
    }
}