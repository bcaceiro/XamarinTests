using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CollectionViewBugs
{
    public partial class CollectionPageBindings : ContentPage
    {
        public CollectionPageBindings()
        {
            InitializeComponent();

            var list = new List<Tables>();
            for (int i = 0; i< 100; i++)
            {
                list.Add(new Tables { Number = i });
            }

            listviewtables.ItemsSource = list;
        }
    }
}
