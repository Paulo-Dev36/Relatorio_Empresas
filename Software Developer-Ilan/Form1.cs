using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using RelatoriosAtendimento;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;
using Fonte = iTextSharp.text.Font;

namespace Software_Developer_Ilan
{
    public partial class frmInformacoesEmpresas : Form
    {
        private RepositorioEmpresas repositorioEmpresas = new RepositorioEmpresas();
        readonly DataTable dataTable = new DataTable();
        public int TotalPaginas = 1;
        public string OrdernarPor { get; set; }
        public frmInformacoesEmpresas()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            AddColunasTabela();
            CarregaStatusEmpresa();
            CarregaEnquadramento();
            CarregaCidades();
            SelecionaTodasColunas();
        }

        private void CarregaStatusEmpresa()
        {
            DataTable objDataTable = repositorioEmpresas.GetStatusEmpresas();
            comboBoxStatus.Items.Add("<Todos>");

            foreach (DataRow dataRow in objDataTable.Rows)
            {
                string status = dataRow["status"].ToString();
                comboBoxStatus.Items.Add(status);
            }
            comboBoxStatus.SelectedIndex = 0;
        }

        private void CarregaEnquadramento()
        {
            DataTable objDataTable = repositorioEmpresas.GetEnquandramento();
            comboBoxEnquadramento.Items.Add("<Todos>");

            foreach (DataRow dataRow in objDataTable.Rows)
            {
                string enquadramento = dataRow["enquadramento"].ToString();
                comboBoxEnquadramento.Items.Add(enquadramento);
            }
            comboBoxEnquadramento.SelectedIndex = 0;
        }
        private void CarregaCidades()
        {
            DataTable objDataTable = repositorioEmpresas.GetCidades();
            comboBoxMunicipio.Items.Add("<Todas>");

            foreach (DataRow dataRow in objDataTable.Rows)
            {
                string cidade = dataRow["cidade"].ToString();
                comboBoxMunicipio.Items.Add(cidade);
            }
            comboBoxMunicipio.SelectedIndex = 0;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string status = comboBoxStatus.Text;
            string enquadramento = comboBoxEnquadramento.Text;
            string cidade = comboBoxMunicipio.Text;

            GridEmpresas(repositorioEmpresas.GetEmpresas(status, enquadramento, cidade));
            if(repositorioEmpresas.QuantidadeEmpresas < 1)
            {
                MessageBox.Show("Nenhum dado carregado com os parâmetros informados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtQuantidadeEmpresas.Text = repositorioEmpresas.QuantidadeEmpresas.ToString();
        }

        private void AddColunasTabela()
        {
            dataTable.Columns.Add("Codigo Empresa", typeof(int));
            dataTable.Columns.Add("Filial", typeof(int));
            dataTable.Columns.Add("Nome Empresa", typeof(string));
            dataTable.Columns.Add("Enquadramento", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Município", typeof(string));
        }

        private void GridEmpresas(IEnumerable<Empresas> empresas)
        {
            DadosDataTable(empresas);
            bindingSource1.DataSource = dataTable;
            dgvEmpresas.DataSource = bindingSource1;

            dgvEmpresas.Columns[0].Width = 50;
            dgvEmpresas.Columns[1].Width = 30;
            dgvEmpresas.Columns[3].Width = 70;
            dgvEmpresas.Columns[4].Width = 80;
            dgvEmpresas.Columns[5].Width = 150;
        }

        private void DadosDataTable(IEnumerable<Empresas> empresas)
        {
            dataTable.Clear();
            foreach(Empresas empresa in empresas)
            {
                dataTable.Rows.Add(empresa.CodigoEmpresa, empresa.Filial, empresa.NomeEmpresa, empresa.Enquadramento, empresa.Status, empresa.Cidade);
            }
        }


        private void timerHoras_Tick(object sender, EventArgs e)
        {
            this.labelHoras.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (!PossuiItemNaGrid())
            {
                return;
            }

            SaveFileDialog salvar = new SaveFileDialog();
            salvar.FileName = "RelatorioEmpresas";

            Excel.Application App;
            Excel.Workbook WorkBook;
            Excel.Worksheet WorkSheet;
            object misValue = System.Reflection.Missing.Value;

            App = new Excel.Application();
            WorkBook = App.Workbooks.Add(misValue);
            WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
            int linha = 1;
            int coluna = 0;

            DataGridViewCell cell = dgvEmpresas[coluna, linha];
            WorkSheet.Cells[linha, 1] = "Código Empresa";
            WorkSheet.Cells[linha, 2] = "Filial";
            WorkSheet.Cells[linha, 3] = "Nome Empresa";
            WorkSheet.Cells[linha, 4] = "Enquadramento";
            WorkSheet.Cells[linha, 5] = "Status";
            WorkSheet.Cells[linha, 6] = "Município";

            var codEmpresa = WorkSheet.Cells[linha, 1];
            var filial = WorkSheet.Cells[linha, 2];
            var nomeEmpresa = WorkSheet.Cells[linha, 3];
            var enquadramento = WorkSheet.Cells[linha, 4];
            var status = WorkSheet.Cells[linha, 5];
            var municipio = WorkSheet.Cells[linha, 6];

            codEmpresa.Cells.Font.Bold = true;
            filial.Cells.Font.Bold = true;
            nomeEmpresa.Cells.Font.Bold = true;
            enquadramento.Cells.Font.Bold = true;
            status.Cells.Font.Bold = true;
            municipio.Cells.Font.Bold = true;

            for (linha = 1; linha <= dgvEmpresas.RowCount - 1; linha++)
            {
                for (coluna = 0; coluna <= dgvEmpresas.ColumnCount - 1; coluna++)
                {
                    DataGridViewCell cell2 = dgvEmpresas[coluna, linha];
                    WorkSheet.Cells[linha + 1, coluna + 1] = cell2.Value.ToString();
                    var tes = WorkSheet.Cells[linha + 1, coluna + 1];
                }
            }

            Excel.Range celulas, celulasTitulo;

            celulas = WorkSheet.get_Range("A1:Z1000");
            celulasTitulo = WorkSheet.get_Range("A1:F1");
            celulas.EntireColumn.AutoFit();
            celulas.VerticalAlignment = XlVAlign.xlVAlignCenter;
            celulas.HorizontalAlignment = XlVAlign.xlVAlignCenter;
            celulasTitulo.Interior.Color = Color.LightBlue;
            celulasTitulo.Borders.Color = Color.Black;
            salvar.Title = "Exportar para Excel";
            salvar.Filter = "Arquivo do Excel *.xls | *.xls";
            salvar.ShowDialog();

            WorkBook.SaveAs(salvar.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
            XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            WorkBook.Close(true, misValue, misValue);
            App.Quit();

            //System.Diagnostics.Process.Start(salvar.FileName);
            MessageBox.Show("Exportado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool PossuiItemNaGrid()
        {
            if (dgvEmpresas.Rows.Count < 1)
            {
                MessageBox.Show("Nenhum dado para ser emitido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (!PossuiItemNaGrid())
            {
                return;
            }

            if (repositorioEmpresas.QuantidadeEmpresas > 18)
                TotalPaginas += (int)Math.Ceiling(
                    (repositorioEmpresas.QuantidadeEmpresas - 18) / 20F);

            bool[] colunasSelecionadas = { checkBoxIdAtendimento.Checked, checkBoxSolicitante.Checked, checkBoxTipoAtendimento.Checked,
                    checkBoxDataAbertura.Checked, checkBoxDataFechamento.Checked, checkBoxDuracao.Checked};

            float[] colunas = { 0.0f, 0.0f, 0.0f, 0.0f, 0.0f, 0.0f};

            BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            Document documento = new Document(PageSize.A4);
            documento.SetMargins(40, 40, 80, 40);
            documento.AddCreationDate();

            string caminhoArquivo = $@"{Path.GetTempFileName()}" + "relatorio.pdf";

            PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(caminhoArquivo, FileMode.Create));
            writer.PageEvent = new EventosPagina(TotalPaginas);
            documento.Open();

            Paragraph titulo = new Paragraph();
            titulo.Font = new Fonte(Fonte.FontFamily.TIMES_ROMAN, 16);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add("RELATÓRIO DE EMPRESAS\n \n \n");

            PdfPTable tabela = new PdfPTable(6);

            if (colunasSelecionadas[0])
            {
                colunas[0] = 0.8f;
            }
            if (colunasSelecionadas[1])
            {
                colunas[1] = 0.8f;
            }
            if (colunasSelecionadas[2])
            {
                colunas[2] = 2.0f;
            }
            if (colunasSelecionadas[3])
            {
                colunas[3] = 1.2f;
            }
            if (colunasSelecionadas[4])
            {
                colunas[4] = 1.2f;
            }
            if (colunasSelecionadas[5])
            {
                colunas[5] = 1.1f;
            }

            float[] larguraColunas = { colunas[0], colunas[1], colunas[2], colunas[3], colunas[4],
                colunas[5] };

            tabela.SetWidths(larguraColunas);
            tabela.DefaultCell.BorderWidth = 0;
            tabela.WidthPercentage = 100;

            CriarCelulaTexto(tabela, "Cód. Empresa", 9, true);
            CriarCelulaTexto(tabela, "Filial", 9, true);
            CriarCelulaTexto(tabela, "Nome Empresa", 9, true);
            CriarCelulaTexto(tabela, "Enquadramento", 9, true);
            CriarCelulaTexto(tabela, "Status", 9, true);
            CriarCelulaTexto(tabela, "Município", 9, true);

            OrdernarPor = comboBoxOrdenar.Text;
            List<Empresas> listaEmpresas = repositorioEmpresas.ListaEmpresas;

            if (OrdernarPor == "Codigo Empresa")
            {
                listaEmpresas = listaEmpresas.OrderBy(x => x.CodigoEmpresa).ToList();
            }
            else if (OrdernarPor == "Nome Empresa")
            {
                listaEmpresas = listaEmpresas.OrderBy(x => x.NomeEmpresa).ToList();
            }
            else if (OrdernarPor == "Enquadramento")
            {
                listaEmpresas = listaEmpresas.OrderBy(x => x.Enquadramento).ToList();
            }
            else if (OrdernarPor == "Status")
            {
                listaEmpresas = listaEmpresas.OrderBy(x => x.Status).ToList();
            }
            else if (OrdernarPor == "Município")
            {
                listaEmpresas = listaEmpresas.OrderBy(x => x.Cidade).ToList();
            }

            foreach (Empresas atendimento in listaEmpresas)
            {
                CriarCelulaTexto(tabela, atendimento.CodigoEmpresa.ToString(), 8, false);
                CriarCelulaTexto(tabela, atendimento.Filial.ToString(), 8, false);
                CriarCelulaTexto(tabela, atendimento.NomeEmpresa.ToString(), 8, false);
                CriarCelulaTexto(tabela, atendimento.Enquadramento.ToString(), 8, false);
                CriarCelulaTexto(tabela, atendimento.Status.ToString(), 8, false);
                CriarCelulaTexto(tabela, atendimento.Cidade.ToString(), 7, false);
            };

            documento.Add(titulo);
            documento.Add(tabela);
            documento.Close();

            System.Diagnostics.Process.Start(caminhoArquivo);
        }
        private static void CriarCelulaTexto(PdfPTable tabela, string texto, int tamanhoFonte, bool negrito,
            int alinhamentoHoriz = PdfPCell.ALIGN_LEFT, bool italico = false, int alturaCelula = 35)
        {
            {
                int estilo = Fonte.NORMAL;
                if (negrito && italico)
                {
                    estilo = Fonte.BOLDITALIC;
                }
                else if (negrito)
                {
                    estilo = Fonte.BOLD;
                }
                else if (italico)
                {
                    estilo = Fonte.ITALIC;
                }

                BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                Fonte fonte = new Fonte(fonteBase, tamanhoFonte,
                    estilo, BaseColor.BLACK);

                var bgColor = BaseColor.WHITE;
                if (tabela.Rows.Count % 2 == 1)
                    bgColor = new BaseColor(0.95f, 0.95f, 0.95f);

                PdfPCell celula = new PdfPCell(new Phrase(texto, fonte))
                {
                    HorizontalAlignment = alinhamentoHoriz,
                    VerticalAlignment = Element.ALIGN_MIDDLE,
                    Border = 0,
                    BorderWidthBottom = 1,
                    FixedHeight = alturaCelula,
                    BackgroundColor = bgColor
                };
                tabela.AddCell(celula);
            }
        }

        private void SelecionaTodasColunas()
        {
            checkBoxIdAtendimento.Checked = true;
            checkBoxSolicitante.Checked = true;
            checkBoxTipoAtendimento.Checked = true;
            checkBoxDataAbertura.Checked = true;
            checkBoxDataFechamento.Checked = true;
            checkBoxDuracao.Checked = true;
        }
    }
}
