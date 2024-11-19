using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestEscola
{
    public partial class frmcursos : Form
    {
        private void limpar()
        {
            txtcodcurso.Clear();
            txtnomecurso.Clear();
            txtcodcurso.Focus();
        }
        public frmcursos()
        {
            InitializeComponent();
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcodcurso.Text) || string.IsNullOrWhiteSpace(txtnomecurso.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtcodcurso.Text, out int codigoCurso))
            {
                MessageBox.Show("O código do curso deve ser um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var cursoExistente in Escola.ListaCursos)
            {
                if (cursoExistente.CodigoCurso == codigoCurso)
                {
                    MessageBox.Show("O código do curso já foi registrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cursoExistente.NomeCurso.Equals(txtnomecurso.Text, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("O nome do curso já foi registrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Curso novoCurso = new Curso
            {
                CodigoCurso = codigoCurso,
                NomeCurso = txtnomecurso.Text
            };
            Escola.ListaCursos.Add(novoCurso);

            MessageBox.Show("Curso salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            PreencherListViewComCursos();
            limpar();
        }
        private void PreencherListViewComCursos()
        {
            listViewcursos.Items.Clear();

            listViewcursos.Columns.Clear();
            listViewcursos.Columns.Add("Código", 100);
            listViewcursos.Columns.Add("Nome", 100);

            foreach (var curso in Escola.ListaCursos)
            {
                ListViewItem item = new ListViewItem(curso.CodigoCurso.ToString());
                item.SubItems.Add(curso.NomeCurso);
                listViewcursos.Items.Add(item);
                listViewcursos.View = View.Details;
            }
            listViewcursos.View = View.Details;
            listViewcursos.FullRowSelect = true;
        }

        private void listViewcursos_DoubleClick(object sender, EventArgs e)
        {
            if (listViewcursos.SelectedItems.Count > 0)
            {
                int codigoCursoSelecionado = Convert.ToInt32(listViewcursos.SelectedItems[0].SubItems[0].Text);
                string nomeCursoSelecionado = listViewcursos.SelectedItems[0].SubItems[1].Text;

                DialogResult result = MessageBox.Show($"Deseja remover o curso '{nomeCursoSelecionado}'?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Curso cursoaRemover = Escola.ListaCursos.Find(curso => curso.CodigoCurso == codigoCursoSelecionado);
                    if (cursoaRemover != null)
                    {
                        Escola.ListaCursos.Remove(cursoaRemover);
                        PreencherListViewComCursos();
                    }
                }
            }

        }
        private void listViewcursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmcursos_Load(object sender, EventArgs e)
        {
            PreencherListViewComCursos();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}