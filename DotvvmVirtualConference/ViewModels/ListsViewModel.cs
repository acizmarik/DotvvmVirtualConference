using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;

namespace DotvvmVirtualConference.ViewModels
{
    public class ListsViewModel : MasterPageViewModel
    {
        public List<int> List { get; set; } = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    }
}

