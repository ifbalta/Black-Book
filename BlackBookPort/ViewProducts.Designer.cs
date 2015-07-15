namespace BlackBookPort
{
    partial class ViewProducts
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
            this.formViewProducts = new System.Windows.Forms.Label();
            this.labelSearchID = new System.Windows.Forms.Label();
            this.labelCategoryFilter = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.listCategoryFilter = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formViewProducts
            // 
            this.formViewProducts.AutoSize = true;
            this.formViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formViewProducts.Location = new System.Drawing.Point(136, 9);
            this.formViewProducts.Name = "formViewProducts";
            this.formViewProducts.Size = new System.Drawing.Size(167, 29);
            this.formViewProducts.TabIndex = 0;
            this.formViewProducts.Text = "View Products";
            // 
            // labelSearchID
            // 
            this.labelSearchID.AutoSize = true;
            this.labelSearchID.Location = new System.Drawing.Point(21, 49);
            this.labelSearchID.Name = "labelSearchID";
            this.labelSearchID.Size = new System.Drawing.Size(72, 13);
            this.labelSearchID.TabIndex = 1;
            this.labelSearchID.Text = "Search by ID:";
            // 
            // labelCategoryFilter
            // 
            this.labelCategoryFilter.AutoSize = true;
            this.labelCategoryFilter.Location = new System.Drawing.Point(21, 77);
            this.labelCategoryFilter.Name = "labelCategoryFilter";
            this.labelCategoryFilter.Size = new System.Drawing.Size(77, 13);
            this.labelCategoryFilter.TabIndex = 2;
            this.labelCategoryFilter.Text = "Category Filter:";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(99, 46);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(123, 20);
            this.txtSearchID.TabIndex = 3;
            // 
            // listCategoryFilter
            // 
            this.listCategoryFilter.FormattingEnabled = true;
            this.listCategoryFilter.Location = new System.Drawing.Point(99, 77);
            this.listCategoryFilter.Name = "listCategoryFilter";
            this.listCategoryFilter.ScrollAlwaysVisible = true;
            this.listCategoryFilter.Size = new System.Drawing.Size(123, 17);
            this.listCategoryFilter.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(415, 144);
            this.textBox1.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(228, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(24, 268);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(309, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(168, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 313);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listCategoryFilter);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.labelCategoryFilter);
            this.Controls.Add(this.labelSearchID);
            this.Controls.Add(this.formViewProducts);
            this.Name = "ViewProducts";
            this.Text = "Black Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formViewProducts;
        private System.Windows.Forms.Label labelSearchID;
        private System.Windows.Forms.Label labelCategoryFilter;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.ListBox listCategoryFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
    }
}