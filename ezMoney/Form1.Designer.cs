namespace ezMoney
{
    partial class FormCategoryManagement
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._tableLayoutPanelCategoryManagement = new System.Windows.Forms.TableLayoutPanel();
            this._categoryNameLabel = new System.Windows.Forms.Label();
            this._textBoxCategoryName = new System.Windows.Forms.TextBox();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._listBoxCategories = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this._tableLayoutPanelCategoryManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // _tableLayoutPanelCategoryManagement
            // 
            this._tableLayoutPanelCategoryManagement.ColumnCount = 3;
            this._tableLayoutPanelCategoryManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tableLayoutPanelCategoryManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this._tableLayoutPanelCategoryManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this._tableLayoutPanelCategoryManagement.Controls.Add(this._categoryNameLabel, 0, 0);
            this._tableLayoutPanelCategoryManagement.Controls.Add(this._textBoxCategoryName, 1, 0);
            this._tableLayoutPanelCategoryManagement.Controls.Add(this._buttonAdd, 2, 0);
            this._tableLayoutPanelCategoryManagement.Controls.Add(this._listBoxCategories, 0, 1);
            this._tableLayoutPanelCategoryManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanelCategoryManagement.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanelCategoryManagement.Name = "_tableLayoutPanelCategoryManagement";
            this._tableLayoutPanelCategoryManagement.RowCount = 2;
            this._tableLayoutPanelCategoryManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this._tableLayoutPanelCategoryManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this._tableLayoutPanelCategoryManagement.Size = new System.Drawing.Size(334, 362);
            this._tableLayoutPanelCategoryManagement.TabIndex = 0;
            // 
            // _categoryNameLabel
            // 
            this._categoryNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._categoryNameLabel.AutoSize = true;
            this._categoryNameLabel.Location = new System.Drawing.Point(17, 24);
            this._categoryNameLabel.Name = "_categoryNameLabel";
            this._categoryNameLabel.Size = new System.Drawing.Size(48, 12);
            this._categoryNameLabel.TabIndex = 0;
            this._categoryNameLabel.Text = "Category";
            // 
            // _textBoxCategoryName
            // 
            this._textBoxCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._textBoxCategoryName.Location = new System.Drawing.Point(86, 19);
            this._textBoxCategoryName.Name = "_textBoxCategoryName";
            this._textBoxCategoryName.Size = new System.Drawing.Size(144, 22);
            this._textBoxCategoryName.TabIndex = 1;
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._buttonAdd.Enabled = false;
            this._buttonAdd.Location = new System.Drawing.Point(246, 18);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(75, 23);
            this._buttonAdd.TabIndex = 2;
            this._buttonAdd.Text = "Add";
            this._buttonAdd.UseVisualStyleBackColor = true;
            // 
            // _listBoxCategories
            // 
            this._tableLayoutPanelCategoryManagement.SetColumnSpan(this._listBoxCategories, 3);
            this._listBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listBoxCategories.FormattingEnabled = true;
            this._listBoxCategories.ItemHeight = 12;
            this._listBoxCategories.Location = new System.Drawing.Point(3, 63);
            this._listBoxCategories.Name = "_listBoxCategories";
            this._listBoxCategories.Size = new System.Drawing.Size(328, 296);
            this._listBoxCategories.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormCategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 362);
            this.Controls.Add(this._tableLayoutPanelCategoryManagement);
            this.Name = "FormCategoryManagement";
            this.Text = "Categories Management";
            this.Load += new System.EventHandler(this.FormCategoryManagement_Load);
            this._tableLayoutPanelCategoryManagement.ResumeLayout(false);
            this._tableLayoutPanelCategoryManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelCategoryManagement;
        private System.Windows.Forms.Label _categoryNameLabel;
        private System.Windows.Forms.TextBox _textBoxCategoryName;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.ListBox _listBoxCategories;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

