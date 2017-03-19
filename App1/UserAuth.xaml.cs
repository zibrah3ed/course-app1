﻿using System;
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

using SQLite;
using SQLite.Net;
using SQLite.Net.Async;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TysonFunkApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserAuth : Page
    {
        private IMobileServiceSyncTable<User_Cred> todoGetTable = App.MobileService.GetSyncTable<User_Cred>();

        public UserAuth()
        {
            this.InitializeComponent();
            txtBoxFooter.Text = BL_PageContent.CreatedBy;
            pageHeader.Source = BL_PageContent.HeaderLogo;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        public int IsAuth { get; set; }

        //[DataTable("Auth_Cred")]
        public class User_Cred
        {
            public string id { get; set; }
            public string FullName { get; set; }
            public string UserID { get; set; }
            public string Password { get; set; }
        }

        

        private async Task InitLocalStoreAsync()
        {
            if (!App.MobileService.SyncContext.IsInitialized)
            {
                var store = new MobileServiceSQLiteStore("Rasmussen.db");
                store.DefineTable<User_Cred>();
                await App.MobileService.SyncContext.InitializeAsync(store);
            }
            await SyncAsync();
        }

        private async Task SyncAsync()
        {
            await App.MobileService.SyncContext.PushAsync();
            await todoGetTable.PullAsync("User_Cred", todoGetTable.CreateQuery());
        }



        async private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            InitLocalStoreAsync();

            GetAuthentication();

        }

        async public void GetAuthentication()
        {
            try
            {

                //IMobileServiceTable<User_Cred> todoTable = App.MobileService.GetTable<User_Cred>();

                List<User_Cred> items = await todoGetTable
                    .Where(User_Cred => User_Cred.UserID == txtBoxUserId.Text)
                    .ToListAsync();

                IsAuth = items.Count();

                foreach (var value in items)
                {
                    var dialog = new MessageDialog("UserID: " + value.UserID);
                    await dialog.ShowAsync();
                }


                if (IsAuth > 0)
                {
                    var dialog = new MessageDialog("You are Authenticated");
                    await dialog.ShowAsync();

                }
                else
                {
                    var dialog = new MessageDialog("User Must Register - Account Does Not Exist");
                    await dialog.ShowAsync();
                }
            }
            catch (Exception em)
            {
                var dialog = new MessageDialog("An Error Occured: " + em.Message);
                await dialog.ShowAsync();
            }
        }

        async private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User_Cred itemReg = new User_Cred
                {
                    FullName = "System Test",
                    UserID = txtBoxUserId.Text,
                    Password = txtBoxPasswd.Text
                };
                await App.MobileService.GetTable<User_Cred>().InsertAsync(itemReg);
                var dialog = new MessageDialog("Successful!");
                await dialog.ShowAsync();
            }
            catch (Exception em)
            {
                var dialog = new MessageDialog("An Error Occured: " + em.Message);
                await dialog.ShowAsync();
            }

        }

        private void btnSync_Click(object sender, RoutedEventArgs e)
        {
            InitLocalStoreAsync();
        }
    }

    
}
