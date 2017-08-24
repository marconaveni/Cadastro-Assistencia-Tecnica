using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using pc1_dao.Persistence;
using System.Data;
using Cadastro_Assistencia_Tecnica.Model;

namespace Cadastro_Assistencia_Tecnica.Persistence
{
    class FichaDAO
    {
        private SqlConnection conn;

        private SqlCommand cmd;

        public void insert(Ficha ficha)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                String query = "insert into ficha (dtentrada,nroficha,cliente,telefone,endereco,nroendereco,aparelho,marca,modelo,acessorios,estado,valor,aprovado,dtaprovado,ok,dtok,entrega,dtentrega,detalhes) values ( @dtentrada , @nroficha, @cliente, @telefone, @endereco, @nroendereco, @aparelho, @marca, @modelo, @acessorios, @estado, @valor, @aprovado, @dtaprovado, @ok, @dtok, @entrega, @dtentrega, @detalhes)";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@dtentrada", ficha.DataEntrada.ToString("dd/MM/yyyy")));
                cmd.Parameters.Add(new SqlParameter("@nroficha", ficha.NroFicha));
                cmd.Parameters.Add(new SqlParameter("@cliente", ficha.Cliente));
                cmd.Parameters.Add(new SqlParameter("@telefone", ficha.Telefone));
                cmd.Parameters.Add(new SqlParameter("@endereco", ficha.Endereco));
                cmd.Parameters.Add(new SqlParameter("@nroendereco", ficha.NroEndereco));
                cmd.Parameters.Add(new SqlParameter("@aparelho", ficha.Aparelho));
                cmd.Parameters.Add(new SqlParameter("@marca", ficha.Marca));
                cmd.Parameters.Add(new SqlParameter("@modelo", ficha.Modelo));
                cmd.Parameters.Add(new SqlParameter("@acessorios", ficha.Acessorios));
                cmd.Parameters.Add(new SqlParameter("@estado", ficha.Estado));
                cmd.Parameters.Add(new SqlParameter("@valor", ficha.Valor));
                cmd.Parameters.Add(new SqlParameter("@aprovado", ficha.Aprovado));
                cmd.Parameters.Add(new SqlParameter("@dtaprovado", ficha.DataAprovado));
                cmd.Parameters.Add(new SqlParameter("@ok", ficha.Ok));
                cmd.Parameters.Add(new SqlParameter("@dtok", ficha.DataOk)); 
                cmd.Parameters.Add(new SqlParameter("@entrega", ficha.Entrega));
                cmd.Parameters.Add(new SqlParameter("@dtentrega", ficha.DataEntrega));
                cmd.Parameters.Add(new SqlParameter("@detalhes", ficha.Detalhes));
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new OperacaoDAOException(erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void update(Ficha ficha)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                String query = "update ficha set dtentrada = @dtentrada , nroficha = @nroficha , cliente = @cliente , telefone = @telefone ,endereco = @endereco ,nroendereco = @nroendereco , aparelho = @aparelho , marca = @marca , modelo = @modelo , acessorios = @acessorios ,estado = @estado ,valor = @valor ,aprovado = @aprovado , dtaprovado = @dtaprovado ,ok = @ok ,dtok = @dtok ,entrega = @entrega ,dtentrega = @dtentrega ,detalhes = @detalhes where id = @id";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", ficha.Id));
                cmd.Parameters.Add(new SqlParameter("@dtentrada", ficha.DataEntrada.ToString("dd/MM/yyyy")));
                cmd.Parameters.Add(new SqlParameter("@nroficha", ficha.NroFicha));
                cmd.Parameters.Add(new SqlParameter("@cliente", ficha.Cliente));
                cmd.Parameters.Add(new SqlParameter("@telefone", ficha.Telefone));
                cmd.Parameters.Add(new SqlParameter("@endereco", ficha.Endereco));
                cmd.Parameters.Add(new SqlParameter("@nroendereco", ficha.NroEndereco));
                cmd.Parameters.Add(new SqlParameter("@aparelho", ficha.Aparelho));
                cmd.Parameters.Add(new SqlParameter("@marca", ficha.Marca));
                cmd.Parameters.Add(new SqlParameter("@modelo", ficha.Modelo));
                cmd.Parameters.Add(new SqlParameter("@acessorios", ficha.Acessorios));
                cmd.Parameters.Add(new SqlParameter("@estado", ficha.Estado));
                cmd.Parameters.Add(new SqlParameter("@valor", ficha.Valor));
                cmd.Parameters.Add(new SqlParameter("@aprovado", ficha.Aprovado));
                cmd.Parameters.Add(new SqlParameter("@dtaprovado", ficha.DataAprovado));
                cmd.Parameters.Add(new SqlParameter("@ok", ficha.Ok));
                cmd.Parameters.Add(new SqlParameter("@dtok", ficha.DataOk));
                cmd.Parameters.Add(new SqlParameter("@entrega", ficha.Entrega));
                cmd.Parameters.Add(new SqlParameter("@dtentrega", ficha.DataEntrega));
                cmd.Parameters.Add(new SqlParameter("@detalhes", ficha.Detalhes));
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new OperacaoDAOException(erro.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public void remove(int id)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                String query = "DELETE FROM ficha WHERE id=@id";
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException erro)
            {
                throw new OperacaoDAOException(erro.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public Ficha findById(int id)
        {
            return null;
        }

        public DataTable findAll()
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                String query = "select id, Entrada = dtentrada,'Número da Ficha' = nroficha,Cliente = cliente, Telefone = telefone,Endereço = endereco,'Número Endereço' = nroendereco,Aparelho = aparelho,Marca = marca,Modelo = modelo,Acessórios = acessorios,Estado = estado,Valor = valor  ,Aprovado = aprovado,'Data Aprovado' = dtaprovado,Pronto = ok,'Data Pronto' = dtok,Entregue = entrega,'Data Entrega' = dtentrega,Detalhes = detalhes from ficha order by id desc";
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataTable.BeginLoadData();
                dataAdapter.Fill(dataTable);
                dataTable.EndLoadData();
                return dataTable;
            }
            catch (SqlException erro)
            {
                throw new OperacaoDAOException(erro.Message);
            }
            finally
            {
                conn.Close();
            }

        }


        public DataTable findCliente(Ficha ficha)
        {

            conn = new ConnectionFactory().getConnection();
            try
            {
                String query = "SELECT top 30 ID = id,Entrada = dtentrada,'Número da Ficha' = nroficha,Cliente = cliente, Telefone = telefone,Endereço = endereco,'Número Endereço' = nroendereco,Aparelho = aparelho,Marca = marca,Modelo = modelo,Acessórios = acessorios,Estado = estado,Valor = valor,Aprovado = aprovado,'Data Aprovado' = dtaprovado,Pronto = ok,'Data Pronto' = dtok,Entregue = entrega,'Data Entrega' = dtentrega,Detalhes = detalhes from ficha  where cliente like '%" + ficha.Cliente + "%' order by id desc ";
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataTable.BeginLoadData();
                dataAdapter.Fill(dataTable);
                dataTable.EndLoadData();
                return dataTable;
            }
            catch (SqlException erro)
            {
                throw new OperacaoDAOException(erro.Message);
            }
            finally
            {
                conn.Close();
            }

        }


        public DataTable findNumero(Ficha ficha)
        {

            conn = new ConnectionFactory().getConnection();
            try
            {
                String query = "SELECT top 30 id,Entrada = dtentrada,'Número da Ficha' = nroficha,Cliente = cliente, Telefone = telefone,Endereço = endereco,'Número Endereço' = nroendereco,Aparelho = aparelho,Marca = marca,Modelo = modelo,Acessórios = acessorios,Estado = estado,Valor = valor,Aprovado = aprovado,'Data Aprovado' = dtaprovado,Pronto = ok,'Data Pronto' = dtok,Entregue = entrega,'Data Entrega' = dtentrega,Detalhes = detalhes from ficha  where nroficha like '%" + ficha.NroFicha + "%' order by id desc";
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataTable.BeginLoadData();
                dataAdapter.Fill(dataTable);
                dataTable.EndLoadData();
                return dataTable;
            }
            catch (SqlException erro)
            {
                throw new OperacaoDAOException(erro.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public DataTable findTelefone(Ficha ficha)
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                String query = "SELECT top 30 id,Entrada = dtentrada,'Número da Ficha' = nroficha,Cliente = cliente, Telefone = telefone,Endereço = endereco,'Número Endereço' = nroendereco,Aparelho = aparelho,Marca = marca,Modelo = modelo,Acessórios = acessorios,Estado = estado,Valor = valor,Aprovado = aprovado,'Data Aprovado' = dtaprovado,Pronto = ok,'Data Pronto' = dtok,Entregue = entrega,'Data Entrega' = dtentrega,Detalhes = detalhes from ficha  where telefone like '%" + ficha.Telefone + "%' order by id desc";
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataTable.BeginLoadData();
                dataAdapter.Fill(dataTable);
                dataTable.EndLoadData();
                return dataTable;
            }
            catch (SqlException erro)
            {
                throw new OperacaoDAOException(erro.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public DataTable findAprovados()
        {
            conn = new ConnectionFactory().getConnection();
            try
            {
                String query = "SELECT  id,Entrada = dtentrada,'Número da Ficha' = nroficha,Cliente = cliente, Telefone = telefone,Endereço = endereco,'Número Endereço' = nroendereco,Aparelho = aparelho,Marca = marca,Modelo = modelo,Acessórios = acessorios,Estado = estado,Valor = valor,Aprovado = aprovado,'Data Aprovado' = dtaprovado,Pronto = ok,'Data Pronto' = dtok,Entregue = entrega,'Data Entrega' = dtentrega,Detalhes = detalhes from ficha where  aprovado = 'Sim' and  ok = 'Não' and entrega = 'Não' order by id desc";
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataTable.BeginLoadData();
                dataAdapter.Fill(dataTable);
                dataTable.EndLoadData();
                return dataTable;
            }
            catch (SqlException erro)
            {
                throw new OperacaoDAOException(erro.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        public DataTable findValidaNROFicha(Ficha ficha)
        {

            conn = new ConnectionFactory().getConnection();
            try
            {
                String query = "select  COUNT (nroficha) from ficha where nroficha = '" + ficha.NroFicha + "' ";
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataTable.BeginLoadData();
                dataAdapter.Fill(dataTable);
                dataTable.EndLoadData();
                return dataTable;
            }
            catch (SqlException erro)
            {
                throw new OperacaoDAOException(erro.Message);
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
