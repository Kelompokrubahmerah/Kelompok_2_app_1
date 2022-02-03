<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Nama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.CmbKelas = New System.Windows.Forms.ComboBox()
        Me.CmbJK = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbMP = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(348, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 67)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Balik woi"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(111, 40)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(53, 20)
        Me.Nama.TabIndex = 1
        Me.Nama.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kelas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jenis kelamin"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(265, 40)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(197, 22)
        Me.TxtNama.TabIndex = 4
        '
        'CmbKelas
        '
        Me.CmbKelas.FormattingEnabled = True
        Me.CmbKelas.Items.AddRange(New Object() {"XII IIS", "XII MIA"})
        Me.CmbKelas.Location = New System.Drawing.Point(265, 91)
        Me.CmbKelas.Name = "CmbKelas"
        Me.CmbKelas.Size = New System.Drawing.Size(197, 24)
        Me.CmbKelas.TabIndex = 5
        '
        'CmbJK
        '
        Me.CmbJK.FormattingEnabled = True
        Me.CmbJK.Items.AddRange(New Object() {"Perempuan", "Laki-laki"})
        Me.CmbJK.Location = New System.Drawing.Point(265, 153)
        Me.CmbJK.Name = "CmbJK"
        Me.CmbJK.Size = New System.Drawing.Size(197, 24)
        Me.CmbJK.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Matpel"
        '
        'CmbMP
        '
        Me.CmbMP.FormattingEnabled = True
        Me.CmbMP.Items.AddRange(New Object() {"Sosiologi", "Geografi", "Sejarah Peminatan", "Sejarah Indonesia", "Ekonomi", "Matematika", "Bahasa Indonesia", "Bahasa Inggris", "Sastra Inggris", "TIK", "Prakarya", "Pkn"})
        Me.CmbMP.Location = New System.Drawing.Point(265, 215)
        Me.CmbMP.Name = "CmbMP"
        Me.CmbMP.Size = New System.Drawing.Size(193, 24)
        Me.CmbMP.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("MV Boli", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(81, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 67)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Tampilkan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 392)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CmbMP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbJK)
        Me.Controls.Add(Me.CmbKelas)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents CmbKelas As System.Windows.Forms.ComboBox
    Friend WithEvents CmbJK As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbMP As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
