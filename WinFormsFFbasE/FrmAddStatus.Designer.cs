namespace WinFormsFFbasE
{
    partial class FrmAddStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.addStatusButton = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new WinFormsFFbasE.FFbasEDataSetTableAdapters.QueriesTableAdapter();
            this.fFbasEDataSet = new WinFormsFFbasE.FFbasEDataSet();
            this.sTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTATUSTableAdapter = new WinFormsFFbasE.FFbasEDataSetTableAdapters.STATUSTableAdapter();
            this.dGVStatus = new System.Windows.Forms.DataGridView();
            this.sGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveStatusButton = new System.Windows.Forms.Button();
            this.delStatusButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fFbasEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя статуса:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(135, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // addStatusButton
            // 
            this.addStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addStatusButton.Location = new System.Drawing.Point(292, 10);
            this.addStatusButton.Name = "addStatusButton";
            this.addStatusButton.Size = new System.Drawing.Size(65, 23);
            this.addStatusButton.TabIndex = 2;
            this.addStatusButton.Text = "Добавить";
            this.addStatusButton.UseVisualStyleBackColor = true;
            this.addStatusButton.Click += new System.EventHandler(this.addStatusButton_Click);
            // 
            // fFbasEDataSet
            // 
            this.fFbasEDataSet.DataSetName = "FFbasEDataSet";
            this.fFbasEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTATUSBindingSource
            // 
            this.sTATUSBindingSource.DataMember = "STATUS";
            this.sTATUSBindingSource.DataSource = this.fFbasEDataSet;
            // 
            // sTATUSTableAdapter
            // 
            this.sTATUSTableAdapter.ClearBeforeFill = true;
            // 
            // dGVStatus
            // 
            this.dGVStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVStatus.AutoGenerateColumns = false;
            this.dGVStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sGIDDataGridViewTextBoxColumn,
            this.sGNAMEDataGridViewTextBoxColumn});
            this.dGVStatus.DataSource = this.sTATUSBindingSource;
            this.dGVStatus.Location = new System.Drawing.Point(12, 49);
            this.dGVStatus.Name = "dGVStatus";
            this.dGVStatus.Size = new System.Drawing.Size(248, 135);
            this.dGVStatus.TabIndex = 3;
            // 
            // sGIDDataGridViewTextBoxColumn
            // 
            this.sGIDDataGridViewTextBoxColumn.DataPropertyName = "SG_ID";
            this.sGIDDataGridViewTextBoxColumn.HeaderText = "SG_ID";
            this.sGIDDataGridViewTextBoxColumn.Name = "sGIDDataGridViewTextBoxColumn";
            this.sGIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sGIDDataGridViewTextBoxColumn.Visible = false;
            this.sGIDDataGridViewTextBoxColumn.Width = 300;
            // 
            // sGNAMEDataGridViewTextBoxColumn
            // 
            this.sGNAMEDataGridViewTextBoxColumn.DataPropertyName = "SG_NAME";
            this.sGNAMEDataGridViewTextBoxColumn.HeaderText = "Имя статуса";
            this.sGNAMEDataGridViewTextBoxColumn.Name = "sGNAMEDataGridViewTextBoxColumn";
            // 
            // saveStatusButton
            // 
            this.saveStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveStatusButton.Location = new System.Drawing.Point(279, 73);
            this.saveStatusButton.Name = "saveStatusButton";
            this.saveStatusButton.Size = new System.Drawing.Size(75, 23);
            this.saveStatusButton.TabIndex = 4;
            this.saveStatusButton.Text = "Сохранить";
            this.saveStatusButton.UseVisualStyleBackColor = true;
            this.saveStatusButton.Click += new System.EventHandler(this.saveStatusButton_Click);
            // 
            // delStatusButton
            // 
            this.delStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delStatusButton.Location = new System.Drawing.Point(279, 112);
            this.delStatusButton.Name = "delStatusButton";
            this.delStatusButton.Size = new System.Drawing.Size(75, 23);
            this.delStatusButton.TabIndex = 5;
            this.delStatusButton.Text = "Удалить";
            this.delStatusButton.UseVisualStyleBackColor = true;
            this.delStatusButton.Click += new System.EventHandler(this.delStatusButton_Click);
            // 
            // FrmAddStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 196);
            this.Controls.Add(this.delStatusButton);
            this.Controls.Add(this.saveStatusButton);
            this.Controls.Add(this.dGVStatus);
            this.Controls.Add(this.addStatusButton);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddStatus";
            this.Text = "Добавить статус";
            this.Load += new System.EventHandler(this.FrmAddStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fFbasEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button addStatusButton;
        private FFbasEDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private FFbasEDataSet fFbasEDataSet;
        private System.Windows.Forms.BindingSource sTATUSBindingSource;
        private FFbasEDataSetTableAdapters.STATUSTableAdapter sTATUSTableAdapter;
        private System.Windows.Forms.DataGridView dGVStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveStatusButton;
        private System.Windows.Forms.Button delStatusButton;
    }
}