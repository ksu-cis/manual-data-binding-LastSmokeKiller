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
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Note note = new Note();

        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }

        /// <summary>
        /// Creates a new not
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        public void OnNewNote(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;
            
        }

        /// <summary>
        /// Clears the notepad
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        public void OnClearNote(object sender, RoutedEventArgs e)
        {
            note.Body = "";
            
        }

        /// <summary>
        /// Lets you know you are simp
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        public void OnMutateNote(object sender, RoutedEventArgs e)
        {
            note.Title = "SIMP!!!";
            note.Body = "You are a simp...";
        }
    }
}
