namespace Software_Developer_Ilan
{
    partial class frmInformacoesEmpresas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.comboBoxEnquadramento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidadeEmpresas = new System.Windows.Forms.TextBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.labelHoras = new System.Windows.Forms.Label();
            this.timerHoras = new System.Windows.Forms.Timer(this.components);
            this.comboBoxMunicipio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxDuracao = new System.Windows.Forms.CheckBox();
            this.checkBoxDataFechamento = new System.Windows.Forms.CheckBox();
            this.checkBoxDataAbertura = new System.Windows.Forms.CheckBox();
            this.checkBoxTipoAtendimento = new System.Windows.Forms.CheckBox();
            this.checkBoxSolicitante = new System.Windows.Forms.CheckBox();
            this.checkBoxIdAtendimento = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxOrdenar = new System.Windows.Forms.ComboBox();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "RELATÓRIOS DE EMPRESAS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 32);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status da empresa:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(15, 76);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(138, 22);
            this.comboBoxStatus.TabIndex = 3;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(739, 412);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(84, 27);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Emitir Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.BackColor = System.Drawing.Color.Black;
            this.btnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.ForeColor = System.Drawing.Color.White;
            this.btnCarregar.Location = new System.Drawing.Point(520, 73);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(96, 25);
            this.btnCarregar.TabIndex = 5;
            this.btnCarregar.Text = "CARREGAR";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(16, 130);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(904, 274);
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEmpresas);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 248);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Dados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AllowUserToAddRows = false;
            this.dgvEmpresas.AllowUserToDeleteRows = false;
            this.dgvEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpresas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpresas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpresas.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvEmpresas.Location = new System.Drawing.Point(3, 3);
            this.dgvEmpresas.MultiSelect = false;
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.ReadOnly = true;
            this.dgvEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresas.Size = new System.Drawing.Size(890, 242);
            this.dgvEmpresas.TabIndex = 0;
            // 
            // comboBoxEnquadramento
            // 
            this.comboBoxEnquadramento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnquadramento.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F);
            this.comboBoxEnquadramento.FormattingEnabled = true;
            this.comboBoxEnquadramento.Location = new System.Drawing.Point(170, 76);
            this.comboBoxEnquadramento.Name = "comboBoxEnquadramento";
            this.comboBoxEnquadramento.Size = new System.Drawing.Size(147, 22);
            this.comboBoxEnquadramento.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enquadramento da empresa:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantidade de empresas:";
            // 
            // txtQuantidadeEmpresas
            // 
            this.txtQuantidadeEmpresas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQuantidadeEmpresas.Location = new System.Drawing.Point(538, 416);
            this.txtQuantidadeEmpresas.Name = "txtQuantidadeEmpresas";
            this.txtQuantidadeEmpresas.ReadOnly = true;
            this.txtQuantidadeEmpresas.Size = new System.Drawing.Size(41, 20);
            this.txtQuantidadeEmpresas.TabIndex = 11;
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F);
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(829, 412);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(84, 27);
            this.btnPDF.TabIndex = 12;
            this.btnPDF.Text = "Emitir PDF";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // labelHoras
            // 
            this.labelHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHoras.AutoSize = true;
            this.labelHoras.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10.2F);
            this.labelHoras.Location = new System.Drawing.Point(33, 420);
            this.labelHoras.Name = "labelHoras";
            this.labelHoras.Size = new System.Drawing.Size(44, 17);
            this.labelHoras.TabIndex = 13;
            this.labelHoras.Text = "11:18:01";
            this.labelHoras.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // timerHoras
            // 
            this.timerHoras.Enabled = true;
            this.timerHoras.Tick += new System.EventHandler(this.timerHoras_Tick);
            // 
            // comboBoxMunicipio
            // 
            this.comboBoxMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMunicipio.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F);
            this.comboBoxMunicipio.FormattingEnabled = true;
            this.comboBoxMunicipio.Location = new System.Drawing.Point(331, 76);
            this.comboBoxMunicipio.Name = "comboBoxMunicipio";
            this.comboBoxMunicipio.Size = new System.Drawing.Size(161, 22);
            this.comboBoxMunicipio.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Município:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 248);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Opções de emissão";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Colounas relatório PDF:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBoxDuracao);
            this.panel2.Controls.Add(this.checkBoxDataFechamento);
            this.panel2.Controls.Add(this.checkBoxDataAbertura);
            this.panel2.Controls.Add(this.checkBoxTipoAtendimento);
            this.panel2.Controls.Add(this.checkBoxSolicitante);
            this.panel2.Controls.Add(this.checkBoxIdAtendimento);
            this.panel2.Location = new System.Drawing.Point(22, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 170);
            this.panel2.TabIndex = 30;
            // 
            // checkBoxDuracao
            // 
            this.checkBoxDuracao.AutoSize = true;
            this.checkBoxDuracao.Location = new System.Drawing.Point(6, 120);
            this.checkBoxDuracao.Name = "checkBoxDuracao";
            this.checkBoxDuracao.Size = new System.Drawing.Size(73, 17);
            this.checkBoxDuracao.TabIndex = 34;
            this.checkBoxDuracao.Text = "Município";
            this.checkBoxDuracao.UseVisualStyleBackColor = true;
            // 
            // checkBoxDataFechamento
            // 
            this.checkBoxDataFechamento.AutoSize = true;
            this.checkBoxDataFechamento.Location = new System.Drawing.Point(6, 102);
            this.checkBoxDataFechamento.Name = "checkBoxDataFechamento";
            this.checkBoxDataFechamento.Size = new System.Drawing.Size(56, 17);
            this.checkBoxDataFechamento.TabIndex = 33;
            this.checkBoxDataFechamento.Text = "Status";
            this.checkBoxDataFechamento.UseVisualStyleBackColor = true;
            // 
            // checkBoxDataAbertura
            // 
            this.checkBoxDataAbertura.AutoSize = true;
            this.checkBoxDataAbertura.Location = new System.Drawing.Point(6, 84);
            this.checkBoxDataAbertura.Name = "checkBoxDataAbertura";
            this.checkBoxDataAbertura.Size = new System.Drawing.Size(101, 17);
            this.checkBoxDataAbertura.TabIndex = 32;
            this.checkBoxDataAbertura.Text = "Enquadramento";
            this.checkBoxDataAbertura.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipoAtendimento
            // 
            this.checkBoxTipoAtendimento.AutoSize = true;
            this.checkBoxTipoAtendimento.Location = new System.Drawing.Point(6, 66);
            this.checkBoxTipoAtendimento.Name = "checkBoxTipoAtendimento";
            this.checkBoxTipoAtendimento.Size = new System.Drawing.Size(98, 17);
            this.checkBoxTipoAtendimento.TabIndex = 31;
            this.checkBoxTipoAtendimento.Text = "Nome Empresa";
            this.checkBoxTipoAtendimento.UseVisualStyleBackColor = true;
            // 
            // checkBoxSolicitante
            // 
            this.checkBoxSolicitante.AutoSize = true;
            this.checkBoxSolicitante.Location = new System.Drawing.Point(6, 48);
            this.checkBoxSolicitante.Name = "checkBoxSolicitante";
            this.checkBoxSolicitante.Size = new System.Drawing.Size(46, 17);
            this.checkBoxSolicitante.TabIndex = 30;
            this.checkBoxSolicitante.Text = "Filial";
            this.checkBoxSolicitante.UseVisualStyleBackColor = true;
            // 
            // checkBoxIdAtendimento
            // 
            this.checkBoxIdAtendimento.AutoSize = true;
            this.checkBoxIdAtendimento.Location = new System.Drawing.Point(6, 30);
            this.checkBoxIdAtendimento.Name = "checkBoxIdAtendimento";
            this.checkBoxIdAtendimento.Size = new System.Drawing.Size(103, 17);
            this.checkBoxIdAtendimento.TabIndex = 29;
            this.checkBoxIdAtendimento.Text = "Codigo Empresa";
            this.checkBoxIdAtendimento.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "Ordernar por:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBoxOrdenar);
            this.panel3.Location = new System.Drawing.Point(276, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 50);
            this.panel3.TabIndex = 39;
            // 
            // comboBoxOrdenar
            // 
            this.comboBoxOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdenar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrdenar.FormattingEnabled = true;
            this.comboBoxOrdenar.Items.AddRange(new object[] {
            "Codigo Empresa",
            "Filial",
            "Nome Empresa",
            "Enquadramento",
            "Status",
            "Município"});
            this.comboBoxOrdenar.Location = new System.Drawing.Point(13, 14);
            this.comboBoxOrdenar.Name = "comboBoxOrdenar";
            this.comboBoxOrdenar.Size = new System.Drawing.Size(170, 22);
            this.comboBoxOrdenar.TabIndex = 27;
            // 
            // frmInformacoesEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 449);
            this.Controls.Add(this.comboBoxMunicipio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelHoras);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.txtQuantidadeEmpresas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxEnquadramento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmInformacoesEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPRESAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.ComboBox comboBoxEnquadramento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidadeEmpresas;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label labelHoras;
        private System.Windows.Forms.Timer timerHoras;
        private System.Windows.Forms.ComboBox comboBoxMunicipio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxDuracao;
        private System.Windows.Forms.CheckBox checkBoxDataFechamento;
        private System.Windows.Forms.CheckBox checkBoxDataAbertura;
        private System.Windows.Forms.CheckBox checkBoxTipoAtendimento;
        private System.Windows.Forms.CheckBox checkBoxSolicitante;
        private System.Windows.Forms.CheckBox checkBoxIdAtendimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxOrdenar;
    }
}

