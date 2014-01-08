// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	ViewModel.tt
// Version:		2.0
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls = WPAppStudio.Controls;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;
using IServices = WPAppStudio.Services.Interfaces;
using IViewModels = WPAppStudio.ViewModel.Interfaces;
using Localization = WPAppStudio.Localization;
using Repositories = WPAppStudio.Repositories;
using Services = WPAppStudio.Services;
using ViewModelsBase = WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of start_Menu ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class start_MenuViewModel : ViewModelsBase.VMBase, IViewModels.Istart_MenuViewModel
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ILockScreenService _lockScreenService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="start_MenuViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="lockScreenService">The Lock Screen Service.</param>
        public start_MenuViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ILockScreenService lockScreenService)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_lockScreenService = lockScreenService;
        }
		
	
		private Controls.MenuItemData _selectedstart_MenuMenuControl;

        /// <summary>
        /// Selectedstart_MenuMenuControl property.
        /// </summary>		
        public Controls.MenuItemData Selectedstart_MenuMenuControl
        {
            get
            {
				return _selectedstart_MenuMenuControl;
            }
            set
            {
                _selectedstart_MenuMenuControl = value;
                if (value != null)
                    _navigationService.NavigateTo(value);
            }
        }
	    /// <summary>
        /// IsInternetAvailable property.
        /// </summary>		
        public override Visibility IsInternetAvailable
        {
	      get
          {
				return Visibility.Collapsed; 
           }
		}

        /// <summary>
        /// Delegate method for the SetLockScreenCommand command.
        /// </summary>
        public  void SetLockScreenCommandDelegate() 
        {
				_lockScreenService.SetLockScreen("LockScreen-2b67af4e-cdc3-476d-8a08-ad77a79cdd50.jpg");
        }
		

        private ICommand _setLockScreenCommand;

        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
        public ICommand SetLockScreenCommand
        {
            get { return _setLockScreenCommand = _setLockScreenCommand ?? new ViewModelsBase.DelegateCommand(SetLockScreenCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the AboutCommand command.
        /// </summary>
        public  void AboutCommandDelegate() 
        {
				_navigationService.NavigateTo<IViewModels.IAboutViewModel>();
        }
		

        private ICommand _aboutCommand;

        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
        public ICommand AboutCommand
        {
            get { return _aboutCommand = _aboutCommand ?? new ViewModelsBase.DelegateCommand(AboutCommandDelegate); }
        }
    }
}
