using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string status = comboBoxStatus.Text;
            string enquadramento = comboBoxEnquadramento.Text;

            GridEmpresas(repositorioEmpresas.GetEmpresas(status, enquadramento));
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
        }

        private void GridEmpresas(IEnumerable<Empresas> empresas)
        {
            DadosDataTable(empresas);
            bindingSource1.DataSource = dataTable;
            dgvEmpresas.DataSource = bindingSource1;

            dgvEmpresas.Columns[0].Width = 100;
            dgvEmpresas.Columns[1].Width = 50;
            dgvEmpresas.Columns[3].Width = 100;
            dgvEmpresas.Columns[4].Width = 100;
        }

        private void DadosDataTable(IEnumerable<Empresas> empresas)
        {
            dataTable.Clear();
            foreach(Empresas empresa in empresas)
            {
                dataTable.Rows.Add(empresa.CodigoEmpresa, empresa.Filial, empresa.NomeEmpresa, empresa.Enquadramento, empresa.Status);
            }
        }


        private void timerHoras_Tick(object sender, EventArgs e)
        {
            this.labelHoras.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
