using System;
using System.Reflection.PortableExecutable;
using SimpleInjector;
using WhoWantsBeMilionare.Presentation;
using WhoWantsBeMilionare.Presentation.Implementation;
using WhoWantsBeMilionare.Presentation.Interfaces;

namespace WhoWantsBeMilionare
{
    class Program
    {
        static readonly Bootstrapper.Bootstrapper bootsrapper;

        static Program()
        {
            bootsrapper = new Bootstrapper.Bootstrapper();
        }

        static void Main(string[] args)
        {
            var menuWritter = bootsrapper.Container.GetInstance<IMenuPresenter>();

            char userOption;
            do
            {
                menuWritter.ShowMenu();
                userOption = Console.ReadKey().KeyChar;
                Console.WriteLine("");
            } while (userOption != '0');

            
        }


    }
}
