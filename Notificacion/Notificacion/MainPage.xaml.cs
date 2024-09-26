using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notificacion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var Notification = new NotificationRequest
            {
                NotificationId=1000,
                Title="Enviaste un notificación",
                Description="Acaba de recibir una información desde la app",
                ReturningData="dato",
                Schedule= new NotificationRequestSchedule
                {
                    NotifyTime=DateTime.Now.AddSeconds(5),
                }
            };
            NotificationCenter.Current.Show(Notification);
        }
    }
}
