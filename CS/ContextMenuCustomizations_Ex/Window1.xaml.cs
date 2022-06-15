using System.Windows;

namespace ContextMenuCustomizations_Ex {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }
        private void bAbout_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            MessageBox.Show("About Window");
        }
    }
}
