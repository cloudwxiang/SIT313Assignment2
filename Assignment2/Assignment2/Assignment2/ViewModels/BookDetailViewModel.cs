using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.ViewModels
{
    public class BookDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public BookDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
