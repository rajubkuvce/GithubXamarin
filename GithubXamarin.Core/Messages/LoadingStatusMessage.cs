﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Plugins.Messenger;

namespace GithubXamarin.Core.Messages
{
    /// <summary>
    /// Activates and deactivates the loading indicator in the UI
    /// </summary>
    public class LoadingStatusMessage : MvxMessage
    {
        public LoadingStatusMessage(object sender) : base(sender)
        {
        }

        public bool IsLoadingIndicatorActive { get; set; }
    }
}
