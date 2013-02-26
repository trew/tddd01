namespace SprakTest
{
    partial class Form1
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

         this.TestTabs = new System.Windows.Forms.TabControl();
         this.Profile = new System.Windows.Forms.TabPage();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.gender_label = new System.Windows.Forms.Label();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.man_radiobutton = new System.Windows.Forms.RadioButton();
         this.woman_radiobutton = new System.Windows.Forms.RadioButton();
         this.age_label = new System.Windows.Forms.Label();
         this.age_box = new System.Windows.Forms.NumericUpDown();
         this.TestTabs.SuspendLayout();
         this.Profile.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.age_box)).BeginInit();
         this.SuspendLayout();
         // 
         // TestTabs
         // 
         this.TestTabs.Controls.Add(this.Profile);
         this.TestTabs.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TestTabs.ItemSize = new System.Drawing.Size(0, 21);
         this.TestTabs.Location = new System.Drawing.Point(0, 0);
         this.TestTabs.Margin = new System.Windows.Forms.Padding(2);
         this.TestTabs.Name = "TestTabs";
         this.TestTabs.SelectedIndex = 0;
         this.TestTabs.Size = new System.Drawing.Size(800, 457);
         this.TestTabs.TabIndex = 0;
         // 
         // Profile
         // 
         this.Profile.Controls.Add(this.tableLayoutPanel1);
         this.Profile.Location = new System.Drawing.Point(4, 25);
         this.Profile.Name = "Profile";
         this.Profile.Padding = new System.Windows.Forms.Padding(3);
         this.Profile.Size = new System.Drawing.Size(792, 428);
         this.Profile.TabIndex = 0;
         this.Profile.Text = "Profile";
         this.Profile.UseVisualStyleBackColor = true;
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.24682F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.75318F));
         this.tableLayoutPanel1.Controls.Add(this.gender_label, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.age_label, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.age_box, 1, 1);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 2;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 422);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // gender_label
         // 
         this.gender_label.AutoSize = true;
         this.gender_label.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gender_label.Location = new System.Drawing.Point(4, 1);
         this.gender_label.Name = "gender_label";
         this.gender_label.Size = new System.Drawing.Size(160, 30);
         this.gender_label.TabIndex = 0;
         this.gender_label.Text = "Kön";
         this.gender_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(171, 4);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.man_radiobutton);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.woman_radiobutton);
         this.splitContainer1.Size = new System.Drawing.Size(611, 24);
         this.splitContainer1.SplitterDistance = 129;
         this.splitContainer1.TabIndex = 1;
         // 
         // man_radiobutton
         // 
         this.man_radiobutton.AutoSize = true;
         this.man_radiobutton.Dock = System.Windows.Forms.DockStyle.Fill;
         this.man_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.man_radiobutton.Location = new System.Drawing.Point(0, 0);
         this.man_radiobutton.Name = "man_radiobutton";
         this.man_radiobutton.Size = new System.Drawing.Size(129, 24);
         this.man_radiobutton.TabIndex = 0;
         this.man_radiobutton.TabStop = true;
         this.man_radiobutton.Text = "Man";
         this.man_radiobutton.UseVisualStyleBackColor = true;
         // 
         // woman_radiobutton
         // 
         this.woman_radiobutton.AutoSize = true;
         this.woman_radiobutton.Dock = System.Windows.Forms.DockStyle.Fill;
         this.woman_radiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.woman_radiobutton.Location = new System.Drawing.Point(0, 0);
         this.woman_radiobutton.Name = "woman_radiobutton";
         this.woman_radiobutton.Size = new System.Drawing.Size(478, 24);
         this.woman_radiobutton.TabIndex = 0;
         this.woman_radiobutton.TabStop = true;
         this.woman_radiobutton.Text = "Kvinna";
         this.woman_radiobutton.UseVisualStyleBackColor = true;
         // 
         // age_label
         // 
         this.age_label.AutoSize = true;
         this.age_label.Dock = System.Windows.Forms.DockStyle.Right;
         this.age_label.Location = new System.Drawing.Point(87, 32);
         this.age_label.Name = "age_label";
         this.age_label.Size = new System.Drawing.Size(77, 389);
         this.age_label.TabIndex = 2;
         this.age_label.Text = "Ålder";
         // 
         // age_box
         // 
         this.age_box.Dock = System.Windows.Forms.DockStyle.Left;
         this.age_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.age_box.Location = new System.Drawing.Point(171, 35);
         this.age_box.Name = "age_box";
         this.age_box.Size = new System.Drawing.Size(77, 26);
         this.age_box.TabIndex = 3;
         this.age_box.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 457);
         this.Controls.Add(this.TestTabs);
         this.Margin = new System.Windows.Forms.Padding(2);
         this.MinimumSize = new System.Drawing.Size(604, 495);
         this.Name = "Form1";
         this.Text = "Språktest";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.TestTabs.ResumeLayout(false);
         this.Profile.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         this.splitContainer1.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.age_box)).EndInit();
         this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl TestTabs;
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RadioButton man_radiobutton;
        private System.Windows.Forms.RadioButton woman_radiobutton;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.NumericUpDown age_box;
    }
}

