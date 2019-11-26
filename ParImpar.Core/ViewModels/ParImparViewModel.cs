using MvvmCross.Commands;
using MvvmCross.ViewModels;
using ParImpar.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ParImpar.Core.ViewModels
{
    public class ParImparViewModel : MvxViewModel
    {
        private readonly IParImparService _parImparService;
        private int _n;
        private string _result;
        private MvxCommand _calculateCommand;

        public ParImparViewModel(IParImparService parImparService)
        {
            _parImparService = parImparService;
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
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        public async override Task Initialize()
        {
            await base.Initialize();

            N = 0;
            Calculate();
        }

        private void Calculate()
        {
            Result = _parImparService.GetParImpar(N);
        }
    }
}
