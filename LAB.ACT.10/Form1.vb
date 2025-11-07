Imports System.IO
Imports System.Linq

Public Class Form1
    Dim filePath As String = "numbers.txt"

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click

        Dim num As Integer = CInt(NumericUpDown1.Value)

            Dim writer As StreamWriter = New StreamWriter(filePath, True)
            writer.WriteLine(num)
        writer.Close()
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ListBox1.Items.Clear()

        If File.Exists(filePath) Then
            Dim reader As StreamReader = New StreamReader(filePath)
            Dim line As String = reader.ReadLine()

            While line IsNot Nothing
                ListBox1.Items.Add(line)
                line = reader.ReadLine()
            End While

            reader.Close()
        End If
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        If File.Exists(filePath) Then
            Dim numbers As New List(Of Integer)
            Dim reader As StreamReader = New StreamReader(filePath)
            Dim line As String = reader.ReadLine()

            While line IsNot Nothing
                numbers.Add(CInt(line))
                line = reader.ReadLine()
            End While
            reader.Close()

            Dim sortedNumbers = From q In numbers
                                Order By q Ascending
                                Select q

            ListBox1.Items.Clear()
            For Each n As Integer In sortedNumbers
                ListBox1.Items.Add(n)
            Next

            Dim writer As StreamWriter = New StreamWriter(filePath, False)
            For Each n As Integer In sortedNumbers
                writer.WriteLine(n)
            Next
            writer.Close()
        End If
    End Sub
End Class