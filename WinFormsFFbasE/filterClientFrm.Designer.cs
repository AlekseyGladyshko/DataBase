namespace WinFormsFFbasE
{
    partial class filterClientFrm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSecPhone = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelExperience = new System.Windows.Forms.Label();
            this.labelInterests = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fFbasEDataSet = new WinFormsFFbasE.FFbasEDataSet();
            this.sTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.queriesTableAdapter = new WinFormsFFbasE.FFbasEDataSetTableAdapters.QueriesTableAdapter();
            this.cLIENTTableAdapter = new WinFormsFFbasE.FFbasEDataSetTableAdapters.CLIENTTableAdapter();
            this.sTATUSTableAdapter = new WinFormsFFbasE.FFbasEDataSetTableAdapters.STATUSTableAdapter();
            this.infoCLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoCLIENTTableAdapter = new WinFormsFFbasE.FFbasEDataSetTableAdapters.infoCLIENTTableAdapter();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxSecPhone = new System.Windows.Forms.TextBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.textBoxInterests = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFbasEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoCLIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя/фамилия:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 41);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 67);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 13);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Телефон:";
            // 
            // labelSecPhone
            // 
            this.labelSecPhone.AutoSize = true;
            this.labelSecPhone.Location = new System.Drawing.Point(12, 93);
            this.labelSecPhone.Name = "labelSecPhone";
            this.labelSecPhone.Size = new System.Drawing.Size(67, 13);
            this.labelSecPhone.TabIndex = 3;
            this.labelSecPhone.Text = "Телефон(2):";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(12, 119);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(61, 13);
            this.labelCompany.TabIndex = 4;
            this.labelCompany.Text = "Компания:";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(12, 145);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(68, 13);
            this.labelPost.TabIndex = 5;
            this.labelPost.Text = "Должность:";
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(12, 171);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(77, 13);
            this.labelExperience.TabIndex = 6;
            this.labelExperience.Text = "Опыт работы:";
            // 
            // labelInterests
            // 
            this.labelInterests.AutoSize = true;
            this.labelInterests.Location = new System.Drawing.Point(12, 197);
            this.labelInterests.Name = "labelInterests";
            this.labelInterests.Size = new System.Drawing.Size(61, 13);
            this.labelInterests.TabIndex = 7;
            this.labelInterests.Text = "Интересы:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 223);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Статус:";
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.fFbasEDataSet;
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
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(201, 270);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // findButton
            // 
            this.findButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.findButton.Location = new System.Drawing.Point(120, 270);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 19;
            this.findButton.Text = "Поиск";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // sTATUSTableAdapter
            // 
            this.sTATUSTableAdapter.ClearBeforeFill = true;
            // 
            // infoCLIENTBindingSource
            // 
            this.infoCLIENTBindingSource.DataMember = "infoCLIENT";
            this.infoCLIENTBindingSource.DataSource = this.fFbasEDataSet;
            // 
            // infoCLIENTTableAdapter
            // 
            this.infoCLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxName.Location = new System.Drawing.Point(101, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 20);
            this.textBoxName.TabIndex = 20;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxEmail.Location = new System.Drawing.Point(101, 38);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(175, 20);
            this.textBoxEmail.TabIndex = 21;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPhone.Location = new System.Drawing.Point(101, 64);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(175, 20);
            this.textBoxPhone.TabIndex = 22;
            // 
            // textBoxSecPhone
            // 
            this.textBoxSecPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSecPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSecPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSecPhone.Location = new System.Drawing.Point(101, 90);
            this.textBoxSecPhone.Name = "textBoxSecPhone";
            this.textBoxSecPhone.Size = new System.Drawing.Size(175, 20);
            this.textBoxSecPhone.TabIndex = 23;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCompany.Location = new System.Drawing.Point(101, 116);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(175, 20);
            this.textBoxCompany.TabIndex = 24;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPost.Location = new System.Drawing.Point(101, 142);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(175, 20);
            this.textBoxPost.TabIndex = 25;
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExperience.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxExperience.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxExperience.Location = new System.Drawing.Point(101, 168);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(175, 20);
            this.textBoxExperience.TabIndex = 26;
            // 
            // textBoxInterests
            // 
            this.textBoxInterests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInterests.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxInterests.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxInterests.Location = new System.Drawing.Point(101, 194);
            this.textBoxInterests.Name = "textBoxInterests";
            this.textBoxInterests.Size = new System.Drawing.Size(175, 20);
            this.textBoxInterests.TabIndex = 27;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.DataSource = this.sTATUSBindingSource;
            this.comboBoxStatus.DisplayMember = "SG_NAME";
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(101, 220);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(175, 21);
            this.comboBoxStatus.TabIndex = 28;
            this.comboBoxStatus.ValueMember = "SG_ID";
            // 
            // filterClientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 322);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxInterests);
            this.Controls.Add(this.textBoxExperience);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.textBoxSecPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelInterests);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.labelSecPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Name = "filterClientFrm";
            this.Text = "Фильтр";
            this.Load += new System.EventHandler(this.filterClientFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFbasEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoCLIENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSecPhone;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.Label labelInterests;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button findButton;
        private FFbasEDataSet fFbasEDataSet;
        private FFbasEDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private FFbasEDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.BindingSource sTATUSBindingSource;
        private FFbasEDataSetTableAdapters.STATUSTableAdapter sTATUSTableAdapter;
        private System.Windows.Forms.BindingSource infoCLIENTBindingSource;
        private FFbasEDataSetTableAdapters.infoCLIENTTableAdapter infoCLIENTTableAdapter;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxSecPhone;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.TextBox textBoxInterests;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}