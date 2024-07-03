Public Class Form1
    Private Sub Frmarraymultidimensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtnim.Text = 1
        Dim arr(3, 1) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "NAMA"
        arr(1, 0) = "JENIS KELAMIN"
        arr(1, 1) = "PRODI"
        arr(2, 0) = "LAKI-LAKI"
        arr(2, 1) = "PEREMPUAN"
        arr(3, 0) = "SISTEM OPERASI"
        arr(3, 1) = "KOMPUTERISASI AKUNTANSI"

        ListView1.GridLines = True
        ListView1.View = View.Details

        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 100)
            Next kolom
        Next baris

        For baris = 2 To 2
            For kolom = 0 To 1
                Cbkelamin.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris

        For baris = 3 To 3
            For kolom = 0 To 1
                Cbprodi.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris

    End Sub

    Private Sub Bproses_Click(sender As Object, e As EventArgs) Handles Bproses.Click
        Dim arr(3) As String
        arr(0) = Txtnim.Text
        arr(1) = Txtnama.Text
        arr(2) = Cbkelamin.Text
        arr(3) = Cbprodi.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(arr(0))
        listitem.SubItems.Add(arr(1))
        listitem.SubItems.Add(arr(2))
        listitem.SubItems.Add(arr(3))
        Txtnim.Text = Txtnim.Text + 1
        Txtnama.Clear()
        Cbkelamin.Text = ""
        Cbprodi.Text = ""
        Txtnama.Focus()


    End Sub
End Class
