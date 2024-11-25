Public Class Form1
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.ShowDialog()

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        ReporteCliente.ShowDialog()
    End Sub

    Private Sub ProducosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProducosToolStripMenuItem.Click
        Producto.ShowDialog()
    End Sub
End Class
