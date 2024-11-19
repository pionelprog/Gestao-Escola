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
            this.btnimagem = new System.Windows.Forms.Button();
            this.txtcaminho = new System.Windows.Forms.TextBox();
            this.comboBoxCursos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioBTNMasc = new System.Windows.Forms.RadioButton();
            this.RadioBTNFem = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnsalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = System.Drawing.Color.Gray;
            btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnsalvar.ForeColor = System.Drawing.SystemColors.Control;
            btnsalvar.Location = new System.Drawing.Point(1171, 136);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new System.Drawing.Size(508, 306);
            btnsalvar.TabIndex = 14;
            btnsalvar.Text = "Guardar";
            btnsalvar.UseVisualStyleBackColor = false;
            btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(634, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alunos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Morada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código Postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Localidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fotografia";
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(185, 60);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(314, 26);
            this.txtnum.TabIndex = 7;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(185, 92);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(314, 26);
            this.txtnome.TabIndex = 8;
            // 
            // txtmorada
            // 
            this.txtmorada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmorada.Location = new System.Drawing.Point(185, 124);
            this.txtmorada.Name = "txtmorada";
            this.txtmorada.Size = new System.Drawing.Size(314, 26);
            this.txtmorada.TabIndex = 9;
            // 
            // txtcodigopos
            // 
            this.txtcodigopos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigopos.Location = new System.Drawing.Point(185, 156);
            this.txtcodigopos.Name = "txtcodigopos";
            this.txtcodigopos.Size = new System.Drawing.Size(314, 26);
            this.txtcodigopos.TabIndex = 10;
            // 
            // txtlocalidade
            // 
            this.txtlocalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocalidade.Location = new System.Drawing.Point(185, 188);
            this.txtlocalidade.Name = "txtlocalidade";
            this.txtlocalidade.Size = new System.Drawing.Size(314, 26);
            this.txtlocalidade.TabIndex = 11;
            // 
            // listdados
            // 
            this.listdados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listdados.HideSelection = false;
            this.listdados.Location = new System.Drawing.Point(33, 591);
            this.listdados.Name = "listdados";
            this.listdados.Size = new System.Drawing.Size(1745, 385);
            this.listdados.TabIndex = 13;
            this.listdados.UseCompatibleStateImageBehavior = false;
            this.listdados.SelectedIndexChanged += new System.EventHandler(this.listdados_SelectedIndexChanged);
            this.listdados.DoubleClick += new System.EventHandler(this.listView1_DoubleClick_1);
            // 
            // picfoto
            // 
            this.picfoto.Location = new System.Drawing.Point(150, 268);
            this.picfoto.Name = "picfoto";
            this.picfoto.Size = new System.Drawing.Size(361, 256);
            this.picfoto.TabIndex = 15;
            this.picfoto.TabStop = false;
            // 
            // btnimagem
            // 
            this.btnimagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimagem.Location = new System.Drawing.Point(648, 355);
            this.btnimagem.Name = "btnimagem";
            this.btnimagem.Size = new System.Drawing.Size(341, 38);
            this.btnimagem.TabIndex = 20;
            this.btnimagem.Text = "Escolher a imagem";
            this.btnimagem.UseVisualStyleBackColor = true;
            this.btnimagem.Click += new System.EventHandler(this.btnimagem_Click);
            // 
            // txtcaminho
            // 
            this.txtcaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcaminho.Location = new System.Drawing.Point(536, 416);
            this.txtcaminho.Name = "txtcaminho";
            this.txtcaminho.Size = new System.Drawing.Size(539, 26);
            this.txtcaminho.TabIndex = 21;
            this.txtcaminho.Visible = false;
            // 
            // comboBoxCursos
            // 
            this.comboBoxCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCursos.FormattingEnabled = true;
            this.comboBoxCursos.Location = new System.Drawing.Point(185, 220);
            this.comboBoxCursos.Name = "comboBoxCursos";
            this.comboBoxCursos.Size = new System.Drawing.Size(314, 28);
            this.comboBoxCursos.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cursos";
            // 
            // radioBTNMasc
            // 
            this.radioBTNMasc.AutoSize = true;
            this.radioBTNMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBTNMasc.Location = new System.Drawing.Point(33, 550);
            this.radioBTNMasc.Name = "radioBTNMasc";
            this.radioBTNMasc.Size = new System.Drawing.Size(107, 24);
            this.radioBTNMasc.TabIndex = 24;
            this.radioBTNMasc.TabStop = true;
            this.radioBTNMasc.Text = "Masculino";
            this.radioBTNMasc.UseVisualStyleBackColor = true;
            // 
            // RadioBTNFem
            // 
            this.RadioBTNFem.AutoSize = true;
            this.RadioBTNFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBTNFem.Location = new System.Drawing.Point(238, 550);
            this.RadioBTNFem.Name = "RadioBTNFem";
            this.RadioBTNFem.Size = new System.Drawing.Size(100, 24);
            this.RadioBTNFem.TabIndex = 25;
            this.RadioBTNFem.TabStop = true;
            this.RadioBTNFem.Text = "Feminino";
            this.RadioBTNFem.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1835, 37);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(70, 33);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmalunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1835, 988);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.RadioBTNFem);
            this.Controls.Add(this.radioBTNMasc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxCursos);
            this.Controls.Add(this.txtcaminho);
            this.Controls.Add(this.btnimagem);
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
        private System.Windows.Forms.Button btnimagem;
        private System.Windows.Forms.TextBox txtcaminho;
        private System.Windows.Forms.ComboBox comboBoxCursos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioBTNMasc;
        private System.Windows.Forms.RadioButton RadioBTNFem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}