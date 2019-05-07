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
        Dim x_min As Double = 999999
        Dim y_min As Double = 999999
        Dim z_min As Double = 999999
        Dim x_max As Double = 0
        Dim y_max As Double = 0
        Dim z_max As Double = 0
        For Each row As DataGridViewRow In Databox1.Rows
            If row.Cells.Item(1).Value < x_min AndAlso row.Cells.Item(1).Value IsNot Nothing Then
                x_min = row.Cells.Item(1).Value
            End If
            If row.Cells.Item(1).Value > x_max AndAlso row.Cells.Item(1).Value IsNot Nothing Then
                x_max = row.Cells.Item(1).Value
            End If
            If row.Cells.Item(2).Value < y_min AndAlso row.Cells.Item(2).Value IsNot Nothing Then
                y_min = row.Cells.Item(2).Value
            End If
            If row.Cells.Item(2).Value > y_max AndAlso row.Cells.Item(2).Value IsNot Nothing Then
                y_max = row.Cells.Item(2).Value
            End If
            If row.Cells.Item(3).Value < z_min AndAlso row.Cells.Item(3).Value IsNot Nothing Then
                z_min = row.Cells.Item(3).Value
            End If
            If row.Cells.Item(3).Value > z_max AndAlso row.Cells.Item(3).Value IsNot Nothing Then
                z_max = row.Cells.Item(3).Value
            End If
            progressor1.Value = progressor1.Value + 1
            ToolStripStatusLabel1.Text = progressor1.Value.ToString + "/" + progressor1.Maximum.ToString
        Next
        Dim X_addition As Double = 0
        Dim Y_addition As Double = 0
        Dim Z_addition As Double = 0
        If (x_min < 0) Then
            X_addition = Math.Abs(x_min)
        Else
            X_addition = 0 - x_min
        End If
        If (x_min < 0) Then
            Y_addition = Math.Abs(y_min)
        Else
            Y_addition = 0 - y_min
        End If
        If (x_min < 0) Then
            Z_addition = Math.Abs(z_min)
        Else
            Z_addition = 0 - z_min
        End If
        For Each row As DataGridViewRow In Databox1.Rows
            If (row.Cells.Item(1).Value IsNot Nothing) Then
                row.Cells.Item(1).Value = Math.Round(row.Cells.Item(1).Value + X_addition + x_offset, 4)
            End If
            If (row.Cells.Item(2).Value IsNot Nothing) Then
                row.Cells.Item(2).Value = Math.Round(row.Cells.Item(2).Value + Y_addition + y_offset, 4)
            End If
            If (row.Cells.Item(3).Value IsNot Nothing) Then
                row.Cells.Item(3).Value = Math.Round(row.Cells.Item(3).Value + Z_addition + z_offset, 4)
            End If
            progressor1.Value = progressor1.Value + 1
            ToolStripStatusLabel1.Text = progressor1.Value.ToString + "/" + progressor1.Maximum.ToString
        Next
        MsgBox("x = " + x_min.ToString + "/" + x_max.ToString + vbNewLine + "y = " + y_min.ToString + "/" + y_max.ToString + vbNewLine + "z = " + z_min.ToString + "/" + z_max.ToString)
        progressor1.Value = 0
        ToolStripStatusLabel1.Text = ""
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
        Dim lastcommand As String = ""
        ''Try
        While (files.Peek >= 0)
            My.Application.DoEvents()
            line = files.ReadLine
            line = line.ToUpper
            line = line.Trim
            If (line = "") Then
            ElseIf (line.Substring(0, 1) = "(") Then
                Dim rownr As Integer = Databox1.Rows.Add
                Dim row As DataGridViewRow = Databox1.Rows.Item(rownr)
                row.Cells.Item(0).Value = line
            Else
                Dim parts() As String = line.Split(" ")
                Dim rownr As Integer = Databox1.Rows.Add
                    Dim row As DataGridViewRow = Databox1.Rows.Item(rownr)
                    Dim firstletter As String = parts(0).Substring(0, 1)
                    Select Case firstletter
                    Case "G"
                        If (parts(0).Substring(1) = "36") Then
                            row.Cells.Item(0).Value = line + "; Retool to " + line.Substring(4)
                        ElseIf (parts(0).Substring(1) = "21") Then
                            row.Cells.Item(0).Value = line
                        ElseIf (parts(0).Substring(1) = "90") Then
                            row.Cells.Item(0).Value = line
                        Else
                            row.Cells.Item(0).Value = parts(0)
                            Fillrow(row, parts)
                        End If
                        lastcommand = parts(0)
                    Case "%"
                            row.Cells.Item(0).Value = punt_comma.Replace(parts(0), ",")
                        Case "M"
                        If (parts(0).Substring(1) = "999") Then
                            row.Cells.Item(0).Value = line
                        Else
                            row.Cells.Item(0).Value = punt_comma.Replace(line, ",")
                        End If

                        lastcommand = parts(0)
                    Case "T"
                            row.Cells.Item(0).Value = punt_comma.Replace(line, ",")
                        Case "("
                            row.Cells.Item(0).Value = line
                        Case "X"
                        row.Cells.Item(0).Value = lastcommand
                        row.Cells.Item(1).value = parts(0).substring(1)
                        Fillrow(row, parts)
                End Select
                    Databox1.Rows.Item(rownr).Selected = True
                End If
            progressor1.Value = progressor1.Value + 1
            ToolStripStatusLabel1.Text = progressor1.Value.ToString + "/" + progressor1.Maximum.ToString
        End While
            files.Close()
        progressor1.Value = 0
        ToolStripStatusLabel1.Text = ""
        ''Catch ex As Exception
        ''End Try
    End Sub
    Private Sub Fillrow(row As DataGridViewRow, data As String())
        For Each block As String In data
            Dim firstl As String = block.Substring(0, 1)
            Select Case firstl
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
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.CheckFileExists = False
        SaveFileDialog1.AddExtension = True
        SaveFileDialog1.CheckPathExists = True
        SaveFileDialog1.DefaultExt = "gcode"
        SaveFileDialog1.Title = "Please enter Gcode File to save to"
        SaveFileDialog1.Filter = "gcode files (*.gcode)|*.gcode|Eagle gcode file (*.ncd)|*.ncd|All files (*.*)|*.*"
        SaveFileDialog1.ShowDialog()
        progressor1.Minimum = 0
        progressor1.Value = 0
        progressor1.Maximum = Databox1.Rows.Count
        If SaveFileDialog1.FileName IsNot "" Then

            Dim files As IO.TextWriter = New IO.StreamWriter(SaveFileDialog1.FileName, False)
            For Each row As DataGridViewRow In Databox1.Rows
                Dim text As String = ""
                If row.Cells(0).Value IsNot Nothing Then
                    text += comma_punt.Replace(row.Cells(0).Value.ToString, ".") + " "
                End If
                If row.Cells(1).Value IsNot Nothing Then
                    text += "X" + comma_punt.Replace(row.Cells(1).Value.ToString, ".") + " "
                End If
                If row.Cells(2).Value IsNot Nothing Then
                    text += "Y" + comma_punt.Replace(row.Cells(2).Value.ToString, ".") + " "
                End If
                If row.Cells(3).Value IsNot Nothing Then
                    text += "Z" + comma_punt.Replace(row.Cells(3).Value.ToString, ".") + " "
                End If
                If row.Cells(4).Value IsNot Nothing Then
                    text += "I" + comma_punt.Replace(row.Cells(4).Value.ToString, ".") + " "
                End If
                If row.Cells(5).Value IsNot Nothing Then
                    text += "J" + comma_punt.Replace(row.Cells(5).Value.ToString, ".") + " "
                End If
                If row.Cells(6).Value IsNot Nothing Then
                    text += "R" + comma_punt.Replace(row.Cells(6).Value.ToString, ".") + " "
                End If
                If row.Cells(7).Value IsNot Nothing Then
                    text += "F" + comma_punt.Replace(row.Cells(7).Value.ToString, ".") + " "
                End If
                text = text.Trim
                files.WriteLine(text)
                progressor1.Value = progressor1.Value + 1
                ToolStripStatusLabel1.Text = progressor1.Value.ToString + "/" + progressor1.Maximum.ToString
            Next
            files.Close()
            progressor1.Value = 0
            ToolStripStatusLabel1.Text = ""
        End If
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
