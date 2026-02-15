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
            lblNome = new Label();
            lblCognome = new Label();
            lblCF = new Label();
            lblSelezionaCliente = new Label();
            lblSelezionaVeicolo = new Label();
            lblPeriodoNoleggio = new Label();
            lblTipoVeicolo = new Label();
            ((System.ComponentModel.ISupportInitialize)numGiorni).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoVeicolo
            // 
            cmbTipoVeicolo.Location = new Point(12, 21);
            cmbTipoVeicolo.Name = "cmbTipoVeicolo";
            cmbTipoVeicolo.Size = new Size(171, 23);
            cmbTipoVeicolo.TabIndex = 0;
            cmbTipoVeicolo.SelectedIndexChanged += cmbTipoVeicolo_SelectedIndexChanged;
            // 
            // txtTarga
            // 
            txtTarga.Location = new Point(12, 50);
            txtTarga.Name = "txtTarga";
            txtTarga.Size = new Size(171, 23);
            txtTarga.TabIndex = 1;
            // 
            // txtModello
            // 
            txtModello.Location = new Point(12, 83);
            txtModello.Name = "txtModello";
            txtModello.Size = new Size(171, 23);
            txtModello.TabIndex = 2;
            // 
            // txtTariffa
            // 
            txtTariffa.Location = new Point(12, 116);
            txtTariffa.Name = "txtTariffa";
            txtTariffa.Size = new Size(171, 23);
            txtTariffa.TabIndex = 3;
            // 
            // txtPostiCarico
            // 
            txtPostiCarico.Location = new Point(12, 149);
            txtPostiCarico.Name = "txtPostiCarico";
            txtPostiCarico.Size = new Size(171, 23);
            txtPostiCarico.TabIndex = 4;
            // 
            // btnAggiungiVeicolo
            // 
            btnAggiungiVeicolo.Location = new Point(25, 178);
            btnAggiungiVeicolo.Name = "btnAggiungiVeicolo";
            btnAggiungiVeicolo.Size = new Size(148, 35);
            btnAggiungiVeicolo.TabIndex = 6;
            btnAggiungiVeicolo.Text = "Aggiungi Veicolo";
            btnAggiungiVeicolo.Click += btnAggiungiVeicolo_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(330, 21);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(171, 23);
            txtNome.TabIndex = 7;
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(330, 55);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(171, 23);
            txtCognome.TabIndex = 8;
            // 
            // txtCF
            // 
            txtCF.Location = new Point(330, 92);
            txtCF.Name = "txtCF";
            txtCF.Size = new Size(171, 23);
            txtCF.TabIndex = 9;
            // 
            // btnAggiungiCliente
            // 
            btnAggiungiCliente.Location = new Point(343, 128);
            btnAggiungiCliente.Name = "btnAggiungiCliente";
            btnAggiungiCliente.Size = new Size(148, 34);
            btnAggiungiCliente.TabIndex = 10;
            btnAggiungiCliente.Text = "Aggiungi Cliente";
            btnAggiungiCliente.Click += btnAggiungiCliente_Click;
            // 
            // cmbVeicoli
            // 
            cmbVeicoli.Location = new Point(629, 55);
            cmbVeicoli.Name = "cmbVeicoli";
            cmbVeicoli.Size = new Size(274, 23);
            cmbVeicoli.TabIndex = 11;
            // 
            // cmbClienti
            // 
            cmbClienti.Location = new Point(629, 21);
            cmbClienti.Name = "cmbClienti";
            cmbClienti.Size = new Size(274, 23);
            cmbClienti.TabIndex = 12;
            // 
            // dtData
            // 
            dtData.Location = new Point(629, 127);
            dtData.Name = "dtData";
            dtData.Size = new Size(397, 23);
            dtData.TabIndex = 13;
            // 
            // numGiorni
            // 
            numGiorni.Location = new Point(629, 94);
            numGiorni.Name = "numGiorni";
            numGiorni.Size = new Size(274, 23);
            numGiorni.TabIndex = 14;
            // 
            // btnAggiungiNoleggio
            // 
            btnAggiungiNoleggio.Location = new Point(738, 162);
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
            lblTarga.Location = new Point(202, 53);
            lblTarga.Name = "lblTarga";
            lblTarga.Size = new Size(36, 15);
            lblTarga.TabIndex = 19;
            lblTarga.Text = "Targa";
            // 
            // lblModello
            // 
            lblModello.AutoSize = true;
            lblModello.Location = new Point(202, 86);
            lblModello.Name = "lblModello";
            lblModello.Size = new Size(51, 15);
            lblModello.TabIndex = 20;
            lblModello.Text = "Modello";
            // 
            // lblTariffa
            // 
            lblTariffa.AutoSize = true;
            lblTariffa.Location = new Point(202, 119);
            lblTariffa.Name = "lblTariffa";
            lblTariffa.Size = new Size(40, 15);
            lblTariffa.TabIndex = 21;
            lblTariffa.Text = "Tariffa";
            // 
            // lblPostiCarico
            // 
            lblPostiCarico.AutoSize = true;
            lblPostiCarico.Location = new Point(202, 152);
            lblPostiCarico.Name = "lblPostiCarico";
            lblPostiCarico.Size = new Size(33, 15);
            lblPostiCarico.TabIndex = 22;
            lblPostiCarico.Text = "Posti";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(521, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 24;
            lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            lblCognome.AutoSize = true;
            lblCognome.Location = new Point(520, 58);
            lblCognome.Name = "lblCognome";
            lblCognome.Size = new Size(60, 15);
            lblCognome.TabIndex = 25;
            lblCognome.Text = "Cognome";
            // 
            // lblCF
            // 
            lblCF.AutoSize = true;
            lblCF.Location = new Point(520, 95);
            lblCF.Name = "lblCF";
            lblCF.Size = new Size(82, 15);
            lblCF.TabIndex = 26;
            lblCF.Text = "Codice Fiscale";
            // 
            // lblSelezionaCliente
            // 
            lblSelezionaCliente.AutoSize = true;
            lblSelezionaCliente.Location = new Point(910, 24);
            lblSelezionaCliente.Name = "lblSelezionaCliente";
            lblSelezionaCliente.Size = new Size(116, 15);
            lblSelezionaCliente.TabIndex = 27;
            lblSelezionaCliente.Text = "Seleziona un Cliente ";
            // 
            // lblSelezionaVeicolo
            // 
            lblSelezionaVeicolo.AutoSize = true;
            lblSelezionaVeicolo.Location = new Point(910, 58);
            lblSelezionaVeicolo.Name = "lblSelezionaVeicolo";
            lblSelezionaVeicolo.Size = new Size(117, 15);
            lblSelezionaVeicolo.TabIndex = 28;
            lblSelezionaVeicolo.Text = "Seleziona un Veicolo ";
            // 
            // lblPeriodoNoleggio
            // 
            lblPeriodoNoleggio.AutoSize = true;
            lblPeriodoNoleggio.Location = new Point(910, 95);
            lblPeriodoNoleggio.Name = "lblPeriodoNoleggio";
            lblPeriodoNoleggio.Size = new Size(110, 15);
            lblPeriodoNoleggio.TabIndex = 29;
            lblPeriodoNoleggio.Text = "Giorni del Noleggio";
            // 
            // lblTipoVeicolo
            // 
            lblTipoVeicolo.AutoSize = true;
            lblTipoVeicolo.Location = new Point(202, 24);
            lblTipoVeicolo.Name = "lblTipoVeicolo";
            lblTipoVeicolo.Size = new Size(91, 15);
            lblTipoVeicolo.TabIndex = 30;
            lblTipoVeicolo.Text = "Tipo del veicolo";
            // 
            // Form1
            // 
            ClientSize = new Size(1056, 450);
            Controls.Add(lblTipoVeicolo);
            Controls.Add(lblPeriodoNoleggio);
            Controls.Add(lblSelezionaVeicolo);
            Controls.Add(lblSelezionaCliente);
            Controls.Add(lblCF);
            Controls.Add(lblCognome);
            Controls.Add(lblNome);
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
        private Label lblNome;
        private Label lblCognome;
        private Label lblCF;
        private Label lblSelezionaCliente;
        private Label lblSelezionaVeicolo;
        private Label lblPeriodoNoleggio;




        #endregion

        private Label lblTipoVeicolo;
    }
}
