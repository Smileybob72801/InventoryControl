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
		public string Title { get; } = "Inventory Control";
		
		public MainViewModel()
        {

        }

        private void LoadProducts()
        {
           
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
