Module gestion_livre

    Public Structure Livre
        Dim ISBN As Integer
        Dim titre As String
        Dim auteur As String
    End Structure
    Public bibliotheque(100) As Livre
    Dim nb As Integer = 0

    Function AjoutLivre(l As Livre)
        If nb < bibliotheque.Length Then
            bibliotheque(nb) = l
            nb += 1
            Return True
        Else
            Return False
        End If
    End Function
    Sub afficher_livre(l1 As ListBox, l2 As ListBox, l3 As ListBox)
        For i As Integer = 0 To nb - 1
            l1.Items.Add(bibliotheque(i).ISBN)
            l2.Items.Add(bibliotheque(i).titre)
            l3.Items.Add(bibliotheque(i).auteur)

        Next
    End Sub
    Sub afficher2_Livre(dgv_Livre As DataGridView)
        For i As Integer = 0 To nb - 1
            Dim livre As Livre = bibliotheque(i)
            dgv_Livre.Rows.Add(livre.ISBN, livre.auteur, livre.titre)

        Next
    End Sub


    Function ObtenirListeLivres() As List(Of Livre)
        Dim livres As New List(Of Livre)
        For i As Integer = 0 To nb - 1
            livres.Add(bibliotheque(i))
        Next
        Return livres
    End Function
End Module



