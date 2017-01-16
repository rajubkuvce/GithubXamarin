﻿using System;
using GithubXamarin.Core.Contracts.Service;
using GithubXamarin.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace GithubXamarin.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<EventsViewModel>();
        }
    }
}
