namespace WinFormsJogo21
{
    partial class btnFinalizarRodada
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
            this.TextoPrincipal = new System.Windows.Forms.GroupBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.GBJogador = new System.Windows.Forms.GroupBox();
            this.TBsomaJogador = new System.Windows.Forms.TextBox();
            this.btPassarVez = new System.Windows.Forms.Button();
            this.btNovaCarta = new System.Windows.Forms.Button();
            this.TBjogador = new System.Windows.Forms.TextBox();
            this.GBPC = new System.Windows.Forms.GroupBox();
            this.TbsomaComputador = new System.Windows.Forms.TextBox();
            this.TBcomputador = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.BTNNovaRodada = new System.Windows.Forms.Button();
            this.BTNIniciar = new System.Windows.Forms.Button();
            this.GPplacar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPlacarPC = new System.Windows.Forms.TextBox();
            this.txbPlacarJogador = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextoPrincipal.SuspendLayout();
            this.GBJogador.SuspendLayout();
            this.GBPC.SuspendLayout();
            this.Menu.SuspendLayout();
            this.GPplacar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextoPrincipal
            // 
            this.TextoPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextoPrincipal.Controls.Add(this.txtPrincipal);
            this.TextoPrincipal.Location = new System.Drawing.Point(25, 18);
            this.TextoPrincipal.Name = "TextoPrincipal";
            this.TextoPrincipal.Size = new System.Drawing.Size(727, 241);
            this.TextoPrincipal.TabIndex = 0;
            this.TextoPrincipal.TabStop = false;
            this.TextoPrincipal.Text = "Jogo 21";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(7, 26);
            this.txtPrincipal.Multiline = true;
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.ReadOnly = true;
            this.txtPrincipal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrincipal.Size = new System.Drawing.Size(714, 209);
            this.txtPrincipal.TabIndex = 2;
            this.txtPrincipal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // GBJogador
            // 
            this.GBJogador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GBJogador.Controls.Add(this.TBsomaJogador);
            this.GBJogador.Controls.Add(this.btPassarVez);
            this.GBJogador.Controls.Add(this.btNovaCarta);
            this.GBJogador.Controls.Add(this.TBjogador);
            this.GBJogador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBJogador.Location = new System.Drawing.Point(26, 267);
            this.GBJogador.Name = "GBJogador";
            this.GBJogador.Size = new System.Drawing.Size(261, 206);
            this.GBJogador.TabIndex = 1;
            this.GBJogador.TabStop = false;
            this.GBJogador.Text = "Jogador";
            // 
            // TBsomaJogador
            // 
            this.TBsomaJogador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBsomaJogador.Location = new System.Drawing.Point(6, 116);
            this.TBsomaJogador.Multiline = true;
            this.TBsomaJogador.Name = "TBsomaJogador";
            this.TBsomaJogador.ReadOnly = true;
            this.TBsomaJogador.Size = new System.Drawing.Size(249, 34);
            this.TBsomaJogador.TabIndex = 3;
            this.TBsomaJogador.Text = "Soma total: ";
            this.TBsomaJogador.TextChanged += new System.EventHandler(this.TBsomaJogador_TextChanged);
            // 
            // btPassarVez
            // 
            this.btPassarVez.Location = new System.Drawing.Point(135, 156);
            this.btPassarVez.Name = "btPassarVez";
            this.btPassarVez.Size = new System.Drawing.Size(120, 40);
            this.btPassarVez.TabIndex = 2;
            this.btPassarVez.Text = "Passar Rodada";
            this.btPassarVez.UseVisualStyleBackColor = true;

