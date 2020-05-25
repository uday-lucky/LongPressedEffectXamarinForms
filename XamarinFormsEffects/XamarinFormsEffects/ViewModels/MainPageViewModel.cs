using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsEffects.Models;

namespace XamarinFormsEffects.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand touchit { get; set; }
        public ObservableCollection<MainModel> dd {get;set;}
        public MainPageViewModel()
        {
            dd = new ObservableCollection<MainModel>();
            dd.Add(new MainModel {Age="21",Name="Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            dd.Add(new MainModel { Age = "21", Name = "Uday" });
            dd.Add(new MainModel { Age = "21", Name = "Adam" });
            touchit = new Command<MainModel>(longpressit);
        }

        public void longpressit(MainModel obj)
        {
            App.Current.MainPage.DisplayAlert("Alert",obj.Name.ToString(),"OK");
        }
    }
}
