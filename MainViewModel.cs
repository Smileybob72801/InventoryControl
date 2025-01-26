using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace InventoryControl
{
    [POCOViewModel]
    public class MainViewModel
    {
        // This is ViewModel for our application
        public MainViewModel()
        {
            Title = "Inventory Control";
        }
        public string Title
        {
            get;
        }
        #region Lifetime
        public async Task OnCreate()
        {
            // Do some initialization (if required)
            await Task.CompletedTask;
        }
        public async Task OnDestroy()
        {
            // Do some cleanup (if required)
            await Task.CompletedTask;
        }
        #endregion Lifetime
    }
}
