﻿using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Distribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            MobileCenter.Start("60978d5a-dee0-43b8-885c-db7faf603da4",typeof(Distribute));
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
