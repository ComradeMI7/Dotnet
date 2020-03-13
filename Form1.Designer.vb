<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblitem = New System.Windows.Forms.Label()
        Me.lbldescriptions = New System.Windows.Forms.Label()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.lblunit = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblcgst = New System.Windows.Forms.Label()
        Me.lblsgst = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsrno = New System.Windows.Forms.TextBox()
        Me.txtlbl = New System.Windows.Forms.TextBox()
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtcgst = New System.Windows.Forms.TextBox()
        Me.txtsgst = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnexcel = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnmultiply = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtvalue = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtsgstvlaue = New System.Windows.Forms.TextBox()
        Me.txttotalvalue = New System.Windows.Forms.TextBox()
        Me.btntotalvalue = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitem.Location = New System.Drawing.Point(12, 52)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(37, 16)
        Me.lblitem.TabIndex = 21
        Me.lblitem.Text = "Item"
        '
        'lbldescriptions
        '
        Me.lbldescriptions.AutoSize = True
        Me.lbldescriptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescriptions.Location = New System.Drawing.Point(12, 91)
        Me.lbldescriptions.Name = "lbldescriptions"
        Me.lbldescriptions.Size = New System.Drawing.Size(95, 16)
        Me.lbldescriptions.TabIndex = 22
        Me.lbldescriptions.Text = "Descriptions"
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantity.Location = New System.Drawing.Point(12, 156)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(64, 16)
        Me.lblquantity.TabIndex = 23
        Me.lblquantity.Text = "Quantity"
        '
        'lblunit
        '
        Me.lblunit.AutoSize = True
        Me.lblunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunit.Location = New System.Drawing.Point(14, 181)
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(35, 16)
        Me.lblunit.TabIndex = 24
        Me.lblunit.Text = "Unit"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(264, 174)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(44, 16)
        Me.lbltotal.TabIndex = 25
        Me.lbltotal.Text = "Total"
        '
        'lblcgst
        '
        Me.lblcgst.AutoSize = True
        Me.lblcgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcgst.Location = New System.Drawing.Point(14, 215)
        Me.lblcgst.Name = "lblcgst"
        Me.lblcgst.Size = New System.Drawing.Size(49, 16)
        Me.lblcgst.TabIndex = 26
        Me.lblcgst.Text = "CGST"
        '
        'lblsgst
        '
        Me.lblsgst.AutoSize = True
        Me.lblsgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsgst.Location = New System.Drawing.Point(14, 245)
        Me.lblsgst.Name = "lblsgst"
        Me.lblsgst.Size = New System.Drawing.Size(49, 16)
        Me.lblsgst.TabIndex = 27
        Me.lblsgst.Text = "SGST"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Sr no"
        '
        'txtsrno
        '
        Me.txtsrno.Location = New System.Drawing.Point(62, 12)
        Me.txtsrno.Name = "txtsrno"
        Me.txtsrno.Size = New System.Drawing.Size(45, 20)
        Me.txtsrno.TabIndex = 0
        '
        'txtlbl
        '
        Me.txtlbl.Location = New System.Drawing.Point(62, 51)
        Me.txtlbl.Name = "txtlbl"
        Me.txtlbl.Size = New System.Drawing.Size(300, 20)
        Me.txtlbl.TabIndex = 1
        '
        'txtdes
        '
        Me.txtdes.Location = New System.Drawing.Point(120, 78)
        Me.txtdes.Multiline = True
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(172, 55)
        Me.txtdes.TabIndex = 2
        '
        'txtquantity
        '
        Me.txtquantity.Location = New System.Drawing.Point(120, 155)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(61, 20)
        Me.txtquantity.TabIndex = 3
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(120, 181)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(54, 20)
        Me.txtunit.TabIndex = 4
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(314, 174)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(45, 20)
        Me.txttotal.TabIndex = 6
        '
        'txtcgst
        '
        Me.txtcgst.Location = New System.Drawing.Point(120, 215)
        Me.txtcgst.Name = "txtcgst"
        Me.txtcgst.Size = New System.Drawing.Size(45, 20)
        Me.txtcgst.TabIndex = 7
        '
        'txtsgst
        '
        Me.txtsgst.Location = New System.Drawing.Point(120, 245)
        Me.txtsgst.Name = "txtsgst"
        Me.txtsgst.Size = New System.Drawing.Size(45, 20)
        Me.txtsgst.TabIndex = 10
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(862, 338)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(82, 39)
        Me.btnadd.TabIndex = 15
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnexcel
        '
        Me.btnexcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexcel.Location = New System.Drawing.Point(862, 383)
        Me.btnexcel.Name = "btnexcel"
        Me.btnexcel.Size = New System.Drawing.Size(124, 39)
        Me.btnexcel.TabIndex = 16
        Me.btnexcel.Text = "Export Excel"
        Me.btnexcel.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(862, 473)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(86, 39)
        Me.btnexit.TabIndex = 19
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 333)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(844, 258)
        Me.DataGridView1.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.HeaderText = "Sr No"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Item"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descriptions"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Unit"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "CGST"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "SGST"
        Me.Column8.Name = "Column8"
        '
        'btnmultiply
        '
        Me.btnmultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmultiply.Location = New System.Drawing.Point(187, 168)
        Me.btnmultiply.Name = "btnmultiply"
        Me.btnmultiply.Size = New System.Drawing.Size(71, 29)
        Me.btnmultiply.TabIndex = 5
        Me.btnmultiply.Text = "Multiply"
        Me.btnmultiply.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(187, 209)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 29)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "PerCGST"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtvalue
        '
        Me.txtvalue.Location = New System.Drawing.Point(283, 214)
        Me.txtvalue.Name = "txtvalue"
        Me.txtvalue.Size = New System.Drawing.Size(45, 20)
        Me.txtvalue.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(192, 245)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 29)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "PerSGST"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtsgstvlaue
        '
        Me.txtsgstvlaue.Location = New System.Drawing.Point(283, 254)
        Me.txtsgstvlaue.Name = "txtsgstvlaue"
        Me.txtsgstvlaue.Size = New System.Drawing.Size(45, 20)
        Me.txtsgstvlaue.TabIndex = 12
        '
        'txttotalvalue
        '
        Me.txttotalvalue.Location = New System.Drawing.Point(161, 297)
        Me.txttotalvalue.Name = "txttotalvalue"
        Me.txttotalvalue.Size = New System.Drawing.Size(97, 20)
        Me.txttotalvalue.TabIndex = 14
        '
        'btntotalvalue
        '
        Me.btntotalvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntotalvalue.Location = New System.Drawing.Point(12, 288)
        Me.btntotalvalue.Name = "btntotalvalue"
        Me.btntotalvalue.Size = New System.Drawing.Size(118, 29)
        Me.btntotalvalue.TabIndex = 13
        Me.btntotalvalue.Text = "Total Value"
        Me.btntotalvalue.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(342, 288)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(86, 39)
        Me.btnclear.TabIndex = 17
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(862, 428)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(108, 39)
        Me.btndelete.TabIndex = 18
        Me.btndelete.Text = "Delete Rows"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(862, 293)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(124, 39)
        Me.btnExport.TabIndex = 29
        Me.btnExport.Text = "Export Word"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1146, 594)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btntotalvalue)
        Me.Controls.Add(Me.txttotalvalue)
        Me.Controls.Add(Me.txtsgstvlaue)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtvalue)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnmultiply)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnexcel)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtsgst)
        Me.Controls.Add(Me.txtcgst)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtunit)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtdes)
        Me.Controls.Add(Me.txtlbl)
        Me.Controls.Add(Me.txtsrno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblsgst)
        Me.Controls.Add(Me.lblcgst)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblunit)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.lbldescriptions)
        Me.Controls.Add(Me.lblitem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblitem As Label
    Friend WithEvents lbldescriptions As Label
    Friend WithEvents lblquantity As Label
    Friend WithEvents lblunit As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblcgst As Label
    Friend WithEvents lblsgst As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtsrno As TextBox
    Friend WithEvents txtlbl As TextBox
    Friend WithEvents txtdes As TextBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtunit As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtcgst As TextBox
    Friend WithEvents txtsgst As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnexcel As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents btnmultiply As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtvalue As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents txtsgstvlaue As TextBox
    Friend WithEvents txttotalvalue As TextBox
    Friend WithEvents btntotalvalue As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnExport As Button
End Class
