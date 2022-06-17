Imports System.Windows

Namespace ContextMenuCustomizations_Ex

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub bAbout_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            MessageBox.Show("About Window")
        End Sub
    End Class
End Namespace
