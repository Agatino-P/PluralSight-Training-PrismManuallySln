using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using PrismManuallyApp.Core.Regions;
using PrismManuallyApp.Views;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PrismManuallyApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication

    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellWindow>();   
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(StackPanel),
                 Container.Resolve<StackPanelRegionAdapter>());
        }
    }
}
