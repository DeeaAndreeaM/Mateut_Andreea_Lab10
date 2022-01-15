﻿

using System;
using Mateut_Andreea_Lab10.Data;
using System.IO;
using Xamarin.Forms;

namespace Mateut_Andreea_Lab10
{
    public partial class App : Application
    {
        static ShoppingListDatabase database;
        public static ShoppingListDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                        LocalApplicationData), "ShoppingList.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
