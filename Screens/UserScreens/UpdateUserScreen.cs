using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar usuário");
            Console.WriteLine("-------------");
            Console.WriteLine("Qual ID de usuário irá atualizar?");
            var id = Console.ReadLine();            

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

            Update(new User
            {
                Id = int.Parse(id),
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

        public static void Update(User user)

       {
        try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine("Usuário atualizado com sucesso!");
            }
        catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o usuário");
                Console.WriteLine(ex.Message);
            }
       }
    }
}