namespace Classroom_Allocation_System
{
    partial class Operation
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
            this.Book = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Book
            // 
            this.Book.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Book.Location = new System.Drawing.Point(414, 160);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(200, 76);
            this.Book.TabIndex = 1;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.button2_Click);
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Change.Location = new System.Drawing.Point(414, 287);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(200, 76);
            this.Change.TabIndex = 2;
            this.Change.Text = "Change";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(414, 417);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(200, 76);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.Back.Location = new System.Drawing.Point(770, 630);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 37);
            this.Back.TabIndex = 4;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(408, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Operation";
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Book);
            this.Name = "Operation";
            this.Text = "Operation";
            this.Load += new System.EventHandler(this.Operation_Load);
            this.Controls.SetChildIndex(this.Book, 0);
            this.Controls.SetChildIndex(this.Change, 0);
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.Back, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
    }
}