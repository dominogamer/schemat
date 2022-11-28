namespace schemat_oragnizacyjny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void galazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "dodawanie ga³êzi";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Add(dialog.nazwa);
            }
        }

        private void podgalazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "dodawanie podga³êzi";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Nodes.Add(dialog.nazwa);
            }
        }

        private void zmienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Modyfikowanie ga³êzi";
            dialog.nazwa = treeView1.SelectedNode.Text; 

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Text = dialog.nazwa;
            }

        }

        private void usunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
      
            private void DodajDoListy(TreeNode node, ref List<myNode> lista)
            {
                if (node == null)
                    return;
                string r, n;
                if (node.Parent == null)
                    r = "brak";
                else
                    r = node.Parent.Text;
                n = node.Text;
                lista.Add(new myNode(r, n));
                if (node.NextNode != null)
                    DodajDoListy(node, ref lista);
                if (node.GetNodeCount (true) > 0)
                DodajDoListy(node.FirstNode, ref lista);

        }
        private void ZapisDoPLiku()
        {
            List<myNode> lista = new List<myNode>();
            DodajDoListy(treeView1.Nodes[0], ref lista);
            if (lista.Count == 0)
                return;
            string text = "";
            foreach (myNode elem in lista)
            {
                text += elem.nazwa + "" + elem.rodzic + "\n";
            }
            File.WriteAllText("firma.txt", text);
     }

        private void button1_Click(object sender, EventArgs e)
        {
            ZapisDoPLiku();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Zapisaæ zmiany przed zamknieciem?", "Zamykanie", MessageBoxButtons.YesNoCancel);
            if (res ==DialogResult.Yes)
            {
                ZapisDoPLiku();
                Application.Exit();

            }
            else if (res == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
    public class myNode
    {
        public string rodzic;
        public string nazwa;

        public myNode(string rodzic, string nazwa)
        {
            this.rodzic = rodzic;
            this.nazwa = nazwa;
        }
    }
    
}