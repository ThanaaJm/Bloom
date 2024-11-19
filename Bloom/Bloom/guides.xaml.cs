using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bloom
{
    public partial class guides : TabbedPage
    {
        ObservableCollection<Class2> l1;
        ObservableCollection<Class2> l2;
        ObservableCollection<Class2> l3;
        ObservableCollection<Class2> l4;
        ObservableCollection<Class2> l5;
        public guides()
        {
            InitializeComponent();
            l1 = new ObservableCollection<Class2>
            {
                new Class2{text="Burping",img="f1"},
                  new Class2{text="Babycare basics",img="f2"},
                    new Class2{text="Bathig your newborn",img="f3"},

            };
            F.ItemsSource = l1;
            l2 = new ObservableCollection<Class2>
            {
                new Class2{text="Hush little baby, don't you cry",img="f4"},
                  new Class2{text="How much crying is normal ? ",img="f5"},
                    new Class2{text="How to soothe a crying baby",img="f6"},

            };
            a.ItemsSource = l2;

            l3 = new ObservableCollection<Class2>
            {
                new Class2{text="About breastfeeding",img="f7"},
                  new Class2{text="Burping your baby",img="f8"},
                    new Class2{text="Baby led weaning",img="f9"},

            };
            m.ItemsSource = l3;

            l4 = new ObservableCollection<Class2>
            {
                new Class2{text="Keeping your baby safe",img="f13"},
                  new Class2{text="Car seat best practices",img="f14"},
                    new Class2{text="Choking hazards",img="f15"},

            };
            H.ItemsSource = l4;

            l5 = new ObservableCollection<Class2>
            {
                new Class2{text="The 'dad look'",img="f10"},
                  new Class2{text="The first Day alone",img="f11"},
                    new Class2{text="The power of dad play",img="f12"},

            };
            i.ItemsSource = l5;
        }


        private void F_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var it = e.CurrentSelection[0] as Class2;
            if (it.text == "Burping")
            {
                Navigation.PushAsync(new Page1());
            }
            else if (it.text == "Babycare basics")
            {
                Navigation.PushAsync(new Page2());
            }
            else if (it.text == "Bathig your newborn")
            {
                Navigation.PushAsync(new Page3());
            }
        }

        private void a_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var it = e.CurrentSelection[0] as Class2;
            if (it.text == "Hush little baby, don't you cry")
            {
                Navigation.PushAsync(new Page4());
            }
            else if (it.text == "How much crying is normal ?")
            {
                Navigation.PushAsync(new Page5());
            }
            else if (it.text == "How to soothe a crying baby")
            {
                Navigation.PushAsync(new Page6());
            }

        }



        private void m_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var it = e.CurrentSelection[0] as Class2;
            if (it.text == "About breastfeeding")
            {
                Navigation.PushAsync(new Page7());
            }
            else if (it.text == "Burping your baby")
            {
                Navigation.PushAsync(new Page8());
            }
            else if (it.text == "Baby led weaning")
            {
                Navigation.PushAsync(new Page9());
            }

        }
        private void H_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var it = e.CurrentSelection[0] as Class2;
            if (it.text == "Keeping your baby safe")
            {
                Navigation.PushAsync(new Page10());
            }
            else if (it.text == "Car seat best practices")
            {
                Navigation.PushAsync(new Page11());
            }
            else if (it.text == "Choking hazards")
            {
                Navigation.PushAsync(new Page12());
            }
        }

        private void i_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var it = e.CurrentSelection[0] as Class2;
            if (it.text == "The 'dad look'")
            {
                Navigation.PushAsync(new Page13());
            }
            else if (it.text == "The first Day alone")
            {
                Navigation.PushAsync(new Page14());
            }
            else if (it.text == "The power of dad play")
            {
                Navigation.PushAsync(new Page15());
            }
        }


    }
}