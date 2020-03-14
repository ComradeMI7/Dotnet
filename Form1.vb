Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports System.Xml.XPath
Imports System.Xml
Imports Word = Microsoft.Office.Interop.Word

Public Class Form1
    
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Me.Hide()
    '    Form2.Show()
    'End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    'TextBox1.AppendText("  " + vbNewLine)
    '    'TextBox1.AppendText(vbTab & Label1.Text + " : " + txtsrno.Text + vbNewLine)
    '    'TextBox1.AppendText("  " + vbNewLine)
    '    'TextBox1.AppendText(vbTab & lblitem.Text + " : " + txtlbl.Text + vbNewLine)
    '    'TextBox1.AppendText("  " + vbNewLine)
    '    'TextBox1.AppendText(vbTab & lbldescriptions.Text + " : " + txtdes.Text + vbNewLine)
    '    'TextBox1.AppendText("  " + vbNewLine)
    '    'TextBox1.AppendText(vbTab & lblquantity.Text + " : " + txtquantity.Text + vbNewLine)
    '    'TextBox1.AppendText("  " + vbNewLine)
    '    'TextBox1.AppendText(vbTab & lblunit.Text + " : " + txtunit.Text + vbNewLine)
    '    'TextBox1.AppendText("  " + vbNewLine)
    '    'TextBox1.AppendText(vbTab & lbltotal.Text + " : " + txttotal.Text + vbNewLine)
    '    'TextBox1.AppendText("  " + vbNewLine)
    '    'TextBox1.AppendText(vbTab & lblcgst.Text + " : " + txtcgst.Text + vbNewLine)
    '    'TextBox1.AppendText("  " + vbNewLine)
    '    'TextBox1.AppendText(vbTab & lblsgst.Text + " : " + txtsgst.Text + vbNewLine)
    '    'TextBox1.AppendText("  " + vbNewLine)
    '    'TextBox1.AppendText(" ================================================================== " + vbNewLine)
    '    'TextBox1.AppendText(vbTab & Today & vbTab & TimeOfDay + vbNewLine)
    '    'TextBox1.AppendText(" ================================================================== " + vbNewLine)
    'End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    iSave.Filter = "CSV files(*.csv) | *.CSV"
    '    iSave.FilterIndex = 2
    '    iSave.RestoreDirectory = False
    '    If iSave.ShowDialog() = DialogResult.OK Then
    '        IO.File.WriteAllText(iSave.FileName, TextBox1.Text)
    '    End If
    'End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Me.DataGridView1.Rows.Add(txtsrno.Text, txtlbl.Text, txtdes.Text, txtquantity.Text, txtunit.Text, txttotal.Text, txtcgst.Text, txtsgst.Text)
    End Sub



    Private Sub btnexcel_Click(sender As Object, e As EventArgs) Handles btnexcel.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To DataGridView1.RowCount - 1
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()

                Next
            Next
        Next

        xlWorkSheet.SaveAs("E:\1.xlsx")
        'MsgBox("You can find the file E:\1.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)


        'Dim xlApp As Microsoft.Office.Interop.Excel.Application
        'Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        'Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        'Dim misValue As Object = System.Reflection.Missing.Value
        'Dim i As Integer
        'Dim j As Integer

        'xlApp = New Microsoft.Office.Interop.Excel.Application
        'xlWorkBook = xlApp.Workbooks.Add(misValue)
        'xlWorkSheet = xlWorkBook.Sheets("sheet1")


        'For i = 0 To DataGridView1.RowCount - 1
        '    For j = 0 To DataGridView1.ColumnCount - 1
        '        For k As Integer = 1 To DataGridView1.Columns.Count
        '            xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
        '            xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
        '        Next
        '    Next
        'Next

        'xlWorkSheet.SaveAs("E:\test.xlsx")
        'xlWorkBook.Close()
        'xlApp.Quit()

        'releaseObject(xlApp)
        'releaseObject(xlWorkBook)
        'releaseObject(xlWorkSheet)

        'MsgBox("You can find the file D:\test.xlsx")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnmultiply_Click(sender As Object, e As EventArgs) Handles btnmultiply.Click
        txttotal.Text = Val(txtquantity.Text) * Val(txtunit.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Percentage, amount, result As Single
        Percentage = txttotal.Text
        amount = txtcgst.Text
        result = (amount / 100) * (Percentage)
        txtvalue.Text = result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Percentage, amount, result As Single
        Percentage = txttotal.Text
        amount = txtsgst.Text
        result = (amount / 100) * (Percentage)
        txtsgstvlaue.Text = result
    End Sub

    Private Sub btntotalvalue_Click(sender As Object, e As EventArgs) Handles btntotalvalue.Click
        txttotalvalue.Text = Val(txttotal.Text) + Val(txtvalue.Text) + Val(txtsgstvlaue.Text)
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        'txtsrno.Clear()
        'txtlbl.Clear()
        'txtdes.Clear()
        'txtquantity.Clear()
        'txtunit.Clear()
        'txttotal.Clear()
        'txtcgst.Clear()
        'txtcgst.Clear()
        For Each txt In {txtsrno, txtlbl, txtdes, txtquantity, txtunit, txttotal, txtcgst, txtvalue, txtsgst, txtsgstvlaue, txttotalvalue}
            txt.Clear()
        Next
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'Delete a Single Row 
        'DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

        'Delete Multiple Rows
        If DataGridView1.SelectedRows.Count > 0 Then
            'you may want to add a confirmation message, and if the user confirms delete
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If

        'Clear All
        'DataGridView1.Rows.Clear()
    End Sub

    'Private Sub btnExport_Click(ByVal sender As System.Object,
    '               ByVal e As System.EventArgs) Handles btnExport.Click
    '    CreateWordDocument()
    'End Sub
    Private Sub CreateWordDocument()
        Dim objWord As Word.Application
        Dim objDoc As Word.Document

        objWord = CreateObject("Word.Application")
        objWord.Visible = True
        objDoc = objWord.Documents.Add

        Dim _RowCount As Integer = DataGridView1.Rows.Count - 1
        Dim _ColCount As Integer = DataGridView1.Columns.Count - 1

        Dim ht1 As Word.Table

        ht1 = objDoc.Tables.Add(objDoc.Bookmarks.Item("\endofdoc").Range,
                                _RowCount + 1, _ColCount + 1)
        ht1.Borders.OutsideColor = Word.WdColor.wdColorBlack
        ht1.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
        ht1.Borders.InsideColor = Word.WdColor.wdColorBlack
        ht1.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle

        For i As Integer = 0 To _RowCount
            ht1.Rows.Add()
            For _col As Integer = 0 To _ColCount
                Dim colType As Type = DataGridView1.Columns(_col).GetType
                If colType.Name = "DataGridViewImageColumn" Then
                    Dim _image As Image = DirectCast(DataGridView1.Rows(i).Cells(_col).Value, Image)
                    Clipboard.SetImage(_image)
                    ht1.Cell(i + 1, _col + 1).Range.Paste()
                Else
                    ht1.Cell(i + 1, _col + 1).Range.Text =
                    DataGridView1.Rows(i).Cells(_col).Value.ToString()
                End If
            Next
        Next
        objDoc.SaveAs2("E:/tee.docx")
    End Sub

    Private Sub btnExport_Click_1(sender As Object, e As EventArgs) Handles btnExport.Click
        CreateWordDocument()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class