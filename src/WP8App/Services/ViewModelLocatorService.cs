// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   	ServiceLocator.tt
// Version:		2.0
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using IIoc = WPAppStudio.Ioc.Interfaces;
using Ioc = WPAppStudio.Ioc;
using IViewModels = WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Services
{
    /// <summary>
    /// Implementation of the ViewModel locator service based on IoC.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class ViewModelLocatorService
    {
        // IoC container
        private readonly IIoc.IContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelLocatorService" /> class.
        /// </summary>
        public ViewModelLocatorService()
        {
            _container = new Ioc.Container();
        }
		
		/// <summary>
        /// Resolve a service of type T
        /// </summary>
        /// <typeparam name="T">Type of the service.</typeparam>
        /// <returns></returns>
        public T ResolveService<T>()
        {
            return _container.Resolve<T>();
        }

        /// <summary>
        /// Gets the reference to a start_MenuViewModel.
        /// </summary>
		public IViewModels.Istart_MenuViewModel start_MenuViewModel
        {
            get { return _container.Resolve<IViewModels.Istart_MenuViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a intheaters_NewsViewModel.
        /// </summary>
		public IViewModels.Iintheaters_NewsViewModel intheaters_NewsViewModel
        {
            get { return _container.Resolve<IViewModels.Iintheaters_NewsViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a intheaters_DetailViewModel.
        /// </summary>
		public IViewModels.Iintheaters_DetailViewModel intheaters_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.Iintheaters_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a movieoftheweek_NewsViewModel.
        /// </summary>
		public IViewModels.Imovieoftheweek_NewsViewModel movieoftheweek_NewsViewModel
        {
            get { return _container.Resolve<IViewModels.Imovieoftheweek_NewsViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a movieoftheweek_DetailViewModel.
        /// </summary>
		public IViewModels.Imovieoftheweek_DetailViewModel movieoftheweek_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.Imovieoftheweek_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a moviebuzz_NewsViewModel.
        /// </summary>
		public IViewModels.Imoviebuzz_NewsViewModel moviebuzz_NewsViewModel
        {
            get { return _container.Resolve<IViewModels.Imoviebuzz_NewsViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a moviebuzz_DetailViewModel.
        /// </summary>
		public IViewModels.Imoviebuzz_DetailViewModel moviebuzz_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.Imoviebuzz_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a newondvd_NewsViewModel.
        /// </summary>
		public IViewModels.Inewondvd_NewsViewModel newondvd_NewsViewModel
        {
            get { return _container.Resolve<IViewModels.Inewondvd_NewsViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a newondvd_DetailViewModel.
        /// </summary>
		public IViewModels.Inewondvd_DetailViewModel newondvd_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.Inewondvd_DetailViewModel>(); }
        }
		/// <summary>
        /// Gets the reference to a AboutViewModel.
        /// </summary>
		public IViewModels.IAboutViewModel AboutViewModel
        {
            get { return _container.Resolve<IViewModels.IAboutViewModel>(); }
        }
		
		/// <summary>
        /// Gets the reference to a LicenseViewModel.
        /// </summary>
		public IViewModels.ILicenseViewModel LicenseViewModel
        {
            get { return _container.Resolve<IViewModels.ILicenseViewModel>(); }
        }
    }
}