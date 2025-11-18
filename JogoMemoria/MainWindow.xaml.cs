using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JogoMemoria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        public List<string> Items = new List<string>() { "Alemanha", "Alemanha", "Brasil", "Brasil", "Chile", "Chile", "Portugal", "Portugal", "Argentina", "Argentina", "Egito", "Egito" };

        public List<Button> Selected = new List<Button>();
        public bool Iniciar = false;

        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            Items = Items.OrderBy(i => rnd.Next()).ToList();
        }

        private void IniciarJogo()
        {
            Iniciar = true;
        }

        private void Id01_Click(object sender, RoutedEventArgs e)
        {
            Selected.Add(Id01);
            Id01.Content = Items[0];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "?";
                }
                Selected.Clear();
            }

        }


        private void Id02_Click(object sender, RoutedEventArgs e)
        {
            Selected.Add(Id02);
            Id02.Content = Items[1];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "?";
                }
                Selected.Clear();
            }
        }

        private void Id03_Click(object sender, RoutedEventArgs e)
        {

            Selected.Add(Id03);
            Id03.Content = Items[2];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "?";
                }
                    Selected.Clear();

            }
        }

        private void Id04_Click(object sender, RoutedEventArgs e)
        {
            Selected.Add(Id04);
            Id04.Content = Items[3];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "?";
                }
                    Selected.Clear();
            }

        }

        private void Id05_Click(object sender, RoutedEventArgs e)
        {
            Selected.Add(Id05);
            Id05.Content = Items[4];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "?";
                }
                    Selected.Clear();
            }

        }


        private void Id06_Click(object sender, RoutedEventArgs e)
        {
            Selected.Add(Id06);
            Id06.Content = Items[5];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "?";
                }
                    Selected.Clear();
            }

        }


        private void Id07_Click(object sender, RoutedEventArgs e)
        {
            Selected.Add(Id07);
            Id07.Content = Items[6];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "?";
                }
                    Selected.Clear();
            }

        }


        private void Id08_Click(object sender, RoutedEventArgs e)
        {
            Selected.Add(Id08);
            Id08.Content = Items[7];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "?";
                }
                    Selected.Clear();
            }

        }


        private void Id09_Click(object sender, RoutedEventArgs e)
        {
            Selected.Add(Id09);
            Id09.Content = Items[8];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "?";
                }
                    Selected.Clear();
            }

        }


        private void Id10_Click(object sender, RoutedEventArgs e)
        {
            Selected.Add(Id10);
            Id10.Content = Items[9];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "";
                }
                    Selected.Clear();
            }

        }


        private void Id11_Click(object sender, RoutedEventArgs e)
        {
            Selected.Add(Id11);
            Id11.Content = Items[10];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "?";
                }
                    Selected.Clear();
            }

        }


        private void Id12_Click(object sender, RoutedEventArgs e)
        {
            Selected.Add(Id12);
            Id12.Content = Items[11];

            if (Selected.Count == 2)
            {
                if (Selected[0].Content == Selected[1].Content)
                {
                    MessageBox.Show("Pares encontrados!");
                }
                else
                {
                    Selected[0].Content = "?";
                    Selected[1].Content = "?";
                }
                    Selected.Clear();
            }

        }

        private void btniniciar_Click(object sender, RoutedEventArgs e)
        {
            IniciarJogo();
        }
    }
}