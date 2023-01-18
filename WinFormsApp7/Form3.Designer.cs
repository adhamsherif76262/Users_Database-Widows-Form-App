
namespace WinFormsApp7
{
    partial class DisplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>A\
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.S_Dep = new System.Windows.Forms.TextBox();
            this.S_id = new System.Windows.Forms.TextBox();
            this.S_Proj = new System.Windows.Forms.TextBox();
            this.S_name = new System.Windows.Forms.TextBox();
            this.ResultData = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ResultData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID";
            // 
            // S_Dep
            // 
            this.S_Dep.Location = new System.Drawing.Point(231, 140);
            this.S_Dep.Name = "S_Dep";
            this.S_Dep.Size = new System.Drawing.Size(100, 23);
            this.S_Dep.TabIndex = 5;
            this.S_Dep.TextChanged += new System.EventHandler(this.S_Dep_TextChanged);
            // 
            // S_id
            // 
            this.S_id.Location = new System.Drawing.Point(231, 48);
            this.S_id.Name = "S_id";
            this.S_id.Size = new System.Drawing.Size(100, 23);
            this.S_id.TabIndex = 6;
            this.S_id.TextChanged += new System.EventHandler(this.S_id_TextChanged);
            // 
            // S_Proj
            // 
            this.S_Proj.Location = new System.Drawing.Point(489, 145);
            this.S_Proj.Name = "S_Proj";
            this.S_Proj.Size = new System.Drawing.Size(100, 23);
            this.S_Proj.TabIndex = 7;
            this.S_Proj.TextChanged += new System.EventHandler(this.S_Proj_TextChanged);
            // 
            // S_name
            // 
            this.S_name.Location = new System.Drawing.Point(489, 48);
            this.S_name.Name = "S_name";
            this.S_name.Size = new System.Drawing.Size(100, 23);
            this.S_name.TabIndex = 8;
            this.S_name.TextChanged += new System.EventHandler(this.S_name_TextChanged);
            // 
            // ResultData
            // 
            this.ResultData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IID,
            this.name,
            this.Gender,
            this.Department});
            this.ResultData.Location = new System.Drawing.Point(177, 265);
            this.ResultData.Name = "ResultData";
            this.ResultData.RowTemplate.Height = 25;
            this.ResultData.Size = new System.Drawing.Size(447, 150);
            this.ResultData.TabIndex = 9;
            this.ResultData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResultData_CellContentClick);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(549, 234);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 10;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // IID
            // 
            this.IID.HeaderText = "ID";
            this.IID.Name = "IID";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Column1";
            this.Gender.Name = "Gender";
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ResultData);
            this.Controls.Add(this.S_name);
            this.Controls.Add(this.S_Proj);
            this.Controls.Add(this.S_id);
            this.Controls.Add(this.S_Dep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox S_Dep;
        private System.Windows.Forms.TextBox S_id;
        private System.Windows.Forms.TextBox S_Proj;
        private System.Windows.Forms.TextBox S_name;
        private System.Windows.Forms.DataGridView ResultData;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
    }
}