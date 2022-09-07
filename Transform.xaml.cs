using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace At_Barika_F
{
    /// <summary>
    /// Interaction logic for Transform.xaml
    /// </summary>
    public partial class Transform : UserControl
    {
        public Transform()
        {
            InitializeComponent();

            var converter = new BrushConverter();
            ObservableCollection<Transformdata> transform =new ObservableCollection<Transformdata>();
        }


        public class Transformdata
        {
             public int IDTransform { get; set; }
            public string IDClient { get; set; }
            public int IDLine { get; set; }
            public string OldStreet { get; set; }
            public string NewStreet { get; set; }

        }

    }
}
