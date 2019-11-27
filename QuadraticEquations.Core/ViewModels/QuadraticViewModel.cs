using MvvmCross.Commands;
using MvvmCross.ViewModels;
using QuadraticEquations.Core.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuadraticEquations.Core.ViewModels
{
    public class QuadraticViewModel : MvxViewModel
    {
        private readonly IQuadraticEquationsService _quadraticEquationsService;
        private float _a;
        private float _b;
        private float _c;
        private double _x1;
        private double _x2;
        private MvxCommand _calculateCommand;

        public QuadraticViewModel(IQuadraticEquationsService quadraticEquationsService)
        {
            _quadraticEquationsService = quadraticEquationsService;
        }

        public float A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }

        public float B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }

        public float C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }

        public double X1
        {
            get => _x1;
            set => SetProperty(ref _x1, value);
        }

        public double X2
        {
            get => _x2;
            set => SetProperty(ref _x2, value);
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(CalculateEquation);
                return _calculateCommand;
            }
        }

        public async override Task Initialize()
        {
            await base.Initialize();

            A = 1;
            B = 3;
            C = 2;
            CalculateEquation();
        }

        private void CalculateEquation()
        {
            X1 = _quadraticEquationsService.QuadraticEquationsX1(A, B, C);
            X2 = _quadraticEquationsService.QuadraticEquationsX2(A, B, C);
        }
    }
}
