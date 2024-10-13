namespace Assignment2_datagrid_
{
    partial class HadiqaTulZahra
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btn_Add = new Button();
            label5 = new Label();
            txt_CT = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_G = new TextBox();
            txt_S = new TextBox();
            txt_OM = new TextBox();
            txt_CC = new TextBox();
            label6 = new Label();
            btn_Exit = new Button();
            btn_Print = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1242, 240);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btn_Add);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_CT);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_G);
            groupBox1.Controls.Add(txt_S);
            groupBox1.Controls.Add(txt_OM);
            groupBox1.Controls.Add(txt_CC);
            groupBox1.Location = new Point(8, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1242, 69);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.RosyBrown;
            btn_Add.ForeColor = Color.White;
            btn_Add.Location = new Point(1123, 18);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(105, 34);
            btn_Add.TabIndex = 10;
            btn_Add.Text = "Add ";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(934, 22);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 9;
            label5.Text = "Status";
            // 
            // txt_CT
            // 
            txt_CT.Location = new Point(347, 20);
            txt_CT.Multiline = true;
            txt_CT.Name = "txt_CT";
            txt_CT.Size = new Size(146, 31);
            txt_CT.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(759, 22);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 8;
            label4.Text = "Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(499, 22);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 7;
            label3.Text = "Obtained_Marks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 22);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 6;
            label2.Text = "Course_Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 5;
            label1.Text = "Course_Code";
            // 
            // txt_G
            // 
            txt_G.Location = new Point(835, 19);
            txt_G.Multiline = true;
            txt_G.Name = "txt_G";
            txt_G.Size = new Size(90, 31);
            txt_G.TabIndex = 4;
            // 
            // txt_S
            // 
            txt_S.Location = new Point(1004, 19);
            txt_S.Name = "txt_S";
            txt_S.Size = new Size(108, 31);
            txt_S.TabIndex = 3;
            // 
            // txt_OM
            // 
            txt_OM.Location = new Point(640, 20);
            txt_OM.Name = "txt_OM";
            txt_OM.Size = new Size(108, 31);
            txt_OM.TabIndex = 2;
            // 
            // txt_CC
            // 
            txt_CC.Location = new Point(126, 21);
            txt_CC.Name = "txt_CC";
            txt_CC.Size = new Size(108, 31);
            txt_CC.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(545, 134);
            label6.Name = "label6";
            label6.Size = new Size(219, 45);
            label6.TabIndex = 2;
            label6.Text = "Show Courses";
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.RosyBrown;
            btn_Exit.ForeColor = Color.White;
            btn_Exit.Location = new Point(1131, 456);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(105, 34);
            btn_Exit.TabIndex = 11;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click_1;
            // 
            // btn_Print
            // 
            btn_Print.BackColor = Color.RosyBrown;
            btn_Print.ForeColor = Color.White;
            btn_Print.Location = new Point(1012, 456);
            btn_Print.Name = "btn_Print";
            btn_Print.Size = new Size(105, 34);
            btn_Print.TabIndex = 12;
            btn_Print.Text = "Print";
            btn_Print.UseVisualStyleBackColor = false;
            btn_Print.Click += btn_Print_Click_1;
            // 
            // HadiqaTulZahra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(1257, 529);
            Controls.Add(btn_Print);
            Controls.Add(btn_Exit);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "HadiqaTulZahra";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox txt_CC;
        private TextBox txt_G;
        private TextBox txt_S;
        private TextBox txt_OM;
        private TextBox txt_CT;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Add;
        private Label label6;
        private Button btn_Exit;
        private Button btn_Print;
    }
}
