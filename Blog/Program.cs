using System;
using Blog.Screens.CategoryScreens;
using Blog.Screens.RoleScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Data Source=NT-03072\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True; TrustServerCertificate=True";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Database.Connection.Close();
            Console.ReadKey();
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;

                case 2:
                    MenuRoleScreen.Load();
                    break;

                case 3:
                    MenuCategoryScreen.Load();
                    break;

                case 4:
                    MenuTagScreen.Load();
                    break;

                default: Load(); break;
            }
        }
    }
}
