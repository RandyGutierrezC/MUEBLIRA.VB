Public Class Clientes

    Private Sub ejemplo_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linea de codigo carga datos en la tabla 'Muebleria1DataSet.Clientes' puede moverla o quitarla segunsea necesario
        Me.ClientesTableAdapter.Fill(Me.Muebleria1DataSet.Clientes)

    End Sub


    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        Close()

    End Sub

    Private Sub CANCELAR_Click(sender As Object, e As EventArgs) Handles CANCELAR.Click
        ClientesBindingSource.CancelEdit()

    End Sub

    Private Sub NUEVO_Click(sender As Object, e As EventArgs) Handles NUEVO.Click
        ClientesBindingSource.AddNew()
        Nombre.Focus()

    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        ClientesBindingSource.EndEdit()
        ClientesTableAdapter.Update(Muebleria1DataSet)
        Muebleria1DataSet.AcceptChanges()
        Me.ClientesTableAdapter.Fill(Me.Muebleria1DataSet.Clientes)


    End Sub

    Private Sub MODIFICAR_Click(sender As Object, e As EventArgs) Handles MODIFICAR.Click
        Nombre.Focus()

    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        If MessageBox.Show("¿ESTAS SEGURO DE ELIMINAR EL REGISTRO", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            ClientesBindingSource.RemoveCurrent()
            ClientesTableAdapter.Update(Muebleria1DataSet)
            Muebleria1DataSet.AcceptChanges()
            Me.ClientesTableAdapter.Fill(Me.Muebleria1DataSet.Clientes)

        End If
    End Sub
End Class