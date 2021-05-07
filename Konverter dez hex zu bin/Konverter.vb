Public Class Konverter
    Dim x As Integer
    Dim y As String
    Dim z As String
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtEing.Clear()
        TxtHex.Clear()
        TxtBin.Clear()
        x = 0
        y = Nothing
        z = Nothing
        TxtEing.ReadOnly = False
        TxtHex.ReadOnly = False
    End Sub

    Private Sub BtnKonv_Click(sender As Object, e As EventArgs) Handles BtnKonv.Click
        If TxtEing.Text = Nothing And TxtHex.Text = Nothing Or 0 And TxtBin.Text = Nothing Then
            TxtEing.Text = 0
            TxtHex.Text = 0
            TxtBin.Text = 0
            TxtEing.ReadOnly = True
            TxtHex.ReadOnly = True
        ElseIf TxtHex.Text = Nothing Or 0 And TxtBin.Text = Nothing Or 0 Then
            TxtHex.ReadOnly = True
            TxtHex.Text = Hex(TxtEing.Text)
            x = CInt(TxtEing.Text)
            Dim a As Long                         'variable für Ganzzahlen
            Dim r As Integer                      'variable für den REST
            Do
                a = x \ 2                         'Resultat wird durch Integerdivision (\) ermittelt        
                r = x Mod 2                       'REST wird durch den Modulo-Operstoren ermittelt
                x = a                             'Die Zahl für den nächsten Durchlauf ist das bisherige Resultat
                z = z & CStr(r)                   'Der Ausgabestring wird mit dem ermittelten Rest verkettet
            Loop While a >= 1                     'Die Schleife wird solange durchlaufen, wie das Resultat grösser oder gleich 1 ist
            TxtBin.Text = StrReverse(z)           'Der Rückgabestring wird umgedreht

        ElseIf TxtEing.Text = Nothing Or 0 And TxtBin.Text = Nothing Or 0 Then
            TxtEing.ReadOnly = True
            y = TxtHex.Text
            Dim i As Integer = Convert.ToInt32(y, 16)
            TxtEing.Text = CStr(i)
            Dim b As Long                         'variable für Ganzzahlen
            Dim rr As Integer                      'variable für den REST
            Do
                b = i \ 2                         'Resultat wird durch Integerdivision (\) ermittelt        
                rr = i Mod 2                       'REST wird durch den Modulo-Operstoren ermittelt
                i = b                             'Die Zahl für den nächsten Durchlauf ist das bisherige Resultat
                z = z & CStr(rr)                   'Der Ausgabestring wird mit dem ermittelten Rest verkettet
            Loop While b >= 1                     'Die Schleife wird solange durchlaufen, wie das Resultat grösser oder gleich 1 ist
            TxtBin.Text = StrReverse(z)           'Der Rückgabestring wird umgedreht

        End If
    End Sub
End Class
