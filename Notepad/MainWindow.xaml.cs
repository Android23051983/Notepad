using Microsoft.Win32;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void CreateWindowsContent()
        {
            var separator = new Separator();
            var separator1 = new Separator();
            var separator2 = new Separator();
            var separator3 = new Separator();

            DockPanel dockPanel = new DockPanel();
            dockPanel.LastChildFill = true;


            var menuItem1301 = new MenuItem { Header = "Открыть папку файла"};
            var menuItem1302 = new MenuItem { Header = "Открыть папку в консоли cmd"};
            var menuItem1303 = new MenuItem { Header = "Папка файла как Проект"};

            var menuItem11 = new MenuItem { Header = "Новый" };
            var menuItem12 = new MenuItem { Header = "Открыть" };
            var menuItem13 = new MenuItem { Header = "Открыть папку файла" };
            menuItem13.Items.Add(menuItem1301);
            menuItem13.Items.Add(menuItem1302);
            menuItem13.Items.Add(separator3);
            menuItem13.Items.Add(menuItem1303);


            var menuItem131 = new MenuItem { Header = "_Параметры командной строки", IsCheckable = false };
            var menuItem132 = new MenuItem { Header = "_Сайт проекта Notepad++", IsCheckable = false };
            var menuItem133 = new MenuItem { Header = "_Страница проекта Notepad++", IsCheckable = false };
            var menuItem134 = new MenuItem { Header = "_Руководство онлайн", IsCheckable = false };
            var menuItem135 = new MenuItem { Header = "_Форум", IsCheckable = false };
            var menuItem136 = new MenuItem { Header = "_Обновить Notepad++", IsCheckable = false };
            var menuItem137 = new MenuItem { Header = "_Задать прокси обновления...", IsCheckable = false };
            var menuItem138 = new MenuItem { Header = "_Отладочная информация", IsCheckable = false };
            var menuItem139 = new MenuItem { Header = "_О программе", IsCheckable = false };

            var menuItems1 = new MenuItem { Header = "Файл" };
            menuItems1.Items.Add(menuItem11);
            menuItems1.Items.Add(menuItem12);
            menuItems1.Items.Add(menuItem13);

            var menuItems2 = new MenuItem { Header = "Правка" };
            var menuItems3 = new MenuItem { Header = "Поиск" };
            var menuItems4 = new MenuItem { Header = "Вид" };
            var menuItems5 = new MenuItem { Header = "Кодировки" };
            var menuItems6 = new MenuItem { Header = "Синтаксисы" };
            var menuItems7 = new MenuItem { Header = "Опции" };
            var menuItems8 = new MenuItem { Header = "Инструменты" };
            var menuItems9 = new MenuItem { Header = "Макросы" };
            var menuItems10 = new MenuItem { Header = "Запуск" };
            var menuItems11 = new MenuItem { Header = "Плагины" };
            var menuItems12 = new MenuItem { Header = "Вкладки" };

            var menuItems13 = new MenuItem { Header = "?" };
            menuItems13.Items.Add(menuItem131);
            menuItems13.Items.Add(separator);
            menuItems13.Items.Add(menuItem132);
            menuItems13.Items.Add(menuItem133);
            menuItems13.Items.Add(menuItem134);
            menuItems13.Items.Add(menuItem135);
            menuItems13.Items.Add(separator1);
            menuItems13.Items.Add(menuItem136);
            menuItems13.Items.Add(menuItem137);
            menuItems13.Items.Add(separator2);
            menuItems13.Items.Add(menuItem138);
            menuItems13.Items.Add(menuItem139);

            var menu = new Menu { IsMainMenu = true };
            menu.Items.Add(menuItems1);
            menu.Items.Add(menuItems2);
            menu.Items.Add(menuItems3);
            menu.Items.Add(menuItems4);
            menu.Items.Add(menuItems5);
            menu.Items.Add(menuItems6);
            menu.Items.Add(menuItems7);
            menu.Items.Add(menuItems8);
            menu.Items.Add(menuItems9);
            menu.Items.Add(menuItems10);
            menu.Items.Add(menuItems11);
            menu.Items.Add(menuItems12);
            menu.Items.Add(menuItems13);

            Border myBorder1 = new Border();
            //myBorder1.Height = 25;
            //myBorder1.Background = Brushes.SkyBlue;
            //myBorder1.BorderBrush = Brushes.Black;
            myBorder1.BorderThickness = new Thickness(1);
            DockPanel.SetDock(myBorder1, Dock.Top);
            myBorder1.Child = menu;

            TextBox txtEditor = new TextBox();
            
            
            Border myBorder3 = new Border();
            //myBorder3.Height = 25;
            myBorder3.Background = Brushes.LemonChiffon;
            //myBorder3.BorderBrush = Brushes.Black;
            myBorder3.BorderThickness = new Thickness(1);
            DockPanel.SetDock(myBorder3, Dock.Bottom);
            //txtEditor.Foreground = Brushes.Black;
            txtEditor.Text = "Dock = Botton";
            myBorder3.Child = txtEditor;
            
            dockPanel.Children.Add(myBorder1);
            dockPanel.Children.Add(myBorder3);

            Content = dockPanel;

        }

        private void StartHelp(object sender, ExecutedRoutedEventArgs e)
        {
            new Help().ShowDialog();
        }

        private void StartPrint(object sender, ExecutedRoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                //txtBox.Margin = new Thickness(5);
                //TC.Focus();
                //printDialog.PrintVisual(txtBox, "Распечатка текста");
                printDialog.PrintDocument(
            ((IDocumentPaginatorSource)txtBox.Document).DocumentPaginator,
            "A Flow Document");
            }
        }
    }
}
