﻿using Prism.Navigation;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System.Windows.Input;

namespace PrismSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            this.Navigate = ReactiveCommand.CreateFromTask<string>(async arg =>
            {
                IsPresented = false;
                await navigationService.NavigateAsync(arg);
            });
        }

        public ICommand Navigate { get; }
        [Reactive] public bool IsPresented { get; set; }
    }
}