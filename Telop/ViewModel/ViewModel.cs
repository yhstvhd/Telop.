using Moddel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Telop.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {
        private ImageSource telopImage;
        public ImageSource TelopImage
        {
            get => telopImage;
            set
            {
                telopImage = value;
                OnPropertyChanged("TelopImage");
            }
        }

        public ViewModel()
        {
            Disp();
        }

        public async Task Disp()
        {
            string TelopText = string.Empty;
            while (true)
            {
                TelopText = "午前１時５８分ごろ　関東地方で地震がありました";
                SetImage(TelopText);

                await Task.Delay(5000);
                TelopText = "この地震による津波の心配はありません";

                SetImage(TelopText);

                await Task.Delay(5000);

                TelopText = "震度５強　横浜栄区　横浜港南区　鎌倉市　藤沢市";
                SetImage(TelopText);
                await Task.Delay(5000);

                TelopText = "震度５弱　横浜金沢区　横浜磯子区　横須賀市　葉山町　逗子市";
                SetImage(TelopText);
                await Task.Delay(5000);

                TelopText = "震度４　横浜西区　横浜中区　横浜旭区　三浦市　大和市　綾瀬市　茅ヶ崎市";
                SetImage(TelopText);
                await Task.Delay(5000);


                TelopText = "震源は相模湾　　深さ５０km　マグニチュード６.２";
                SetImage(TelopText);
                await Task.Delay(5000);


                TelopText = "この地震による津波の心配はありません";
                SetImage(TelopText);
                await Task.Delay(5000);
            }
        }


        public void SetImage(string TelopText)
        {
            var img = DrawFacingText.Draw(TelopText);
            var imgSource = ConvertBitMapToImageSource.ToImageSource(img);
            TelopImage = imgSource;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
