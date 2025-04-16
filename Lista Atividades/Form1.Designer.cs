namespace Lista_Atividades
{
    partial class ListaDeAtividades
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
            txtAtividadeEmAndamento = new TextBox();
            btnFinalizar = new Button();
            dgvAtividades = new DataGridView();
            btnAtualizar = new Button();
            btnCriar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAtividades).BeginInit();
            SuspendLayout();
            // 
            // txtAtividadeEmAndamento
            // 
            txtAtividadeEmAndamento.Location = new Point(12, 12);
            txtAtividadeEmAndamento.Name = "txtAtividadeEmAndamento";
            txtAtividadeEmAndamento.ReadOnly = true;
            txtAtividadeEmAndamento.Size = new Size(310, 23);
            txtAtividadeEmAndamento.TabIndex = 0;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(328, 12);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(71, 23);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // dgvAtividades
            // 
            dgvAtividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAtividades.Location = new Point(12, 41);
            dgvAtividades.Name = "dgvAtividades";
            dgvAtividades.Size = new Size(310, 174);
            dgvAtividades.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(328, 41);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(71, 23);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCriar
            // 
            btnCriar.Location = new Point(328, 70);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(71, 23);
            btnCriar.TabIndex = 1;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            // 
            // ListaDeAtividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 457);
            Controls.Add(dgvAtividades);
            Controls.Add(btnCriar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnFinalizar);
            Controls.Add(txtAtividadeEmAndamento);
            Name = "ListaDeAtividades";
            Text = "Lista de Atividades";
            Load += ListaDeAtividades_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAtividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAtividadeEmAndamento;
        private Button btnFinalizar;
        private DataGridView dgvAtividades;
        private Button btnAtualizar;
        private Button btnCriar;
    }
}
