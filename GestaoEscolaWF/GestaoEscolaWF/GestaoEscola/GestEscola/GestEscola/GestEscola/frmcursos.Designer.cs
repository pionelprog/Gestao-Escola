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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodcurso = new System.Windows.Forms.TextBox();
            this.txtnomecurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewcursos = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnsalvar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalvar
            // 
            btnsalvar.BackColor = System.Drawing.Color.Gray;
            btnsalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnsalvar.ForeColor = System.Drawing.SystemColors.Control;
            btnsalvar.Location = new System.Drawing.Point(931, 104);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new System.Drawing.Size(222, 175);
            btnsalvar.TabIndex = 15;
            btnsalvar.Text = "Guardar";
            btnsalvar.UseVisualStyleBackColor = false;
            btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Curso";
            // 
            // txtcodcurso
            // 
            this.txtcodcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodcurso.Location = new System.Drawing.Point(549, 142);
            this.txtcodcurso.Name = "txtcodcurso";
            this.txtcodcurso.Size = new System.Drawing.Size(100, 32);
            this.txtcodcurso.TabIndex = 4;
            // 
            // txtnomecurso
            // 
            this.txtnomecurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomecurso.Location = new System.Drawing.Point(549, 210);
            this.txtnomecurso.Name = "txtnomecurso";
            this.txtnomecurso.Size = new System.Drawing.Size(182, 32);
            this.txtnomecurso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(471, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cursos";
            // 
            // listViewcursos
            // 
            this.listViewcursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewcursos.HideSelection = false;
            this.listViewcursos.Location = new System.Drawing.Point(312, 319);
            this.listViewcursos.Name = "listViewcursos";
            this.listViewcursos.Size = new System.Drawing.Size(486, 207);
            this.listViewcursos.TabIndex = 16;
            this.listViewcursos.UseCompatibleStateImageBehavior = false;
            this.listViewcursos.SelectedIndexChanged += new System.EventHandler(this.listViewcursos_SelectedIndexChanged);
            this.listViewcursos.DoubleClick += new System.EventHandler(this.listViewcursos_DoubleClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(1270, 37);
            this.menuStrip1.TabIndex = 17;
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
            // frmcursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 576);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewcursos);
            this.Controls.Add(btnsalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnomecurso);
            this.Controls.Add(this.txtcodcurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmcursos";
            this.Text = "frmcursos";
            this.Load += new System.EventHandler(this.frmcursos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodcurso;
        private System.Windows.Forms.TextBox txtnomecurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewcursos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}