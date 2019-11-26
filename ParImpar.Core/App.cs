using MvvmCross.IoC;
using MvvmCross.ViewModels;
using ParImpar.Core.ViewModels;

namespace ParImpar.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ParImparViewModel>();
        }
    }
}

