// Developer Express Code Central Example:
// How to define bars and bar items via a template
// 
// This example shows how to define a bar, bar items and bar item links in a
// DataTemplate, and then use this template to create these objects in a
// BarManager. Bar objects are defined via the DataTemplate class. The
// DataTemplate's content must be a BarManagerActionContainer object, containing
// actions to create bar objects. The created template is used within the
// BarManager via the BarManager.Controllers collection.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1731

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BarManagerControllerExample {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void btnExit_ItemClick(object sender, DevExpress.Wpf.Bars.ItemClickEventArgs e) {
            Close();
        }

        private void btnAbout_ItemClick(object sender, DevExpress.Wpf.Bars.ItemClickEventArgs e) {
            MessageBox.Show("About Window");
        }
    }
}
