namespace schemat_oragnizacyjny
{
    partial class Form2
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.bnt1 = new System.Windows.Forms.Button();
            this.bnt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(251, 187);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 23);
            this.txt1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(192, 190);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(45, 15);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Nazwa:";
            // 
            // bnt1
            // 
            this.bnt1.Location = new System.Drawing.Point(225, 252);
            this.bnt1.Name = "bnt1";
            this.bnt1.Size = new System.Drawing.Size(75, 23);
            this.bnt1.TabIndex = 2;
            this.bnt1.Text = "ok";
            this.bnt1.UseVisualStyleBackColor = true;
            // 
            // bnt2
            // 
            this.bnt2.Location = new System.Drawing.Point(330, 252);
            this.bnt2.Name = "bnt2";
            this.bnt2.Size = new System.Drawing.Size(75, 23);
            this.bnt2.TabIndex = 3;
            this.bnt2.Text = "Anuluj";
            this.bnt2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.bnt1;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bnt2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt2);
            this.Controls.Add(this.bnt1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt1;
        private Label lbl1;
        private Button bnt1;
        private Button bnt2;
    }
}