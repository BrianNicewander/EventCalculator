Public Class EventCalculator
    'Ice Wolf Calculator
    'Calculates totals for group rates
    'Last Modified 3/17/19
    'Created by Brian Nicewader

    'For random number
    Dim intNum As Integer           'Class Variable for random number
    Dim rand As New Random          'Random number object
    Dim intResult As Integer        'For my winner message box

    'Declaring my constans for Groups
    Const dec_ATHLETIC As Decimal = 60D         'Athletic event rate
    Const dec_BUSINESS As Decimal = 75D         'Business Party event rate
    Const dec_CONCERTS As Decimal = 150D        'Concert event rate
    Const dec_ICEWOLF As Decimal = 105D         'IceWolf Picture event rate
    Const dec_SCHOOL As Decimal = 50D           'School event rate
    Const dec_WEDDING As Decimal = 200D         'Wedding event rate

    'Declaring Constants for special discounts
    Const dec_AAA As Decimal = 0.15D             'AAA discount rate 15%
    Const dec_EMPLOYEE As Decimal = 0.1D        'Emplyee discount rate 10%
    Const dec_FREQUENT As Decimal = 0.05D       'Frequent user discount rate 5%
    Const dec_GROUP_5 As Decimal = 0.07D        'Group of 5+ discount rate 7%
    Const dec_GROUP_10 As Decimal = 0.11D       'Group of 10+ discount rate 11%
    Const dec_NRA As Decimal = 0.12D            'NRA discount rate 12%

    'Constant for Tax Rate
    Const dec_TAX_RATE As Decimal = 0.083D      'Tax rate 8.3%

	Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
		'Calculates the total and discounts and displays in a label

		'Declaring variables for input
		Dim StrGroup As String                  'String used to hold the group name
		Dim strName As String                   'String used to hold the contact name
		Dim intNights As Integer                'Used to hold the nights
		Dim intGroup As Integer                 'Used to hold the group #

		'Declaring variables for calculations and ouput
		Dim decTotal As Decimal                 'Holds the total of sub * (guests (loop))
		Dim strOutName As String                'Holds output format for rate and discount
		Dim strOutGroup As String               'Holds the output format for group and contact
		Dim decSub As Decimal                   'Holds my sub total (nights * event)
		Dim intCount As Integer                 'Holds the counter for the loop
		Dim decEvent As Decimal                 'Holds the event price selected
		Dim decDiscount As Decimal              'Holds the discount price
		Dim strOutTotal As String               'Holds output format for Nights and Guests
		Dim strOutFees As String                'Holds output forma for total
		Dim decTotalFees As Decimal             'Holds the grand total
		Dim strOutDiscount As String            'Holds the output format for sub total and tax total
		Dim decTax As Decimal                   'Holds the tax total
		Dim decOutDisount As Decimal            'Holds the output formate of tax %

		'Generating a random number for a free stay in hotel using 10
		intNum = rand.Next(10)

        'Check for winner
        If intNum = 1 Then          'Winner if 2 is selected
            intResult = MessageBox.Show("You have been randomly selected to win a free stay" & ControlChars.CrLf & "Would you like to use this now?", "WINNER", MessageBoxButtons.YesNo)
            'Checking to see which button was selected on message box
            If intResult = Windows.Forms.DialogResult.Yes Then
                'Puts free stay in labels and clears the form to start over
                btnReset_Click(sender, e)
                lblCost1.Text = "FREE STAY"
                lblPartyFees.Text = "FREE STAY"
                Exit Sub
            End If
        End If

        'Handles the group rate
        If lstEvent.SelectedIndex = -1 Then
                MessageBox.Show("Please select a valid event from the list", "Event Error")
                Exit Sub
            ElseIf lstEvent.SelectedIndex = 0 Then
                decEvent = dec_ATHLETIC
            ElseIf lstEvent.SelectedIndex = 1 Then
                decEvent = dec_BUSINESS
            ElseIf lstEvent.SelectedIndex = 2 Then
                decEvent = dec_CONCERTS
            ElseIf lstEvent.SelectedIndex = 3 Then
                decEvent = dec_ICEWOLF
            ElseIf lstEvent.SelectedIndex = 4 Then
                decEvent = dec_SCHOOL
            ElseIf lstEvent.SelectedIndex = 5 Then
                decEvent = dec_WEDDING
            End If

            'Handles the Discount
            If cboDiscount.SelectedIndex = -1 Then
                decDiscount = 0
            ElseIf cboDiscount.SelectedIndex = 0 Then
                decDiscount = dec_AAA
            ElseIf cboDiscount.SelectedIndex = 1 Then
                decDiscount = dec_EMPLOYEE
            ElseIf cboDiscount.SelectedIndex = 2 Then
                decDiscount = dec_FREQUENT
            ElseIf cboDiscount.SelectedIndex = 3 Then
                decDiscount = dec_GROUP_5
            ElseIf cboDiscount.SelectedIndex = 4 Then
                decDiscount = dec_GROUP_10
            ElseIf cboDiscount.SelectedIndex = 5 Then
                decDiscount = dec_NRA
            End If

            'Handles the Duration of stay conversion
            If Integer.TryParse(txtStay.Text, intNights) Then
                If intNights <= 0 Or intNights >= 10 Then
                    MessageBox.Show("A valid number between 1-10 must be entered", "Error in Nights")
                    txtStay.Clear()
                    txtStay.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Did not enter a valid number for nights", "Error in Nights")
                txtStay.Clear()
                txtStay.Focus()
                Exit Sub
            End If

            'Move number of Guests to Variables
            If Integer.TryParse(txtGuests.Text, intGroup) Then
                If intGroup <= 0 Or intGroup >= 26 Then
                    MessageBox.Show("Group must be between 1-25", "Group Error")
                    txtGuests.Clear()
                    txtGuests.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Did not enter a valid number for guests", "Group Error")
                txtGuests.Clear()
                txtGuests.Focus()
                Exit Sub
            End If
            'Move Contact to string
            If txtParty.Text <> String.Empty And txtParty.Text.Length <= 15 Then
                strName = CStr(txtParty.Text)
            Else
                MessageBox.Show("You must enter a Contact name in 15 spaces or less", "Contact Name Error")
                strName = " "
                txtParty.Clear()
                txtParty.Focus()
                Exit Sub
            End If

            'Calculations
            decSub = intNights * decEvent

            'Loop for number of guests
            Do Until intCount = intGroup
                decTotal += decSub
                intCount += 1
            Loop

            'Discount removed from total of bill
            decTotalFees = decTotal - (decTotal * decDiscount)

            'Tax Calculation & Discount Output
            decTax = decTotalFees * dec_TAX_RATE
            decTotalFees += decTax
            decOutDisount = decDiscount * 100

            'Use an Input box to get a Group name for the Group
            If lstEvent.SelectedIndex <> -1 And txtParty.Text <> String.Empty Then
                StrGroup = InputBox("Enter a Group name Please!", "Contact info")
            Else
                StrGroup = " "
                Exit Sub
            End If

            'Format the output
            strOutGroup = "Group:        " & StrGroup & ControlChars.CrLf & "Contact:     " & strName & ControlChars.CrLf
            strOutName = "Rate:         " & decEvent.ToString("C") & ControlChars.CrLf & "Discount    " & decDiscount.ToString("P") & ControlChars.CrLf
            strOutTotal = "Nights:        " & intNights.ToString() & ControlChars.CrLf & "Guests:       " & intGroup & ControlChars.CrLf
            strOutFees = "Total Due:   " & decTotalFees.ToString("C")
            strOutDiscount = "Sub Total:   " & decTotal.ToString("C") & ControlChars.CrLf & "Tax:             $" & decTax.ToString("F") & ControlChars.CrLf

            'Send it out
            lblPartyFees.Text = strOutGroup & strOutName & strOutTotal
            lblCost1.Text = strOutDiscount & strOutFees

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'This Resets the text boxes, outputs, lists, Clear class variables, and Updates the time

        'Resets the Text Boxes
        txtGuests.Text = String.Empty
        txtParty.Text = String.Empty
        txtStay.Text = String.Empty

        'Resets the output
        lblPartyFees.Text = " "
        lblCost1.Text = " "

        'Resets the lists
        lstEvent.SelectedIndex = -1
        cboDiscount.SelectedIndex = -1

        'Clear my class Variables
        intNum = 0
        intResult = 0

        'Update the time and date
        lblDate.Text = Now.ToString("T") & " " & Now.ToString("D")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the Program
        Me.Close()
    End Sub

    Private Sub EventCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Shows time and date, Check for winner, Does a random number

        'Update the time
        lblDate.Text = Now.ToString("T") & " " & Now.ToString("D")

        'Generating a random number for a free stay in hotel
        intNum = rand.Next(10)

        'Check for winner
        If intNum = 2 Then
            intResult = MessageBox.Show("You have been randomly selected to win a free stay" & ControlChars.CrLf & "Would you like to use this now?", "WINNER", MessageBoxButtons.YesNo)
            If intResult = Windows.Forms.DialogResult.Yes Then
                'Resets the form and puts free stay in labels
                btnReset_Click(sender, e)
                lblCost1.Text = "FREE STAY"
                lblPartyFees.Text = "FREE STAY"
            End If
        End If
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuCalculateToolStripMenuItem.Click
        'Calculates the total  from the tool strip button
        btnCalc_Click(sender, e)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClearToolStripMenuItem.Click
        'Resets the program and updates the time from the tool strip button
        btnReset_Click(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExitToolStripMenuItem.Click
        'Exits the Program from the tool strip button
        btnExit_Click(sender, e)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAboutToolStripMenuItem.Click
        'Shows about from the tool strip button
        MessageBox.Show("Ice Wolf Group Calculator V1.0" & ControlChars.CrLf & "Created by: Brian Nicewander", "About")
    End Sub
End Class
