using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Stocker.Views;
using Stocker.Uygula;
using System.ComponentModel;
namespace Stocker.Views
{
    public partial class Yönetim : UserControl
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private PagedCollectionView görüntüle;
        public Yönetim()
        {
            InitializeComponent();
        
        }

        private void ekleme_Click(object sender, RoutedEventArgs e)
        {
            StokEkle kl = new StokEkle();
            kl.Show();
        }
   
        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            UygulayıcıClient ynt = new UygulayıcıClient();
            ynt.TümKayıtlarıAlCompleted += new EventHandler<TümKayıtlarıAlCompletedEventArgs>(Tum_Kayıtları_Al);
            ynt.TümKayıtlarıAlAsync();
           
        }
        private void Tum_Kayıtları_Al(object sender, TümKayıtlarıAlCompletedEventArgs e)
        {
            Görüntüle = new PagedCollectionView(e.Result);
            kayıtlar.ItemsSource = Görüntüle;
        }
        private void kayıtlar_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(Satır_Yuklemelerini_aL);
        }
        private void Satır_Yuklemelerini_aL(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Bıcımlendır bcm = (Bıcımlendır)kayıtlar.SelectedItem;
            KoduDüzenleme = bcm.UrunKodu.ToString();
            İsmiDüzenleme = bcm.UrunIsmı;
            FiyatıDüzenleme = bcm.UrunFıyat.ToString();
            AcıklamaDüzenleme = bcm.UruhnAcıklama;
           
        }
        private void HepsiniYukle()
        {
            UygulayıcıClient uyg = new UygulayıcıClient();
            uyg.TümKayıtlarıAlCompleted += new EventHandler<TümKayıtlarıAlCompletedEventArgs>(Tum_Kayıtları_Al);
            uyg.TümKayıtlarıAlAsync();
        }
        //private void kayıtlar_Loaded(object sender, RoutedEventArgs e)
        //{
        //    HepsiniYukle();
        //}

        private void guncelleme_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Bıcımlendır bcm = new Bıcımlendır();
                UygulayıcıClient ynt = new UygulayıcıClient();
                ynt.GüncelleCompleted += new EventHandler<GüncelleCompletedEventArgs>(Guncelleme_Tetikle);

                bcm.UrunKodu = Convert.ToInt32(dz1box.Text);
                bcm.UrunIsmı = dzBox2.Text;
                bcm.UrunFıyat = Convert.ToInt32(dzBox3.Text);
                bcm.UruhnAcıklama = dzBox4.Text;
                ynt.GüncelleAsync(bcm);
            }
            catch (FormatException ef)
            {
                System.Console.WriteLine(ef.Message);
            }            
        }
        private void Guncelleme_Tetikle(object sender, GüncelleCompletedEventArgs e)
        {
            if (e.Result > 0)
            {
                MessageBox.Show("Güncelledi", "Güncellensin mi", MessageBoxButton.OK);
                HepsiniYukle();
            }
        }
        private void silme_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                UygulayıcıClient ynt = new UygulayıcıClient();
                ynt.SilmeCompleted += new EventHandler<SilmeCompletedEventArgs>(Silme_Tetiklemesi);
                ynt.SilmeAsync(Convert.ToInt32(dz1box.Text));
                HepsiniYukle();
            }
            catch (FormatException efx)
            {
                MessageBox.Show("{0}Sıfır Grişi Hatası Oluştu{1}"+efx.Message);
            }
        }
        private void Silme_Tetiklemesi(object sender, SilmeCompletedEventArgs e)
        {
            if (e.Result)
            { 
                MessageBox.Show("Kayıt Silinsin mi", "SİL", MessageBoxButton.OKCancel);
                //HepsiniYukle();
                
            }
            //else
            //{
            //    MessageBox.Show("Kayıtı Sil", "asa", MessageBoxButton.OK);
            //}

        }

        private void kayıtlar_RowEditEnded(object sender, DataGridRowEditEndedEventArgs e)
        {
            Bıcımlendır bcm = new Bıcımlendır();
            UygulayıcıClient ynt = new UygulayıcıClient();
            ynt.GüncelleCompleted += new EventHandler<GüncelleCompletedEventArgs>(Guncelleme_Tetikle);
            bcm.UrunKodu = Convert.ToInt32(dz1box.Text);
            bcm.UrunIsmı = dzBox2.Text;
            bcm.UrunFıyat = Convert.ToInt32(dzBox3.Text);
            bcm.UruhnAcıklama = dzBox4.Text;
            ynt.GüncelleAsync(bcm);
            HepsiniYukle();
        }
        public string KoduDüzenleme
        {
            get
            { return dz1box.Text; }
            set
            {
                dz1box.Text = value;
            }
        }
        public string İsmiDüzenleme
        {
            get
            { return dzBox2.Text; }
            set
            {
                dzBox2.Text = value;
            }
        }
        public string FiyatıDüzenleme
        {
            get
            { return dzBox3.Text; }
            set
            {
                dzBox3.Text = value;
            }
        }
        public string AcıklamaDüzenleme
        {
            get
            { return dzBox4.Text; }
            set
            {
                dzBox4.Text = value;
            }
        }
        public PagedCollectionView Görüntüle
        {
            get
            { return görüntüle; }
            set
            {
                görüntüle = value;
                OnPropertyChanged("görüntüle");
            }
        }
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

            Görüntüle.Filter = null;
            Görüntüle.Filter = delegate(object o)
            {
                Uygula.Bıcımlendır bcm = o as Uygula.Bıcımlendır;

                if (bcm != null)
                {
                    if (bcm.UrunIsmı.Contains(aramadurumu.Text))
                    {
                        return true;
                    }

                }
                return false;
            };
        }
        
        //public void AramayıFiltrele(string arm)
        //{
        //    this.arama = arm;
        //    Görüntüle.Filter = null;
        //    Görüntüle.Filter = new Predicate<object>(Filtrele);

        //}
        //private bool Filtrele(object obj)
        //{
        //    var vr = obj as Stocker.Uygula.Bıcımlendır;

        //    return vr != null && (vr.UrunIsmı.ToLower().IndexOf(arama) >= 0);
        //}
        public void OnPropertyChanged(string propname)
        {
            var hand = PropertyChanged;
            if (hand != null)
            {
                hand(this, new PropertyChangedEventArgs(propname));
            }
        }
    }
}
