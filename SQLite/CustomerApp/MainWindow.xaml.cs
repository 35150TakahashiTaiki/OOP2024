using CustomerApp.Objects;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        private byte[] _imageData;
        public MainWindow() {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var cutomer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                ImageData = _imageData,
            };

            //string databaseName = "Shop.db";
            //var folderPass = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //var databasePass = System.IO. Path.Combine(folderPass, databaseName);

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(cutomer);
            }

            ReadDatabase();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var selectedCustomer = (Customer)CustomerListView.SelectedItem;

            if (selectedCustomer == null) {
                MessageBox.Show("更新する顧客を選択してください");
                return;
            }
            selectedCustomer.Name = NameTextBox.Text;
            selectedCustomer.Phone = PhoneTextBox.Text;
            selectedCustomer.Address = AddressTextBox.Text;

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Update(CustomerListView.SelectedItem);
            }

            ReadDatabase();

            NameTextBox.Clear();
            PhoneTextBox.Clear();
            AddressTextBox.Clear();
        }

        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();
                CustomerListView.ItemsSource = _customers;
            }
        }

        private void SearchTextbox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextbox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);
                ReadDatabase();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            ReadDatabase();
        }

        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectedCustomer = (Customer)CustomerListView.SelectedItem;
            if (selectedCustomer != null) {
                NameTextBox.Text = selectedCustomer.Name;
                PhoneTextBox.Text = selectedCustomer.Phone;
                AddressTextBox.Text = selectedCustomer.Address;
                
            }
        }

        private void SelectImageButton_Click(object sender, RoutedEventArgs e) {
            
        }
    }
}
