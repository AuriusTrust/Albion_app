using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Albion_app_2.Models;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace Albion_app_2
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Page1_Equipment : Page
    {
        private List<Cuirs_Equipements> Cuirs;

        public Page1_Equipment()
        {
            this.InitializeComponent();
            Cuirs = CuirManager.GetCuirs();

        }

        public String categorieResult { get; set; }
        public String rang { get; set; }
        public String enchantement { get; set; }
        public String pano { get; set; }
        public String type { get; set; }
        public String SortieImage { get; set; }



        // Bouton retour
        private void RetourButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        // Bouton Accueil
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        // Bouton Equipements
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page1_Equipment));
        }

        // Bouton Armes
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page2_Armes));
        }

        // Bouton Outils
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page3_Outils));
        }

        // Bouton Monture
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page4_Monture));
        }

        // Bouton PNJ
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page5_PNJ));
        }

        // Bouton Agriculture
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page6_Agriculture));
        }

        // Bouton Consommable 
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page7_Consommables));
        }

        // Catégorie
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;

            categorieResult = item.Content.ToString();
        }

        // Rang
        private void ComboBox_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;

            rang = item.Content.ToString();
        }

        // Pano
        private void ComboBox_SelectionChanged3(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;

            pano = item.Content.ToString();
        }

        // Type
        private void ComboBox_SelectionChanged4(object sender, SelectionChangedEventArgs e)
        {
            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;

            type = item.Content.ToString();
        }

        

        /*
        private void radio1_Checked(object sender, RoutedEventArgs e)
        {
            if( radio1.IsChecked ?? true)
            {
                
            }
            else if (radio2.IsChecked ?? true)
            {

            }
            else if (radio3.IsChecked ?? true)
            {

            }
        }*/


        //Enchantements

        //T.1
        private void enchantement_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            retourTest.Text = "1";    
                //var enchantement = "1";
        }

        //T.2
        private void enchantement2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            enchantement = "2";
        }

        //T.3
        private void enchantement3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            enchantement = "3";

        }

        // Ici on test !
        private void Test(object sender, RoutedEventArgs e)
        {
            if(categorieResult == "Cuir")
            {
                if(rang == "1")
                {
                    if(type == "Tête")
                    {
                        retourTest.Text = categorieResult;
                        
                    }
                    else if(type == "Torse")
                    {

                    }
                    else if (type == "Pied")
                    {

                    }
                }
                else if (rang == "2")
                {

                }
                else if (rang == "3")
                {

                }
                else if (rang == "4")
                {

                }
            }

            else if (categorieResult == "Tissu")
            {

            }

            else if (categorieResult == "Tissu")
            {

            }


            
        }
    }
}
