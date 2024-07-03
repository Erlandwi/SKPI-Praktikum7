<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Txtnim = New TextBox()
        Txtnama = New TextBox()
        Cbkelamin = New ComboBox()
        Cbprodi = New ComboBox()
        Bproses = New Button()
        ListView1 = New ListView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 0
        Label1.Text = "NIM"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 1
        Label2.Text = "NAMA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 2
        Label3.Text = "JENIS KELAMIN"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 3
        Label4.Text = "PRODI"
        ' 
        ' Txtnim
        ' 
        Txtnim.Location = New Point(131, 14)
        Txtnim.Name = "Txtnim"
        Txtnim.Size = New Size(290, 23)
        Txtnim.TabIndex = 4
        ' 
        ' Txtnama
        ' 
        Txtnama.Location = New Point(131, 45)
        Txtnama.Name = "Txtnama"
        Txtnama.Size = New Size(290, 23)
        Txtnama.TabIndex = 5
        ' 
        ' Cbkelamin
        ' 
        Cbkelamin.FormattingEnabled = True
        Cbkelamin.Location = New Point(131, 76)
        Cbkelamin.Name = "Cbkelamin"
        Cbkelamin.Size = New Size(290, 23)
        Cbkelamin.TabIndex = 6
        ' 
        ' Cbprodi
        ' 
        Cbprodi.FormattingEnabled = True
        Cbprodi.Location = New Point(131, 109)
        Cbprodi.Name = "Cbprodi"
        Cbprodi.Size = New Size(290, 23)
        Cbprodi.TabIndex = 7
        ' 
        ' Bproses
        ' 
        Bproses.Location = New Point(31, 151)
        Bproses.Name = "Bproses"
        Bproses.Size = New Size(390, 23)
        Bproses.TabIndex = 8
        Bproses.Text = "Proses"
        Bproses.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(31, 189)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(390, 122)
        ListView1.TabIndex = 9
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ListView1)
        Controls.Add(Bproses)
        Controls.Add(Cbprodi)
        Controls.Add(Cbkelamin)
        Controls.Add(Txtnama)
        Controls.Add(Txtnim)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Array Multi Dimensi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txtnim As TextBox
    Friend WithEvents Txtnama As TextBox
    Friend WithEvents Cbkelamin As ComboBox
    Friend WithEvents Cbprodi As ComboBox
    Friend WithEvents Bproses As Button
    Friend WithEvents ListView1 As ListView

End Class
