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
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Storage;
using System.Net.Http;
using Newtonsoft.Json;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TysonFunkApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Add2DB : Page
    {
        public Add2DB()
        {
            this.InitializeComponent();
            pageHeader.Source = BL_PageContent.HeaderLogo;
            txtBoxFooter.Text = BL_PageContent.CreatedBy;
        }
        private async void InsertRecord()
        {
            try
            {

                BookDB.childrens_book_db item = new BookDB.childrens_book_db
                {
                    Book_Title = txtBox_title.Text,
                    Author_First = txtBox_auth_first.Text,
                    Author_Last = txtBox_auth_last.Text,
                    Author_Middle = txtBox_auth_mid.Text,
                    ISBN_Num = txtBox_isbn.Text,
                    Pub_Name = txtBox_publisher.Text,
                    Gps_Checkin = txtBox_gps.Text
                };
                await App.MobileService.GetTable<BookDB.childrens_book_db>().InsertAsync(item);

                //using Windows.UI.Popups;
                MessageDialog messageDialog = new MessageDialog("Completed Successfully!", "WinCloud CP");
                await messageDialog.ShowAsync();

            }
            catch (Exception e)
            {
                MessageDialog messageDialog = new MessageDialog("An Error Occurred: " + e.Message, "WinCloud CP");
                await messageDialog.ShowAsync();
            }
        }
        private void pageNav_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void add_Book_Click(object sender, RoutedEventArgs e)
        {
            InsertRecord();
        }

        private void previous_page_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BookDB));
        }
    }
}
