Imports System.IO

Public Class frm_main

    Private Sub btn_seleccionar_Click(sender As System.Object, e As System.EventArgs) Handles btn_seleccionar.Click
        opf_selec.FileName = ""
        opf_selec.ShowDialog()

        If opf_selec.FileNames.Length > 0 Then
            Label4.Text = "*Se han seleccionado " & opf_selec.FileNames.Length & " imagenes."
        End If
        If opf_selec.FileName = "" Then
            Label4.Text = "*No hay imagenes seleccionadas"
        End If



    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Gakuseisean_Aire_Images




        opf_selec.Filter = "Imagenes (*.jpg,*.png)|*.jpg;*.png"
        'opf_selec.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png"
        opf_selec.FilterIndex = 1
        opf_selec.FileName = ""
        Label4.Text = "*No hay imagenes seleccionadas"


    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles btn_aceptar.Click
        Dim selectedPath As String
        Dim dir As DirectoryInfo
        Dim ancho, alto As Integer

        If opf_selec.FileName <> "" Then
            Label5.Text = ""
            If Integer.TryParse(txtAlto.Text, alto) Then
                If Integer.TryParse(txtAncho.Text, ancho) Then

                    selectedPath = Path.GetDirectoryName(opf_selec.FileName)
                    Dim img As Bitmap
                    Dim s As Integer
                    selectedPath = selectedPath & "\ImgTemp"
                    My.Computer.FileSystem.CreateDirectory(selectedPath)
                    For Each x As String In opf_selec.FileNames

                        img = New Bitmap(New Bitmap(x), ancho, alto)
                        dir = New DirectoryInfo(selectedPath)
                        s = dir.GetFiles().Length
                        img.Save(selectedPath & "\img" & s + 1 & ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg)
                    Next

                    MessageBox.Show("Las imagenes han sido redimensionadas!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Complete el campo ancho", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Complete el campo alto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If
        Else
            Label5.Text = "*Debe selccionar alguna imagen"

        End If


    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        MessageBox.Show(opf_selec.FileNames(0))


    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs)

        'opf_selec.FileName.s(0).

    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles gb_titulo.Enter

    End Sub
End Class