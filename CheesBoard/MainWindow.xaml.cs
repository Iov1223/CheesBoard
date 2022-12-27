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

namespace CheesBoard
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CheesBoard.Rows = 9;
            CheesBoard.Columns = 9;
        }

        private void CheesBoard_Loaded(object sender, RoutedEventArgs e)
        {
            bool isBlack = true;
            char letter = 'A';
            int num = 1;

            for (int i = 0; i < CheesBoard.Rows; i++)
            {
                for (int j = 0; j < CheesBoard.Columns; j++)
                {
                    if (i == 0 && j != 0)
                    {
                        TextBlock tbForLetter = new TextBlock();
                        tbForLetter.FontSize = 20;
                        tbForLetter.FontWeight = FontWeights.Bold;
                        tbForLetter.Padding = new Thickness(17);
                        tbForLetter.Text = letter.ToString();
                        tbForLetter.TextAlignment = TextAlignment.Center;
                        tbForLetter.Background = Brushes.SandyBrown;
                        CheesBoard.Children.Add(tbForLetter);
                        letter++;
                    }
                    else if (j == 0 && i != 0)
                    {
                        TextBlock tbForNum = new TextBlock();
                        tbForNum.FontSize = 20;
                        tbForNum.FontWeight = FontWeights.Bold;
                        tbForNum.Padding = new Thickness(17);
                        tbForNum.Text = num.ToString();
                        tbForNum.TextAlignment = TextAlignment.Center;
                        tbForNum.Background = Brushes.SandyBrown;
                        CheesBoard.Children.Add(tbForNum);
                        num++;
                    }
                    else if (j == 0 && i == 0)
                    {
                        Rectangle recWhite = new Rectangle()
                        {
                            Fill = Brushes.SandyBrown,
                        };
                        CheesBoard.Children.Add(recWhite);
                    }
                    else if (isBlack)
                    {
                        Rectangle recBlac = new Rectangle()
                        {
                            Fill = Brushes.Black,
                            Stroke = Brushes.Black
                        };
                        CheesBoard.Children.Add(recBlac);
                        isBlack = false;
                    }
                    else if (!isBlack)
                    {
                        Rectangle recWhite = new Rectangle()
                        {
                            Fill = Brushes.SandyBrown,
                            Stroke = Brushes.Black
                        };
                        CheesBoard.Children.Add(recWhite);
                        isBlack = true;
                    }
                }
                isBlack = !isBlack;
            }
        }
    }
}
