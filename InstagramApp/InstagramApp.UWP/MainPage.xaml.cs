﻿using Windows.Foundation;
using Windows.UI.ViewManagement;

namespace InstagramApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadApplication(new InstagramApp.App());
        }
    }
}
