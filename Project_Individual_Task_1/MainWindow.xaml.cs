using MahApps.Metro.Controls.Dialogs;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Project_Individual_Task_1
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            /*            TreeViewItem newChild = new TreeViewItem();
                        newChild.Header = textBox1.Text;
                        newChild.DataContext = newChild;
                        Parent.Items.Add(newChild);*/
            TreeNode node = new TreeNode(textBox1.Text);
            TreeView1.Items.Add(node);
            
            


        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            //This method would return the number of list that are in the treeview, depending on the number that have been added

            TextWriter fileName = new StreamWriter("treeview.txt");
            IList list = TreeView1.Items;
            for (int i = 0; i < list.Count; i++)
            {
                string s = (string)list[i];
                fileName.WriteLine(s);
            }
            fileName.Close();
        }          
                 }
}
