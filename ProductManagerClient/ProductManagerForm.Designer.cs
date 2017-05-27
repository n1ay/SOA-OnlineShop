using System;

namespace ProductManagerClient
{
    partial class ProductManagerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagerForm));
            this.buttonGet = new System.Windows.Forms.Button();
            this.textBoxAttribute = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonMenuDelete = new System.Windows.Forms.Button();
            this.buttonMenuUpdate = new System.Windows.Forms.Button();
            this.buttonMenuAdd = new System.Windows.Forms.Button();
            this.buttonMenuGet = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.panelGet = new System.Windows.Forms.Panel();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelGet.SuspendLayout();
            this.panelUpdate.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(3, 3);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 0;
            this.buttonGet.Text = "Get Product";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // textBoxAttribute
            // 
            this.textBoxAttribute.Location = new System.Drawing.Point(84, 4);
            this.textBoxAttribute.Name = "textBoxAttribute";
            this.textBoxAttribute.Size = new System.Drawing.Size(113, 20);
            this.textBoxAttribute.TabIndex = 1;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(16, 163);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(25, 13);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Info";
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.Location = new System.Drawing.Point(3, 28);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(75, 24);
            this.buttonGetAll.TabIndex = 3;
            this.buttonGetAll.Text = "Get All";
            this.buttonGetAll.UseVisualStyleBackColor = true;
            this.buttonGetAll.Click += new System.EventHandler(this.buttonGetAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewWrongFormat);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ProductDatabase.Product);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.labelMenu);
            this.panelMenu.Controls.Add(this.buttonMenuDelete);
            this.panelMenu.Controls.Add(this.buttonMenuUpdate);
            this.panelMenu.Controls.Add(this.buttonMenuAdd);
            this.panelMenu.Controls.Add(this.buttonMenuGet);
            this.panelMenu.Location = new System.Drawing.Point(15, 12);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(333, 51);
            this.panelMenu.TabIndex = 5;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(4, 4);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(60, 13);
            this.labelMenu.TabIndex = 4;
            this.labelMenu.Text = "Main Menu";
            // 
            // buttonMenuDelete
            // 
            this.buttonMenuDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMenuDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuDelete.Image")));
            this.buttonMenuDelete.Location = new System.Drawing.Point(246, 20);
            this.buttonMenuDelete.Name = "buttonMenuDelete";
            this.buttonMenuDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonMenuDelete.TabIndex = 3;
            this.buttonMenuDelete.Text = "Delete";
            this.buttonMenuDelete.UseVisualStyleBackColor = true;
            this.buttonMenuDelete.Click += new System.EventHandler(this.buttonMenuDelete_Click);
            // 
            // buttonMenuUpdate
            // 
            this.buttonMenuUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMenuUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuUpdate.Image")));
            this.buttonMenuUpdate.Location = new System.Drawing.Point(165, 20);
            this.buttonMenuUpdate.Name = "buttonMenuUpdate";
            this.buttonMenuUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonMenuUpdate.TabIndex = 2;
            this.buttonMenuUpdate.Text = "Update";
            this.buttonMenuUpdate.UseVisualStyleBackColor = true;
            this.buttonMenuUpdate.Click += new System.EventHandler(this.buttonMenuUpdate_Click);
            // 
            // buttonMenuAdd
            // 
            this.buttonMenuAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMenuAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuAdd.Image")));
            this.buttonMenuAdd.Location = new System.Drawing.Point(84, 20);
            this.buttonMenuAdd.Name = "buttonMenuAdd";
            this.buttonMenuAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonMenuAdd.TabIndex = 1;
            this.buttonMenuAdd.Text = "Add";
            this.buttonMenuAdd.UseVisualStyleBackColor = true;
            this.buttonMenuAdd.Click += new System.EventHandler(this.buttonMenuAdd_Click);
            // 
            // buttonMenuGet
            // 
            this.buttonMenuGet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMenuGet.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenuGet.Image")));
            this.buttonMenuGet.Location = new System.Drawing.Point(3, 20);
            this.buttonMenuGet.Name = "buttonMenuGet";
            this.buttonMenuGet.Size = new System.Drawing.Size(75, 23);
            this.buttonMenuGet.TabIndex = 0;
            this.buttonMenuGet.Text = "Get";
            this.buttonMenuGet.UseVisualStyleBackColor = true;
            this.buttonMenuGet.Click += new System.EventHandler(this.buttonMenuGet_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Id",
            "Name",
            "Count",
            "Price"});
            this.comboBoxFilter.Location = new System.Drawing.Point(203, 3);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter.TabIndex = 6;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // panelGet
            // 
            this.panelGet.Controls.Add(this.buttonGet);
            this.panelGet.Controls.Add(this.comboBoxFilter);
            this.panelGet.Controls.Add(this.textBoxAttribute);
            this.panelGet.Controls.Add(this.buttonGetAll);
            this.panelGet.Location = new System.Drawing.Point(15, 94);
            this.panelGet.Name = "panelGet";
            this.panelGet.Size = new System.Drawing.Size(337, 55);
            this.panelGet.TabIndex = 7;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.buttonUpdate);
            this.panelUpdate.Location = new System.Drawing.Point(354, 75);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(340, 55);
            this.panelUpdate.TabIndex = 8;
            this.panelUpdate.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(7, -1);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.buttonAdd);
            this.panelAdd.Location = new System.Drawing.Point(354, 136);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(340, 56);
            this.panelAdd.TabIndex = 1;
            this.panelAdd.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelDelete
            // 
            this.panelDelete.Controls.Add(this.buttonDelete);
            this.panelDelete.Location = new System.Drawing.Point(354, 12);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(340, 57);
            this.panelDelete.TabIndex = 9;
            this.panelDelete.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(7, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(391, 183);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // ProductManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(559, 410);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelGet);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelInfo);
            this.Name = "ProductManagerForm";
            this.Text = "Product Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelGet.ResumeLayout(false);
            this.panelGet.PerformLayout();
            this.panelUpdate.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.TextBox textBoxAttribute;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonGetAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMenuDelete;
        private System.Windows.Forms.Button buttonMenuUpdate;
        private System.Windows.Forms.Button buttonMenuAdd;
        private System.Windows.Forms.Button buttonMenuGet;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Panel panelGet;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
    }
}

