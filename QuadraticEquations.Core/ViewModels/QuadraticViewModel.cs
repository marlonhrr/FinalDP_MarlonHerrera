using MvvmCross.Commands;
using MvvmCross.ViewModels;
using QuadraticEquations.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuadraticEquations.Core.ViewModels
{
    public class QuadraticViewModel : MvxViewModel
    {
        private readonly IQuadraticEquations _quadraticEquations;
        private double _a;
        private double _b;
        private double _c;
        private double _x1;
        private double _x2;
        private MvxCommand _calculateCommand;

        public QuadraticViewModel(IQuadraticEquations quadraticEquations)
        {
            _quadraticEquations = quadraticEquations;
        }

        public double A 
        { 
            get => _a; 
            set => SetProperty(ref _a, value);
        }

        public double B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }

        public double C
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

            A = 0;
            B = 0;
            C = 0;
        }

        private void CalculateEquation()
        {
            X1 = _quadraticEquations.QuadraticEquationsX1(A, B, C);
            X2 = _quadraticEquations.QuadraticEquationsX2(A, B, C);
        }
    }
}
