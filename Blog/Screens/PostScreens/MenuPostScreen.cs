using System;

namespace Blog.Screens.PostScreens
{
    public class MenuPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Posts");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Posts");
            Console.WriteLine("2 - Cadastrar Post");
            Console.WriteLine("3 - Atualizar Post");
            Console.WriteLine("4 - Excluir Post");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListPostsScreen.Load();
                    break;
                case 2:
                    CreatePostScreen.Load();
                    break;
                case 3:
                    UpdatePostScreen.Load();
                    break;
                case 4:
                    DeletePostScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
