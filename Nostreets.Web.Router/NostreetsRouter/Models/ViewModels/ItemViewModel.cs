using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nostreets.Web.Router.Models.ViewModels
{
    public class ItemViewModel<T> : BaseViewModel
    {
        public ItemViewModel(T data) { Item = data; }

        public T Item { get; set; }
    }
}