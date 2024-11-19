using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestEscola
{
    public partial class frmalunos : Form
    {
        public Aluno novoAluno { get; private set; }

        public frmalunos()
        {
            InitializeComponent();
            PreencherComboBoxcomCursos();
        }

        private void PreencherComboBoxcomCursos()
        {
            comboBoxCursos.Items.Clear();

            foreach (var curso in Escola.ListaCursos)
            {
                comboBoxCursos.Items.Add(curso.CodigoCurso+ "-" + curso.NomeCurso);
            }

            comboBoxCursos.SelectedIndex = -1;
        }

        private void PreencherListViewComAlunos()
        {
            listdados.Items.Clear();

            listdados.Columns.Clear();
            listdados.Columns.Add("Número", 120);
            listdados.Columns.Add("Nome", 200);
            listdados.Columns.Add("Morada", 200);
            listdados.Columns.Add("Código Postal", 200);
            listdados.Columns.Add("Localidade", 200);
            listdados.Columns.Add("Caminho", 200);
            listdados.Columns.Add("Cursos", 200);
            listdados.Columns.Add("Género", 140);

            foreach (var aluno in Escola.ListaAlunos)
            {
                ListViewItem item = new ListViewItem(aluno.Numero.ToString());
                item.SubItems.Add(aluno.Nome);
                item.SubItems.Add(aluno.morada);
                item.SubItems.Add(aluno.codigopos);
                item.SubItems.Add(aluno.localidade);
                item.SubItems.Add(aluno.Foto);
                item.SubItems.Add(aluno.Curso);
                item.SubItems.Add(aluno.Genero);
                listdados.Items.Add(item);
            }

            listdados.View = View.Details;
            listdados.FullRowSelect = true;
        }

        private void Limpa()
        {
            txtnum.Clear();
            txtnome.Clear();
            txtmorada.Clear();
            txtcodigopos.Clear();
            txtlocalidade.Clear();
            txtcaminho.Clear();
            comboBoxCursos.SelectedIndex = -1;
            picfoto.Image = null;
            radioBTNMasc.Checked = false;
            RadioBTNFem.Checked = false;
        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (listdados.SelectedItems.Count > 0)
            {
                int numeroSelecionado = Convert.ToInt32(listdados.SelectedItems[0].SubItems[0].Text);
                Aluno alunoSelecionado = Escola.ListaAlunos.Find(aluno => aluno.Numero == numeroSelecionado);

                DialogResult result = MessageBox.Show("Deseja remover este aluno?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Escola.ListaAlunos.Remove(alunoSelecionado);

                    Limpa();

                    PreencherListViewComAlunos();
                }
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

            string genero = radioBTNMasc.Checked ? "Masculino" : (RadioBTNFem.Checked ? "Feminino" : "");
            if (string.IsNullOrWhiteSpace(genero))
            {
                MessageBox.Show("O Parâmetro Género não foi completo.");
                radioBTNMasc.Checked = true;
                RadioBTNFem.Checked = false;
                return;
            }

            foreach (var alunoexistente in Escola.ListaAlunos)
            {
                if (alunoexistente.Numero == Convert.ToInt16(txtnum.Text))
                {
                    MessageBox.Show("O código do aluno já foi registrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (alunoexistente.Foto == txtcaminho.Text)
                {
                    MessageBox.Show("Esta imagem já foi associada a outro aluno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string cursoSelecionado = comboBoxCursos.SelectedItem.ToString().Split('-')[1].Trim();

            if (string.IsNullOrWhiteSpace(cursoSelecionado))
            {
                MessageBox.Show("Selecione um curso válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Aluno novoAluno = new Aluno();
            novoAluno.Numero = Convert.ToInt16(txtnum.Text);
            novoAluno.Nome = txtnome.Text;
            novoAluno.morada = txtmorada.Text;
            novoAluno.codigopos = txtcodigopos.Text;
            novoAluno.localidade = txtlocalidade.Text;
            novoAluno.Foto = txtcaminho.Text;
            novoAluno.Curso = cursoSelecionado; 
            novoAluno.Genero = genero;

            Escola.ListaAlunos.Add(novoAluno);

            PreencherListViewComAlunos();
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

                picfoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void listdados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmalunos_Load(object sender, EventArgs e)
        {
            PreencherListViewComAlunos();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

