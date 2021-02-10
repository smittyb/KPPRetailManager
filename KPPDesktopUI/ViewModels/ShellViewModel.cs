using Caliburn.Micro;
using KPPDesktopUI.EventModels;
using KPPDesktopUI.Library.Api;
using KPPDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPPDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        //// TODO - removed per start of lesson 23
        //private LoginViewModel _loginVM;
        private IEventAggregator _events;
        private SalesViewModel _salesVM;
        private ILoggedInUserModel _user;
        //// TODO -- added per start of lesson 23
        //private IAPIHelper _apiHelper;

        // TODO -- added per start of lesson 23 below was before
        //public ShellViewModel(IEventAggregator events, SalesViewModel salesVM, ILoggedInUserModel user)
        public ShellViewModel(IEventAggregator events, SalesViewModel salesVM, ILoggedInUserModel user, IAPIHelper apiHelper)
        {
            _events = events;
            _salesVM = salesVM;
            _user = user;
            // TODO -- added per start of lesson 23
            _apiHelper = APIHelper;

            _events.Subscribe(this);

            ActivateItem(IoC.Get<LoginViewModel>());
        }

        public bool IsLoggedIn
        {
            get
            {
                bool output = false;
                if (string.IsNullOrWhiteSpace(_user.Token) == false)
                {
                    output = true;
                }
                return output;
            }
        }

        public void ExitApplication()
        {
            TryClose();
        }

        public void LogOut()
        {
            _user.ResetUserModel();
            // TODO -- added per start of lesson 23
            _apiHelper.LogOffUser();
            ActivateItem(IoC.Get<LoginViewModel>());
            NotifyOfPropertyChange(() => IsLoggedIn);
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
            NotifyOfPropertyChange(() => IsLoggedIn);
        }
    }
}
