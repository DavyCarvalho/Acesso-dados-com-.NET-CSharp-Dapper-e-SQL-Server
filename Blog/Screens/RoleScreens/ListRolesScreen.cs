using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;

namespace Blog.Screens.RoleScreens
{
    public class ListRolesScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Perfis");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Role>(Database.Connection);
            var roles = repository.Get();
            foreach (var item in roles)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }
    }
}
