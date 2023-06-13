using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Screens.CategoryScreens
{
    public class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de categorias");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("1 - Listar categorias");
            Console.WriteLine("2 - Cadastrar categorias");
            Console.WriteLine("3 - Atualizar categorias");
            Console.WriteLine("4 - Excluir categorias");
            Console.WriteLine("5 - Voltar");
            Console.WriteLine("");
            Console.WriteLine("");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListCategoryScreen.Load();
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3:
                    UpdateCategoryScreen.Load();
                    break;
                case 4:
                    DeleteCategoryScreen.Load();
                    break;
                case 5:
                    Menu.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}