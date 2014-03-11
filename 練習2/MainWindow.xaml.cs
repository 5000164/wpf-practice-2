using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 練習2
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // 現在地を取得
            Double leftPosition = Canvas.GetLeft(player);
            Double topPosition = Canvas.GetTop(player);
            
            // 入力された方向キーの方向へ移動
            if (e.Key == Key.Up)
                Canvas.SetTop(player, topPosition - 10);
            else if (e.Key == Key.Down)
                Canvas.SetTop(player, topPosition + 10);
            else if (e.Key == Key.Left)
                Canvas.SetLeft(player, leftPosition - 10);
            else if (e.Key == Key.Right)
                Canvas.SetLeft(player, leftPosition + 10);
        }
    }
}
