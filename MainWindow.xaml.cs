using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       
        private MediaPlayer _mpBgr;
        private MediaPlayer _mpCurSound;
        public int click;
        public MainWindow()
        {
            InitializeComponent();
            _mpBgr = new MediaPlayer();
            _mpCurSound = new MediaPlayer();
            _mpBgr.Open(new Uri(@"M:\Загрузки\jin.wav"));
            _mpBgr.Play();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Build(object sender, RoutedEventArgs e)
        {
            click++;
            if (click == 1)
            {
                TranslateTransform trans = new TranslateTransform();
                firstsnow.RenderTransform = trans;
                DoubleAnimation animX = new DoubleAnimation(0, 50, TimeSpan.FromSeconds(1));
                trans.BeginAnimation(TranslateTransform.XProperty, animX);
                DoubleAnimation animY = new DoubleAnimation(0, 50, TimeSpan.FromSeconds(1));
                trans.BeginAnimation(TranslateTransform.YProperty, animY);
            }
               
            if (click ==2)
            {
                TranslateTransform trans2 = new TranslateTransform();
                secondsnow.RenderTransform = trans2;
                DoubleAnimation animX2 = new DoubleAnimation(0, 250, TimeSpan.FromSeconds(1));
                trans2.BeginAnimation(TranslateTransform.XProperty, animX2);
                DoubleAnimation animY2 = new DoubleAnimation(0, 0, TimeSpan.FromSeconds(1));
                trans2.BeginAnimation(TranslateTransform.YProperty, animY2);
            }
               
           if (click == 3)
            {
                TranslateTransform trans3 = new TranslateTransform();
                thirdsnow.RenderTransform = trans3;
                DoubleAnimation animX3 = new DoubleAnimation(0, -195, TimeSpan.FromSeconds(1));
                trans3.BeginAnimation(TranslateTransform.XProperty, animX3);
                DoubleAnimation animY3 = new DoubleAnimation(0, 175, TimeSpan.FromSeconds(1));
                trans3.BeginAnimation(TranslateTransform.YProperty, animY3);
            }
                
                
        }

     
    }
}
