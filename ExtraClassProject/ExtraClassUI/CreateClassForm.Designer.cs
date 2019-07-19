namespace ExtraClassUI
{
    partial class CreateClassForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classNameTb = new System.Windows.Forms.TextBox();
            this.teacherCbb = new System.Windows.Forms.ComboBox();
            this.createClassBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classLv = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createClassBtn);
            this.groupBox1.Controls.Add(this.teacherCbb);
            this.groupBox1.Controls.Add(this.classNameTb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CREATE NEW CLASS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class Name";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teacher";
            // 
            // classNameTb
            // 
            this.classNameTb.Location = new System.Drawing.Point(129, 76);
            this.classNameTb.Name = "classNameTb";
            this.classNameTb.Size = new System.Drawing.Size(167, 20);
            this.classNameTb.TabIndex = 2;
            // 
            // teacherCbb
            // 
            this.teacherCbb.FormattingEnabled = true;
            this.teacherCbb.Location = new System.Drawing.Point(129, 144);
            this.teacherCbb.Name = "teacherCbb";
            this.teacherCbb.Size = new System.Drawing.Size(167, 21);
            this.teacherCbb.TabIndex = 3;
            // 
            // createClassBtn
            // 
            this.createClassBtn.Location = new System.Drawing.Point(84, 210);
            this.createClassBtn.Name = "createClassBtn";
            this.createClassBtn.Size = new System.Drawing.Size(108, 23);
            this.createClassBtn.TabIndex = 4;
            this.createClassBtn.Text = "Create new class";
            this.createClassBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.classLv);
            this.groupBox2.Location = new System.Drawing.Point(397, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 358);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Class";
            // 
            // classLv
            // 
            this.classLv.Location = new System.Drawing.Point(27, 35);
            this.classLv.Name = "classLv";
            this.classLv.Size = new System.Drawing.Size(326, 301);
            this.classLv.TabIndex = 0;
            this.classLv.UseCompatibleStateImageBehavior = false;
            // 
            // CreateClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateClassForm";
            this.Text = "CreateClassForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createClassBtn;
        private System.Windows.Forms.ComboBox teacherCbb;
        private System.Windows.Forms.TextBox classNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView classLv;
    }
}