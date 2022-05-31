using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IO_Tech.Editor.ViewModels
{
    public class HeaderViewModel : ViewModelBase
    {
        private DelegateCommand _showResultForm;
        private DelegateCommand _showSetupForm;
        private DelegateCommand _exitCommand;
        readonly Messenger _messenger;
        private string _mainText = "Initial Value";

        public HeaderViewModel(Messenger messenger)
        {
            _messenger = messenger;
            _messenger.Register(MediatorMessages.ViewModelResultFormToMainViewModel,
                                (Action<ResultFormViewModel>)(param => this.UpdateFromResultForm(param)));

            _messenger.Register(MediatorMessages.ViewModelSetupFormToMainViewModel,
                                (Action<SetupFormViewModel>)(param => this.UpdateFromSetupForm(param)));
        }

        public ICommand ShowResultForm
        {
            get
            {
                if (_showResultForm == null)
                {
                    _showResultForm = new DelegateCommand(param => this.ExecuteResultForm(), param => this.CanExecute);
                }
                return _showResultForm;
            }
        }

        public ICommand ShowSetupForm
        {
            get
            {
                if (_showSetupForm == null)
                {
                    _showSetupForm = new DelegateCommand(param => this.ExecuteSetupForm(), param => this.CanExecute);
                }
                return _showSetupForm;
            }
        }

        public ICommand ExitCommand
        {
            get
            {
                if (_exitCommand == null)
                    _exitCommand = new DelegateCommand(Exit);
                return _exitCommand;
            }
        }

        private bool CanExecute
        {
            get
            {
                return true;
            }
        }

        public string MainText
        {
            get
            {
                return _mainText;
            }
            set
            {
                _mainText = value;
                RaisePropertyChanged("MainText");
            }
        }


        private void ExecuteResultForm()
        {
            _messenger.NotifyColleagues(MediatorMessages.ViewModelToView, "ShowResultForm");

        }

        private void ExecuteSetupForm()
        {
            _messenger.NotifyColleagues(MediatorMessages.ViewModelToView, "ShowSetupForm");

        }

        private void UpdateFromResultForm(ResultFormViewModel resultFormViewModel)
        {
            MainText = resultFormViewModel.WindowText;
        }

        private void UpdateFromSetupForm(SetupFormViewModel setupFormViewModel)
        {
            MainText = setupFormViewModel.WindowText;
        }

        private void Exit(object obj)
        {
            System.Windows.Application.Current.Shutdown();
        }

    }

}
} 