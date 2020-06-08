namespace comparator_on_a_1D_array
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
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lstResult2 = new System.Windows.Forms.ListBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(21, 12);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(120, 277);
            this.lstResult.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(112, 342);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Compare";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lstResult2
            // 
            this.lstResult2.FormattingEnabled = true;
            this.lstResult2.Location = new System.Drawing.Point(147, 12);
            this.lstResult2.Name = "lstResult2";
            this.lstResult2.Size = new System.Drawing.Size(120, 277);
            this.lstResult2.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(70, 295);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(169, 20);
            this.txtResult.TabIndex = 3;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 377);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lstResult2);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lstResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lstResult2;
        private System.Windows.Forms.TextBox txtResult;
    }
}

