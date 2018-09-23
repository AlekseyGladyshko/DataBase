namespace WinFormsFFbasE
{
    partial class FrmAddStudent
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
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fFbasEDataSet = new WinFormsFFbasE.FFbasEDataSet();
            this.cLIENTTableAdapter = new WinFormsFFbasE.FFbasEDataSetTableAdapters.CLIENTTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelTip1 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.cOURSEOFLECTUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCL = new System.Windows.Forms.ComboBox();
            this.comboBoxInterests = new System.Windows.Forms.ComboBox();
            this.comboBoxExperience = new System.Windows.Forms.ComboBox();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxSecPhone = new System.Windows.Forms.ComboBox();
            this.comboBoxPhone = new System.Windows.Forms.ComboBox();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelTip2 = new System.Windows.Forms.Label();
            this.labelCourseOfLecture = new System.Windows.Forms.Label();
            this.labelInterests = new System.Windows.Forms.Label();
            this.labelExperience = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelSecPhone = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.sTATUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSE_OF_LECTURETableAdapter = new WinFormsFFbasE.FFbasEDataSetTableAdapters.COURSE_OF_LECTURETableAdapter();
            this.sTATUSTableAdapter = new WinFormsFFbasE.FFbasEDataSetTableAdapters.STATUSTableAdapter();
            this.queriesTableAdapter1 = new WinFormsFFbasE.FFbasEDataSetTableAdapters.QueriesTableAdapter();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new WinFormsFFbasE.FFbasEDataSetTableAdapters.STUDENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFbasEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEOFLECTUREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxClient);
            this.splitContainer1.Panel1.Controls.Add(this.labelCourse);
            this.splitContainer1.Panel1.Controls.Add(this.labelClient);
            this.splitContainer1.Panel1.Controls.Add(this.labelTip1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxCourse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxCL);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxInterests);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxExperience);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxPost);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxCompany);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxSecPhone);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxPhone);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxEmail);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxName);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAdd);
            this.splitContainer1.Panel2.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel2.Controls.Add(this.labelTip2);
            this.splitContainer1.Panel2.Controls.Add(this.labelCourseOfLecture);
            this.splitContainer1.Panel2.Controls.Add(this.labelInterests);
            this.splitContainer1.Panel2.Controls.Add(this.labelExperience);
            this.splitContainer1.Panel2.Controls.Add(this.labelPost);
            this.splitContainer1.Panel2.Controls.Add(this.labelCompany);
            this.splitContainer1.Panel2.Controls.Add(this.labelSecPhone);
            this.splitContainer1.Panel2.Controls.Add(this.labelPhone);
            this.splitContainer1.Panel2.Controls.Add(this.labelEmail);
            this.splitContainer1.Panel2.Controls.Add(this.labelName);
            this.splitContainer1.Size = new System.Drawing.Size(319, 393);
            this.splitContainer1.SplitterDistance = 76;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DataSource = this.cLIENTBindingSource;
            this.comboBoxClient.DisplayMember = "C_NAME";
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(113, 49);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(181, 21);
            this.comboBoxClient.TabIndex = 4;
            this.comboBoxClient.ValueMember = "C_ID";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(12, 25);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(95, 13);
            this.labelCourse.TabIndex = 3;
            this.labelCourse.Text = "Обучающий курс:";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(12, 52);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(46, 13);
            this.labelClient.TabIndex = 2;
            this.labelClient.Text = "Клиент:";
            // 
            // labelTip1
            // 
            this.labelTip1.AutoSize = true;
            this.labelTip1.Location = new System.Drawing.Point(3, 6);
            this.labelTip1.Name = "labelTip1";
            this.labelTip1.Size = new System.Drawing.Size(128, 13);
            this.labelTip1.TabIndex = 1;
            this.labelTip1.Text = "Выбор клиента и курса:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DataSource = this.cOURSEOFLECTUREBindingSource;
            this.comboBoxCourse.DisplayMember = "CL_THEME";
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(113, 22);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(181, 21);
            this.comboBoxCourse.TabIndex = 0;
            this.comboBoxCourse.ValueMember = "CL_ID";
            // 
            // cOURSEOFLECTUREBindingSource
            // 
            this.cOURSEOFLECTUREBindingSource.DataMember = "COURSE_OF_LECTURE";
            this.cOURSEOFLECTUREBindingSource.DataSource = this.fFbasEDataSet;
            // 
            // comboBoxCL
            // 
            this.comboBoxCL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCL.DataSource = this.cOURSEOFLECTUREBindingSource;
            this.comboBoxCL.DisplayMember = "CL_THEME";
            this.comboBoxCL.FormattingEnabled = true;
            this.comboBoxCL.Location = new System.Drawing.Point(113, 19);
            this.comboBoxCL.Name = "comboBoxCL";
            this.comboBoxCL.Size = new System.Drawing.Size(181, 21);
            this.comboBoxCL.TabIndex = 32;
            this.comboBoxCL.ValueMember = "CL_ID";
            // 
            // comboBoxInterests
            // 
            this.comboBoxInterests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxInterests.DataSource = this.cLIENTBindingSource;
            this.comboBoxInterests.DisplayMember = "C_INTERESTS";
            this.comboBoxInterests.FormattingEnabled = true;
            this.comboBoxInterests.Location = new System.Drawing.Point(113, 239);
            this.comboBoxInterests.Name = "comboBoxInterests";
            this.comboBoxInterests.Size = new System.Drawing.Size(181, 21);
            this.comboBoxInterests.TabIndex = 30;
            this.comboBoxInterests.ValueMember = "C_ID";
            // 
            // comboBoxExperience
            // 
            this.comboBoxExperience.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxExperience.DataSource = this.cLIENTBindingSource;
            this.comboBoxExperience.DisplayMember = "C_EXPERIENCE";
            this.comboBoxExperience.FormattingEnabled = true;
            this.comboBoxExperience.Location = new System.Drawing.Point(113, 211);
            this.comboBoxExperience.Name = "comboBoxExperience";
            this.comboBoxExperience.Size = new System.Drawing.Size(181, 21);
            this.comboBoxExperience.TabIndex = 29;
            this.comboBoxExperience.ValueMember = "C_ID";
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPost.DataSource = this.cLIENTBindingSource;
            this.comboBoxPost.DisplayMember = "C_POST";
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Location = new System.Drawing.Point(113, 183);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(181, 21);
            this.comboBoxPost.TabIndex = 28;
            this.comboBoxPost.ValueMember = "C_ID";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCompany.DataSource = this.cLIENTBindingSource;
            this.comboBoxCompany.DisplayMember = "C_COMPANY";
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(113, 156);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(181, 21);
            this.comboBoxCompany.TabIndex = 27;
            this.comboBoxCompany.ValueMember = "C_ID";
            // 
            // comboBoxSecPhone
            // 
            this.comboBoxSecPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSecPhone.DataSource = this.cLIENTBindingSource;
            this.comboBoxSecPhone.DisplayMember = "C_SEC_PHONE";
            this.comboBoxSecPhone.FormattingEnabled = true;
            this.comboBoxSecPhone.Location = new System.Drawing.Point(113, 129);
            this.comboBoxSecPhone.Name = "comboBoxSecPhone";
            this.comboBoxSecPhone.Size = new System.Drawing.Size(181, 21);
            this.comboBoxSecPhone.TabIndex = 26;
            this.comboBoxSecPhone.ValueMember = "C_ID";
            // 
            // comboBoxPhone
            // 
            this.comboBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPhone.DataSource = this.cLIENTBindingSource;
            this.comboBoxPhone.DisplayMember = "C_PHONE";
            this.comboBoxPhone.FormattingEnabled = true;
            this.comboBoxPhone.Location = new System.Drawing.Point(113, 101);
            this.comboBoxPhone.Name = "comboBoxPhone";
            this.comboBoxPhone.Size = new System.Drawing.Size(181, 21);
            this.comboBoxPhone.TabIndex = 25;
            this.comboBoxPhone.ValueMember = "C_ID";
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEmail.DataSource = this.cLIENTBindingSource;
            this.comboBoxEmail.DisplayMember = "C_EMAIL";
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(113, 73);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(181, 21);
            this.comboBoxEmail.TabIndex = 24;
            this.comboBoxEmail.ValueMember = "C_ID";
            // 
            // comboBoxName
            // 
            this.comboBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxName.DataSource = this.cLIENTBindingSource;
            this.comboBoxName.DisplayMember = "C_NAME";
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(113, 46);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(181, 21);
            this.comboBoxName.TabIndex = 23;
            this.comboBoxName.ValueMember = "C_ID";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(219, 278);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(128, 278);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelTip2
            // 
            this.labelTip2.AutoSize = true;
            this.labelTip2.Location = new System.Drawing.Point(3, 0);
            this.labelTip2.Name = "labelTip2";
            this.labelTip2.Size = new System.Drawing.Size(80, 13);
            this.labelTip2.TabIndex = 20;
            this.labelTip2.Text = "Поля клиента:";
            // 
            // labelCourseOfLecture
            // 
            this.labelCourseOfLecture.AutoSize = true;
            this.labelCourseOfLecture.Location = new System.Drawing.Point(12, 22);
            this.labelCourseOfLecture.Name = "labelCourseOfLecture";
            this.labelCourseOfLecture.Size = new System.Drawing.Size(95, 13);
            this.labelCourseOfLecture.TabIndex = 9;
            this.labelCourseOfLecture.Text = "Обучающий курс:";
            // 
            // labelInterests
            // 
            this.labelInterests.AutoSize = true;
            this.labelInterests.Location = new System.Drawing.Point(12, 242);
            this.labelInterests.Name = "labelInterests";
            this.labelInterests.Size = new System.Drawing.Size(61, 13);
            this.labelInterests.TabIndex = 7;
            this.labelInterests.Text = "Интересы:";
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(12, 214);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(77, 13);
            this.labelExperience.TabIndex = 6;
            this.labelExperience.Text = "Опыт работы:";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(12, 186);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(68, 13);
            this.labelPost.TabIndex = 5;
            this.labelPost.Text = "Должность:";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(12, 159);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(61, 13);
            this.labelCompany.TabIndex = 4;
            this.labelCompany.Text = "Компания:";
            // 
            // labelSecPhone
            // 
            this.labelSecPhone.AutoSize = true;
            this.labelSecPhone.Location = new System.Drawing.Point(12, 132);
            this.labelSecPhone.Name = "labelSecPhone";
            this.labelSecPhone.Size = new System.Drawing.Size(67, 13);
            this.labelSecPhone.TabIndex = 3;
            this.labelSecPhone.Text = "Телефон(2):";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 104);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 13);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Телефон:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 76);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя/фамилия:";
            // 
            // sTATUSBindingSource
            // 
            this.sTATUSBindingSource.DataMember = "STATUS";
            this.sTATUSBindingSource.DataSource = this.fFbasEDataSet;
            // 
            // cOURSE_OF_LECTURETableAdapter
            // 
            this.cOURSE_OF_LECTURETableAdapter.ClearBeforeFill = true;
            // 
            // sTATUSTableAdapter
            // 
            this.sTATUSTableAdapter.ClearBeforeFill = true;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.fFbasEDataSet;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 393);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmAddStudent";
            this.Text = "Добавление студента";
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fFbasEDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEOFLECTUREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FFbasEDataSet fFbasEDataSet;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private FFbasEDataSetTableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.BindingSource cOURSEOFLECTUREBindingSource;
        private FFbasEDataSetTableAdapters.COURSE_OF_LECTURETableAdapter cOURSE_OF_LECTURETableAdapter;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelTip1;
        private System.Windows.Forms.Label labelCourseOfLecture;
        private System.Windows.Forms.Label labelInterests;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelSecPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTip2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.BindingSource sTATUSBindingSource;
        private FFbasEDataSetTableAdapters.STATUSTableAdapter sTATUSTableAdapter;
        private FFbasEDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.ComboBox comboBoxInterests;
        private System.Windows.Forms.ComboBox comboBoxExperience;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxSecPhone;
        private System.Windows.Forms.ComboBox comboBoxPhone;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxCL;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private FFbasEDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
    }
}