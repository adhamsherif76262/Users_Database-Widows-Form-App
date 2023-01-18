
namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.show = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.checkedListBox1_Project = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID";
            // 
            // Txt_id
            // 
            this.Txt_id.Location = new System.Drawing.Point(293, 33);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(100, 23);
            this.Txt_id.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(293, 82);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 23);
            this.txt_name.TabIndex = 6;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Location = new System.Drawing.Point(299, 138);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(51, 19);
            this.radio_male.TabIndex = 7;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Male";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Location = new System.Drawing.Point(409, 134);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(63, 19);
            this.radio_female.TabIndex = 8;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Female";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(134, 384);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 11;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmb_department
            // 
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Items.AddRange(new object[] {
            "d1",
            "d2",
            "d3"});
            this.cmb_department.Location = new System.Drawing.Point(299, 197);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(121, 23);
            this.cmb_department.TabIndex = 14;
            // 
            // checkedListBox1_Project
            // 
            this.checkedListBox1_Project.FormattingEnabled = true;
            this.checkedListBox1_Project.Items.AddRange(new object[] {
            "p1",
            "p2",
            "p3"});
            this.checkedListBox1_Project.Location = new System.Drawing.Point(293, 254);
            this.checkedListBox1_Project.Name = "checkedListBox1_Project";
            this.checkedListBox1_Project.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1_Project.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1_Project);
            this.Controls.Add(this.cmb_department);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.show);
            this.Controls.Add(this.radio_female);
            this.Controls.Add(this.radio_male);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.CheckedListBox d;
        private System.Windows.Forms.CheckedListBox checkedListBox1_Project;
    }
}

