Public Class calcForm
    Public Shared Total As Integer
    Public Shared alt = GetSetting("PoEFGCalc", "CurrencyValues", "Alteration", calcForm.alt),
                  chrom = GetSetting("PoEFGCalc", "CurrencyValues", "Chromatic", calcForm.chrom),
                  glass = GetSetting("PoEFGCalc", "CurrencyValues", "Glassblower's Bauble", calcForm.glass),
                  jewl = GetSetting("PoEFGCalc", "CurrencyValues", "Jewellers Orb", calcForm.jewl),
                  chance = GetSetting("PoEFGCalc", "CurrencyValues", "Orb of Chance", calcForm.chance),
                  chisel = GetSetting("PoEFGCalc", "CurrencyValues", "Cartographers Chisel", calcForm.chisel),
                  fusing = GetSetting("PoEFGCalc", "CurrencyValues", "Orb of Fusing", calcForm.fusing),
                  alch = GetSetting("PoEFGCalc", "CurrencyValues", "Orb of Alchemy", calcForm.alch),
                  scour = GetSetting("PoEFGCalc", "CurrencyValues", "Orb of Scouring", calcForm.scour),
                  blessed = GetSetting("PoEFGCalc", "CurrencyValues", "Blessed Orb", calcForm.blessed),
                  chaos = GetSetting("PoEFGCalc", "CurrencyValues", "Chaos Orb", calcForm.chaos),
                  regret = GetSetting("PoEFGCalc", "CurrencyValues", "Orb of Regret", calcForm.regret),
                  regal = GetSetting("PoEFGCalc", "CurrencyValues", "Regal Orb", calcForm.regal),
                  gcp = GetSetting("PoEFGCalc", "CurrencyValues", "Gemcutters Prism", calcForm.gcp),
                  divine = GetSetting("PoEFGCalc", "CurrencyValues", "Divine Orb", calcForm.divine),
                  exalted = GetSetting("PoEFGCalc", "CurrencyValues", "Exalted Orb", calcForm.exalted)
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        settings.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Total = (altBox.Text * calcForm.alt) + (chromBox.Text * calcForm.chrom) + (glassBox.Text * calcForm.glass) + (jewlBox.Text * calcForm.jewl) + (chanceBox.Text * calcForm.chance) + (chiselBox.Text * calcForm.chisel) + (fusingBox.Text * calcForm.fusing) + (alchBox.Text * calcForm.alch) + (scourBox.Text * calcForm.scour) + (blessedBox.Text * calcForm.blessed) + (chaosBox.Text * calcForm.chaos) + (regretBox.Text * calcForm.regret) + (gcpBox.Text * calcForm.gcp) + (divineBox.Text * calcForm.divine) + (exaltedBox.Text * calcForm.exalted)
        Results.valueBox.Text = calcForm.Total
        Results.Show()
    End Sub

    Private Sub calcForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (GetSetting("PoEFGCalc", "FirstRun", "First Run", True) = True) Then
            FirstRun.Show()
            alt = 7
            chrom = 8
            glass = 5
            jewl = 15
            chance = 10
            chisel = 35
            fusing = 60
            alch = 60
            scour = 50
            blessed = 70
            chaos = 120
            regret = 100
            regal = 170
            gcp = 300
            divine = 600
            exalted = 1500
            SaveSetting("PoEFGCalc", "FirstRun", "First Run", False)
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()
    End Sub
End Class
