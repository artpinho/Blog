using System;
using Blog.Models;
using Blog.Repositories;
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
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            //ReadUsers(connection);
            //ReadRoles(connection);
            //ReadTags(connection);
            //ReadUser();
            //CreateUser(connection);
            //UpdateUser(connection);
            //DeleteUser(connection, id);
            //DelUser(connection);

            connection.Close();
        }
        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var items = repository.Get();

            foreach(var item in items)
                Console.WriteLine(item.Name);
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
            var user = new User()
            {
                Bio="Equipe Pinho", 
                Email="time@pinho.com",
                Image="https://...",
                Name="Equipe Pinho",
                PasswordHash="HASH3",
                Slug="time-pinho"
            };
            repository.Create(user);
            Console.WriteLine($"Usuário {user.Name} criado com sucesso!");
        }

        public static void UpdateUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var user = new User()
            {
                Id = 2007,
                Bio="Teste Padrão", 
                Email="teste@pinho.com",
                Image="https://...",
                Name="Teste Pinho",
                PasswordHash="HASH3",
                Slug="teste-pinho"
            };
            repository.Update(user);
            Console.WriteLine($"usuário atualizado com sucesso: {user.Name}");
        }

        public static void DelUser(SqlConnection connection)
        {
            var repository = new Repository<User>(connection);
            var user = new User()
            {
                Id = 2012
            };
            
            repository.Delete(user);
            Console.WriteLine("Item Deletado com sucesso");
        }

        public static void DeleteUser(SqlConnection connection, int id)
        {
            var repository = new Repository<User>(connection);
            repository.Delete(id);

            Console.WriteLine($"{id} item deletado");
        }
        
    }
}