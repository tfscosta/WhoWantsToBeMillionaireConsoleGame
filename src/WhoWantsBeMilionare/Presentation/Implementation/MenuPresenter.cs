using System;
using WhoWantsBeMilionare.Presentation.Interfaces;

namespace WhoWantsBeMilionare.Presentation.Implementation
{
    public class MenuPresenter : IMenuPresenter
    {
        public MenuPresenter()
        {

        }

        public void ShowMenu()
        {
            Console.WriteLine("Who want's go be a Milionare");
            Console.WriteLine("1- New Game");
            Console.WriteLine("2- Load Game");
            Console.WriteLine("0- Exit Game");
        }
    }
}
