﻿using System.Waf.Applications;

namespace Waf.InformationManager.EmailClient.Modules.Applications.Views
{
    public interface IEmailAccountsView : IView
    {
        void ShowDialog(object owner);
    }
}
