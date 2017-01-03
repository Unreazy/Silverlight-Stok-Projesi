using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ServiceModel.DomainServices.Client.ApplicationServices;
using Stocker.Views;
using Stocker.Uygula;
namespace Stocker
{
    public partial class MainPage : UserControl
    {
        Yönetim yn = new Yönetim();
        public MainPage()
        {
            InitializeComponent();
        }
        private void GörünümüKontrolEt(bool gr)
        {
            if (gr)
            {
                this.uygırısı.Visibility = Visibility.Collapsed;
                this.kuladı.Visibility = Visibility.Collapsed;
                this.kulbox.Visibility = Visibility.Collapsed;
                this.passbox.Visibility = Visibility.Collapsed;
                this.sıfre.Visibility = Visibility.Collapsed;
                this.giris.Visibility = Visibility.Collapsed;
                this.icgrid.Visibility = Visibility.Collapsed;
                this.icborder.Visibility = Visibility.Collapsed;
                this.anaresim.Visibility = Visibility.Collapsed;
                this.hata_mesajı.Visibility = Visibility.Collapsed;
            }
        }
        private void Login_Op_Completed(LoginOperation lo)
        {

            if (lo.HasError)
            {
                this.hata_mesajı.Text = lo.Error.Message;
                this.hata_mesajı.Visibility = Visibility.Visible;
                this.dikkatıco.Visibility = Visibility.Visible;
                lo.MarkErrorAsHandled();
            }
            else if (lo.LoginSuccess == false)
            {
                this.hata_mesajı.Visibility = Visibility.Visible;
                this.dikkatıco.Visibility = Visibility.Visible;
            }
            else if (lo.LoginSuccess == true)
            {
                GörünümüKontrolEt(true);
                this.Content = yn;
                //this.nav.Navigate(new Uri("/Views/Yonet.xaml", UriKind.Relative));
            }

        }

        private void giris_Click(object sender, RoutedEventArgs e)
        {
            if (kulbox.Text == string.Empty && passbox.Password == string.Empty)
            {
                this.hata_mesajı.Visibility = Visibility.Visible;
                this.dikkatıco.Visibility = Visibility.Visible;

            }
            else
            {
                LoginParameters lp = new LoginParameters(kulbox.Text, passbox.Password);
                WebContext.Current.Authentication.Login(lp, this.Login_Op_Completed, null);
            }
        }
    }
}
