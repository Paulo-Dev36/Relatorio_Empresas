using Npgsql;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Software_Developer_Ilan
{
    public class RepositorioEmpresas
    {
        static readonly string serverName = "192.168.1.5";
        static readonly string port = "5432";
        static readonly string userName = "postgres";
        static readonly string password = "wl@post2013\r\n";
        static readonly string dataBase = @"wlvalidador";

        public int QuantidadeEmpresas { get; set; }

        readonly string ConnString = $@"Server={serverName};Port={port};User Id={userName};Password={password};Database={dataBase};";

        NpgsqlConnection pgsqlConnection = null;

        public DataTable GetStatusEmpresas()
        {
            DataTable dataTable = new DataTable();

            pgsqlConnection = new NpgsqlConnection(ConnString);
            pgsqlConnection.Open();

            string consultaStatusEmpresas = @"SELECT DISTINCT UPPER(STATUS) AS STATUS
                                              FROM PRESTACAOSERVICO
                                              ORDER BY 1";

            NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(consultaStatusEmpresas, pgsqlConnection);
            Adpt.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetEnquandramento()
        {
            DataTable dataTable = new DataTable();
            pgsqlConnection = new NpgsqlConnection(ConnString);
            pgsqlConnection.Open();

            string consultaEnquadramento = @"SELECT DISTINCT UPPER(ENQUADRAMENTO) AS ENQUADRAMENTO
                                                FROM EMPRESAS
                                                ORDER BY 1";

            NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(consultaEnquadramento, pgsqlConnection);
            Adpt.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetCidades()
        {
            DataTable dataTable = new DataTable();
            pgsqlConnection = new NpgsqlConnection(ConnString);
            pgsqlConnection.Open();

            string consultaEnquadramento = @"SELECT DISTINCT UPPER(CIDADE) AS CIDADE
                                                FROM EMPRESAS
                                                WHERE CIDADE <> '' AND CIDADE <> ' '
                                                ORDER BY 1";

            NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(consultaEnquadramento, pgsqlConnection);
            Adpt.Fill(dataTable);
            return dataTable;
        }

        public IEnumerable<Empresas> GetEmpresas(string status, string enquadramento, string cidade)
        {
            DataTable dataTable = new DataTable();
            pgsqlConnection = new NpgsqlConnection(ConnString);
            pgsqlConnection.Open();

            string consultaEmpresa = @"SELECT empresas.codigoempresa, empresas.filial, empresas.nomeempresa, UPPER(empresas.enquadramento), UPPER(prestacaoservico.status), UPPER(empresas.cidade)
                                        FROM empresas 
                                        INNER JOIN prestacaoservico on empresas.idempresa = prestacaoservico.idempresa ";

            if (status != "<Todos>" && enquadramento != "<Todos>" && cidade != "<Todas>")
            {
                consultaEmpresa += $@"WHERE UPPER(prestacaoservico.status) = '{status}' AND UPPER(empresas.enquadramento) = '{enquadramento}' AND empresas.cidade LIKE '%{cidade}' ";
            }
            else if (status != "<Todos>" && cidade != "<Todas>" && enquadramento == "<Todos>")
            {
                consultaEmpresa += $@"WHERE UPPER(prestacaoservico.status) = '{status}' AND UPPER(empresas.cidade) = '{cidade}' ";
            }
            else if (status != "<Todos>" && cidade == "<Todas>" && enquadramento == "<Todos>")
            {
                consultaEmpresa += $@"WHERE UPPER(prestacaoservico.status) = '{status}' ";
            }
            else if (status == "<Todos>" && cidade != "<Todas>" && enquadramento == "<Todos>")
            {
                consultaEmpresa += $@"WHERE UPPER(empresas.cidade) = '{cidade}' ";
            }
            else if (status == "<Todos>" && cidade == "<Todas>" && enquadramento != "<Todos>")
            {
                consultaEmpresa += $@"WHERE UPPER(empresas.enquadramento) = '{enquadramento}' ";
            }
            else if (status != "<Todos>" && cidade == "<Todas>" && enquadramento != "<Todos>")
            {
                consultaEmpresa += $@"WHERE  UPPER(empresas.enquadramento) = '{enquadramento}' AND UPPER(prestacaoservico.status) = '{status}' ";
            }
            else if(status == "<Todos>" && cidade != "<Todas>" && enquadramento != "<Todos>")
            {
                consultaEmpresa += $@"WHERE UPPER(empresas.cidade) = '{cidade}' AND UPPER(empresas.enquadramento) = '{enquadramento}' ";
            }
            
            

            consultaEmpresa += "ORDER BY 1, 2 ";

            NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(consultaEmpresa, pgsqlConnection);
            Adpt.Fill(dataTable);

            List<Empresas> empresas = new List<Empresas>();

            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                var empresa = new Empresas()
                {
                    CodigoEmpresa = (int)dataTable.Rows[i][0],
                    Filial = (int)dataTable.Rows[i][1],
                    NomeEmpresa = dataTable.Rows[i][2].ToString(),
                    Enquadramento = dataTable.Rows[i][3].ToString(),
                    Status = dataTable.Rows[i][4].ToString(),
                    Cidade = string.IsNullOrEmpty(dataTable.Rows[i][5].ToString()) ? "Não informado" : dataTable.Rows[i][5].ToString()
                };
                empresas.Add(empresa);
            }
            QuantidadeEmpresas = empresas.Count;
            return empresas;
        }
    }
}
