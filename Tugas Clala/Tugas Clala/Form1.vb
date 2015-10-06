Public Class Form1


    Private Sub Latian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Violet
    End Sub

    Private Sub ubah_Click_1(sender As Object, e As EventArgs) Handles ubah.Click
        If Me.BackColor = Color.Violet Then
            Me.BackColor = Color.Salmon
        Else
            Me.BackColor = Color.Violet

        End If
    End Sub
End Class
