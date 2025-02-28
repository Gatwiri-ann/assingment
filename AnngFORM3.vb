Public Class Form1
    ' Change font based on selection
    Private Sub cmbFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFont.SelectedIndexChanged
        lblSampleText.Font = New Font(cmbFont.Text, lblSampleText.Font.Size,
        lblSampleText.Font.Style)
    End Sub
    ' Change font style based on checkboxes
    Private Sub UpdateFontStyle()
        Dim newFontStyle As FontStyle = FontStyle.Regular
        If chkBold.Checked Then newFontStyle = newFontStyle Or FontStyle.Bold
        If chkItalic.Checked Then newFontStyle = newFontStyle Or FontStyle.Italic
        If chkBoldItalic.Checked Then newFontStyle = FontStyle.Bold Or FontStyle.Italic
        lblSampleText.Font = New Font(lblSampleText.Font.FontFamily,
lblSampleText.Font.Size, newFontStyle)
    End Sub
    Private Sub chkBold_CheckedChanged(sender As Object, e As EventArgs) Handles chkBold.CheckedChanged
        UpdateFontStyle()
    End Sub
    Private Sub chkItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chkItalic.CheckedChanged
        UpdateFontStyle()
    End Sub
    Private Sub chkBoldItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoldItalic.CheckedChanged
        UpdateFontStyle()
    End Sub
    ' Change font color based on selected radio button
    Private Sub rbColor_CheckedChanged(sender As Object, e As EventArgs) Handles rbGreen.CheckedChanged, rbBlue.CheckedChanged, rbRed.CheckedChanged
        If rbGreen.Checked Then lblSampleText.ForeColor = Color.Green
        If rbBlue.Checked Then lblSampleText.ForeColor = Color.Blue
        If rbRed.Checked Then lblSampleText.ForeColor = Color.Red
    End Sub

    ' Load picture from file
    Private Sub btnLoadPicture_Click(sender As Object, e As EventArgs) Handles btnLoadPicture.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            picBox.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub
    ' Close the form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

