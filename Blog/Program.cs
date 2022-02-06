using System;
using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Data Source=NT-03072\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True; TrustServerCertificate=True";
        static void Main(string[] args)
        {
            //ReadUsers();
            //ReadUser();
            //CreateUser();
            //UpdateUser();
            //DeleteUser();
        }

        public static void ReadUsers()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var users = connection.GetAll<User>();

                foreach (var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }
        }

        public static void ReadUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);

                Console.WriteLine(user.Name);

            }
        }

        public static void CreateUser()
        {
            var user = new User()
            {
                Id = 2,
                Bio = "Equipe balta.io",
                Email = "hello@balta",
                Imagem = "http://...",
                Name = "balta suporte",
                PasswordHash = "HASH",
                Slug = "equipe-balta"
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Insert<User>(user);

                Console.WriteLine("Cadastro realizado com sucesso!");

            }
        }

        public static void UpdateUser()
        {
            var user = new User()
            {
                Bio = "Equipe de suporte balta.io",
                Email = "hello@balta",
                Imagem = "http://...",
                Name = "balta",
                PasswordHash = "HASH",
                Slug = "equipe-balta"
            };

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Update<User>(user);

                Console.WriteLine("Atualização realizada com sucesso!");

            }
        }

        public static void DeleteUser()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var user = connection.Get<User>(1);

                connection.Delete<User>(user);

                Console.WriteLine("Exclusão realizada com sucesso!");

            }
        }
    }
}
