using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public class UpdatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando um Post");
            Console.WriteLine("-------------");
            
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Titulo: ");
            var title = Console.ReadLine();

            Console.Write("Sumario: ");
            var summary = Console.ReadLine();

            Console.Write("Conteudo: ");
            var body = Console.ReadLine();

            Console.Write("Id da Categoria: ");
            var categoryId = Console.ReadLine();

            Console.Write("Id do Autor: ");
            var authorId = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Post
            {
                Id = int.Parse(id),
                Title = title,
                Summary = summary,
                Body = body,
                CategoryId = int.Parse(categoryId),
                AuthorId = int.Parse(authorId),
                Slug = slug,
                CreateDate = DateTime.UtcNow
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Update(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Update(post);
                Console.WriteLine("Post atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
