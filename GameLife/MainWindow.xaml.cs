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

namespace GameLife
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bool[,] testarray = new bool[,] {{false, false, false, false, false, false, false},
                                            {false, false, false, true, false, false, false},
                                            {false, false, true, false, false, false, false},
                                            {false, true, true, true, false, false, false},
                                            {false, false, false, false, false, false, false},
                                            {false, false, false, false, false, false, false},
                                            {false, false, false, false, false, false, false}};

            LifeLogic ll = new LifeLogic(7, 7, testarray);
            //MainGrid.ItemsSource2D = ll.Universe;
            
            MainGrid.DataContext = ll;
            
        }
    }
}
    