namespace WinFormsFFbasE
{
    partial class FrmAddCourseOfLecture
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.clearCourseButton = new System.Windows.Forms.Button();
            this.fFbasEDataSet = new WinFormsFFbasE.FFbasEDataSet();
            this.cOURSEOFLECTUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSE_OF_LECTURETableAdapter = new WinFormsFFbasE.FFbasEDataSetTableAdapters.COURSE_OF_LECTURETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fFbasEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEOFLECTUREBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название курса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата начала:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата конца:";
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTheme.Location = new System.Drawing.Point(110, 12);
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(162, 20);
            this.textBoxTheme.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerStart.CustomFormat = " ";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(110, 38);
            this.dateTimePickerStart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(162, 20);
            this.dateTimePickerStart.TabIndex = 4;
            this.dateTimePickerStart.Value = new System.DateTime(2018, 4, 12, 20, 18, 56, 0);
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEnd.CustomFormat = " ";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(110, 64);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(162, 20);
            this.dateTimePickerEnd.TabIndex = 5;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addCourseButton.Location = new System.Drawing.Point(54, 114);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(75, 23);
            this.addCourseButton.TabIndex = 6;
            this.addCourseButton.Text = "Добавить";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // clearCourseButton
            // 
            this.clearCourseButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearCourseButton.Location = new System.Drawing.Point(148, 114);
            this.clearCourseButton.Name = "clearCourseButton";
            this.clearCourseButton.Size = new System.Drawing.Size(75, 23);
            this.clearCourseButton.TabIndex = 7;
            this.clearCourseButton.Text = "Очистить";
            this.clearCourseButton.UseVisualStyleBackColor = true;
            this.clearCourseButton.Click += new System.EventHandler(this.clearCourseButton_Click);
            // 
            // fFbasEDataSet
            // 
            this.fFbasEDataSet.DataSetName = "FFbasEDataSet";
            this.fFbasEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOURSEOFLECTUREBindingSource
            // 
            this.cOURSEOFLECTUREBindingSource.DataMember = "COURSE_OF_LECTURE";
            this.cOURSEOFLECTUREBindingSource.DataSource = this.fFbasEDataSet;
            // 
            // cOURSE_OF_LECTURETableAdapter
            // 
            this.cOURSE_OF_LECTURETableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddCourseOfLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 164);
            this.Controls.Add(this.clearCourseButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.textBoxTheme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddCourseOfLecture";
            this.Text = "Добавление обучающего курса";
            this.Load += new System.EventHandler(this.FrmAddCourseOfLecture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fFbasEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEOFLECTUREBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTheme;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button clearCourseButton;
        private FFbasEDataSet fFbasEDataSet;
        private System.Windows.Forms.BindingSource cOURSEOFLECTUREBindingSource;
        private FFbasEDataSetTableAdapters.COURSE_OF_LECTURETableAdapter cOURSE_OF_LECTURETableAdapter;
    }
}