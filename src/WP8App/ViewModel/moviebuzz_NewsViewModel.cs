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
    /// Implementation of moviebuzz_News ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class moviebuzz_NewsViewModel : ViewModelsBase.VMBase, IViewModels.Imoviebuzz_NewsViewModel
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly Repositories.Imoviebuzz_reviewsDataSource _moviebuzz_reviewsDataSource;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="moviebuzz_NewsViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="moviebuzz_reviewsDataSource">The Moviebuzz_reviews Data Source.</param>
        public moviebuzz_NewsViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, Repositories.Imoviebuzz_reviewsDataSource moviebuzz_reviewsDataSource)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_moviebuzz_reviewsDataSource = moviebuzz_reviewsDataSource;
        }
		
	
		private ObservableCollection<EntitiesBase.RssSearchResult> _moviebuzz_NewsListControlCollection;

        /// <summary>
        /// Moviebuzz_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> Moviebuzz_NewsListControlCollection
        {
            get
            {
				
                if(_moviebuzz_NewsListControlCollection == null)
					Getmoviebuzz_NewsListControlCollectionData();
				return _moviebuzz_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _moviebuzz_NewsListControlCollection, value);
            }
        }
	
		private EntitiesBase.RssSearchResult _selectedmoviebuzz_NewsListControlCollection;

        /// <summary>
        /// Selectedmoviebuzz_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult Selectedmoviebuzz_NewsListControlCollection
        {
            get
            {
				return _selectedmoviebuzz_NewsListControlCollection;
            }
            set
            {
                _selectedmoviebuzz_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.Imoviebuzz_DetailViewModel>(_selectedmoviebuzz_NewsListControlCollection);
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
        /// Delegate method for the Refreshmoviebuzz_NewsListControlCollectionCommand command.
        /// </summary>
        public async void Refreshmoviebuzz_NewsListControlCollectionCommandDelegate() 
        {
			try
			{
				LoadingMoviebuzz_NewsListControlCollection = true;
				var items = await  _moviebuzz_reviewsDataSource.Refresh();
				Moviebuzz_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				Moviebuzz_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingMoviebuzz_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingMoviebuzz_NewsListControlCollection;
		
        public bool LoadingMoviebuzz_NewsListControlCollection
        {
            get { return _loadingMoviebuzz_NewsListControlCollection; }
            set { SetProperty(ref _loadingMoviebuzz_NewsListControlCollection, value); }
        }

        private ICommand _refreshmoviebuzz_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the Refreshmoviebuzz_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand Refreshmoviebuzz_NewsListControlCollectionCommand
        {
            get { return _refreshmoviebuzz_NewsListControlCollectionCommand = _refreshmoviebuzz_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand(Refreshmoviebuzz_NewsListControlCollectionCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the Getmoviebuzz_NewsListControlCollectionCommand command.
        /// </summary>
        public  void Getmoviebuzz_NewsListControlCollectionCommandDelegate(int pageNumber= 0) 
        {
				Getmoviebuzz_NewsListControlCollectionData(pageNumber);
        }
		

        private ICommand _getmoviebuzz_NewsListControlCollectionCommand;

        /// <summary>
        /// Gets the Getmoviebuzz_NewsListControlCollectionCommand command.
        /// </summary>
        public ICommand Getmoviebuzz_NewsListControlCollectionCommand
        {
            get { return _getmoviebuzz_NewsListControlCollectionCommand = _getmoviebuzz_NewsListControlCollectionCommand ?? new ViewModelsBase.DelegateCommand<int>(Getmoviebuzz_NewsListControlCollectionCommandDelegate); }
        }

        private async void Getmoviebuzz_NewsListControlCollectionData(int pageNumber = 0)
        {
	
			try
			{
				LoadingMoviebuzz_NewsListControlCollection = true;
			
				var items = await _moviebuzz_reviewsDataSource.GetData();
                Moviebuzz_NewsListControlCollection = items;
			}
            catch (Exception ex)
            {
				Moviebuzz_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingMoviebuzz_NewsListControlCollection = false;
			}
		}
    }
}