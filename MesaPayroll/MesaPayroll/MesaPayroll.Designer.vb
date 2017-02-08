<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MesaPayroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpBenefits = New System.Windows.Forms.GroupBox()
        Me.grpMiscellaneous = New System.Windows.Forms.GroupBox()
        Me.chkVision = New System.Windows.Forms.CheckBox()
        Me.chkLongTermCare = New System.Windows.Forms.CheckBox()
        Me.chkLifeInsurance = New System.Windows.Forms.CheckBox()
        Me.chkDental = New System.Windows.Forms.CheckBox()
        Me.grp401KPercentage = New System.Windows.Forms.GroupBox()
        Me.radFivePercent401K = New System.Windows.Forms.RadioButton()
        Me.radFourPercent401K = New System.Windows.Forms.RadioButton()
        Me.radThreePercent401K = New System.Windows.Forms.RadioButton()
        Me.radTwoPercent401K = New System.Windows.Forms.RadioButton()
        Me.radOnePercent401K = New System.Windows.Forms.RadioButton()
        Me.grpMedical = New System.Windows.Forms.GroupBox()
        Me.radNoneMedical = New System.Windows.Forms.RadioButton()
        Me.radScrippsMedical = New System.Windows.Forms.RadioButton()
        Me.radKaiserMedical = New System.Windows.Forms.RadioButton()
        Me.radBlueCrossMedical = New System.Windows.Forms.RadioButton()
        Me.radAlliedMedical = New System.Windows.Forms.RadioButton()
        Me.grpPayrollReport = New System.Windows.Forms.GroupBox()
        Me.lstPayroll = New System.Windows.Forms.ListBox()
        Me.grpEnterHoursAndPayrate = New System.Windows.Forms.GroupBox()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.txtNumberOfHours = New System.Windows.Forms.TextBox()
        Me.lblPayRate = New System.Windows.Forms.Label()
        Me.lblNumberOfHours = New System.Windows.Forms.Label()
        Me.btnPayCalc = New System.Windows.Forms.Button()
        Me.btnClearForNextEmployee = New System.Windows.Forms.Button()
        Me.btnDisplayTotals = New System.Windows.Forms.Button()
        Me.Tabstop = New System.Windows.Forms.Button()
        Me.grpBenefits.SuspendLayout()
        Me.grpMiscellaneous.SuspendLayout()
        Me.grp401KPercentage.SuspendLayout()
        Me.grpMedical.SuspendLayout()
        Me.grpPayrollReport.SuspendLayout()
        Me.grpEnterHoursAndPayrate.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBenefits
        '
        Me.grpBenefits.Controls.Add(Me.grpMiscellaneous)
        Me.grpBenefits.Controls.Add(Me.grp401KPercentage)
        Me.grpBenefits.Controls.Add(Me.grpMedical)
        Me.grpBenefits.Location = New System.Drawing.Point(12, 26)
        Me.grpBenefits.Name = "grpBenefits"
        Me.grpBenefits.Size = New System.Drawing.Size(376, 277)
        Me.grpBenefits.TabIndex = 0
        Me.grpBenefits.TabStop = False
        Me.grpBenefits.Text = "Benefits"
        '
        'grpMiscellaneous
        '
        Me.grpMiscellaneous.Controls.Add(Me.chkVision)
        Me.grpMiscellaneous.Controls.Add(Me.chkLongTermCare)
        Me.grpMiscellaneous.Controls.Add(Me.chkLifeInsurance)
        Me.grpMiscellaneous.Controls.Add(Me.chkDental)
        Me.grpMiscellaneous.Location = New System.Drawing.Point(16, 204)
        Me.grpMiscellaneous.Name = "grpMiscellaneous"
        Me.grpMiscellaneous.Size = New System.Drawing.Size(339, 60)
        Me.grpMiscellaneous.TabIndex = 2
        Me.grpMiscellaneous.TabStop = False
        Me.grpMiscellaneous.Text = "Miscellaneous"
        '
        'chkVision
        '
        Me.chkVision.Location = New System.Drawing.Point(276, 27)
        Me.chkVision.Name = "chkVision"
        Me.chkVision.Size = New System.Drawing.Size(54, 17)
        Me.chkVision.TabIndex = 3
        Me.chkVision.Text = "&Vision"
        Me.chkVision.UseVisualStyleBackColor = True
        '
        'chkLongTermCare
        '
        Me.chkLongTermCare.Location = New System.Drawing.Point(173, 27)
        Me.chkLongTermCare.Name = "chkLongTermCare"
        Me.chkLongTermCare.Size = New System.Drawing.Size(102, 17)
        Me.chkLongTermCare.TabIndex = 2
        Me.chkLongTermCare.Text = "Long Term &Care"
        Me.chkLongTermCare.UseVisualStyleBackColor = True
        '
        'chkLifeInsurance
        '
        Me.chkLifeInsurance.Location = New System.Drawing.Point(76, 27)
        Me.chkLifeInsurance.Name = "chkLifeInsurance"
        Me.chkLifeInsurance.Size = New System.Drawing.Size(93, 17)
        Me.chkLifeInsurance.TabIndex = 1
        Me.chkLifeInsurance.Text = "Life &Insurance"
        Me.chkLifeInsurance.UseVisualStyleBackColor = True
        '
        'chkDental
        '
        Me.chkDental.Location = New System.Drawing.Point(13, 27)
        Me.chkDental.Name = "chkDental"
        Me.chkDental.Size = New System.Drawing.Size(57, 17)
        Me.chkDental.TabIndex = 0
        Me.chkDental.Text = "&Dental"
        Me.chkDental.UseVisualStyleBackColor = True
        '
        'grp401KPercentage
        '
        Me.grp401KPercentage.Controls.Add(Me.radFivePercent401K)
        Me.grp401KPercentage.Controls.Add(Me.radFourPercent401K)
        Me.grp401KPercentage.Controls.Add(Me.radThreePercent401K)
        Me.grp401KPercentage.Controls.Add(Me.radTwoPercent401K)
        Me.grp401KPercentage.Controls.Add(Me.radOnePercent401K)
        Me.grp401KPercentage.Location = New System.Drawing.Point(196, 24)
        Me.grp401KPercentage.Name = "grp401KPercentage"
        Me.grp401KPercentage.Size = New System.Drawing.Size(159, 174)
        Me.grp401KPercentage.TabIndex = 1
        Me.grp401KPercentage.TabStop = False
        Me.grp401KPercentage.Text = "401K Percentage"
        '
        'radFivePercent401K
        '
        Me.radFivePercent401K.Location = New System.Drawing.Point(20, 122)
        Me.radFivePercent401K.Name = "radFivePercent401K"
        Me.radFivePercent401K.Size = New System.Drawing.Size(56, 17)
        Me.radFivePercent401K.TabIndex = 9
        Me.radFivePercent401K.TabStop = True
        Me.radFivePercent401K.Text = "&Five %"
        Me.radFivePercent401K.UseVisualStyleBackColor = True
        '
        'radFourPercent401K
        '
        Me.radFourPercent401K.Location = New System.Drawing.Point(20, 99)
        Me.radFourPercent401K.Name = "radFourPercent401K"
        Me.radFourPercent401K.Size = New System.Drawing.Size(57, 17)
        Me.radFourPercent401K.TabIndex = 8
        Me.radFourPercent401K.TabStop = True
        Me.radFourPercent401K.Text = "&Four %"
        Me.radFourPercent401K.UseVisualStyleBackColor = True
        '
        'radThreePercent401K
        '
        Me.radThreePercent401K.Location = New System.Drawing.Point(20, 76)
        Me.radThreePercent401K.Name = "radThreePercent401K"
        Me.radThreePercent401K.Size = New System.Drawing.Size(64, 17)
        Me.radThreePercent401K.TabIndex = 7
        Me.radThreePercent401K.TabStop = True
        Me.radThreePercent401K.Text = "&Three %"
        Me.radThreePercent401K.UseVisualStyleBackColor = True
        '
        'radTwoPercent401K
        '
        Me.radTwoPercent401K.Location = New System.Drawing.Point(20, 53)
        Me.radTwoPercent401K.Name = "radTwoPercent401K"
        Me.radTwoPercent401K.Size = New System.Drawing.Size(57, 17)
        Me.radTwoPercent401K.TabIndex = 6
        Me.radTwoPercent401K.TabStop = True
        Me.radTwoPercent401K.Text = "&Two %"
        Me.radTwoPercent401K.UseVisualStyleBackColor = True
        '
        'radOnePercent401K
        '
        Me.radOnePercent401K.Location = New System.Drawing.Point(20, 30)
        Me.radOnePercent401K.Name = "radOnePercent401K"
        Me.radOnePercent401K.Size = New System.Drawing.Size(56, 17)
        Me.radOnePercent401K.TabIndex = 5
        Me.radOnePercent401K.TabStop = True
        Me.radOnePercent401K.Text = "&One %"
        Me.radOnePercent401K.UseVisualStyleBackColor = True
        '
        'grpMedical
        '
        Me.grpMedical.Controls.Add(Me.radNoneMedical)
        Me.grpMedical.Controls.Add(Me.radScrippsMedical)
        Me.grpMedical.Controls.Add(Me.radKaiserMedical)
        Me.grpMedical.Controls.Add(Me.radBlueCrossMedical)
        Me.grpMedical.Controls.Add(Me.radAlliedMedical)
        Me.grpMedical.Location = New System.Drawing.Point(15, 24)
        Me.grpMedical.Name = "grpMedical"
        Me.grpMedical.Size = New System.Drawing.Size(159, 174)
        Me.grpMedical.TabIndex = 0
        Me.grpMedical.TabStop = False
        Me.grpMedical.Text = "Medical"
        '
        'radNoneMedical
        '
        Me.radNoneMedical.Location = New System.Drawing.Point(18, 122)
        Me.radNoneMedical.Name = "radNoneMedical"
        Me.radNoneMedical.Size = New System.Drawing.Size(51, 17)
        Me.radNoneMedical.TabIndex = 4
        Me.radNoneMedical.TabStop = True
        Me.radNoneMedical.Text = "&None"
        Me.radNoneMedical.UseVisualStyleBackColor = True
        '
        'radScrippsMedical
        '
        Me.radScrippsMedical.Location = New System.Drawing.Point(18, 99)
        Me.radScrippsMedical.Name = "radScrippsMedical"
        Me.radScrippsMedical.Size = New System.Drawing.Size(60, 17)
        Me.radScrippsMedical.TabIndex = 3
        Me.radScrippsMedical.TabStop = True
        Me.radScrippsMedical.Text = "&Scripps"
        Me.radScrippsMedical.UseVisualStyleBackColor = True
        '
        'radKaiserMedical
        '
        Me.radKaiserMedical.Location = New System.Drawing.Point(18, 76)
        Me.radKaiserMedical.Name = "radKaiserMedical"
        Me.radKaiserMedical.Size = New System.Drawing.Size(54, 17)
        Me.radKaiserMedical.TabIndex = 2
        Me.radKaiserMedical.TabStop = True
        Me.radKaiserMedical.Text = "&Kaiser"
        Me.radKaiserMedical.UseVisualStyleBackColor = True
        '
        'radBlueCrossMedical
        '
        Me.radBlueCrossMedical.Location = New System.Drawing.Point(18, 53)
        Me.radBlueCrossMedical.Name = "radBlueCrossMedical"
        Me.radBlueCrossMedical.Size = New System.Drawing.Size(75, 17)
        Me.radBlueCrossMedical.TabIndex = 1
        Me.radBlueCrossMedical.TabStop = True
        Me.radBlueCrossMedical.Text = "&Blue Cross"
        Me.radBlueCrossMedical.UseVisualStyleBackColor = True
        '
        'radAlliedMedical
        '
        Me.radAlliedMedical.Location = New System.Drawing.Point(18, 30)
        Me.radAlliedMedical.Name = "radAlliedMedical"
        Me.radAlliedMedical.Size = New System.Drawing.Size(50, 17)
        Me.radAlliedMedical.TabIndex = 0
        Me.radAlliedMedical.TabStop = True
        Me.radAlliedMedical.Text = "&Allied"
        Me.radAlliedMedical.UseVisualStyleBackColor = True
        '
        'grpPayrollReport
        '
        Me.grpPayrollReport.Controls.Add(Me.lstPayroll)
        Me.grpPayrollReport.Location = New System.Drawing.Point(394, 26)
        Me.grpPayrollReport.Name = "grpPayrollReport"
        Me.grpPayrollReport.Size = New System.Drawing.Size(412, 400)
        Me.grpPayrollReport.TabIndex = 1
        Me.grpPayrollReport.TabStop = False
        Me.grpPayrollReport.Text = "Payroll Report"
        '
        'lstPayroll
        '
        Me.lstPayroll.FormattingEnabled = True
        Me.lstPayroll.Location = New System.Drawing.Point(20, 22)
        Me.lstPayroll.Name = "lstPayroll"
        Me.lstPayroll.Size = New System.Drawing.Size(377, 355)
        Me.lstPayroll.TabIndex = 0
        '
        'grpEnterHoursAndPayrate
        '
        Me.grpEnterHoursAndPayrate.Controls.Add(Me.txtPayRate)
        Me.grpEnterHoursAndPayrate.Controls.Add(Me.txtNumberOfHours)
        Me.grpEnterHoursAndPayrate.Controls.Add(Me.lblPayRate)
        Me.grpEnterHoursAndPayrate.Controls.Add(Me.lblNumberOfHours)
        Me.grpEnterHoursAndPayrate.Location = New System.Drawing.Point(12, 316)
        Me.grpEnterHoursAndPayrate.Name = "grpEnterHoursAndPayrate"
        Me.grpEnterHoursAndPayrate.Size = New System.Drawing.Size(376, 47)
        Me.grpEnterHoursAndPayrate.TabIndex = 2
        Me.grpEnterHoursAndPayrate.TabStop = False
        Me.grpEnterHoursAndPayrate.Text = "Enter hours worked and pay rate below."
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(270, 17)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(71, 20)
        Me.txtPayRate.TabIndex = 3
        '
        'txtNumberOfHours
        '
        Me.txtNumberOfHours.Location = New System.Drawing.Point(103, 20)
        Me.txtNumberOfHours.Name = "txtNumberOfHours"
        Me.txtNumberOfHours.Size = New System.Drawing.Size(71, 20)
        Me.txtNumberOfHours.TabIndex = 2
        '
        'lblPayRate
        '
        Me.lblPayRate.Location = New System.Drawing.Point(213, 20)
        Me.lblPayRate.Name = "lblPayRate"
        Me.lblPayRate.Size = New System.Drawing.Size(51, 13)
        Me.lblPayRate.TabIndex = 1
        Me.lblPayRate.Text = "Pay &Rate"
        '
        'lblNumberOfHours
        '
        Me.lblNumberOfHours.Location = New System.Drawing.Point(11, 20)
        Me.lblNumberOfHours.Name = "lblNumberOfHours"
        Me.lblNumberOfHours.Size = New System.Drawing.Size(87, 13)
        Me.lblNumberOfHours.TabIndex = 0
        Me.lblNumberOfHours.Text = "Number of &Hours"
        '
        'btnPayCalc
        '
        Me.btnPayCalc.Location = New System.Drawing.Point(11, 381)
        Me.btnPayCalc.Name = "btnPayCalc"
        Me.btnPayCalc.Size = New System.Drawing.Size(89, 44)
        Me.btnPayCalc.TabIndex = 3
        Me.btnPayCalc.Text = "&Pay Calculation"
        Me.btnPayCalc.UseVisualStyleBackColor = True
        '
        'btnClearForNextEmployee
        '
        Me.btnClearForNextEmployee.Location = New System.Drawing.Point(106, 382)
        Me.btnClearForNextEmployee.Name = "btnClearForNextEmployee"
        Me.btnClearForNextEmployee.Size = New System.Drawing.Size(89, 44)
        Me.btnClearForNextEmployee.TabIndex = 4
        Me.btnClearForNextEmployee.Text = "Clear for &next employee"
        Me.btnClearForNextEmployee.UseVisualStyleBackColor = True
        '
        'btnDisplayTotals
        '
        Me.btnDisplayTotals.Location = New System.Drawing.Point(201, 382)
        Me.btnDisplayTotals.Name = "btnDisplayTotals"
        Me.btnDisplayTotals.Size = New System.Drawing.Size(89, 44)
        Me.btnDisplayTotals.TabIndex = 5
        Me.btnDisplayTotals.Text = "Display &Totals"
        Me.btnDisplayTotals.UseVisualStyleBackColor = True
        '
        'Tabstop
        '
        Me.Tabstop.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Tabstop.Location = New System.Drawing.Point(296, 382)
        Me.Tabstop.Name = "Tabstop"
        Me.Tabstop.Size = New System.Drawing.Size(89, 44)
        Me.Tabstop.TabIndex = 6
        Me.Tabstop.TabStop = False
        Me.Tabstop.Text = "E&xit"
        Me.Tabstop.UseVisualStyleBackColor = True
        '
        'MesaPayroll
        '
        Me.AcceptButton = Me.btnPayCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Tabstop
        Me.ClientSize = New System.Drawing.Size(818, 438)
        Me.Controls.Add(Me.Tabstop)
        Me.Controls.Add(Me.btnDisplayTotals)
        Me.Controls.Add(Me.btnClearForNextEmployee)
        Me.Controls.Add(Me.btnPayCalc)
        Me.Controls.Add(Me.grpEnterHoursAndPayrate)
        Me.Controls.Add(Me.grpPayrollReport)
        Me.Controls.Add(Me.grpBenefits)
        Me.Name = "MesaPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mesa Accounting - Payroll Section"
        Me.grpBenefits.ResumeLayout(False)
        Me.grpMiscellaneous.ResumeLayout(False)
        Me.grp401KPercentage.ResumeLayout(False)
        Me.grpMedical.ResumeLayout(False)
        Me.grpPayrollReport.ResumeLayout(False)
        Me.grpEnterHoursAndPayrate.ResumeLayout(False)
        Me.grpEnterHoursAndPayrate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBenefits As System.Windows.Forms.GroupBox
    Friend WithEvents grpMiscellaneous As System.Windows.Forms.GroupBox
    Friend WithEvents chkVision As System.Windows.Forms.CheckBox
    Friend WithEvents chkLongTermCare As System.Windows.Forms.CheckBox
    Friend WithEvents chkLifeInsurance As System.Windows.Forms.CheckBox
    Friend WithEvents chkDental As System.Windows.Forms.CheckBox
    Friend WithEvents grp401KPercentage As System.Windows.Forms.GroupBox
    Friend WithEvents radFivePercent401K As System.Windows.Forms.RadioButton
    Friend WithEvents radFourPercent401K As System.Windows.Forms.RadioButton
    Friend WithEvents radThreePercent401K As System.Windows.Forms.RadioButton
    Friend WithEvents radTwoPercent401K As System.Windows.Forms.RadioButton
    Friend WithEvents radOnePercent401K As System.Windows.Forms.RadioButton
    Friend WithEvents grpMedical As System.Windows.Forms.GroupBox
    Friend WithEvents radNoneMedical As System.Windows.Forms.RadioButton
    Friend WithEvents radScrippsMedical As System.Windows.Forms.RadioButton
    Friend WithEvents radKaiserMedical As System.Windows.Forms.RadioButton
    Friend WithEvents radBlueCrossMedical As System.Windows.Forms.RadioButton
    Friend WithEvents radAlliedMedical As System.Windows.Forms.RadioButton
    Friend WithEvents grpPayrollReport As System.Windows.Forms.GroupBox
    Friend WithEvents lstPayroll As System.Windows.Forms.ListBox
    Friend WithEvents grpEnterHoursAndPayrate As System.Windows.Forms.GroupBox
    Friend WithEvents txtPayRate As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberOfHours As System.Windows.Forms.TextBox
    Friend WithEvents lblPayRate As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfHours As System.Windows.Forms.Label
    Friend WithEvents btnPayCalc As System.Windows.Forms.Button
    Friend WithEvents btnClearForNextEmployee As System.Windows.Forms.Button
    Friend WithEvents btnDisplayTotals As System.Windows.Forms.Button
    Friend WithEvents Tabstop As System.Windows.Forms.Button

End Class
