namespace GestaoTarefas.WinApp
{
    partial class ListaTarefa
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
            this.btnIncerir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrarIten = new System.Windows.Forms.Button();
            this.btnAtualizaritens = new System.Windows.Forms.Button();
            this.listListagemTarefa = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIncerir
            // 
            this.btnIncerir.Location = new System.Drawing.Point(35, 31);
            this.btnIncerir.Name = "btnIncerir";
            this.btnIncerir.Size = new System.Drawing.Size(79, 34);
            this.btnIncerir.TabIndex = 0;
            this.btnIncerir.Text = "Incerir\r\n";
            this.btnIncerir.UseVisualStyleBackColor = true;
            this.btnIncerir.Click += new System.EventHandler(this.btnIncerir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(142, 31);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(79, 34);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(244, 31);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(79, 34);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrarIten
            // 
            this.btnCadastrarIten.Location = new System.Drawing.Point(351, 31);
            this.btnCadastrarIten.Name = "btnCadastrarIten";
            this.btnCadastrarIten.Size = new System.Drawing.Size(94, 34);
            this.btnCadastrarIten.TabIndex = 3;
            this.btnCadastrarIten.Text = "Cadastrar item";
            this.btnCadastrarIten.UseVisualStyleBackColor = true;
            this.btnCadastrarIten.Click += new System.EventHandler(this.btnCadastrarIten_Click);
            // 
            // btnAtualizaritens
            // 
            this.btnAtualizaritens.Location = new System.Drawing.Point(472, 31);
            this.btnAtualizaritens.Name = "btnAtualizaritens";
            this.btnAtualizaritens.Size = new System.Drawing.Size(93, 34);
            this.btnAtualizaritens.TabIndex = 4;
            this.btnAtualizaritens.Text = "Atualizar itens";
            this.btnAtualizaritens.UseVisualStyleBackColor = true;
            // 
            // listListagemTarefa
            // 
            this.listListagemTarefa.FormattingEnabled = true;
            this.listListagemTarefa.ItemHeight = 15;
            this.listListagemTarefa.Location = new System.Drawing.Point(35, 104);
            this.listListagemTarefa.Name = "listListagemTarefa";
            this.listListagemTarefa.Size = new System.Drawing.Size(654, 244);
            this.listListagemTarefa.TabIndex = 5;
            // 
            // ListaTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(737, 394);
            this.Controls.Add(this.listListagemTarefa);
            this.Controls.Add(this.btnAtualizaritens);
            this.Controls.Add(this.btnCadastrarIten);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncerir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ListaTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Tarefas 1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIncerir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrarIten;
        private System.Windows.Forms.Button btnAtualizaritens;
        private System.Windows.Forms.ListBox listListagemTarefa;
    }
}
