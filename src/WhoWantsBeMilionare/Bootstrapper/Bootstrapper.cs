using System;
using SimpleInjector;
using WhoWantsBeMilionare.Presentation.Implementation;
using WhoWantsBeMilionare.Presentation.Interfaces;

namespace WhoWantsBeMilionare.Bootstrapper
{
    public class Bootstrapper
    {

       
        public Bootstrapper()
        {
            this.Container = new Container();

        }


        private void SetupPresentation()
        {
            this.Container.Register<IMenuPresenter, MenuPresenter>();
        }


        public Container Container { get;  }
    }
}
