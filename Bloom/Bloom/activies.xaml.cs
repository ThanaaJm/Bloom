using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace Bloom
    {

        public partial class activies : TabbedPage
        {
            ObservableCollection<Class1> l1;
            ObservableCollection<Class1> l2;
            ObservableCollection<Class1> l3;
            ObservableCollection<Class1> l4;
            ObservableCollection<Class1> l5;
            public activies()
            {
                InitializeComponent();

                l1 = new ObservableCollection<Class1>
            {
              new Class1{text= "You are the entertainer", img ="p1" },
              new Class1{text= "Early sensory experiences", img ="p2" },
              new Class1{text= "How and when to start with tummy time", img ="p3" },
              new Class1{text= "Reading with baby every day", img ="p4" },
              new Class1{text= "Start tummy time early", img ="p5" },

            };
                co1.ItemsSource = l1;
                l2 = new ObservableCollection<Class1>
            {
                new Class1{text="Sandbox activities", img ="p6" },
                new Class1{text="When to start talking to your baby and why", img ="p7" },
                new Class1{text="5 benefits for your baby development through tummy time", img ="p8" },
                new Class1{text="3D objects", img ="p10" },

            };
                co2.ItemsSource = l2;
                l3 = new ObservableCollection<Class1>
            {
                new Class1{text="Rolling a ball", img ="p20" },
                new Class1{text="Reading is encouraging language", img ="p11" },
                new Class1{text="Conversations with your baby", img ="p12" },
                new Class1{text="Toddler touchables", img ="p13" },
            };
                co3.ItemsSource = l3;
                l4 = new ObservableCollection<Class1>
            {
                new Class1{text="Getting ready to walk", img ="p14" },
                new Class1{text="Moments for music", img ="p15" },
                new Class1{text="Get out and get active", img ="p16" }
            };
                co4.ItemsSource = l4;
                l5 = new ObservableCollection<Class1>
            {
                new Class1{text="Finding a rhythm", img = "p17" },
                new Class1{text="Hide and seek", img ="p18" },
                new Class1{text="Developing a voice", img = "p19" }
            };
                co5.ItemsSource = l5;
            }



            private void co1_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

                var it = e.CurrentSelection[0] as Class1;
                if (it.text == "You are the entertainer")
                {
                    Navigation.PushAsync(new l1_1());
                }
                else if (it.text == "Early sensory experiences")
                {
                    Navigation.PushAsync(new l1_2());
                }
                else if (it.text == "How and when to start with tummy time")
                {
                    Navigation.PushAsync(new l1_3());
                }
                else if (it.text == "Reading with baby every day")
                {
                    Navigation.PushAsync(new l1_4());
                }
                else if (it.text == "Start tummy time early")
                {
                    Navigation.PushAsync(new l1_5());
                }
            }

            private void co2_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                var it = e.CurrentSelection[0] as Class1;
                if (it.text == "Sandbox activities")
                {
                    Navigation.PushAsync(new l2_1());
                }
                else if (it.text == "When to start talking to your baby and why")
                {
                    Navigation.PushAsync(new l2_2());
                }
                else if (it.text == "5 benefits for your baby development through tummy time")
                {
                    Navigation.PushAsync(new l2_3());
                }
                else if (it.text == "3D objects")
                {
                    Navigation.PushAsync(new l2_4());
                }

            }

            private void co3_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                var it = e.CurrentSelection[0] as Class1;
                if (it.text == "Rolling a ball")
                {
                    Navigation.PushAsync(new l3_1());
                }
                else if (it.text == "Reading is encouraging language")
                {
                    Navigation.PushAsync(new l3_2());
                }
                else if (it.text == "Conversations with your baby")
                {
                    Navigation.PushAsync(new l3_3());
                }
                else if (it.text == "Toddler touchables")
                {
                    Navigation.PushAsync(new l3_4());
                }

            }

            private void co4_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                var it = e.CurrentSelection[0] as Class1;
                if (it.text == "Getting ready to walk")
                {
                    Navigation.PushAsync(new l4_1());
                }
                else if (it.text == "Moments for music")
                {
                    Navigation.PushAsync(new l4_2());
                }
                else if (it.text == "Get out and get active")
                {
                    Navigation.PushAsync(new l4_3());
                }

            }

            private void co5_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                var it = e.CurrentSelection[0] as Class1;
                if (it.text == "Finding a rhythm")
                {
                    Navigation.PushAsync(new l5_1());
                }
                else if (it.text == "Hide and seek")
                {
                    Navigation.PushAsync(new l5_2());
                }
                else if (it.text == "Developing a voice")
                {
                    Navigation.PushAsync(new l5_3());
                }

            }
        }
    }