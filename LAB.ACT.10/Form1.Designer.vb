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
        Me.components = New System.ComponentModel.Container()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnWrite
        '
        Me.btnWrite.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnWrite.Location = New System.Drawing.Point(380, 60)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(103, 46)
        Me.btnWrite.TabIndex = 1
        Me.btnWrite.Text = "WRITE"
        Me.btnWrite.UseVisualStyleBackColor = False
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnRead.Location = New System.Drawing.Point(215, 267)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(103, 67)
        Me.btnRead.TabIndex = 2
        Me.btnRead.Text = "READ"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(215, 75)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(138, 20)
        Me.NumericUpDown1.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(215, 122)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(228, 121)
        Me.ListBox1.TabIndex = 4
        '
        'btnSort
        '
        Me.btnSort.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnSort.Location = New System.Drawing.Point(340, 267)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(103, 67)
        Me.btnSort.TabIndex = 5
        Me.btnSort.Text = "SORT"
        Me.btnSort.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(707, 430)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnWrite)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnWrite As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnSort As Button
    Friend WithEvents BindingSource1 As BindingSource
End Class
