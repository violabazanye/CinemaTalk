// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	IViewModel.tt
// Version:		2.0
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities = WPAppStudio.Entities;
using EntitiesBase = WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// moviebuzz_News ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface Imoviebuzz_NewsViewModel
    {		
        /// <summary>
        /// Gets/Sets the Moviebuzz_NewsListControlCollection property.
        /// </summary>
		ObservableCollection<EntitiesBase.RssSearchResult> Moviebuzz_NewsListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Selectedmoviebuzz_NewsListControlCollection property.
        /// </summary>
		EntitiesBase.RssSearchResult Selectedmoviebuzz_NewsListControlCollection { get; set; }
	    /// <summary>
        /// IsInternetAvailable property.
        /// </summary>		
        Visibility IsInternetAvailable { get; }
        
        /// <summary>
        /// Gets the Refreshmoviebuzz_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand Refreshmoviebuzz_NewsListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the Getmoviebuzz_NewsListControlCollectionCommand command.
        /// </summary>
		ICommand Getmoviebuzz_NewsListControlCollectionCommand { get; }

	}
}
