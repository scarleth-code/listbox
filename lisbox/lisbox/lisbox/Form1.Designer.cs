namespace lisbox
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
            btagregar = new Button();
            btcopiar = new Button();
            btborrar = new Button();
            cmbcontinente = new ComboBox();
            lstpais = new ListBox();
            lstlista = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btagregar
            // 
            btagregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btagregar.Location = new Point(365, 80);
            btagregar.Name = "btagregar";
            btagregar.Size = new Size(94, 29);
            btagregar.TabIndex = 0;
            btagregar.Text = "agregar";
            btagregar.UseVisualStyleBackColor = true;
            btagregar.Click += button1_Click;
            // 
            // btcopiar
            // 
            btcopiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btcopiar.Location = new Point(311, 186);
            btcopiar.Name = "btcopiar";
            btcopiar.Size = new Size(94, 29);
            btcopiar.TabIndex = 1;
            btcopiar.Text = "cargar";
            btcopiar.UseVisualStyleBackColor = true;
            btcopiar.Click += btcopiar_Click;
            // 
            // btborrar
            // 
            btborrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btborrar.Location = new Point(311, 258);
            btborrar.Name = "btborrar";
            btborrar.Size = new Size(94, 29);
            btborrar.TabIndex = 2;
            btborrar.Text = "borrar";
            btborrar.UseVisualStyleBackColor = true;
            btborrar.Click += btborrar_Click;
            // 
            // cmbcontinente
            // 
            cmbcontinente.FormattingEnabled = true;
            cmbcontinente.Location = new Point(193, 84);
            cmbcontinente.Name = "cmbcontinente";
            cmbcontinente.Size = new Size(151, 28);
            cmbcontinente.TabIndex = 3;
            // 
            // lstpais
            // 
            lstpais.FormattingEnabled = true;
            lstpais.Location = new Point(90, 183);
            lstpais.Name = "lstpais";
            lstpais.Size = new Size(150, 104);
            lstpais.TabIndex = 4;
            // 
            // lstlista
            // 
            lstlista.FormattingEnabled = true;
            lstlista.Location = new Point(450, 183);
            lstlista.Name = "lstlista";
            lstlista.Size = new Size(150, 104);
            lstlista.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 84);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 6;
            label1.Text = "continente";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lstlista);
            Controls.Add(lstpais);
            Controls.Add(cmbcontinente);
            Controls.Add(btborrar);
            Controls.Add(btcopiar);
            Controls.Add(btagregar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btagregar;
        private Button btcopiar;
        private Button btborrar;
        private ComboBox cmbcontinente;
        private ListBox lstpais;
        private ListBox lstlista;
        private Label label1;
    }
}
