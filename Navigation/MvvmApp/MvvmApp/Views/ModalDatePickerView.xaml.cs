using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmApp.ViewModels;
using Rg.Plugins.Popup.Pages;

using Xamarin.Forms;

namespace MvvmApp.Views
{
    public partial class ModalDatePickerView : PopupPage
    {
        public ModalDatePickerView(ModalDatePickerViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
