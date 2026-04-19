'Project11: create an application that keeps track of cookie sales.
'Name : Bhoomi Patel
'Subject : Event Driven Programming
'Date : 11 April 2026


Public Class Form1
    Private Sub SalesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SalesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CookiesDBDataSet)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CookiesDBDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.CookiesDBDataSet.Sales)

    End Sub

    Private Sub SalesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SalesDataGridView.CellContentClick

    End Sub

End Class
