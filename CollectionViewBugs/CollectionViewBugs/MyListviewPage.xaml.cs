using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CollectionViewBugs
{
    public class LabelDisplay
    {
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }
    }
    public partial class MyListviewPage : ContentPage
    {
        Random rnd;
        public MyListviewPage()
        {
            InitializeComponent();

            BindingContext = this;
            rnd = new Random();

            var lista = new ObservableCollection<LabelDisplay>();
            for (int i = 0; i < 30; i++)
            {
                lista.Add(new LabelDisplay
                {
                    Text1 = RandomString(8),
                    Text2 = RandomString(28),
                    Text3 = rnd.Next(1, 30).ToString(),
                    Text4 = $"{rnd.Next(1, 30)}.{rnd.Next(1, 30)}€"
                }); ;
            }


            listViewLabels.ItemsSource = lista;
        }


        public string RandomString(int size, bool lowerCase = false)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rnd.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
    }
}
