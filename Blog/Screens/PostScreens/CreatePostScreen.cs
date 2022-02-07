using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;

namespace Blog.Screens.PostScreens
{
    public class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Post");
            Console.WriteLine("-------------");
            
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

            Create(new Post
            {
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

        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                Console.WriteLine("Post cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o Post");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
