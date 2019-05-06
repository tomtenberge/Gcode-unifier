Imports System.IO

Public Class Form1
    Private isclosing As Boolean = False
    Public x_offset As Double
    Public y_offset As Double
    Public z_offset As Double
    Dim punt_comma As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[.]")
    Dim comma_punt As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("[,]")
    Private Sub OptimizeSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptimizeSettingsToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub OptimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptimizeToolStripMenuItem.Click
        Dim datarowscount As UInt32 = Databox1.Rows.Count
        progressor1.Maximum = datarowscount * 2
        progressor1.Minimum = 0
        progressor1.Value = 0
        Dim x_min As Double = 0
        Dim y_min As Double = 0
        Dim z_min As Double = 0
        Dim x_max As Double = 0
        Dim y_max As Double = 0
        Dim z_max As Double = 0
        For Each row As DataGridViewRow In Databox1.Rows
            If row.Cells.Item(1).Value < x_min Then
                x_min = row.Cells.Item(1).Value
            End If
            If row.Cells.Item(1).Value > x_max Then
                x_max = row.Cells.Item(1).Value
            End If
            If row.Cells.Item(2).Value < y_min Then
                y_min = row.Cells.Item(2).Value
            End If
            If row.Cells.Item(2).Value > y_max Then
                y_max = row.Cells.Item(2).Value
            End If
            If row.Cells.Item(3).Value < z_min Then
                z_min = row.Cells.Item(3).Value
            End If
            If row.Cells.Item(3).Value > z_max Then
                z_max = row.Cells.Item(3).Value
            End If
            progressor1.Value = progressor1.Value + 1
        Next
        MsgBox("x = " + x_min.ToString + "/" + x_max.ToString + vbNewLine + "y = " + y_min.ToString + "/" + y_max.ToString + vbNewLine + "z = " + z_min.ToString + "/" + z_max.ToString)
        progressor1.Value = 0
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.AddExtension = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.DefaultExt = "gcode"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.Title = "Please select Gcode File"
        OpenFileDialog1.Filter = "gcode files (*.gcode)|*.gcode|Eagle gcode file (*.ncd)|*.ncd|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        ''If OpenFileDialog1.
        ''Exit Then Sub

        progressor1.Minimum = 0
        progressor1.Value = 0

        progressor1.Maximum = System.IO.File.ReadAllLines(OpenFileDialog1.FileName).Length

        Dim files As IO.TextReader = New IO.StreamReader(OpenFileDialog1.FileName)
        Dim line As String
        Databox1.Rows.Clear()
        Try
            While (files.Peek >= 0)
                My.Application.DoEvents()
                line = files.ReadLine
                line = line.ToUpper
                line = line.Trim
                If (line.Substring(0, 1) = "(") Then

                Else
                    Dim parts() As String = line.Split(" ")
                    Dim rownr As Integer = Databox1.Rows.Add
                    Dim row As DataGridViewRow = Databox1.Rows.Item(rownr)
                    For Each block As String In parts
                        Dim firstl As String = block.Substring(0, 1)
                        Select Case firstl
                            Case "%"
                                row.Cells.Item(0).Value = punt_comma.Replace(block, ",")
                            Case "G"
                                row.Cells.Item(0).Value = punt_comma.Replace(block, ",")
                            Case "M"
                                row.Cells.Item(0).Value = punt_comma.Replace(block, ",")
                            Case "X"
                                row.Cells.Item(1).Value = punt_comma.Replace(block.Substring(1), ",")
                            Case "Y"
                                row.Cells.Item(2).Value = punt_comma.Replace(block.Substring(1), ",")
                            Case "Z"
                                row.Cells.Item(3).Value = punt_comma.Replace(block.Substring(1), ",")
                            Case "I"
                                row.Cells.Item(4).Value = punt_comma.Replace(block.Substring(1), ",")
                            Case "J"
                                row.Cells.Item(5).Value = punt_comma.Replace(block.Substring(1), ",")
                            Case "R"
                                row.Cells.Item(6).Value = punt_comma.Replace(block.Substring(1), ",")
                            Case "F"
                                row.Cells.Item(7).Value = punt_comma.Replace(block.Substring(1), ",")
                        End Select
                    Next
                    Databox1.Rows.Item(rownr).Selected = True
                End If
                progressor1.Value = progressor1.Value + 1
            End While
            files.Close()
            progressor1.Value = 0
        Catch ex As Exception
            files.Close()
            progressor1.Value = 0
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub form1_close(sender As Object, e As EventArgs) Handles MyBase.Closing
    End Sub

    Private Sub ToolStripProgressBar1_Click(sender As Object, e As EventArgs) Handles progressor1.Click

    End Sub
End Class
