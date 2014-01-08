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
    /// moviebuzz_Detail ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface Imoviebuzz_DetailViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentRssSearchResult property.
        /// </summary>
		EntitiesBase.RssSearchResult CurrentRssSearchResult { get; set; }
        /// <summary>
        /// Gets/Sets the HasNextpanoramamoviebuzz_Detail0 property.
        /// </summary>
		bool HasNextpanoramamoviebuzz_Detail0 { get; set; }
        /// <summary>
        /// Gets/Sets the HasPreviouspanoramamoviebuzz_Detail0 property.
        /// </summary>
		bool HasPreviouspanoramamoviebuzz_Detail0 { get; set; }
	    /// <summary>
        /// IsInternetAvailable property.
        /// </summary>		
        Visibility IsInternetAvailable { get; }
        
        /// <summary>
        /// Gets the TextToSpeechmoviebuzz_DetailStaticControlCommand command.
        /// </summary>
		ICommand TextToSpeechmoviebuzz_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the Sharemoviebuzz_DetailStaticControlCommand command.
        /// </summary>
		ICommand Sharemoviebuzz_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartmoviebuzz_DetailStaticControlCommand command.
        /// </summary>
		ICommand PinToStartmoviebuzz_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the GoToSourcemoviebuzz_DetailStaticControlCommand command.
        /// </summary>
		ICommand GoToSourcemoviebuzz_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the Nextpanoramamoviebuzz_Detail0 command.
        /// </summary>
		ICommand Nextpanoramamoviebuzz_Detail0 { get; }

        
        /// <summary>
        /// Gets the Previouspanoramamoviebuzz_Detail0 command.
        /// </summary>
		ICommand Previouspanoramamoviebuzz_Detail0 { get; }

	}
}
