<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Konverter
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnKonv = New System.Windows.Forms.Button()
        Me.LblEingabe = New System.Windows.Forms.Label()
        Me.TxtEing = New System.Windows.Forms.TextBox()
        Me.LblHex = New System.Windows.Forms.Label()
        Me.LblBin = New System.Windows.Forms.Label()
        Me.TxtHex = New System.Windows.Forms.TextBox()
        Me.TxtBin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Red
        Me.BtnClose.Location = New System.Drawing.Point(346, 249)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtnClear.Location = New System.Drawing.Point(204, 249)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 1
        Me.BtnClear.Text = "CLEAR"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnKonv
        '
        Me.BtnKonv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKonv.Location = New System.Drawing.Point(48, 249)
        Me.BtnKonv.Name = "BtnKonv"
        Me.BtnKonv.Size = New System.Drawing.Size(75, 23)
        Me.BtnKonv.TabIndex = 2
        Me.BtnKonv.Text = "KONVERT"
        Me.BtnKonv.UseVisualStyleBackColor = True
        '
        'LblEingabe
        '
        Me.LblEingabe.AutoSize = True
        Me.LblEingabe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEingabe.Location = New System.Drawing.Point(55, 53)
        Me.LblEingabe.Name = "LblEingabe"
        Me.LblEingabe.Size = New System.Drawing.Size(68, 16)
        Me.LblEingabe.TabIndex = 3
        Me.LblEingabe.Text = "Dezimal "
        '
        'TxtEing
        '
        Me.TxtEing.Location = New System.Drawing.Point(168, 56)
        Me.TxtEing.Name = "TxtEing"
        Me.TxtEing.Size = New System.Drawing.Size(237, 20)
        Me.TxtEing.TabIndex = 4
        '
        'LblHex
        '
        Me.LblHex.AutoSize = True
        Me.LblHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHex.Location = New System.Drawing.Point(76, 106)
        Me.LblHex.Name = "LblHex"
        Me.LblHex.Size = New System.Drawing.Size(35, 16)
        Me.LblHex.TabIndex = 5
        Me.LblHex.Text = "Hex"
        '
        'LblBin
        '
        Me.LblBin.AutoSize = True
        Me.LblBin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBin.Location = New System.Drawing.Point(71, 161)
        Me.LblBin.Name = "LblBin"
        Me.LblBin.Size = New System.Drawing.Size(44, 16)
        Me.LblBin.TabIndex = 6
        Me.LblBin.Text = "Binär"
        '
        'TxtHex
        '
        Me.TxtHex.Location = New System.Drawing.Point(168, 106)
        Me.TxtHex.Name = "TxtHex"
        Me.TxtHex.Size = New System.Drawing.Size(237, 20)
        Me.TxtHex.TabIndex = 7
        '
        'TxtBin
        '
        Me.TxtBin.Location = New System.Drawing.Point(168, 154)
        Me.TxtBin.Name = "TxtBin"
        Me.TxtBin.ReadOnly = True
        Me.TxtBin.Size = New System.Drawing.Size(237, 20)
        Me.TxtBin.TabIndex = 8
        '
        'Konverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 330)
        Me.Controls.Add(Me.TxtBin)
        Me.Controls.Add(Me.TxtHex)
        Me.Controls.Add(Me.LblBin)
        Me.Controls.Add(Me.LblHex)
        Me.Controls.Add(Me.TxtEing)
        Me.Controls.Add(Me.LblEingabe)
        Me.Controls.Add(Me.BtnKonv)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnClose)
        Me.Name = "Konverter"
        Me.Text = "Konverter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnKonv As Button
    Friend WithEvents LblEingabe As Label
    Friend WithEvents TxtEing As TextBox
    Friend WithEvents LblHex As Label
    Friend WithEvents LblBin As Label
    Friend WithEvents TxtHex As TextBox
    Friend WithEvents TxtBin As TextBox
End Class
