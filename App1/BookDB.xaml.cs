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
    public sealed partial class BookDB : Page
    {
        public BookDB()
        {
            this.InitializeComponent();
            pageHeader.Source = BL_PageContent.HeaderLogo;
            txtBoxFooter.Text = BL_PageContent.CreatedBy;
        }

        private void pageNav_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void add_Book_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Add2DB));
        }

        private void button_listall_Click(object sender, RoutedEventArgs e)
        {
           RefreshDatabase();
        }
        public class childrens_book_db
        {
            public string ID { get; set; }
            public string Text { get; set; }
            public string Book_Title { get; set; }
            public string Author_First { get; set; }
            public string Author_Middle { get; set; }
            public string Author_Last { get; set; }
            public string ISBN_Num { get; set; }
            public Boolean deleted { get; set; }
            public string Pub_Name { get; set; }
            public string Gps_Checkin { get; set; }
            public bool Complete { get; internal set; }
        }

        IMobileServiceTable<childrens_book_db> bookTable = App.MobileService.GetTable<childrens_book_db>();

        MobileServiceCollection<childrens_book_db, childrens_book_db> items;

        // Display All Books
        public async Task RefreshDatabase()
        {
            MobileServiceInvalidOperationException exception = null;

            try
            {
                // This code refreshes the entries in the list view by querying the TodoItems table.
                // The query excludes completed TodoItems

                items = await bookTable

                .Where(childrens_book_db => childrens_book_db.deleted == false)

                .ToCollectionAsync();
            }
            catch (MobileServiceInvalidOperationException e)
            {
                exception = e;
            }
            if (exception != null)
            {
                await new MessageDialog(exception.Message, "Error loading items").ShowAsync();
            }
            else
            {
                ListBooks.ItemsSource = items;
             
            }
        }

        private void search_Book_Click(object sender, RoutedEventArgs e)
        {
            searchDatabase(search_textBox.Text.ToString());
        }

        public async Task searchDatabase(string searchTerm)
        {
            MobileServiceInvalidOperationException exception = null;

            try
            {
                // This code refreshes the entries in the list view by querying the TodoItems table.
                // The query excludes completed TodoItems

                items = await bookTable

                .Where(childrens_book_db => childrens_book_db.Author_Last.ToUpper() == searchTerm.ToUpper())

                .ToCollectionAsync();
            }
            catch (MobileServiceInvalidOperationException e)
            {
                exception = e;
            }
            if (exception != null)
            {
                await new MessageDialog(exception.Message, "Error loading items").ShowAsync();
            }
            else
            {
                ListBooks.ItemsSource = items;

            }
        }
    }
}

