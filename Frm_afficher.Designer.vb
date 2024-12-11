<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_afficher
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lst_isbn = New ListBox()
        lst_auteur = New ListBox()
        lst_titre = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' lst_isbn
        ' 
        lst_isbn.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        lst_isbn.ForeColor = SystemColors.InactiveBorder
        lst_isbn.FormattingEnabled = True
        lst_isbn.Location = New Point(33, 121)
        lst_isbn.Name = "lst_isbn"
        lst_isbn.Size = New Size(214, 224)
        lst_isbn.TabIndex = 0
        ' 
        ' lst_auteur
        ' 
        lst_auteur.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        lst_auteur.ForeColor = SystemColors.InactiveBorder
        lst_auteur.FormattingEnabled = True
        lst_auteur.Location = New Point(543, 121)
        lst_auteur.Name = "lst_auteur"
        lst_auteur.Size = New Size(214, 224)
        lst_auteur.TabIndex = 1
        ' 
        ' lst_titre
        ' 
        lst_titre.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        lst_titre.ForeColor = SystemColors.InactiveBorder
        lst_titre.FormattingEnabled = True
        lst_titre.Location = New Point(289, 121)
        lst_titre.Name = "lst_titre"
        lst_titre.Size = New Size(214, 224)
        lst_titre.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(103, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 20)
        Label1.TabIndex = 3
        Label1.Text = "ISBN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(606, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 4
        Label2.Text = "Auteur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(375, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 20)
        Label3.TabIndex = 5
        Label3.Text = "Titre"
        ' 
        ' Frm_afficher
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.livre1
        ClientSize = New Size(797, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lst_titre)
        Controls.Add(lst_auteur)
        Controls.Add(lst_isbn)
        Name = "Frm_afficher"
        Text = "Frm_afficher"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lst_isbn As ListBox
    Friend WithEvents lst_auteur As ListBox
    Friend WithEvents lst_titre As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
