using MvvmCross.Commands;
using MvvmCross.ViewModels;
using PrimeNumber.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrimeNumber.Core.ViewModels
{
    public class PrimeViewModel : MvxViewModel
    {
        private readonly IPrimeService _primeService;
        private int _n;
        private string _result;
        private MvxCommand _calculateCommand;

        public PrimeViewModel(IPrimeService primeService)
        {
            _primeService = primeService;
        }

        public int N
        {
            get => _n;
            set => SetProperty(ref _n, value);
        }

        public string Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(CalculatePrime);
                return _calculateCommand;
            }
        }

        public async override Task Initialize()
        {
            await base.Initialize();

            N = 0;
            CalculatePrime();
        }

        private void CalculatePrime()
        {
            throw new NotImplementedException();
        }
    }
}
