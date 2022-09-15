<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Window1
    Inherits Wisej.Web.Form

    'Overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.DataGridView1 = New Wisej.Web.DataGridView()
        Me.TableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.Label1 = New Wisej.Web.Label()
        Me.Label3 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.Label4 = New Wisej.Web.Label()
        Me.Label6 = New Wisej.Web.Label()
        Me.TypedTextBox1 = New Wisej.Web.TypedTextBox()
        Me.TypedTextBox2 = New Wisej.Web.TypedTextBox()
        Me.TypedTextBox3 = New Wisej.Web.TypedTextBox()
        Me.TypedTextBox4 = New Wisej.Web.TypedTextBox()
        Me.TypedTextBox5 = New Wisej.Web.TypedTextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Location = New System.Drawing.Point(98, 260)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(438, 152)
        Me.DataGridView1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 15.07!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 84.93!))
        Me.TableLayoutPanel1.Controls.Add(Me.TypedTextBox5, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TypedTextBox4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TypedTextBox3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TypedTextBox2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TypedTextBox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(98, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(438, 128)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Street"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Zip"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Country"
        '
        'TypedTextBox1
        '
        Me.TypedTextBox1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.TypedTextBox1.Location = New System.Drawing.Point(69, 3)
        Me.TypedTextBox1.Name = "TypedTextBox1"
        Me.TypedTextBox1.Size = New System.Drawing.Size(366, 19)
        Me.TypedTextBox1.TabIndex = 7
        Me.TypedTextBox1.ValueType = GetType(String)
        '
        'TypedTextBox2
        '
        Me.TypedTextBox2.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.TypedTextBox2.Location = New System.Drawing.Point(69, 28)
        Me.TypedTextBox2.Name = "TypedTextBox2"
        Me.TypedTextBox2.Size = New System.Drawing.Size(366, 19)
        Me.TypedTextBox2.TabIndex = 8
        Me.TypedTextBox2.ValueType = GetType(String)
        '
        'TypedTextBox3
        '
        Me.TypedTextBox3.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.TypedTextBox3.Location = New System.Drawing.Point(69, 53)
        Me.TypedTextBox3.Name = "TypedTextBox3"
        Me.TypedTextBox3.Size = New System.Drawing.Size(366, 19)
        Me.TypedTextBox3.TabIndex = 9
        Me.TypedTextBox3.ValueType = GetType(String)
        '
        'TypedTextBox4
        '
        Me.TypedTextBox4.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.TypedTextBox4.Location = New System.Drawing.Point(69, 78)
        Me.TypedTextBox4.Name = "TypedTextBox4"
        Me.TypedTextBox4.Size = New System.Drawing.Size(366, 19)
        Me.TypedTextBox4.TabIndex = 10
        Me.TypedTextBox4.ValueType = GetType(String)
        '
        'TypedTextBox5
        '
        Me.TypedTextBox5.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.TypedTextBox5.Location = New System.Drawing.Point(69, 103)
        Me.TypedTextBox5.Name = "TypedTextBox5"
        Me.TypedTextBox5.Size = New System.Drawing.Size(366, 22)
        Me.TypedTextBox5.TabIndex = 11
        Me.TypedTextBox5.ValueType = GetType(String)
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 432)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Window1"
        Me.Text = "Window1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As Wisej.Web.DataGridView
    Friend WithEvents TableLayoutPanel1 As Wisej.Web.TableLayoutPanel
    Friend WithEvents Label1 As Wisej.Web.Label
    Friend WithEvents Label3 As Wisej.Web.Label
    Friend WithEvents Label2 As Wisej.Web.Label
    Friend WithEvents Label4 As Wisej.Web.Label
    Friend WithEvents Label6 As Wisej.Web.Label
    Friend WithEvents TypedTextBox5 As Wisej.Web.TypedTextBox
    Friend WithEvents TypedTextBox4 As Wisej.Web.TypedTextBox
    Friend WithEvents TypedTextBox3 As Wisej.Web.TypedTextBox
    Friend WithEvents TypedTextBox2 As Wisej.Web.TypedTextBox
    Friend WithEvents TypedTextBox1 As Wisej.Web.TypedTextBox
End Class
