Public Class Form1

    Private Sub Btn_ajouter_Click(sender As Object, e As EventArgs) Handles Btn_ajouter.Click
        Dim l As Livre
        l.ISBN = Txt_isbn.Text
        l.titre = Txt_titre.Text
        l.auteur = Txt_auteur.Text
        If AjoutLivre(l) Then
            MessageBox.Show("ajout du livre avec succes")
        Else
            MessageBox.Show("le tableau bibliotheque est saturé")
        End If
    End Sub

    Private Sub Btn_afficher_Click(sender As Object, e As EventArgs) Handles Btn_afficher.Click
        Frm_afficher.Show()
    End Sub
End Class
