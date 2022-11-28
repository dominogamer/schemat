namespace schemat_oragnizacyjny
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.galazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podgalazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.galazToolStripMenuItem,
            this.podgalazToolStripMenuItem,
            this.usunToolStripMenuItem,
            this.zmienToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // galazToolStripMenuItem
            // 
            this.galazToolStripMenuItem.Name = "galazToolStripMenuItem";
            this.galazToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.galazToolStripMenuItem.Text = "galaz";
            this.galazToolStripMenuItem.Click += new System.EventHandler(this.galazToolStripMenuItem_Click);
            // 
            // podgalazToolStripMenuItem
            // 
            this.podgalazToolStripMenuItem.Name = "podgalazToolStripMenuItem";
            this.podgalazToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.podgalazToolStripMenuItem.Text = "podgalaz";
            this.podgalazToolStripMenuItem.Click += new System.EventHandler(this.podgalazToolStripMenuItem_Click);
            // 
            // usunToolStripMenuItem
            // 
            this.usunToolStripMenuItem.Name = "usunToolStripMenuItem";
            this.usunToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.usunToolStripMenuItem.Text = "usun";
            this.usunToolStripMenuItem.Click += new System.EventHandler(this.usunToolStripMenuItem_Click);
            // 
            // zmienToolStripMenuItem
            // 
            this.zmienToolStripMenuItem.Name = "zmienToolStripMenuItem";
            this.zmienToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.zmienToolStripMenuItem.Text = "zmien";
            this.zmienToolStripMenuItem.Click += new System.EventHandler(this.zmienToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(55, 45);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(255, 368);
            this.treeView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem galazToolStripMenuItem;
        private ToolStripMenuItem podgalazToolStripMenuItem;
        private ToolStripMenuItem usunToolStripMenuItem;
        private ToolStripMenuItem zmienToolStripMenuItem;
        private TreeView treeView1;
        private Button button1;
        private Button button2;
    }
}