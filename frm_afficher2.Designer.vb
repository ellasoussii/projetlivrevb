<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_afficher2
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
        dgv_livre = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        CType(dgv_livre, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgv_livre
        ' 
        dgv_livre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_livre.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        dgv_livre.Location = New Point(146, 135)
        dgv_livre.Name = "dgv_livre"
        dgv_livre.RowHeadersWidth = 51
        dgv_livre.Size = New Size(449, 117)
        dgv_livre.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ISBN"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Titre"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Auteur"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' frm_afficher2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgv_livre)
        Name = "frm_afficher2"
        Text = "frm_afficher2"
        CType(dgv_livre, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgv_livre As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
