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
using System.Windows.Data;
using Stocker.Uygula;
using Stocker.Web;
using Stocker.Views;
namespace Stocker.Views
{
    public partial class StokEkle : ChildWindow
    {
        Yönetim ynt = new Yönetim();
        public StokEkle()
        {
            InitializeComponent();
        }
        private void kayıt_Click(object sender, RoutedEventArgs e)
        {
            Bıcımlendır bcm = new Bıcımlendır();
            UygulayıcıClient ynt = new UygulayıcıClient();
           
            bcm.UrunKodu = Convert.ToInt32(ürkodbox.Text);
            bcm.UrunIsmı = Convert.ToString(ürisimbox.Text);
            bcm.UrunFıyat = Convert.ToInt32(ürfiyatbox.Text);
            bcm.UruhnAcıklama = Convert.ToString(üracıklamabox.Text);
            ynt.EklemeCompleted += new EventHandler<EklemeCompletedEventArgs>(Eklemeleri_Tetikle);
            ynt.EklemeAsync(bcm);
            HepsiniYukle();
        }
        private void Eklemeleri_Tetikle(object sender, EklemeCompletedEventArgs e)
        {
            if (e.Result > 0)
            {
                basarılı.Visibility = Visibility.Visible;
                HepsiniYukle();
            }
            else
            {
                MessageBox.Show("eklenmedi");
            }
        }
        private void HepsiniYukle()
        {
            UygulayıcıClient uyg = new UygulayıcıClient();
            uyg.TümKayıtlarıAlCompleted += new EventHandler<TümKayıtlarıAlCompletedEventArgs>(Tum_Kayıtları_Al);
            uyg.TümKayıtlarıAlAsync();
        }
        private void Tum_Kayıtları_Al(object sender, TümKayıtlarıAlCompletedEventArgs e)
        {
            PagedCollectionView pg = new PagedCollectionView(e.Result);
            ynt.kayıtlar.ItemsSource = pg;
        }
    }
}

