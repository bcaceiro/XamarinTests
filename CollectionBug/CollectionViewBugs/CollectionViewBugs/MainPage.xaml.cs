﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewBugs
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        void NavigateList(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyListviewPage());
        }

        void NavigateCollectionView(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CollectionPage());
        }
    }

}