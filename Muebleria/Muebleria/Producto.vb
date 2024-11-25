Imports Muebleria.Muebleria1DataSetTableAdapters

Public Class Producto


    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Muebleria1DataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.Muebleria1DataSet.Productos)

    End Sub

    Private Sub CANCELAR_Click(sender As Object, e As EventArgs) Handles CANCELAR.Click
        ProductosBindingSource.CancelEdit()
    End Sub

    Private Sub NUEVO_Click(sender As Object, e As EventArgs) Handles NUEVO.Click
        ProductosBindingSource.AddNew()
        NombreTextBox.Focus()
    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        ProductosBindingSource.EndEdit()
        ProductosTableAdapter.Update(Muebleria1DataSet)
        Muebleria1DataSet.AcceptChanges()
        Me.ProductosTableAdapter.Fill(Me.Muebleria1DataSet.Productos)
    End Sub

    Private Sub MODIFICAR_Click(sender As Object, e As EventArgs) Handles MODIFICAR.Click
        NombreTextBox.Focus()
    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        If MessageBox.Show("¿ESTAS SEGURO DE ELIMINAR EL REGISTRO", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            ProductosBindingSource.RemoveCurrent()
            ProductosTableAdapter.Update(Muebleria1DataSet)
            Muebleria1DataSet.AcceptChanges()
            Me.ProductosTableAdapter.Fill(Me.Muebleria1DataSet.Productos)

        End If
    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        Close()
    End Sub
End Class