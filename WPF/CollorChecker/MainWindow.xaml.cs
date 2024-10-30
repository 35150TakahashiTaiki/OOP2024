using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Reflection;

namespace CollorChecker {
    
    public partial class MainWindow : Window {
        MyColor currentColer;


        public MainWindow() {
            InitializeComponent();
            //αチャンネルの初期値を設定（起動時すぐにストックボタンが押された時の対応）
            currentColer.Color = Color.FromArgb(255,0,0,0);
            DataContext = GetColorList();
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColer.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            colorArea.Background = new SolidColorBrush(currentColer.Color);
            currentColer.Name=null;
        }

        private void stockBotton_Click(object sender, RoutedEventArgs e) {
            bool exists = false;
            foreach (MyColor color in list.Items) {
                if (color.Color == currentColer.Color) {
                    exists = true;
                    break;
                }
            }

            if (!exists) {
                list.Items.Insert(0, currentColer);
            } else {
                MessageBox.Show("この色はすでにストックされています。");
            }

        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (list.SelectedIndex != -1) {
                colorArea.Background = new SolidColorBrush(((MyColor)list.Items[list.SelectedIndex]).Color);
                setSliderValue(((MyColor)list.Items[list.SelectedIndex]).Color);
            }

        }

        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }


        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void s_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor=(MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;

            setSliderValue(color);

            currentColer.Name=name;
        }

        private void deleteBotton_Click(object sender, RoutedEventArgs e) {
            if (list.SelectedIndex != -1) {
                list.Items.Remove(list.Items[list.SelectedIndex]);
            }
            

        }
    }
}
