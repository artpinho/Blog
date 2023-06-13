using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo usuário");
            Console.WriteLine("-------------");

            Console.Write("Name: ");
            var name = Console.ReadLine();
            
            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Imagem: ");
            var image = Console.ReadLine();

            Create(new User
            {
                Name=name,
                Slug=slug,
                Bio=bio,
                Email=email,
                Image =image,
                PasswordHash = Guid.NewGuid().ToString()
            });
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)

       {
        try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuário cadastrada com sucesso!");
            }
        catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar o usuário");
                Console.WriteLine(ex.Message);
            }
       }
    }
}