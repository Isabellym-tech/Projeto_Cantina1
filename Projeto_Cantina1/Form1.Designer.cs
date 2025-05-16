namespace Projeto_Cantina1
{
    partial class Form1
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
            Nome = new TextBox();
            label1 = new Label();
            Produtos = new ListBox();
            Addq = new Button();
            Sub = new Button();
            Adicionar = new Button();
            Remover = new Button();
            Editar = new Button();
            Forma_Pagamento = new ListBox();
            label2 = new Label();
            Local = new CheckBox();
            Viagem = new CheckBox();
            SuspendLayout();
            // 
            // Nome
            // 
            Nome.Location = new Point(92, 78);
            Nome.Name = "Nome";
            Nome.Size = new Size(315, 23);
            Nome.TabIndex = 0;
            Nome.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 86);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // Produtos
            // 
            Produtos.FormattingEnabled = true;
            Produtos.ItemHeight = 15;
            Produtos.Location = new Point(93, 119);
            Produtos.Name = "Produtos";
            Produtos.Size = new Size(310, 259);
            Produtos.TabIndex = 2;
            Produtos.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Addq
            // 
            Addq.Location = new Point(490, 127);
            Addq.Name = "Addq";
            Addq.Size = new Size(37, 33);
            Addq.TabIndex = 3;
            Addq.Text = " +";
            Addq.UseVisualStyleBackColor = true;
            // 
            // Sub
            // 
            Sub.Location = new Point(422, 127);
            Sub.Name = "Sub";
            Sub.Size = new Size(45, 33);
            Sub.TabIndex = 4;
            Sub.Text = "-";
            Sub.UseVisualStyleBackColor = true;
            // 
            // Adicionar
            // 
            Adicionar.Location = new Point(428, 191);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(104, 36);
            Adicionar.TabIndex = 5;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += button3_Click;
            // 
            // Remover
            // 
            Remover.Location = new Point(428, 246);
            Remover.Name = "Remover";
            Remover.Size = new Size(104, 32);
            Remover.TabIndex = 6;
            Remover.Text = "Remover";
            Remover.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            Editar.Location = new Point(428, 305);
            Editar.Name = "Editar";
            Editar.Size = new Size(104, 30);
            Editar.TabIndex = 7;
            Editar.Text = "Editar";
            Editar.UseVisualStyleBackColor = true;
            // 
            // Forma_Pagamento
            // 
            Forma_Pagamento.FormattingEnabled = true;
            Forma_Pagamento.ItemHeight = 15;
            Forma_Pagamento.Location = new Point(734, 119);
            Forma_Pagamento.Name = "Forma_Pagamento";
            Forma_Pagamento.Size = new Size(207, 259);
            Forma_Pagamento.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(734, 81);
            label2.Name = "label2";
            label2.Size = new Size(181, 15);
            label2.TabIndex = 9;
            label2.Text = "Selecione a forma de Pagamento";
            // 
            // Local
            // 
            Local.AutoSize = true;
            Local.Location = new Point(1020, 119);
            Local.Name = "Local";
            Local.Size = new Size(110, 19);
            Local.TabIndex = 10;
            Local.Text = "Comer no Local";
            Local.UseVisualStyleBackColor = true;
            // 
            // Viagem
            // 
            Viagem.AutoSize = true;
            Viagem.Location = new Point(1020, 154);
            Viagem.Name = "Viagem";
            Viagem.Size = new Size(122, 19);
            Viagem.TabIndex = 11;
            Viagem.Text = "Levar para viagem";
            Viagem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 626);
            Controls.Add(Viagem);
            Controls.Add(Local);
            Controls.Add(label2);
            Controls.Add(Forma_Pagamento);
            Controls.Add(Editar);
            Controls.Add(Remover);
            Controls.Add(Adicionar);
            Controls.Add(Sub);
            Controls.Add(Addq);
            Controls.Add(Produtos);
            Controls.Add(label1);
            Controls.Add(Nome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nome;
        private Label label1;
        private ListBox Produtos;
        private Button Addq;
        private Button Sub;
        private Button Adicionar;
        private Button Remover;
        private Button Editar;
        private ListBox Forma_Pagamento;
        private Label label2;
        private CheckBox Local;
        private CheckBox Viagem;
    }
}
