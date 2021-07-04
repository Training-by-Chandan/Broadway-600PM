
namespace Broadway.CodeFirst.UI.Admin
{
    partial class SubjectForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxClass = new System.Windows.Forms.ComboBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.LabelId = new System.Windows.Forms.Label();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.TextCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.GridSubject = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxTeacher = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BoxTeacher);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BoxClass);
            this.groupBox1.Controls.Add(this.ButtonDelete);
            this.groupBox1.Controls.Add(this.LabelId);
            this.groupBox1.Controls.Add(this.ButtonCreate);
            this.groupBox1.Controls.Add(this.TextCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ButtonEdit);
            this.groupBox1.Location = new System.Drawing.Point(38, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(725, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Class";
            // 
            // BoxClass
            // 
            this.BoxClass.FormattingEnabled = true;
            this.BoxClass.Location = new System.Drawing.Point(579, 26);
            this.BoxClass.Margin = new System.Windows.Forms.Padding(2);
            this.BoxClass.Name = "BoxClass";
            this.BoxClass.Size = new System.Drawing.Size(140, 21);
            this.BoxClass.TabIndex = 22;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(509, 76);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(98, 35);
            this.ButtonDelete.TabIndex = 20;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Visible = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Location = new System.Drawing.Point(49, 10);
            this.LabelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(0, 13);
            this.LabelId.TabIndex = 19;
            this.LabelId.Visible = false;
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(620, 76);
            this.ButtonCreate.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(98, 35);
            this.ButtonCreate.TabIndex = 18;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // TextCode
            // 
            this.TextCode.Location = new System.Drawing.Point(326, 26);
            this.TextCode.Margin = new System.Windows.Forms.Padding(2);
            this.TextCode.Name = "TextCode";
            this.TextCode.Size = new System.Drawing.Size(140, 20);
            this.TextCode.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Code";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(88, 28);
            this.TextName.Margin = new System.Windows.Forms.Padding(2);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(140, 20);
            this.TextName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(620, 76);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(98, 35);
            this.ButtonEdit.TabIndex = 21;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Visible = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // GridSubject
            // 
            this.GridSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSubject.Location = new System.Drawing.Point(38, 211);
            this.GridSubject.Margin = new System.Windows.Forms.Padding(2);
            this.GridSubject.Name = "GridSubject";
            this.GridSubject.RowHeadersWidth = 51;
            this.GridSubject.RowTemplate.Height = 24;
            this.GridSubject.Size = new System.Drawing.Size(725, 201);
            this.GridSubject.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 10);
            this.label2.TabIndex = 25;
            this.label2.Text = "Teacher";
            // 
            // BoxTeacher
            // 
            this.BoxTeacher.FormattingEnabled = true;
            this.BoxTeacher.Location = new System.Drawing.Point(88, 74);
            this.BoxTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.BoxTeacher.Name = "BoxTeacher";
            this.BoxTeacher.Size = new System.Drawing.Size(140, 21);
            this.BoxTeacher.TabIndex = 24;
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridSubject);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BoxClass;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.TextBox TextCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.DataGridView GridSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BoxTeacher;
    }
}