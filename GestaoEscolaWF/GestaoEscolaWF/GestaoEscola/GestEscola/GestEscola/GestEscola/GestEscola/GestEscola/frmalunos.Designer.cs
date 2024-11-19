namespace GestEscola
{
    partial class frmalunos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtmorada = new System.Windows.Forms.TextBox();
            this.txtcodigopos = new System.Windows.Forms.TextBox();
            this.txtlocalidade = new System.Windows.Forms.TextBox();
            this.listdados = new System.Windows.Forms.ListView();
            this.picfoto = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.akunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnimagem = new System.Windows.Forms.Button();
            this.txtcaminho = new System.Windows.Forms.TextBox();
            btnsalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = System.Drawing.Color.Moccasin;
            btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnsalvar.ForeColor = System.Drawing.Color.Chocolate;
            btnsalvar.Location = new System.Drawing.Point(422, 63);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new System.Drawing.Size(305, 153);
            btnsalvar.TabIndex = 14;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = false;
            btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Morada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código Postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Localidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fotografia";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(155, 63);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(186, 20);
            this.txtnum.TabIndex = 7;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(155, 89);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(186, 20);
            this.txtnome.TabIndex = 8;
            // 
            // txtmorada
            // 
            this.txtmorada.Location = new System.Drawing.Point(155, 115);
            this.txtmorada.Name = "txtmorada";
            this.txtmorada.Size = new System.Drawing.Size(186, 20);
            this.txtmorada.TabIndex = 9;
            // 
            // txtcodigopos
            // 
            this.txtcodigopos.Location = new System.Drawing.Point(155, 141);
            this.txtcodigopos.Name = "txtcodigopos";
            this.txtcodigopos.Size = new System.Drawing.Size(186, 20);
            this.txtcodigopos.TabIndex = 10;
            // 
            // txtlocalidade
            // 
            this.txtlocalidade.Location = new System.Drawing.Point(155, 171);
            this.txtlocalidade.Name = "txtlocalidade";
            this.txtlocalidade.Size = new System.Drawing.Size(186, 20);
            this.txtlocalidade.TabIndex = 11;
            // 
            // listdados
            // 
            this.listdados.HideSelection = false;
            this.listdados.Location = new System.Drawing.Point(17, 299);
            this.listdados.Name = "listdados";
            this.listdados.Size = new System.Drawing.Size(771, 147);
            this.listdados.TabIndex = 13;
            this.listdados.UseCompatibleStateImageBehavior = false;
            this.listdados.SelectedIndexChanged += new System.EventHandler(this.listdados_SelectedIndexChanged);
            this.listdados.DoubleClick += new System.EventHandler(this.listView1_DoubleClick_1);
            // 
            // picfoto
            // 
            this.picfoto.Location = new System.Drawing.Point(155, 222);
            this.picfoto.Name = "picfoto";
            this.picfoto.Size = new System.Drawing.Size(89, 71);
            this.picfoto.TabIndex = 15;
            this.picfoto.TabStop = false;
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
            this.menuStrip1.TabIndex = 16;
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
            // btnimagem
            // 
            this.btnimagem.Location = new System.Drawing.Point(260, 222);
            this.btnimagem.Name = "btnimagem";
            this.btnimagem.Size = new System.Drawing.Size(181, 35);
            this.btnimagem.TabIndex = 20;
            this.btnimagem.Text = "Escolher a imagem";
            this.btnimagem.UseVisualStyleBackColor = true;
            this.btnimagem.Click += new System.EventHandler(this.btnimagem_Click);
            // 
            // txtcaminho
            // 
            this.txtcaminho.Location = new System.Drawing.Point(260, 273);
            this.txtcaminho.Name = "txtcaminho";
            this.txtcaminho.Size = new System.Drawing.Size(467, 20);
            this.txtcaminho.TabIndex = 21;
            // 
            // frmalunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcaminho);
            this.Controls.Add(this.btnimagem);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picfoto);
            this.Controls.Add(btnsalvar);
            this.Controls.Add(this.listdados);
            this.Controls.Add(this.txtlocalidade);
            this.Controls.Add(this.txtcodigopos);
            this.Controls.Add(this.txtmorada);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmalunos";
            this.Text = "frmalunos";
            this.Load += new System.EventHandler(this.frmalunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtmorada;
        private System.Windows.Forms.TextBox txtcodigopos;
        private System.Windows.Forms.TextBox txtlocalidade;
        private System.Windows.Forms.ListView listdados;
        private System.Windows.Forms.PictureBox picfoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem akunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnimagem;
        private System.Windows.Forms.TextBox txtcaminho;
    }
}