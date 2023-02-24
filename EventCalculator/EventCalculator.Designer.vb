<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventCalculator
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EventCalculator))
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblName = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pbxLogo2 = New System.Windows.Forms.PictureBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstEvent = New System.Windows.Forms.ListBox()
        Me.cboDiscount = New System.Windows.Forms.ComboBox()
        Me.grpEvent = New System.Windows.Forms.GroupBox()
        Me.grpInformation = New System.Windows.Forms.GroupBox()
        Me.txtParty = New System.Windows.Forms.TextBox()
        Me.txtGuests = New System.Windows.Forms.TextBox()
        Me.txtStay = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblGuests = New System.Windows.Forms.Label()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.grpFees = New System.Windows.Forms.GroupBox()
        Me.lblCost1 = New System.Windows.Forms.Label()
        Me.lblCosts = New System.Windows.Forms.Label()
        Me.lblPartyFees = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.grpEvent.SuspendLayout()
        Me.grpInformation.SuspendLayout()
        Me.grpFees.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(247, 398)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(72, 28)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalc, "This will Calculate your total")
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(349, 398)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(72, 28)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "C&lear"
        Me.ToolTip1.SetToolTip(Me.btnReset, "This will Clear your inputs and results")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(446, 398)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 28)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "&Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "This will Exit you out of the Program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(487, 434)
        Me.lblName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(91, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Brian Nicewander"
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(12, 27)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(99, 72)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 4
        Me.pbxLogo.TabStop = False
        '
        'pbxLogo2
        '
        Me.pbxLogo2.Image = CType(resources.GetObject("pbxLogo2.Image"), System.Drawing.Image)
        Me.pbxLogo2.Location = New System.Drawing.Point(477, 27)
        Me.pbxLogo2.Name = "pbxLogo2"
        Me.pbxLogo2.Size = New System.Drawing.Size(99, 72)
        Me.pbxLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo2.TabIndex = 5
        Me.pbxLogo2.TabStop = False
        '
        'lblCompany
        '
        Me.lblCompany.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCompany.Location = New System.Drawing.Point(117, 27)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(354, 72)
        Me.lblCompany.TabIndex = 6
        Me.lblCompany.Text = "ICE WOLF HOTEL GROUP RATES"
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileToolStripMenuItem, Me.mnuHelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(609, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFileToolStripMenuItem
        '
        Me.mnuFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCalculateToolStripMenuItem, Me.mnuClearToolStripMenuItem, Me.mnuExitToolStripMenuItem})
        Me.mnuFileToolStripMenuItem.Name = "mnuFileToolStripMenuItem"
        Me.mnuFileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.mnuFileToolStripMenuItem.Text = "&File"
        '
        'mnuCalculateToolStripMenuItem
        '
        Me.mnuCalculateToolStripMenuItem.Name = "mnuCalculateToolStripMenuItem"
        Me.mnuCalculateToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.mnuCalculateToolStripMenuItem.Text = "Calculate"
        Me.mnuCalculateToolStripMenuItem.ToolTipText = "This will Calculate your total"
        '
        'mnuClearToolStripMenuItem
        '
        Me.mnuClearToolStripMenuItem.Name = "mnuClearToolStripMenuItem"
        Me.mnuClearToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.mnuClearToolStripMenuItem.Text = "C&lear"
        Me.mnuClearToolStripMenuItem.ToolTipText = "This will Clear your inputs and results"
        '
        'mnuExitToolStripMenuItem
        '
        Me.mnuExitToolStripMenuItem.Name = "mnuExitToolStripMenuItem"
        Me.mnuExitToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.mnuExitToolStripMenuItem.Text = "&Exit"
        Me.mnuExitToolStripMenuItem.ToolTipText = "This will Exit you out of the Program"
        '
        'mnuHelpToolStripMenuItem
        '
        Me.mnuHelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAboutToolStripMenuItem})
        Me.mnuHelpToolStripMenuItem.Name = "mnuHelpToolStripMenuItem"
        Me.mnuHelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelpToolStripMenuItem.Text = "&Help"
        '
        'mnuAboutToolStripMenuItem
        '
        Me.mnuAboutToolStripMenuItem.Name = "mnuAboutToolStripMenuItem"
        Me.mnuAboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.mnuAboutToolStripMenuItem.Text = "&About"
        Me.mnuAboutToolStripMenuItem.ToolTipText = "This will tell you about the program"
        '
        'lstEvent
        '
        Me.lstEvent.FormattingEnabled = True
        Me.lstEvent.Items.AddRange(New Object() {"Athletic", "Business Retreat", "Concerts", "Ice Wolf Pictures", "School Event", "Weddings"})
        Me.lstEvent.Location = New System.Drawing.Point(6, 19)
        Me.lstEvent.Name = "lstEvent"
        Me.lstEvent.Size = New System.Drawing.Size(120, 95)
        Me.lstEvent.TabIndex = 0
        '
        'cboDiscount
        '
        Me.cboDiscount.FormattingEnabled = True
        Me.cboDiscount.Items.AddRange(New Object() {"AAA", "Employee", "Frequent Usage", "Group (5+)", "Group (10+)", "NRA"})
        Me.cboDiscount.Location = New System.Drawing.Point(6, 192)
        Me.cboDiscount.Name = "cboDiscount"
        Me.cboDiscount.Size = New System.Drawing.Size(121, 21)
        Me.cboDiscount.TabIndex = 1
        '
        'grpEvent
        '
        Me.grpEvent.Controls.Add(Me.lstEvent)
        Me.grpEvent.Controls.Add(Me.cboDiscount)
        Me.grpEvent.Location = New System.Drawing.Point(12, 138)
        Me.grpEvent.Name = "grpEvent"
        Me.grpEvent.Size = New System.Drawing.Size(154, 229)
        Me.grpEvent.TabIndex = 0
        Me.grpEvent.TabStop = False
        Me.grpEvent.Text = "Select Event"
        '
        'grpInformation
        '
        Me.grpInformation.Controls.Add(Me.txtParty)
        Me.grpInformation.Controls.Add(Me.txtGuests)
        Me.grpInformation.Controls.Add(Me.txtStay)
        Me.grpInformation.Controls.Add(Me.lblContact)
        Me.grpInformation.Controls.Add(Me.lblGuests)
        Me.grpInformation.Controls.Add(Me.lblNights)
        Me.grpInformation.Location = New System.Drawing.Point(194, 138)
        Me.grpInformation.Name = "grpInformation"
        Me.grpInformation.Size = New System.Drawing.Size(175, 229)
        Me.grpInformation.TabIndex = 1
        Me.grpInformation.TabStop = False
        Me.grpInformation.Text = "Party Information"
        '
        'txtParty
        '
        Me.txtParty.Location = New System.Drawing.Point(53, 163)
        Me.txtParty.Name = "txtParty"
        Me.txtParty.Size = New System.Drawing.Size(114, 20)
        Me.txtParty.TabIndex = 2
        '
        'txtGuests
        '
        Me.txtGuests.Location = New System.Drawing.Point(53, 94)
        Me.txtGuests.Name = "txtGuests"
        Me.txtGuests.Size = New System.Drawing.Size(114, 20)
        Me.txtGuests.TabIndex = 1
        '
        'txtStay
        '
        Me.txtStay.Location = New System.Drawing.Point(53, 44)
        Me.txtStay.Name = "txtStay"
        Me.txtStay.Size = New System.Drawing.Size(114, 20)
        Me.txtStay.TabIndex = 0
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(7, 166)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(44, 13)
        Me.lblContact.TabIndex = 2
        Me.lblContact.Text = "Contact"
        '
        'lblGuests
        '
        Me.lblGuests.AutoSize = True
        Me.lblGuests.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuests.Location = New System.Drawing.Point(7, 96)
        Me.lblGuests.Name = "lblGuests"
        Me.lblGuests.Size = New System.Drawing.Size(40, 13)
        Me.lblGuests.TabIndex = 1
        Me.lblGuests.Text = "Guests"
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNights.Location = New System.Drawing.Point(7, 44)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(37, 13)
        Me.lblNights.TabIndex = 0
        Me.lblNights.Text = "Nights"
        '
        'grpFees
        '
        Me.grpFees.Controls.Add(Me.lblCost1)
        Me.grpFees.Controls.Add(Me.lblCosts)
        Me.grpFees.Controls.Add(Me.lblPartyFees)
        Me.grpFees.Controls.Add(Me.lblInformation)
        Me.grpFees.Location = New System.Drawing.Point(397, 138)
        Me.grpFees.Name = "grpFees"
        Me.grpFees.Size = New System.Drawing.Size(174, 229)
        Me.grpFees.TabIndex = 12
        Me.grpFees.TabStop = False
        Me.grpFees.Text = "Party Fees"
        '
        'lblCost1
        '
        Me.lblCost1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCost1.Location = New System.Drawing.Point(9, 165)
        Me.lblCost1.Name = "lblCost1"
        Me.lblCost1.Size = New System.Drawing.Size(143, 47)
        Me.lblCost1.TabIndex = 3
        '
        'lblCosts
        '
        Me.lblCosts.AutoSize = True
        Me.lblCosts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosts.Location = New System.Drawing.Point(65, 141)
        Me.lblCosts.Name = "lblCosts"
        Me.lblCosts.Size = New System.Drawing.Size(33, 13)
        Me.lblCosts.TabIndex = 2
        Me.lblCosts.Text = "Costs"
        '
        'lblPartyFees
        '
        Me.lblPartyFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPartyFees.Location = New System.Drawing.Point(9, 34)
        Me.lblPartyFees.Name = "lblPartyFees"
        Me.lblPartyFees.Size = New System.Drawing.Size(143, 95)
        Me.lblPartyFees.TabIndex = 1
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.Location = New System.Drawing.Point(35, 19)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(86, 13)
        Me.lblInformation.TabIndex = 0
        Me.lblInformation.Text = "Party Information"
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Location = New System.Drawing.Point(12, 398)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(220, 23)
        Me.lblDate.TabIndex = 13
        '
        'EventCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 450)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.grpFees)
        Me.Controls.Add(Me.grpInformation)
        Me.Controls.Add(Me.grpEvent)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.pbxLogo2)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "EventCalculator"
        Me.Text = "Ice Wolf Event Calculator"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpEvent.ResumeLayout(False)
        Me.grpInformation.ResumeLayout(False)
        Me.grpInformation.PerformLayout()
        Me.grpFees.ResumeLayout(False)
        Me.grpFees.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblName As Label
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pbxLogo2 As PictureBox
    Friend WithEvents lblCompany As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents lstEvent As ListBox
    Friend WithEvents cboDiscount As ComboBox
    Friend WithEvents grpEvent As GroupBox
    Friend WithEvents grpInformation As GroupBox
    Friend WithEvents grpFees As GroupBox
    Friend WithEvents txtParty As TextBox
    Friend WithEvents txtGuests As TextBox
    Friend WithEvents txtStay As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents lblGuests As Label
    Friend WithEvents lblNights As Label
    Friend WithEvents lblPartyFees As Label
    Friend WithEvents lblInformation As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblCost1 As Label
    Friend WithEvents lblCosts As Label
    Friend WithEvents mnuFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuCalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAboutToolStripMenuItem As ToolStripMenuItem
End Class
