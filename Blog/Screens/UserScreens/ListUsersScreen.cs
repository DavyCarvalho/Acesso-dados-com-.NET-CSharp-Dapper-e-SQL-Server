using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;

namespace Blog.Screens.UserScreens
{
    public class ListUsersScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Usuários");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<User>(Database.Connection);
            var users = repository.Get();
            foreach (var user in users)
                Console.WriteLine($"{user.Id} - {user.Name} ({user.Email})");
        }
    }
}
