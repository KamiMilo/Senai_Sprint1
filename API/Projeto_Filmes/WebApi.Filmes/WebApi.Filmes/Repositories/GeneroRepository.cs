﻿using System.Data.SqlClient;
using WebApi.Filmes.Domains;
using WebApi.Filmes.Interface;

namespace webapi.filme.manha.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// string de conexao com o banco de dados que recebe os seguintes parametros
        /// Data Source : nome do servidor
        /// Initial Catalog : nome do banco de dados
        /// Autenticacao :
        ///     - Windows : integrated Security = true;
        ///     - SQL : User id : sa; Pwd : Senha
        /// </summary>
        public string StringConexao = "Data Source = NOTE07-S14; Initial Catalog = Filmes; User Id = sa; Pwd = Senai@134";
        void IGeneroRepository.AtualizarIdCorpo(GeneroDomain Genero)
        {
            throw new NotImplementedException();
        }

        void IGeneroRepository.AtualizarIdUrl(int id, GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        GeneroDomain IGeneroRepository.BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        void IGeneroRepository.Cadastrar(GeneroDomain NovoGenero)
        {
            throw new NotImplementedException();
        }

        void IGeneroRepository.Deletar(int id)
        {
            throw new NotImplementedException();
        }

        List<GeneroDomain> IGeneroRepository.ListarTodos()
        {
            //Cria uma lista de objetos do tipo gênero
            List<GeneroDomain> ListaGeneros = new List<GeneroDomain>();

            using (SqlConnection connection = new SqlConnection(StringConexao))
            {
                //Declaração a instrução a ser executada
                string querySelectAll = "SELECT IdGenero,Nome FROM Genero";

                //Ele abre a conexão com o banco de dados
                connection.Open();

                //Declara o SqlDataReader para percorrer a tabela do banco de dados
                SqlDataReader rdr;

                //Declara o SqlCommand passsando a query que sera executada e a conexão com o bd
                using (SqlCommand cmd = new SqlCommand(querySelectAll, connection))
                {
                    //Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        GeneroDomain genero = new GeneroDomain()
                        {
                            //Atribui a propiedade IdGenero o valor recebido no rdr
                            IdGenero = Convert.ToInt32(rdr[0]),
                            //Atribui a propiedade Nome o valor recebido no rdr
                            Nome = rdr["Nome"].ToString(),
                        };

                        //Adiciona cada objeto dentro da lista
                        ListaGeneros.Add(genero);
                    }
                }
            }
            //Retorna a lista
            return ListaGeneros;
        }
    }
}


