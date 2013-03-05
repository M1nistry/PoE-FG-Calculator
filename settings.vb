Public Class settings

    Private Sub currencyBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles currencyBox.SelectedIndexChanged
        If (currencyBox.Text = "Alteration") Then
            numericBox.Value = calcForm.alt
        ElseIf (currencyBox.Text = "Chromatic") Then
            numericBox.Value = calcForm.chrom
        ElseIf (currencyBox.Text = "Glassblower's Bauble") Then
            numericBox.Value = calcForm.glass
        ElseIf (currencyBox.Text = "Jeweller's Orb") Then
            numericBox.Value = calcForm.jewl
        ElseIf (currencyBox.Text = "Orb of Chance") Then
            numericBox.Value = calcForm.chance
        ElseIf (currencyBox.Text = "Cartographers Chisel") Then
            numericBox.Value = calcForm.chisel
        ElseIf (currencyBox.Text = "Orb of Fusing") Then
            numericBox.Value = calcForm.fusing
        ElseIf (currencyBox.Text = "Orb of Alchemy") Then
            numericBox.Value = calcForm.alch
        ElseIf (currencyBox.Text = "Orb of Scouring") Then
            numericBox.Value = calcForm.scour
        ElseIf (currencyBox.Text = "Blessed Orb") Then
            numericBox.Value = calcForm.blessed
        ElseIf (currencyBox.Text = "Chaos Orb") Then
            numericBox.Value = calcForm.chaos
        ElseIf (currencyBox.Text = "Orb of Regret") Then
            numericBox.Value = calcForm.regret
        ElseIf (currencyBox.Text = "Regal Orb") Then
            numericBox.Value = calcForm.regal
        ElseIf (currencyBox.Text = "Gemcutters Prism") Then
            numericBox.Value = calcForm.gcp
        ElseIf (currencyBox.Text = "Divine Orb") Then
            numericBox.Value = calcForm.divine
        ElseIf (currencyBox.Text = "Exalted Orb") Then
            numericBox.Value = calcForm.exalted
        End If
    End Sub

    Private Sub numericBox_ValueChanged(sender As Object, e As EventArgs) Handles numericBox.ValueChanged
        If (currencyBox.Text = "Alteration") Then
            calcForm.alt = numericBox.Value
        ElseIf (currencyBox.Text = "Chromatic") Then
            calcForm.chrom = numericBox.Value
        ElseIf (currencyBox.Text = "Glassblower's Bauble") Then
            calcForm.glass = numericBox.Value
        ElseIf (currencyBox.Text = "Jeweller's Orb") Then
            calcForm.jewl = numericBox.Value
        ElseIf (currencyBox.Text = "Orb of Chance") Then
            calcForm.chance = numericBox.Value
        ElseIf (currencyBox.Text = "Cartographers Chisel") Then
            calcForm.chisel = numericBox.Value
        ElseIf (currencyBox.Text = "Orb of Fusing") Then
            calcForm.fusing = numericBox.Value
        ElseIf (currencyBox.Text = "Orb of Alchemy") Then
            calcForm.alch = numericBox.Value
        ElseIf (currencyBox.Text = "Orb of Scouring") Then
            calcForm.scour = numericBox.Value
        ElseIf (currencyBox.Text = "Blessed Orb") Then
            calcForm.blessed = numericBox.Value
        ElseIf (currencyBox.Text = "Chaos Orb") Then
            calcForm.chaos = numericBox.Value
        ElseIf (currencyBox.Text = "Orb of Regret") Then
            calcForm.regret = numericBox.Value
        ElseIf (currencyBox.Text = "Regal Orb") Then
            calcForm.regal = numericBox.Value
        ElseIf (currencyBox.Text = "Gemcutters Prism") Then
            calcForm.gcp = numericBox.Value
        ElseIf (currencyBox.Text = "Divine Orb") Then
            calcForm.divine = numericBox.Value
        ElseIf (currencyBox.Text = "Exalted Orb") Then
            calcForm.exalted = numericBox.Value
        End If
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        SaveSetting("PoEFGCalc", "CurrencyValues", "Alteration", calcForm.alt)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Chromatic", calcForm.chrom)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Glassblower's Bauble", calcForm.glass)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Jewellers Orb", calcForm.jewl)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Orb of Chance", calcForm.chance)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Cartographers Chisel", calcForm.chisel)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Orb of Fusing", calcForm.fusing)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Orb of Alchemy", calcForm.alch)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Orb of Scouring", calcForm.scour)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Blessed Orb", calcForm.blessed)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Chaos Orb", calcForm.chaos)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Orb of Regret", calcForm.regret)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Regal Orb", calcForm.regal)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Gemcutters Prism", calcForm.gcp)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Divine Orb", calcForm.divine)
        SaveSetting("PoEFGCalc", "CurrencyValues", "Exalted Orb", calcForm.exalted)

    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calcForm.alt = 7
        calcForm.chrom = 8
        calcForm.glass = 5
        calcForm.jewl = 15
        calcForm.chance = 10
        calcForm.chisel = 35
        calcForm.fusing = 60
        calcForm.alch = 60
        calcForm.scour = 50
        calcForm.blessed = 70
        calcForm.chaos = 120
        calcForm.regret = 100
        calcForm.regal = 170
        calcForm.gcp = 300
        calcForm.divine = 600
        calcForm.exalted = 1500
        Button1.Visible = False
        CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            Button1.Visible = True
        Else : Button1.Visible = False
        End If
    End Sub
End Class
