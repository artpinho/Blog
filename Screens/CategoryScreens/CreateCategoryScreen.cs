using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova categoria");
            Console.WriteLine("-------------");

            Console.Write("Name: ");
            var name = Console.ReadLine();
            
            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Category
            {
                Name=name,
                Slug=slug
            });
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Create(Category category)

       {
        try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Create(category);
                Console.WriteLine("Categoria cadastrada com sucesso!");
            }
        catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a categoria");
                Console.WriteLine(ex.Message);
            }
       }
    }
}