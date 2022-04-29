Imports System.Windows
Imports System.Windows.Controls
Imports System.Data

Namespace WpfApplication53

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.pivotGridControl1.DataSource = CreatePivotDataSource()
        End Sub

        Private Function CreatePivotDataSource() As DataTable
            Dim myTable As DataTable = New DataTable()
            myTable.Columns.Add("Name", GetType(String))
            myTable.Columns.Add("Type", GetType(String))
            myTable.Columns.Add("Value", GetType(Decimal))
            myTable.Rows.Add(New Object() {"Aaa", "Type 1", 7})
            myTable.Rows.Add(New Object() {"Aaa", "Type 1", 4})
            myTable.Rows.Add(New Object() {"Bbb", "Type 1", 12})
            myTable.Rows.Add(New Object() {"Bbb", "Type 1", 14})
            myTable.Rows.Add(New Object() {"Ccc", "Type 1", 11})
            myTable.Rows.Add(New Object() {"Ccc", "Type 1", 10})
            myTable.Rows.Add(New Object() {"Aaa", "Type 2", 4})
            myTable.Rows.Add(New Object() {"Aaa", "Type 2", 2})
            myTable.Rows.Add(New Object() {"Bbb", "Type 2", 3})
            myTable.Rows.Add(New Object() {"Bbb", "Type 2", 1})
            myTable.Rows.Add(New Object() {"Ccc", "Type 2", 8})
            myTable.Rows.Add(New Object() {"Ccc", "Type 2", 22})
            Return myTable
        End Function
    End Class
End Namespace
