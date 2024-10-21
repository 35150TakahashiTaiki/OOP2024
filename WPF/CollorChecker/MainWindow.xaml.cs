﻿using System;
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

namespace CollorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            var rvalue = (int)rSlider.Value;
            var gvalue = (int)gSlider.Value;
            var bvalue = (int)bSlider.Value;
            byte red = (byte)rvalue; 
            byte green = (byte)gvalue; ;
            byte blue = (byte)bvalue; ;

            
            colorArea.Background = new SolidColorBrush(Color.FromArgb(0xFF, red, green, blue));
        }
    }
}
