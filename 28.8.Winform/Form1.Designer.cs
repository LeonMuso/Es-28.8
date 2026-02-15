namespace _28._8.Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbTipoVeicolo;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.TextBox txtModello;
        private System.Windows.Forms.TextBox txtTariffa;
        private System.Windows.Forms.TextBox txtPostiCarico;
        private System.Windows.Forms.Button btnAggiungiVeicolo;

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Button btnAggiungiCliente;

        private System.Windows.Forms.ComboBox cmbVeicoli;
        private System.Windows.Forms.ComboBox cmbClienti;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.NumericUpDown numGiorni;
        private System.Windows.Forms.Button btnAggiungiNoleggio;

        private System.Windows.Forms.ListBox lstNoleggi;

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
            cmbTipoVeicolo = new ComboBox();
            txtTarga = new TextBox();
            txtModello = new TextBox();
            txtTariffa = new TextBox();
            txtPostiCarico = new TextBox();
            btnAggiungiVeicolo = new Button();
            txtNome = new TextBox();
            txtCognome = new TextBox();
            txtCF = new TextBox();
            btnAggiungiCliente = new Button();
            cmbVeicoli = new ComboBox();
            cmbClienti = new ComboBox();
            dtData = new DateTimePicker();
            numGiorni = new NumericUpDown();
            btnAggiungiNoleggio = new Button();
            lstNoleggi = new ListBox();
            btnTotlCliente = new Button();
            btnRicavatoTotale = new Button();
            lblTarga = new Label();
            lblModello = new Label();
            lblTariffa = new Label();
            lblPostiCarico = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lblTipoVeicolo = new Label();
            ((System.ComponentModel.ISupportInitialize)numGiorni).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoVeicolo
            // 
            cmbTipoVeicolo.Location = new Point(34, 20);
            cmbTipoVeicolo.Name = "cmbTipoVeicolo";
            cmbTipoVeicolo.Size = new Size(121, 23);
            cmbTipoVeicolo.TabIndex = 0;
            cmbTipoVeicolo.SelectedIndexChanged += cmbTipoVeicolo_SelectedIndexChanged;
            // 
            // txtTarga
            // 
            txtTarga.Location = new Point(12, 62);
            txtTarga.Name = "txtTarga";
            txtTarga.Size = new Size(171, 23);
            txtTarga.TabIndex = 1;
            // 
            // txtModello
            // 
            txtModello.Location = new Point(12, 95);
            txtModello.Name = "txtModello";
            txtModello.Size = new Size(171, 23);
            txtModello.TabIndex = 2;
            // 
            // txtTariffa
            // 
            txtTariffa.Location = new Point(12, 128);
            txtTariffa.Name = "txtTariffa";
            txtTariffa.Size = new Size(171, 23);
            txtTariffa.TabIndex = 3;
            // 
            // txtPostiCarico
            // 
            txtPostiCarico.Location = new Point(12, 161);
            txtPostiCarico.Name = "txtPostiCarico";
            txtPostiCarico.Size = new Size(171, 23);
            txtPostiCarico.TabIndex = 4;
            // 
            // btnAggiungiVeicolo
            // 
            btnAggiungiVeicolo.Location = new Point(25, 190);
            btnAggiungiVeicolo.Name = "btnAggiungiVeicolo";
            btnAggiungiVeicolo.Size = new Size(148, 35);
            btnAggiungiVeicolo.TabIndex = 6;
            btnAggiungiVeicolo.Text = "Aggiungi Veicolo";
            btnAggiungiVeicolo.Click += btnAggiungiVeicolo_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(392, 20);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(171, 23);
            txtNome.TabIndex = 7;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(392, 54);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(171, 23);
            txtCognome.TabIndex = 8;
            // 
            // txtCF
            // 
            txtCF.Location = new Point(392, 91);
            txtCF.Name = "txtCF";
            txtCF.Size = new Size(171, 23);
            txtCF.TabIndex = 9;
            // 
            // btnAggiungiCliente
            // 
            btnAggiungiCliente.Location = new Point(405, 127);
            btnAggiungiCliente.Name = "btnAggiungiCliente";
            btnAggiungiCliente.Size = new Size(148, 34);
            btnAggiungiCliente.TabIndex = 10;
            btnAggiungiCliente.Text = "Aggiungi Cliente";
            btnAggiungiCliente.Click += btnAggiungiCliente_Click;
            // 
            // cmbVeicoli
            // 
            cmbVeicoli.Location = new Point(710, 57);
            cmbVeicoli.Name = "cmbVeicoli";
            cmbVeicoli.Size = new Size(214, 23);
            cmbVeicoli.TabIndex = 11;
            // 
            // cmbClienti
            // 
            cmbClienti.Location = new Point(710, 23);
            cmbClienti.Name = "cmbClienti";
            cmbClienti.Size = new Size(214, 23);
            cmbClienti.TabIndex = 12;
            // 
            // dtData
            // 
            dtData.Location = new Point(710, 129);
            dtData.Name = "dtData";
            dtData.Size = new Size(337, 23);
            dtData.TabIndex = 13;
            // 
            // numGiorni
            // 
            numGiorni.Location = new Point(710, 96);
            numGiorni.Name = "numGiorni";
            numGiorni.Size = new Size(214, 23);
            numGiorni.TabIndex = 14;
            // 
            // btnAggiungiNoleggio
            // 
            btnAggiungiNoleggio.Location = new Point(759, 164);
            btnAggiungiNoleggio.Name = "btnAggiungiNoleggio";
            btnAggiungiNoleggio.Size = new Size(148, 35);
            btnAggiungiNoleggio.TabIndex = 15;
            btnAggiungiNoleggio.Text = "Aggiungi Noleggio";
            btnAggiungiNoleggio.Click += btnAggiungiNoleggio_Click;
            // 
            // lstNoleggi
            // 
            lstNoleggi.ItemHeight = 15;
            lstNoleggi.Location = new Point(12, 237);
            lstNoleggi.Name = "lstNoleggi";
            lstNoleggi.Size = new Size(1032, 154);
            lstNoleggi.TabIndex = 16;
            lstNoleggi.DoubleClick += lstNoleggi_DoubleClick;
            // 
            // btnTotlCliente
            // 
            btnTotlCliente.Location = new Point(12, 396);
            btnTotlCliente.Name = "btnTotlCliente";
            btnTotlCliente.Size = new Size(148, 34);
            btnTotlCliente.TabIndex = 17;
            btnTotlCliente.Text = "Totale Cliente";
            btnTotlCliente.UseVisualStyleBackColor = true;
            btnTotlCliente.Click += btnTotCliente_Click;
            // 
            // btnRicavatoTotale
            // 
            btnRicavatoTotale.Location = new Point(896, 396);
            btnRicavatoTotale.Name = "btnRicavatoTotale";
            btnRicavatoTotale.Size = new Size(148, 34);
            btnRicavatoTotale.TabIndex = 18;
            btnRicavatoTotale.Text = "Ricavato Totale";
            btnRicavatoTotale.UseVisualStyleBackColor = true;
            btnRicavatoTotale.Click += btnRicavoTotale_Click;
            // 
            // lblTarga
            // 
            lblTarga.AutoSize = true;
            lblTarga.Location = new Point(202, 65);
            lblTarga.Name = "lblTarga";
            lblTarga.Size = new Size(36, 15);
            lblTarga.TabIndex = 19;
            lblTarga.Text = "Targa";
            // 
            // lblModello
            // 
            lblModello.AutoSize = true;
            lblModello.Location = new Point(202, 98);
            lblModello.Name = "lblModello";
            lblModello.Size = new Size(51, 15);
            lblModello.TabIndex = 20;
            lblModello.Text = "Modello";
            // 
            // lblTariffa
            // 
            lblTariffa.AutoSize = true;
            lblTariffa.Location = new Point(202, 131);
            lblTariffa.Name = "lblTariffa";
            lblTariffa.Size = new Size(40, 15);
            lblTariffa.TabIndex = 21;
            lblTariffa.Text = "Tariffa";
            // 
            // lblPostiCarico
            // 
            lblPostiCarico.AutoSize = true;
            lblPostiCarico.Location = new Point(202, 164);
            lblPostiCarico.Name = "lblPostiCarico";
            lblPostiCarico.Size = new Size(33, 15);
            lblPostiCarico.TabIndex = 22;
            lblPostiCarico.Text = "Posti";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(583, 23);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 24;
            label6.Text = "Nome";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(582, 57);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 25;
            label7.Text = "Cognome";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(582, 94);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 26;
            label8.Text = "Codice Fiscale";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(931, 23);
            label9.Name = "label9";
            label9.Size = new Size(116, 15);
            label9.TabIndex = 27;
            label9.Text = "Seleziona un Cliente ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(930, 60);
            label10.Name = "label10";
            label10.Size = new Size(117, 15);
            label10.TabIndex = 28;
            label10.Text = "Seleziona un Veicolo ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(931, 98);
            label11.Name = "label11";
            label11.Size = new Size(100, 15);
            label11.TabIndex = 29;
            label11.Text = "Periodo Noleggio";
            // 
            // lblTipoVeicolo
            // 
            lblTipoVeicolo.AutoSize = true;
            lblTipoVeicolo.Location = new Point(202, 23);
            lblTipoVeicolo.Name = "lblTipoVeicolo";
            lblTipoVeicolo.Size = new Size(91, 15);
            lblTipoVeicolo.TabIndex = 30;
            lblTipoVeicolo.Text = "Tipo del veicolo";
            // 
            // Form1
            // 
            ClientSize = new Size(1056, 450);
            Controls.Add(lblTipoVeicolo);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblPostiCarico);
            Controls.Add(lblTariffa);
            Controls.Add(lblModello);
            Controls.Add(lblTarga);
            Controls.Add(btnRicavatoTotale);
            Controls.Add(btnTotlCliente);
            Controls.Add(cmbTipoVeicolo);
            Controls.Add(txtTarga);
            Controls.Add(txtModello);
            Controls.Add(txtTariffa);
            Controls.Add(txtPostiCarico);
            Controls.Add(btnAggiungiVeicolo);
            Controls.Add(txtNome);
            Controls.Add(txtCognome);
            Controls.Add(txtCF);
            Controls.Add(btnAggiungiCliente);
            Controls.Add(cmbVeicoli);
            Controls.Add(cmbClienti);
            Controls.Add(dtData);
            Controls.Add(numGiorni);
            Controls.Add(btnAggiungiNoleggio);
            Controls.Add(lstNoleggi);
            Name = "Form1";
            Text = "Gestione Noleggi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numGiorni).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnTotlCliente;
        private Button btnRicavatoTotale;
        private Label lblTarga;
        private Label lblModello;
        private Label lblTariffa;
        private Label lblPostiCarico;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;




        #endregion

        private Label lblTipoVeicolo;
    }
}
