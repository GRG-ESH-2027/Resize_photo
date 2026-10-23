Imports System.IO

Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_convert.Click

        If Directory.Exists("new_image") = False Then
            Directory.CreateDirectory("new_image")
        End If
        For Each var In ListBox1.Items

            'ptnam = Image.FromFile(var + "")
            Dim ptnam As New Bitmap(Image.FromFile(var), New Size(Convert.ToInt32(num_withw.Value), Convert.ToInt32(num_hight.Value)))
            ptnam.Save("new_image\" + Path.GetFileName(var + ""))



        Next
        MessageBox.Show("تم التحويل بنجاح")
    End Sub

    Private Sub btn_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_select.Click
        Try
            Dim op As New OpenFileDialog()
            op.Filter = "image files|*.jpg;*.png"
            op.Multiselect = True
            If op.ShowDialog = Windows.Forms.DialogResult.OK Then

                For Each var In op.FileNames
                    ListBox1.Items.Add(var)
                    btn_convert.Enabled = True
                Next




            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
End Class
