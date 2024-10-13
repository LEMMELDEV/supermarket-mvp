namespace Supermarket_mvp.Views
{
    partial class CategoriesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategoriesList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategories = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoriesDetail = new TabPage();
            TxtCategoriesDescription = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            label5 = new Label();
            TxtCategoriesName = new TextBox();
            label4 = new Label();
            TxtCategoriesId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            tabPageCategoriesDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 131);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 41);
            label1.Name = "label1";
            label1.Size = new Size(241, 49);
            label1.TabIndex = 2;
            label1.Text = "CATEGORIES";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 131);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 397);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategoriesList
            // 
            tabPageCategoriesList.Controls.Add(BtnClose);
            tabPageCategoriesList.Controls.Add(BtnDelete);
            tabPageCategoriesList.Controls.Add(BtnEdit);
            tabPageCategoriesList.Controls.Add(BtnNew);
            tabPageCategoriesList.Controls.Add(DgCategories);
            tabPageCategoriesList.Controls.Add(BtnSearch);
            tabPageCategoriesList.Controls.Add(TxtSearch);
            tabPageCategoriesList.Controls.Add(label2);
            tabPageCategoriesList.Location = new Point(4, 29);
            tabPageCategoriesList.Name = "tabPageCategoriesList";
            tabPageCategoriesList.Padding = new Padding(3);
            tabPageCategoriesList.Size = new Size(792, 364);
            tabPageCategoriesList.TabIndex = 0;
            tabPageCategoriesList.Text = "Categories List";
            tabPageCategoriesList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.AutoSize = true;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(641, 278);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(130, 59);
            BtnClose.TabIndex = 15;
            BtnClose.TextAlign = ContentAlignment.BottomCenter;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.AutoSize = true;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(641, 213);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(130, 59);
            BtnDelete.TabIndex = 14;
            BtnDelete.TextAlign = ContentAlignment.BottomCenter;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.AutoSize = true;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(641, 148);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(130, 59);
            BtnEdit.TabIndex = 13;
            BtnEdit.TextAlign = ContentAlignment.BottomCenter;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.AutoSize = true;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(641, 83);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(130, 59);
            BtnNew.TabIndex = 12;
            BtnNew.TextAlign = ContentAlignment.BottomCenter;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(21, 74);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.RowHeadersWidth = 51;
            DgCategories.Size = new Size(603, 281);
            DgCategories.TabIndex = 11;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.AutoSize = true;
            BtnSearch.Image = (Image)resources.GetObject("BtnSearch.Image");
            BtnSearch.Location = new Point(641, 9);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(48, 50);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(21, 32);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "DATA TO SEARCH";
            TxtSearch.Size = new Size(603, 27);
            TxtSearch.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 9);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 8;
            label2.Text = "Search Category";
            // 
            // tabPageCategoriesDetail
            // 
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesDescription);
            tabPageCategoriesDetail.Controls.Add(BtnCancel);
            tabPageCategoriesDetail.Controls.Add(BtnSave);
            tabPageCategoriesDetail.Controls.Add(label5);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesName);
            tabPageCategoriesDetail.Controls.Add(label4);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesId);
            tabPageCategoriesDetail.Controls.Add(label3);
            tabPageCategoriesDetail.Location = new Point(4, 29);
            tabPageCategoriesDetail.Name = "tabPageCategoriesDetail";
            tabPageCategoriesDetail.Padding = new Padding(3);
            tabPageCategoriesDetail.Size = new Size(792, 364);
            tabPageCategoriesDetail.TabIndex = 1;
            tabPageCategoriesDetail.Text = "Categories Detail";
            tabPageCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // TxtCategoriesDescription
            // 
            TxtCategoriesDescription.Location = new Point(18, 184);
            TxtCategoriesDescription.Multiline = true;
            TxtCategoriesDescription.Name = "TxtCategoriesDescription";
            TxtCategoriesDescription.Size = new Size(516, 89);
            TxtCategoriesDescription.TabIndex = 16;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(142, 300);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(118, 48);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(18, 300);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(118, 48);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 161);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 12;
            label5.Text = "Description";
            // 
            // TxtCategoriesName
            // 
            TxtCategoriesName.Location = new Point(18, 116);
            TxtCategoriesName.Name = "TxtCategoriesName";
            TxtCategoriesName.Size = new Size(249, 27);
            TxtCategoriesName.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 93);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 10;
            label4.Text = "Category Name";
            // 
            // TxtCategoriesId
            // 
            TxtCategoriesId.Location = new Point(18, 48);
            TxtCategoriesId.Name = "TxtCategoriesId";
            TxtCategoriesId.ReadOnly = true;
            TxtCategoriesId.Size = new Size(163, 27);
            TxtCategoriesId.TabIndex = 9;
            TxtCategoriesId.Text = "0";
            TxtCategoriesId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 25);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 8;
            label3.Text = "Category ID";
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "Categories Management";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategoriesList.ResumeLayout(false);
            tabPageCategoriesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            tabPageCategoriesDetail.ResumeLayout(false);
            tabPageCategoriesDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCategoriesList;
        private TabPage tabPageCategoriesDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCategories;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnCancel;
        private Button BtnSave;
        private Label label5;
        private TextBox TxtCategoriesName;
        private Label label4;
        private TextBox TxtCategoriesId;
        private Label label3;
        private TextBox TxtCategoriesDescription;
    }
}