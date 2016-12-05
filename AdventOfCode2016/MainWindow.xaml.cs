using AdventOfCode2016.Code;
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

namespace AdventOfCode2016
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

        private void btn_Day1_1_Click(object sender, RoutedEventArgs e)
        {
            Day1 day = new Day1();
            string test1 = day.Puzzle1("R2, L3");
            string test2 = day.Puzzle1("R2, R2, R2");
            string test3 = day.Puzzle1("R5, L5, R5, R3");
            string puzzle1 = day.Puzzle1();
            MessageBox.Show(puzzle1);
        }

        private void btn_Day1_2_Click(object sender, RoutedEventArgs e)
        {
            Day1 day = new Day1();
            string test4 = day.Puzzle2("R8, R4, R4, R8");
            string puzzle2 = day.Puzzle2();
            MessageBox.Show(puzzle2);
        }
    }
}
