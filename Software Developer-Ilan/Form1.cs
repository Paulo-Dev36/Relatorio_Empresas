using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace Software_Developer_Ilan
{
    public partial class frmInformacoesEmpresas : Form
    {
        private RepositorioEmpresas repositorioEmpresas = new RepositorioEmpresas();
        readonly DataTable dataTable = new DataTable();
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
    }
}
