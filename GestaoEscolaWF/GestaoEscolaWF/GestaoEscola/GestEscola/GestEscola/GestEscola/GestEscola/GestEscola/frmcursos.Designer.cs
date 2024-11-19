namespace GestEscola
{
    partial class frmcursos
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
            System.Windows.Forms.Button btnsalvar;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.akunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codcurso = new System.Windows.Forms.TextBox();
            this.numcurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listdados = new System.Windows.Forms.ListView();
            btnsalvar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Moccasin;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akunosToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // akunosToolStripMenuItem
            // 
            this.akunosToolStripMenuItem.Name = "akunosToolStripMenuItem";
            this.akunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.akunosToolStripMenuItem.Text = "Alunos";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Curso";
            // 
            // codcurso
            // 
            this.codcurso.Location = new System.Drawing.Point(162, 180);
            this.codcurso.Name = "codcurso";
            this.codcurso.Size = new System.Drawing.Size(100, 20);
            this.codcurso.TabIndex = 4;
            // 
            // numcurso
            // 
            this.numcurso.Location = new System.Drawing.Point(162, 210);
            this.numcurso.Name = "numcurso";
            this.numcurso.Size = new System.Drawing.Size(324, 20);
            this.numcurso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(313, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cursos";
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = System.Drawing.Color.Moccasin;
            btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnsalvar.ForeColor = System.Drawing.Color.Chocolate;
            btnsalvar.Location = new System.Drawing.Point(533, 128);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new System.Drawing.Size(192, 110);
            btnsalvar.TabIndex = 15;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = false;
            // 
            // listdados
            // 
            this.listdados.HideSelection = false;
            this.listdados.Location = new System.Drawing.Point(12, 281);
            this.listdados.Name = "listdados";
            this.listdados.Size = new System.Drawing.Size(771, 147);
            this.listdados.TabIndex = 16;
            this.listdados.UseCompatibleStateImageBehavior = false;
            // 
            // frmcursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listdados);
            this.Controls.Add(btnsalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numcurso);
            this.Controls.Add(this.codcurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmcursos";
            this.Text = "frmcursos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem akunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codcurso;
        private System.Windows.Forms.TextBox numcurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listdados;
    }
}