Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dispose()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTTanggal.ValueChanged
        DTTanggal.Format = DateTimePickerFormat.Long
        DTTanggal.CustomFormat = "dd/mm/yyyy"
        DTTanggal.Value = Format(Now)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = DTTanggal.Text
    End Sub
End Class