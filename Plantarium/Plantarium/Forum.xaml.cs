﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Plantarium
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Forum : ContentPage
    {
        public Forum(string Username)
        {
            InitializeComponent();
        }
    }
}