using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notificacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            NotificationCenter.Current.NotificationTapped += OnLocalNotificationTapped;
        }
        private void OnLocalNotificationTapped(NotificationEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Notificación clickeada");
            Device.BeginInvokeOnMainThread(async () =>
            {
                await MainPage.Navigation.PushAsync(new HolaPage());
            });
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
