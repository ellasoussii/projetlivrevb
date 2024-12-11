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
        Txt_isbn = New TextBox()
        Txt_titre = New TextBox()
        Txt_auteur = New TextBox()
        Btn_ajouter = New Button()
        Btn_afficher = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(68, 263)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 0
        Label1.Text = "Auteur"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(68, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 20)
        Label2.TabIndex = 1
        Label2.Text = "ISBN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(68, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 20)
        Label3.TabIndex = 2
        Label3.Text = "Titre"
        ' 
        ' Txt_isbn
        ' 
        Txt_isbn.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Txt_isbn.ForeColor = SystemColors.InactiveBorder
        Txt_isbn.Location = New Point(220, 98)
        Txt_isbn.Name = "Txt_isbn"
        Txt_isbn.Size = New Size(175, 27)
        Txt_isbn.TabIndex = 3
        ' 
        ' Txt_titre
        ' 
        Txt_titre.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Txt_titre.ForeColor = SystemColors.InactiveBorder
        Txt_titre.Location = New Point(220, 183)
        Txt_titre.Name = "Txt_titre"
        Txt_titre.Size = New Size(175, 27)
        Txt_titre.TabIndex = 4
        ' 
        ' Txt_auteur
        ' 
        Txt_auteur.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Txt_auteur.ForeColor = SystemColors.InactiveBorder
        Txt_auteur.Location = New Point(220, 256)
        Txt_auteur.Name = "Txt_auteur"
        Txt_auteur.Size = New Size(175, 27)
        Txt_auteur.TabIndex = 5
        ' 
        ' Btn_ajouter
        ' 
        Btn_ajouter.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Btn_ajouter.ForeColor = SystemColors.ButtonFace
        Btn_ajouter.Location = New Point(252, 361)
        Btn_ajouter.Name = "Btn_ajouter"
        Btn_ajouter.Size = New Size(94, 29)
        Btn_ajouter.TabIndex = 6
        Btn_ajouter.Text = "Ajouter"
        Btn_ajouter.UseVisualStyleBackColor = False
        ' 
        ' Btn_afficher
        ' 
        Btn_afficher.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Btn_afficher.ForeColor = SystemColors.ButtonFace
        Btn_afficher.Location = New Point(441, 361)
        Btn_afficher.Name = "Btn_afficher"
        Btn_afficher.Size = New Size(94, 29)
        Btn_afficher.TabIndex = 7
        Btn_afficher.Text = "Afficher"
        Btn_afficher.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.livre2
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_afficher)
        Controls.Add(Btn_ajouter)
        Controls.Add(Txt_auteur)
        Controls.Add(Txt_titre)
        Controls.Add(Txt_isbn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_isbn As TextBox
    Friend WithEvents Txt_titre As TextBox
    Friend WithEvents Txt_auteur As TextBox
    Friend WithEvents Btn_ajouter As Button
    Friend WithEvents Btn_afficher As Button

End Class
