using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens;
using Blog.Screens.TagScreens;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog
{
    class Program
    {
        private const string CONNECTION_STRING = @"
                                                    Server=localhost,1433;
                                                    Database=Blog;
                                                    User ID=sa;
                                                    Password=1q2w3e4r@#$;
                                                    Trusted_Connection=False; 
                                                    TrustServerCertificate=True;";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            MainMenu();

            /*ReadUsers(connection);
            //ReadRoles(connection);
            //ReadTags(connection);
            //ReadUser();
            //CreateUser(connection);
            //UpdateUser(connection);
            //DeleteUser(connection, id);
            //DelUser(connection);
            ReadWithRoles(connection);*/

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void MainMenu()
            {
                Menu.Load();
                /*Console.Clear();
                Console.WriteLine("Meu Blog");
                Console.WriteLine("----------------");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("");
                Console.WriteLine("1 - Gestão de usuário");
                Console.WriteLine("2 - Gestão de perfil");
                Console.WriteLine("3 - Gestão de categoria");
                Console.WriteLine("4 - Gestão de tag");
                Console.WriteLine("5 - Vincular perfil/usuário");
                Console.WriteLine("6 - Vincular post/tag");
                Console.WriteLine("7 - Relatórios");
                Console.WriteLine("");
                Console.WriteLine("");
                var option = short.Parse(Console.ReadLine()!);

                switch (option)
                {
                    case 4:
                        MenuTagScreen.Load();
                        break;
                    default: Load(); break;
                }*/
            }
        /*public static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var items = repository.Get();

            foreach(var item in items)
                {
                    Console.WriteLine(item.Name);
                    foreach(var role in item.Roles)
                    {
                        Console.WriteLine($" - {role.Name}");
                    }
                }
        }

        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.Get();

            foreach(var item in items)
                Console.WriteLine(item.Name);
        }

         public static void ReadTags(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.Get();

            foreach(var item in items)
                Console.WriteLine(item.Name);
        }

        public static void CreateUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var user = new User
            {
                Bio = "8x Microsoft MVP",
                Email = "andre@balta.io",
                Image = "https://balta.io/andrebaltieri.jpg",
                Name = "André Baltieri",
                Slug = "andre-baltieri",
                PasswordHash = Guid.NewGuid().ToString()
                
            };

            repository.Create(user);
            Console.WriteLine($"Usuário {user.Name} criado com sucesso!");
        }

        public static void UpdateUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var user = repository.Get(1003);
            user.Email = "novo@artpinho.com";
            repository.Update(user);
            Console.WriteLine($"usuário atualizado com sucesso: {user?.Email}");
        }

        public static void DelUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var user = repository.Get(2014);
            repository.Delete(user);
            Console.WriteLine($"{user.Name} Deletado com sucesso");
        }

        public static void DeleteUser(SqlConnection connection, int id)
        {
            var repository = new Repository<User>(connection);
            var item = repository.Get(id);
            repository.Delete(id);

            Console.WriteLine($"{item.Name} deletado com sucesso");
        }

        private static void ReadWithRoles(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var items = repository.GetWithRoles();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($"{role.Name}");
                }
                    
            }
        }
    }*/

    }       
}