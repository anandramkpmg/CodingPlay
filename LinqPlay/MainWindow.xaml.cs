using System;
using System.Collections;
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

namespace LinqPlay
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            //var str = "Anand:Name;Bravo:Name;";

            //var output1 = str.Split(';').ToList();

            //var output = str.Split(';').Select(x => x.Split(':')).ToList();

            ////var input = "[()]{}{[()()]()}";

            //var input = "[()]]";

            //var chararray = input.ToCharArray();

            //matchBrackets(chararray);
        }

        //Matching Brackets

        static string matchBrackets(char[] chars)
        {
            Stack s = new Stack();
            foreach (char c in chars)
            {
                if (c == '{') s.Push('}');
                else if (c == '(') s.Push(')');
                else if (c == '[') s.Push(']');
                else
                {
                    if (s.Count == 0 || c != (char)s.Peek())
                        return "NO";
                    s.Pop();
                }
            }
            return s.Count == 0 ? "YES" : "NO";
        }

        private string Match(char[] expression)
        {
            var stack = new Stack();

            foreach (var c in expression)
            {
                if (c.Equals("{"))
                    stack.Push("}");
                else if (c.Equals("("))
                    stack.Push(")");
                else if (c.Equals("["))
                    stack.Push("]");
                else                 
                {
                    if (stack.Count == 0 || c != (char)stack.Peek())
                        return "NO";
                    stack.Pop();
                }
                
            }

            return (stack.Count==0)?"Yes": "No";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //var output = CodeWar.CountBits(1234);

            //var output = CodeWar.DescendingOrder(1234);#

            //var output = CodeWar.SubtractSum(1234);

            //var output = CodeWar.Solve(new List<int>(){ 15, 11, 10, 7, 12 });

            
        }
    }
}
