﻿using DotNetService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Plantarium
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Forum_Content : ContentPage
    {
        private string User;
        private string Headline;
        private string Poster;
        


        public Forum_Content(string Poster, string Headline, string User)
        {
            InitializeComponent();
           
            this.Headline = Headline;
            string Date, Time, Forum_Content;
            this.Poster = Poster;
            this.Headline = Headline;
            this.User = User;
            Service1Client srvc = new Service1Client();
            Forum_Content = srvc.GetForumContent(Poster, Headline, out Date, out Time);

            ForumContent_Label.Text = Forum_Content;
            DateLabel.Text = Date.Substring(0,10);
            UsernameLabel.Text = Poster;
            Forum_HeadlineLabel.Text = Headline;








        }

        private async void ViewCommentsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Comments(User,Headline,Poster));
        }
    }
}