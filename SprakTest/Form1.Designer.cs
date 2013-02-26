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
         this.SuspendLayout();
         // 
         // TestTabs
         // 
         this.TestTabs.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TestTabs.ItemSize = new System.Drawing.Size(0, 21);
         this.TestTabs.Location = new System.Drawing.Point(0, 0);
         this.TestTabs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.TestTabs.Name = "TestTabs";
         this.TestTabs.SelectedIndex = 0;
         this.TestTabs.Size = new System.Drawing.Size(800, 457);
         this.TestTabs.TabIndex = 0;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 457);
         this.Controls.Add(this.TestTabs);
         this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
         this.MinimumSize = new System.Drawing.Size(604, 495);
         this.Name = "Form1";
         this.Text = "Språktest";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TestTabs;
    }
}

