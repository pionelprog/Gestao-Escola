using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GestEscola
{
    public partial class frmalunos : Form
    {
        public frmalunos()
        {
            InitializeComponent();
            listdados.SelectedIndexChanged += listdados_SelectedIndexChanged; 
            SetupListView(); 
        }

        private void SetupListView()
        {
            listdados.View = View.Details;
            listdados.FullRowSelect = true;
            listdados.GridLines = true;
            listdados.Columns.Clear(); 
            listdados.Columns.Add("Número", 60);
            listdados.Columns.Add("Nome", 100);
            listdados.Columns.Add("Morada", 100);
            listdados.Columns.Add("Código Postal", 100);
            listdados.Columns.Add("Localidade", 100);
            listdados.Columns.Add("Caminho", 150);
        }

        private void Limpa() 
        {
            txtnum.Text = "";
            txtnome.Text = "";
            txtmorada.Text = "";
            txtcodigopos.Text = "";
            txtlocalidade.Text = "";
            txtcaminho.Text = "";
            picfoto.Image = null;

        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (listdados.SelectedItems.Count > 0) 
            {
                txtnum.Text = listdados.SelectedItems[0].SubItems[0].Text;
                txtnome.Text = listdados.SelectedItems[0].SubItems[1].Text;
                txtmorada.Text = listdados.SelectedItems[0].SubItems[2].Text;
                txtcodigopos.Text = listdados.SelectedItems[0].SubItems[3].Text;
                txtlocalidade.Text = listdados.SelectedItems[0].SubItems[4].Text;
                txtcaminho.Text = listdados.SelectedItems[0].SubItems[5].Text;
                
                picfoto.Image = Image.FromFile(txtcaminho.Text);


                listdados.Items.Remove(listdados.SelectedItems[0]);
            }
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnum.Text))
            {
                MessageBox.Show("O Parâmetro Número não foi completo.");
                txtnum.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {
                MessageBox.Show("O Parâmetro Nome não foi completo.");
                txtnome.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtmorada.Text))
            {
                MessageBox.Show("O Parâmetro Morada não foi completo.");
                txtmorada.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtcodigopos.Text))
            {
                MessageBox.Show("O Parâmetro Código Postal não foi completo.");
                txtcodigopos.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtlocalidade.Text))
            {
                MessageBox.Show("O Parâmetro Localidade não foi completo.");
                txtlocalidade.Focus();
                return;
            }
            

            
            ListViewItem item = new ListViewItem(txtnum.Text);
            item.SubItems.Add(txtnome.Text);
            item.SubItems.Add(txtmorada.Text);
            item.SubItems.Add(txtcodigopos.Text);
            item.SubItems.Add(txtlocalidade.Text);
            item.SubItems.Add(txtcaminho.Text);
            listdados.Items.Add(item);

           
            Limpa();
        }

        private void btnimagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ficheiros de Imagem |*.jpg; *.png; *.bmp; *.svg; *.gif";
            ofd.Title = "Escolha uma imagem";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picfoto.Image = Image.FromFile(ofd.FileName);

                txtcaminho.Text = ofd.FileName;
            }
        }

        private void listdados_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmalunos_Load(object sender, EventArgs e)
        {

        }
    }
}
