﻿using AdventOfCode2016.Code;
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

        private void btn_Day2_1_Click(object sender, RoutedEventArgs e)
        {
            Day2 day = new Day2();
            string test1 = day.Puzzle1("ULL\nRRDDD\nLURDL\nUUUUD");
            string puzzle1 = day.Puzzle1();
            MessageBox.Show(puzzle1);
        }

        private void btn_Day2_2_Click(object sender, RoutedEventArgs e)
        {
            Day2 day = new Day2();
            string test2 = day.Puzzle2("ULL\nRRDDD\nLURDL\nUUUUD");
            string puzzle2 = day.Puzzle2();
            MessageBox.Show(puzzle2);
        }

        private void btn_Day3_1_Click(object sender, RoutedEventArgs e)
        {
            Day3 day = new Day3();
            string test2 = day.Puzzle2(" 5 10 25 ");
            string puzzle1 = day.Puzzle1();
            MessageBox.Show(puzzle1);
        }

        private void btn_Day3_2_Click(object sender, RoutedEventArgs e)
        {
            Day3 day = new Day3();
            string test2 = day.Puzzle2(" 5 10 25 ");
            string puzzle2 = day.Puzzle2();
            MessageBox.Show(puzzle2);
        }

        private void btn_Day4_1_Click(object sender, RoutedEventArgs e)
        {
            Day4 day = new Day4();
            string test = day.Puzzle1("aaaaa-bbb-z-y-x-123[abxyz]\na-b-c-d-e-f-g-h-987[abcde]\nnot-a-real-room-404[oarel]\ntotally-real-room-200[decoy]");
            string puzzle = day.Puzzle1();
            MessageBox.Show(puzzle);
        }

        private void btn_Day4_2_Click(object sender, RoutedEventArgs e)
        {
            Day4 day = new Day4();
            string test = day.Puzzle2("qzmt-zixmtkozy-ivhz-343[zimth]");
            string puzzle = day.Puzzle2();
            MessageBox.Show(puzzle);
        }
        private void btn_Day5_1_Click(object sender, RoutedEventArgs e)
        {
            Day5 day = new Day5();
            //string test = day.Puzzle1("abc");
            string puzzle = day.Puzzle1("wtnhxymk");
            MessageBox.Show(puzzle);
        }

        private void btn_Day5_2_Click(object sender, RoutedEventArgs e)
        {
            Day5 day = new Day5();
            string test = day.Puzzle2("abc");
            string puzzle = day.Puzzle2("wtnhxymk");
            MessageBox.Show(puzzle);
        }

        private void btn_Day6_1_Click(object sender, RoutedEventArgs e)
        {
            Day6 day = new Day6();
            string test = day.Puzzle1("eedadn\ndrvtee\neandsr\nraavrd\natevrs\ntsrnev\nsdttsa\nrasrtv\nnssdts\nntnada\nsvetve\ntesnvt\nvntsnd\nvrdear\ndvrsen\nenarar");
            string puzzle = day.Puzzle1();
            MessageBox.Show(puzzle);
        }

        private void btn_Day6_2_Click(object sender, RoutedEventArgs e)
        {
            Day6 day = new Day6();
            string test = day.Puzzle2("eedadn\ndrvtee\neandsr\nraavrd\natevrs\ntsrnev\nsdttsa\nrasrtv\nnssdts\nntnada\nsvetve\ntesnvt\nvntsnd\nvrdear\ndvrsen\nenarar");
            string puzzle = day.Puzzle2();
            MessageBox.Show(puzzle);
        }

        private void btn_Day7_1_Click(object sender, RoutedEventArgs e)
        {
            Day7 day = new Day7();
            string test = day.Puzzle1("abba[mnop]qrst\nabcd[bddb]xyyx\naaaa[qwer]tyui\nioxxoj[asdfgh]zxcvbn"); //2
            string puzzle = day.Puzzle1();
            MessageBox.Show(puzzle);
        }

        private void btn_Day7_2_Click(object sender, RoutedEventArgs e)
        {
            Day7 day = new Day7();
            string test = day.Puzzle2("aba[bab]xyz\nxyx[xyx]xyx\n\naaa[kek]eke\nzazbz[bzb]cdb"); //3
            string puzzle = day.Puzzle2();
            MessageBox.Show(puzzle);
        }

        private void btn_Day8_1_Click(object sender, RoutedEventArgs e)
        {
            Day8 day = new Day8();
            //string test = day.Puzzle1("abba[mnop]qrst\nabcd[bddb]xyyx\naaaa[qwer]tyui\nioxxoj[asdfgh]zxcvbn"); //2
            string puzzle = day.Puzzle1();
            MessageBox.Show(puzzle);
        }

        private void btn_Day8_2_Click(object sender, RoutedEventArgs e)
        {
            Day8 day = new Day8();
            string puzzle = day.Puzzle2();
            Console.Write(puzzle);
            MessageBox.Show(puzzle);
        }
        
        private void btn_Day9_1_Click(object sender, RoutedEventArgs e)
        {
            Day9 day = new Day9();
            string test = day.Puzzle1("ADVENT\nA(1x5)BC\n(3x3)XYZ\nA(2x2)BCD(2x2)EFG\n(6x1)(1x3)A\nX(8x2)(3x3)ABCY"); //57
            string puzzle = day.Puzzle1();
            MessageBox.Show(puzzle);
        }

        private void btn_Day9_2_Click(object sender, RoutedEventArgs e)
        {
            Day9 day = new Day9();
            //string test = day.Puzzle2("(25x3)(3x3)ABC(2x3)XY(5x2)PQRSTX(18x9)(3x2)TWO(5x7)SEVEN"); //241920+445=242365
            string test2 = day.Puzzle2("(27x12)(20x12)(13x14)(7x10)(1x12)A"); //241920+445=242365
            string puzzle = day.Puzzle2();
            MessageBox.Show(puzzle);
        }

    }
}