            // 
            // btNovaCarta
            // 
            this.btNovaCarta.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btNovaCarta.Location = new System.Drawing.Point(6, 156);
            this.btNovaCarta.Name = "btNovaCarta";
            this.btNovaCarta.Size = new System.Drawing.Size(120, 37);
            this.btNovaCarta.TabIndex = 1;
            this.btNovaCarta.Text = "Nova Carta";
            this.btNovaCarta.UseVisualStyleBackColor = true;
            this.btNovaCarta.Click += new System.EventHandler(this.btNovaCarta_Click);
            // 
            // TBjogador
            // 
            this.TBjogador.Location = new System.Drawing.Point(6, 26);
            this.TBjogador.Multiline = true;
            this.TBjogador.Name = "TBjogador";
            this.TBjogador.ReadOnly = true;
            this.TBjogador.Size = new System.Drawing.Size(249, 84);
            this.TBjogador.TabIndex = 0;
            this.TBjogador.Text = "As cartas tiradas foram: ";
            this.TBjogador.TextChanged += new System.EventHandler(this.TBjogador_TextChanged);
            // 
            // GBPC
            // 
            this.GBPC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GBPC.Controls.Add(this.TbsomaComputador);
            this.GBPC.Controls.Add(this.TBcomputador);
            this.GBPC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GBPC.Location = new System.Drawing.Point(293, 267);
            this.GBPC.Name = "GBPC";
            this.GBPC.Size = new System.Drawing.Size(261, 206);
            this.GBPC.TabIndex = 2;
            this.GBPC.TabStop = false;
            this.GBPC.Text = "Computador";
            // 
            // TbsomaComputador
            // 
            this.TbsomaComputador.Location = new System.Drawing.Point(6, 156);
            this.TbsomaComputador.Multiline = true;
            this.TbsomaComputador.Name = "TbsomaComputador";
            this.TbsomaComputador.ReadOnly = true;
            this.TbsomaComputador.Size = new System.Drawing.Size(249, 40);
            this.TbsomaComputador.TabIndex = 4;
            this.TbsomaComputador.Text = "Soma total: ";
            // 
            // TBcomputador
            // 
            this.TBcomputador.Location = new System.Drawing.Point(6, 26);
            this.TBcomputador.Multiline = true;
            this.TBcomputador.Name = "TBcomputador";
            this.TBcomputador.ReadOnly = true;
            this.TBcomputador.Size = new System.Drawing.Size(249, 124);
            this.TBcomputador.TabIndex = 1;
            this.TBcomputador.Text = "As cartas tiradas foram: ";
            this.TBcomputador.TextChanged += new System.EventHandler(this.TBcomputador_TextChanged);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu.Controls.Add(this.BTNNovaRodada);
            this.Menu.Controls.Add(this.BTNIniciar);
            this.Menu.Location = new System.Drawing.Point(560, 267);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(192, 90);
            this.Menu.TabIndex = 3;
            this.Menu.TabStop = false;
            this.Menu.Text = "Menu";
            // 
            // BTNNovaRodada
            // 
            this.BTNNovaRodada.Location = new System.Drawing.Point(97, 26);
            this.BTNNovaRodada.Name = "BTNNovaRodada";
            this.BTNNovaRodada.Size = new System.Drawing.Size(89, 51);
            this.BTNNovaRodada.TabIndex = 1;
            this.BTNNovaRodada.Text = "Nova Partida";
            this.BTNNovaRodada.UseVisualStyleBackColor = true;
            // 
            // BTNIniciar
            // 
            this.BTNIniciar.Location = new System.Drawing.Point(6, 26);
            this.BTNIniciar.Name = "BTNIniciar";
            this.BTNIniciar.Size = new System.Drawing.Size(89, 51);
            this.BTNIniciar.TabIndex = 0;
            this.BTNIniciar.Text = "Iniciar";
            this.BTNIniciar.UseVisualStyleBackColor = true;
            this.BTNIniciar.Click += new System.EventHandler(this.BTNIniciar_Click);
            // 
            // GPplacar
            // 
            this.GPplacar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GPplacar.Controls.Add(this.label3);
            this.GPplacar.Controls.Add(this.label2);
            this.GPplacar.Controls.Add(this.label1);
            this.GPplacar.Controls.Add(this.txbPlacarPC);
            this.GPplacar.Controls.Add(this.txbPlacarJogador);
            this.GPplacar.Location = new System.Drawing.Point(560, 363);
            this.GPplacar.Name = "GPplacar";
            this.GPplacar.Size = new System.Drawing.Size(192, 110);
            this.GPplacar.TabIndex = 4;
            this.GPplacar.TabStop = false;
            this.GPplacar.Text = "Placar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Computador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jogador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbPlacarPC
            // 
            this.txbPlacarPC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbPlacarPC.Location = new System.Drawing.Point(101, 57);
            this.txbPlacarPC.Name = "txbPlacarPC";
            this.txbPlacarPC.ReadOnly = true;
            this.txbPlacarPC.Size = new System.Drawing.Size(60, 47);
            this.txbPlacarPC.TabIndex = 1;
            this.txbPlacarPC.TextChanged += new System.EventHandler(this.txbPlacarPC_TextChanged);
            // 
            // txbPlacarJogador
            // 
            this.txbPlacarJogador.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbPlacarJogador.Location = new System.Drawing.Point(6, 57);
            this.txbPlacarJogador.Name = "txbPlacarJogador";
            this.txbPlacarJogador.ReadOnly = true;
            this.txbPlacarJogador.Size = new System.Drawing.Size(60, 47);
            this.txbPlacarJogador.TabIndex = 0;
            this.txbPlacarJogador.TextChanged += new System.EventHandler(this.txbPlacarJogador_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(727, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Finalizar Rodada";
            this.button1.UseVisualStyleBackColor = true;

            // 
            // btnFinalizarRodada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(776, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GPplacar);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.GBPC);
            this.Controls.Add(this.GBJogador);
            this.Controls.Add(this.TextoPrincipal);
            this.Name = "btnFinalizarRodada";
            this.Text = "Form1";

            this.TextoPrincipal.ResumeLayout(false);
            this.TextoPrincipal.PerformLayout();
            this.GBJogador.ResumeLayout(false);
            this.GBJogador.PerformLayout();
            this.GBPC.ResumeLayout(false);
            this.GBPC.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.GPplacar.ResumeLayout(false);
            this.GPplacar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox TextoPrincipal;
        private GroupBox GBJogador;
        private GroupBox GBPC;
        private GroupBox Menu;
        private Button BTNNovaRodada;
        private Button BTNIniciar;
        private GroupBox GPplacar;
        private TextBox txbPlacarPC;
        private TextBox txbPlacarJogador;
        private Label label1;
        private TextBox txtPrincipal;
        private Button btPassarVez;
        private Button btNovaCarta;
        private TextBox TBjogador;
        private TextBox TBcomputador;
        private Label label3;
        private Label label2;
        private TextBox TBsomaJogador;
        private TextBox TbsomaComputador;
        private Button button1;
    }
}