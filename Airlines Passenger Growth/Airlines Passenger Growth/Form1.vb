'Program Name:Airline passenger Growth
'Developer :City Hussen
'Date:07/26/2022
'Purpose:This program takes the year the user want to know the growth rate of passenger 
'and displays the growth back to the user.

Option Strict On
Public Class frmAirlinePassengerGrowth
    'Declare Class variables

    Private _dblcurrent As Double = 3.9
    Private _dblincrease As Double = 0.069
    Private _stryear1 As String = "First year growth"
    Private _stryear2 As String = "Second year growth"
    Private _stryear3 As String = "Third year growth"
    Private _stryear4 As String = "Fourth year growth"
    Private _stryear5 As String = "Fifth year growth"
    Private _stryear6 As String = "Six year growth"
    Private _stryear7 As String = "Seventh year growth"
    Private _stryear8 As String = "Eight year growth"
    Private _stryear9 As String = "Nine year growth"
    Private _stryear10 As String = "Ten year growth"


    Private Sub cboComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboComboBox.SelectedIndexChanged
        'This event handler allows the user to enter the Year choice and then calls subprocedures
        'to place the year in the list.
        Dim doubleYearChoice As Double

        doubleYearChoice = cboComboBox.SelectedIndex
        lstYear.Items.Clear()
        Select Case doubleYearChoice
            Case 0
                FirstYear()
            Case 1
                SecondYear()
            Case 2
                ThirdYear()
            Case 3
                FourthYear()
            Case 4
                FifthYear()
            Case 5
                SixthYear()
            Case 6
                SeventhYear()
            Case 7
                EighthYear()
            Case 8
                NinthYear()
            Case 9
                TenthYear()

        End Select
        'Make items Visible in the windows
        lblyear.Visible = True
        txtyear.Visible = True
        lblSelect.Visible = True
        lstYear.Visible = True
        btnGrowth.Visible = True
        btnClear.Visible = True
        lblYearSelected.Visible = True
        lblFinalGrowth.Visible = True
        'Clear the lables 
        lblYearSelected.Text = ""
        lblFinalGrowth.Text = ""
        'Set focus on Enter year text box
        txtyear.Focus()
    End Sub
    Private Sub FirstYear()
        'This procedure fills in the possible Year for year 1 
        lstYear.Items.Add(_stryear1)
        lstYear.Items.Add(_stryear2)
        lstYear.Items.Add(_stryear3)
        lstYear.Items.Add(_stryear4)
        lstYear.Items.Add(_stryear5)
        lstYear.Items.Add(_stryear6)
        lstYear.Items.Add(_stryear7)
        lstYear.Items.Add(_stryear8)
        lstYear.Items.Add(_stryear9)
        lstYear.Items.Add(_stryear10)


    End Sub

    Private Sub SecondYear()
        'This procedure fills in the possible Year for year 2  
        lstYear.Items.Add(_stryear1)
        lstYear.Items.Add(_stryear2)
        lstYear.Items.Add(_stryear3)
        lstYear.Items.Add(_stryear4)
        lstYear.Items.Add(_stryear5)
        lstYear.Items.Add(_stryear6)
        lstYear.Items.Add(_stryear7)
        lstYear.Items.Add(_stryear8)
        lstYear.Items.Add(_stryear9)
        lstYear.Items.Add(_stryear10)
    End Sub
    Private Sub ThirdYear()
        'This procedure fills in the possible Year for year 3 
        lstYear.Items.Add(_stryear1)
        lstYear.Items.Add(_stryear2)
        lstYear.Items.Add(_stryear3)
        lstYear.Items.Add(_stryear4)
        lstYear.Items.Add(_stryear5)
        lstYear.Items.Add(_stryear6)
        lstYear.Items.Add(_stryear7)
        lstYear.Items.Add(_stryear8)
        lstYear.Items.Add(_stryear9)
        lstYear.Items.Add(_stryear10)
    End Sub
    Private Sub FourthYear()
        'This procedure fills in the possible Year for year 4 
        lstYear.Items.Add(_stryear1)
        lstYear.Items.Add(_stryear2)
        lstYear.Items.Add(_stryear3)
        lstYear.Items.Add(_stryear4)
        lstYear.Items.Add(_stryear5)
        lstYear.Items.Add(_stryear6)
        lstYear.Items.Add(_stryear7)
        lstYear.Items.Add(_stryear8)
        lstYear.Items.Add(_stryear9)
        lstYear.Items.Add(_stryear10)
    End Sub
    Private Sub FifthYear()
        'This procedure fills in the possible Year for year 5 
        lstYear.Items.Add(_stryear1)
        lstYear.Items.Add(_stryear2)
        lstYear.Items.Add(_stryear3)
        lstYear.Items.Add(_stryear4)
        lstYear.Items.Add(_stryear5)
        lstYear.Items.Add(_stryear6)
        lstYear.Items.Add(_stryear7)
        lstYear.Items.Add(_stryear8)
        lstYear.Items.Add(_stryear9)
        lstYear.Items.Add(_stryear10)
    End Sub
    Private Sub SixthYear()
        'This procedure fills in the possible Year for year 6 
        lstYear.Items.Add(_stryear1)
        lstYear.Items.Add(_stryear2)
        lstYear.Items.Add(_stryear3)
        lstYear.Items.Add(_stryear4)
        lstYear.Items.Add(_stryear5)
        lstYear.Items.Add(_stryear6)
        lstYear.Items.Add(_stryear7)
        lstYear.Items.Add(_stryear8)
        lstYear.Items.Add(_stryear9)
        lstYear.Items.Add(_stryear10)
    End Sub
    Private Sub SeventhYear()
        'This procedure fills in the possible Year for year 7
        lstYear.Items.Add(_stryear1)
        lstYear.Items.Add(_stryear2)
        lstYear.Items.Add(_stryear3)
        lstYear.Items.Add(_stryear4)
        lstYear.Items.Add(_stryear5)
        lstYear.Items.Add(_stryear6)
        lstYear.Items.Add(_stryear7)
        lstYear.Items.Add(_stryear8)
        lstYear.Items.Add(_stryear9)
        lstYear.Items.Add(_stryear10)
    End Sub
    Private Sub EighthYear()
        'This procedure fills in the possible Year for year 8 
        lstYear.Items.Add(_stryear1)
        lstYear.Items.Add(_stryear2)
        lstYear.Items.Add(_stryear3)
        lstYear.Items.Add(_stryear4)
        lstYear.Items.Add(_stryear5)
        lstYear.Items.Add(_stryear6)
        lstYear.Items.Add(_stryear7)
        lstYear.Items.Add(_stryear8)
        lstYear.Items.Add(_stryear9)
        lstYear.Items.Add(_stryear10)
    End Sub
    Private Sub NinthYear()
        'This procedure fills in the possible Year for year 9

        lstYear.Items.Add(_stryear1)
        lstYear.Items.Add(_stryear2)
        lstYear.Items.Add(_stryear3)
        lstYear.Items.Add(_stryear4)
        lstYear.Items.Add(_stryear5)
        lstYear.Items.Add(_stryear6)
        lstYear.Items.Add(_stryear7)
        lstYear.Items.Add(_stryear8)
        lstYear.Items.Add(_stryear9)
        lstYear.Items.Add(_stryear10)
    End Sub
    Private Sub TenthYear()
        'This procedure fills in the possible Year for year 10 
        lstYear.Items.Add(_stryear1)
        lstYear.Items.Add(_stryear2)
        lstYear.Items.Add(_stryear3)
        lstYear.Items.Add(_stryear4)
        lstYear.Items.Add(_stryear5)
        lstYear.Items.Add(_stryear6)
        lstYear.Items.Add(_stryear7)
        lstYear.Items.Add(_stryear8)
        lstYear.Items.Add(_stryear9)
        lstYear.Items.Add(_stryear10)
    End Sub
    Private Sub btnGrowth_Click(sender As Object, e As EventArgs) Handles btnGrowth.Click
        'This button event handler determines the passenger growth of an airline and displays 
        'the growth and the year bieng calculated
        Dim doubleYearSize As Double
        Dim blnYearEnteredIsValid As Boolean = False
        Dim blnYearIsSelected As Boolean = False
        Dim doubleWhatYearChoice As Double
        Dim strSelectedYear As String = ""
        Dim doubleYearChoice As Double
        Dim decTotalGrowth As Double
        'Call  a function to ensure the year enterd is valid 
        blnYearEnteredIsValid = ValidateYearEntered()
        'Call a function to ensure a year was selected
        doubleWhatYearChoice = ValidateWhatYearSelection(blnYearIsSelected, strSelectedYear)
        'If entered year and selected year are valid, calculate the growth
        If (blnYearEnteredIsValid And blnYearIsSelected) Then
            doubleYearSize = Convert.ToDouble(txtyear.Text)
            doubleYearChoice = cboComboBox.SelectedIndex
            Select Case doubleYearChoice
                Case 0
                    decTotalGrowth = firstYeargrowth(doubleWhatYearChoice, doubleYearSize)
                Case 1
                    decTotalGrowth = secondYeargrowth(doubleWhatYearChoice, doubleYearSize)
                Case 2
                    decTotalGrowth = thirdYeargrowth(doubleWhatYearChoice, doubleYearSize)
                Case 3
                    decTotalGrowth = fourthYeargrowth(doubleWhatYearChoice, doubleYearSize)
                Case 4
                    decTotalGrowth = fifthYeargrowth(doubleWhatYearChoice, doubleYearSize)
                Case 5
                    decTotalGrowth = sixthYeargrowth(doubleWhatYearChoice, doubleYearSize)
                Case 6
                    decTotalGrowth = seventhYeargrowth(doubleWhatYearChoice, doubleYearSize)
                Case 7
                    decTotalGrowth = eigthYeargrowth(doubleWhatYearChoice, doubleYearSize)
                Case 8
                    decTotalGrowth = ninthYeargrowth(doubleWhatYearChoice, doubleYearSize)
                Case 9
                    decTotalGrowth = tenthYeargrowth(doubleWhatYearChoice, doubleYearSize)
            End Select
            'Display the growth rate of passenger
            lblYearSelected.Text = "Year:" & strSelectedYear
            lblFinalGrowth.Text = "Growth:" & decTotalGrowth.ToString("G") & "Billion passenger"

        End If

    End Sub


    Private Function ValidateYearEntered() As Boolean
        'This procedure validate the value entered for year
        Dim doubleYearSize As Double
        Dim blnValidityCheck As Boolean = False
        Dim strYearEnteredMessage As String = "Please enter year you want to know the passenger growth (1-10)"
        Dim strMessageBoxTitle As String = "Error"
        Try
            doubleYearSize = Convert.ToDouble(txtyear.Text)
            If doubleYearSize >= 1 And doubleYearSize <= 10 Then
                blnValidityCheck = True
            Else
                MsgBox(strYearEnteredMessage, , strMessageBoxTitle)
                txtyear.Focus()
                txtyear.Clear()
            End If
        Catch ex As FormatException
            MsgBox(strYearEnteredMessage, , strMessageBoxTitle)
            txtyear.Focus()
            txtyear.Clear()
        Catch Exception As OverflowException
            MsgBox(strYearEnteredMessage, , strMessageBoxTitle)
            txtyear.Focus()
            txtyear.Clear()
        End Try
        Return blnValidityCheck
    End Function
    Private Function ValidateWhatYearSelection(ByRef blnDive As Boolean, ByRef strDive As String) As Double
        'This Function ensures the user selected a year
        Dim doubleYearType As Double
        Try
            doubleYearType = Convert.ToDouble(lstYear.SelectedIndex)
            strDive = lstYear.SelectedItem.ToString()
            blnDive = True
        Catch ex As SystemException
            'Detects if a year type is not selected 
            MsgBox("Select a Year", , "Error")
            blnDive = False
        End Try
        Return doubleYearType
    End Function
    Private Function firstYeargrowth(ByVal doubleYear As Double, ByVal doublecalc As Double) As Double
        'This function calculates the growth of first Year
        Dim doubleTotalGrowth As Double
        Dim doubleFinalGrowth As Double
        Dim doublereturn As Double
        Dim doubleYear1 As Double
        Dim doubleYear2 As Double
        Dim doubleYear3 As Double
        Dim doubleYear4 As Double
        Dim doubleYear5 As Double
        Dim doubleYear6 As Double
        Dim doubleYear7 As Double
        Dim doubleYear8 As Double
        Dim doubleYear9 As Double
        Dim doubleYear10 As Double


        Select Case doubleYear
            Case 0
                doubleTotalGrowth = doubleYear1
                doubleYear = _dblcurrent
            Case 1
                doubleTotalGrowth = doubleYear2
                doubleYear = 2 * _dblcurrent
            Case 2
                doubleTotalGrowth = doubleYear3
                doubleYear = 3 * _dblcurrent
            Case 3
                doubleTotalGrowth = doubleYear4
                doubleYear = 4 * _dblcurrent
            Case 4
                doubleTotalGrowth = doubleYear5
                doubleYear = 5 * _dblcurrent
            Case 5
                doubleTotalGrowth = doubleYear6
                doubleYear = 6 * _dblcurrent
            Case 6
                doubleTotalGrowth = doubleYear7
                doubleYear = 7 * _dblcurrent
            Case 7
                doubleTotalGrowth = doubleYear8
                doubleYear = 8 * _dblcurrent
            Case 8
                doubleTotalGrowth = doubleYear9
                doubleYear = 9 * _dblcurrent
            Case 9
                doubleTotalGrowth = doubleYear10
                doubleYear = 10 * _dblcurrent
        End Select
        doubleFinalGrowth = _dblcurrent + (doubleYear * _dblincrease)
        doublereturn = doubleYear * doubleFinalGrowth + (_dblcurrent + (_dblcurrent * _dblincrease))
        Return doublereturn
    End Function
    Private Function secondYeargrowth(ByVal doubleYear As Double, ByVal doublecalc As Double) As Double
        'This function calculates the growth of second Year
        Dim doubleTotalGrowth As Double
        Dim doubleFinalGrowth As Double
        Dim doublereturn2 As Double
        Dim doubleYear1 As Double
        Dim doubleYear2 As Double
        Dim doubleYear3 As Double
        Dim doubleYear4 As Double
        Dim doubleYear5 As Double
        Dim doubleYear6 As Double
        Dim doubleYear7 As Double
        Dim doubleYear8 As Double
        Dim doubleYear9 As Double
        Dim doubleYear10 As Double


        Select Case doubleYear
            Case 0
                doubleTotalGrowth = doubleYear1
                doubleYear = _dblcurrent
            Case 1
                doubleTotalGrowth = doubleYear2
                doubleYear = 2 * _dblcurrent
            Case 2
                doubleTotalGrowth = doubleYear3
                doubleYear = 3 * _dblcurrent
            Case 3
                doubleTotalGrowth = doubleYear4
                doubleYear = 4 * _dblcurrent
            Case 4
                doubleTotalGrowth = doubleYear5
                doubleYear = 5 * _dblcurrent
            Case 5
                doubleTotalGrowth = doubleYear6
                doubleYear = 6 * _dblcurrent
            Case 6
                doubleTotalGrowth = doubleYear7
                doubleYear = 7 * _dblcurrent
            Case 7
                doubleTotalGrowth = doubleYear8
                doubleYear = 8 * _dblcurrent
            Case 8
                doubleTotalGrowth = doubleYear9
                doubleYear = 9 * _dblcurrent
            Case 9
                doubleTotalGrowth = doubleYear10
                doubleYear = 10 * _dblcurrent
        End Select
        doubleFinalGrowth = _dblcurrent + (doubleYear * _dblincrease)
        doublereturn2 = 2 * (doubleFinalGrowth + (_dblcurrent + (_dblcurrent * _dblincrease)))
        Return doublereturn2
    End Function
    Private Function thirdYeargrowth(ByVal doubleYear As Double, ByVal doublecalc As Double) As Double
        'This function calculates the growth of third Year
        Dim doubleTotalGrowth As Double
        Dim doubleFinalGrowth As Double
        Dim doublereturn3 As Double
        Dim doubleYear1 As Double
        Dim doubleYear2 As Double
        Dim doubleYear3 As Double
        Dim doubleYear4 As Double
        Dim doubleYear5 As Double
        Dim doubleYear6 As Double
        Dim doubleYear7 As Double
        Dim doubleYear8 As Double
        Dim doubleYear9 As Double
        Dim doubleYear10 As Double


        Select Case doubleYear
            Case 0
                doubleTotalGrowth = doubleYear1
                doubleYear = _dblcurrent
            Case 1
                doubleTotalGrowth = doubleYear2
                doubleYear = 2 * _dblcurrent
            Case 2
                doubleTotalGrowth = doubleYear3
                doubleYear = 3 * _dblcurrent
            Case 3
                doubleTotalGrowth = doubleYear4
                doubleYear = 4 * _dblcurrent
            Case 4
                doubleTotalGrowth = doubleYear5
                doubleYear = 5 * _dblcurrent
            Case 5
                doubleTotalGrowth = doubleYear6
                doubleYear = 6 * _dblcurrent
            Case 6
                doubleTotalGrowth = doubleYear7
                doubleYear = 7 * _dblcurrent
            Case 7
                doubleTotalGrowth = doubleYear8
                doubleYear = 8 * _dblcurrent
            Case 8
                doubleTotalGrowth = doubleYear9
                doubleYear = 9 * _dblcurrent
            Case 9
                doubleTotalGrowth = doubleYear10
                doubleYear = 10 * _dblcurrent
        End Select
        doubleFinalGrowth = _dblcurrent + (doubleYear * _dblincrease)
        doublereturn3 = 3 * (doubleFinalGrowth + (_dblcurrent + (_dblcurrent * _dblincrease)))
        Return doublereturn3
    End Function
    Private Function fourthYeargrowth(ByVal doubleYear As Double, ByVal doublecalc As Double) As Double
        'This function calculates the growth of fourth Year
        Dim doubleTotalGrowth As Double
        Dim doubleFinalGrowth As Double
        Dim doublereturn4 As Double
        Dim doubleYear1 As Double
        Dim doubleYear2 As Double
        Dim doubleYear3 As Double
        Dim doubleYear4 As Double
        Dim doubleYear5 As Double
        Dim doubleYear6 As Double
        Dim doubleYear7 As Double
        Dim doubleYear8 As Double
        Dim doubleYear9 As Double
        Dim doubleYear10 As Double


        Select Case doubleYear
            Case 0
                doubleTotalGrowth = doubleYear1
                doubleYear = _dblcurrent
            Case 1
                doubleTotalGrowth = doubleYear2
                doubleYear = 2 * _dblcurrent
            Case 2
                doubleTotalGrowth = doubleYear3
                doubleYear = 3 * _dblcurrent
            Case 3
                doubleTotalGrowth = doubleYear4
                doubleYear = 4 * _dblcurrent
            Case 4
                doubleTotalGrowth = doubleYear5
                doubleYear = 5 * _dblcurrent
            Case 5
                doubleTotalGrowth = doubleYear6
                doubleYear = 6 * _dblcurrent
            Case 6
                doubleTotalGrowth = doubleYear7
                doubleYear = 7 * _dblcurrent
            Case 7
                doubleTotalGrowth = doubleYear8
                doubleYear = 8 * _dblcurrent
            Case 8
                doubleTotalGrowth = doubleYear9
                doubleYear = 9 * _dblcurrent
            Case 9
                doubleTotalGrowth = doubleYear10
                doubleYear = 10 * _dblcurrent
        End Select
        doubleFinalGrowth = _dblcurrent + (doubleYear * _dblincrease)
        doublereturn4 = 4 * (doubleFinalGrowth + (_dblcurrent + (_dblcurrent * _dblincrease)))
        Return doublereturn4
    End Function
    Private Function fifthYeargrowth(ByVal doubleYear As Double, ByVal doublecalc As Double) As Double
        'This function calculates the growth of fifth Year
        Dim doubleTotalGrowth As Double
        Dim doubleFinalGrowth As Double
        Dim doublereturn5 As Double
        Dim doubleYear1 As Double
        Dim doubleYear2 As Double
        Dim doubleYear3 As Double
        Dim doubleYear4 As Double
        Dim doubleYear5 As Double
        Dim doubleYear6 As Double
        Dim doubleYear7 As Double
        Dim doubleYear8 As Double
        Dim doubleYear9 As Double
        Dim doubleYear10 As Double


        Select Case doubleYear
            Case 0
                doubleTotalGrowth = doubleYear1
                doubleYear = _dblcurrent
            Case 1
                doubleTotalGrowth = doubleYear2
                doubleYear = 2 * _dblcurrent
            Case 2
                doubleTotalGrowth = doubleYear3
                doubleYear = 3 * _dblcurrent
            Case 3
                doubleTotalGrowth = doubleYear4
                doubleYear = 4 * _dblcurrent
            Case 4
                doubleTotalGrowth = doubleYear5
                doubleYear = 5 * _dblcurrent
            Case 5
                doubleTotalGrowth = doubleYear6
                doubleYear = 6 * _dblcurrent
            Case 6
                doubleTotalGrowth = doubleYear7
                doubleYear = 7 * _dblcurrent
            Case 7
                doubleTotalGrowth = doubleYear8
                doubleYear = 8 * _dblcurrent
            Case 8
                doubleTotalGrowth = doubleYear9
                doubleYear = 9 * _dblcurrent
            Case 9
                doubleTotalGrowth = doubleYear10
                doubleYear = 10 * _dblcurrent
        End Select
        doubleFinalGrowth = _dblcurrent + (doubleYear * _dblincrease)
        doublereturn5 = 5 * (doubleFinalGrowth + (_dblcurrent + (_dblcurrent * _dblincrease)))
        Return doublereturn5
    End Function
    Private Function sixthYeargrowth(ByVal doubleYear As Double, ByVal doublecalc As Double) As Double
        'This function calculates the growth of sixth Year
        Dim doubleTotalGrowth As Double
        Dim doubleFinalGrowth As Double
        Dim doublereturn6 As Double
        Dim doubleYear1 As Double
        Dim doubleYear2 As Double
        Dim doubleYear3 As Double
        Dim doubleYear4 As Double
        Dim doubleYear5 As Double
        Dim doubleYear6 As Double
        Dim doubleYear7 As Double
        Dim doubleYear8 As Double
        Dim doubleYear9 As Double
        Dim doubleYear10 As Double


        Select Case doubleYear
            Case 0
                doubleTotalGrowth = doubleYear1
                doubleYear = _dblcurrent
            Case 1
                doubleTotalGrowth = doubleYear2
                doubleYear = 2 * _dblcurrent
            Case 2
                doubleTotalGrowth = doubleYear3
                doubleYear = 3 * _dblcurrent
            Case 3
                doubleTotalGrowth = doubleYear4
                doubleYear = 4 * _dblcurrent
            Case 4
                doubleTotalGrowth = doubleYear5
                doubleYear = 5 * _dblcurrent
            Case 5
                doubleTotalGrowth = doubleYear6
                doubleYear = 6 * _dblcurrent
            Case 6
                doubleTotalGrowth = doubleYear7
                doubleYear = 7 * _dblcurrent
            Case 7
                doubleTotalGrowth = doubleYear8
                doubleYear = 8 * _dblcurrent
            Case 8
                doubleTotalGrowth = doubleYear9
                doubleYear = 9 * _dblcurrent
            Case 9
                doubleTotalGrowth = doubleYear10
                doubleYear = 10 * _dblcurrent
        End Select
        doubleFinalGrowth = _dblcurrent + (doubleYear * _dblincrease)
        doublereturn6 = 6 * (doubleFinalGrowth + (_dblcurrent + (_dblcurrent * _dblincrease)))
        Return doublereturn6
    End Function
    Private Function seventhYeargrowth(ByVal doubleYear As Double, ByVal doublecalc As Double) As Double
        'This function calculates the growth of seventh Year
        Dim doubleTotalGrowth As Double
        Dim doubleFinalGrowth As Double
        Dim doublereturn7 As Double
        Dim doubleYear1 As Double
        Dim doubleYear2 As Double
        Dim doubleYear3 As Double
        Dim doubleYear4 As Double
        Dim doubleYear5 As Double
        Dim doubleYear6 As Double
        Dim doubleYear7 As Double
        Dim doubleYear8 As Double
        Dim doubleYear9 As Double
        Dim doubleYear10 As Double


        Select Case doubleYear
            Case 0
                doubleTotalGrowth = doubleYear1
                doubleYear = _dblcurrent
            Case 1
                doubleTotalGrowth = doubleYear2
                doubleYear = 2 * _dblcurrent
            Case 2
                doubleTotalGrowth = doubleYear3
                doubleYear = 3 * _dblcurrent
            Case 3
                doubleTotalGrowth = doubleYear4
                doubleYear = 4 * _dblcurrent
            Case 4
                doubleTotalGrowth = doubleYear5
                doubleYear = 5 * _dblcurrent
            Case 5
                doubleTotalGrowth = doubleYear6
                doubleYear = 6 * _dblcurrent
            Case 6
                doubleTotalGrowth = doubleYear7
                doubleYear = 7 * _dblcurrent
            Case 7
                doubleTotalGrowth = doubleYear8
                doubleYear = 8 * _dblcurrent
            Case 8
                doubleTotalGrowth = doubleYear9
                doubleYear = 9 * _dblcurrent
            Case 9
                doubleTotalGrowth = doubleYear10
                doubleYear = 10 * _dblcurrent
        End Select
        doubleFinalGrowth = _dblcurrent + (doubleYear * _dblincrease)
        doublereturn7 = 7 * (doubleFinalGrowth + (_dblcurrent + (_dblcurrent * _dblincrease)))
        Return doublereturn7
    End Function
    Private Function eigthYeargrowth(ByVal doubleYear As Double, ByVal doublecalc As Double) As Double
        'This function calculates the growth of eighth Year
        Dim doubleTotalGrowth As Double
        Dim doubleFinalGrowth As Double
        Dim doublereturn8 As Double
        Dim doubleYear1 As Double
        Dim doubleYear2 As Double
        Dim doubleYear3 As Double
        Dim doubleYear4 As Double
        Dim doubleYear5 As Double
        Dim doubleYear6 As Double
        Dim doubleYear7 As Double
        Dim doubleYear8 As Double
        Dim doubleYear9 As Double
        Dim doubleYear10 As Double


        Select Case doubleYear
            Case 0
                doubleTotalGrowth = doubleYear1
                doubleYear = _dblcurrent
            Case 1
                doubleTotalGrowth = doubleYear2
                doubleYear = 2 * _dblcurrent
            Case 2
                doubleTotalGrowth = doubleYear3
                doubleYear = 3 * _dblcurrent
            Case 3
                doubleTotalGrowth = doubleYear4
                doubleYear = 4 * _dblcurrent
            Case 4
                doubleTotalGrowth = doubleYear5
                doubleYear = 5 * _dblcurrent
            Case 5
                doubleTotalGrowth = doubleYear6
                doubleYear = 6 * _dblcurrent
            Case 6
                doubleTotalGrowth = doubleYear7
                doubleYear = 7 * _dblcurrent
            Case 7
                doubleTotalGrowth = doubleYear8
                doubleYear = 8 * _dblcurrent
            Case 8
                doubleTotalGrowth = doubleYear9
                doubleYear = 9 * _dblcurrent
            Case 9
                doubleTotalGrowth = doubleYear10
                doubleYear = 10 * _dblcurrent
        End Select
        doubleFinalGrowth = _dblcurrent + (doubleYear * _dblincrease)
        doublereturn8 = 8 * (doubleFinalGrowth + (_dblcurrent + (_dblcurrent * _dblincrease)))
        Return doublereturn8
    End Function
    Private Function ninthYeargrowth(ByVal doubleYear As Double, ByVal doublecalc As Double) As Double
        'This function calculates the growth of ninth Year
        Dim doubleTotalGrowth As Double
        Dim doubleFinalGrowth As Double
        Dim doublereturn9 As Double
        Dim doubleYear1 As Double
        Dim doubleYear2 As Double
        Dim doubleYear3 As Double
        Dim doubleYear4 As Double
        Dim doubleYear5 As Double
        Dim doubleYear6 As Double
        Dim doubleYear7 As Double
        Dim doubleYear8 As Double
        Dim doubleYear9 As Double
        Dim doubleYear10 As Double


        Select Case doubleYear
            Case 0
                doubleTotalGrowth = doubleYear1
                doubleYear = _dblcurrent
            Case 1
                doubleTotalGrowth = doubleYear2
                doubleYear = 2 * _dblcurrent
            Case 2
                doubleTotalGrowth = doubleYear3
                doubleYear = 3 * _dblcurrent
            Case 3
                doubleTotalGrowth = doubleYear4
                doubleYear = 4 * _dblcurrent
            Case 4
                doubleTotalGrowth = doubleYear5
                doubleYear = 5 * _dblcurrent
            Case 5
                doubleTotalGrowth = doubleYear6
                doubleYear = 6 * _dblcurrent
            Case 6
                doubleTotalGrowth = doubleYear7
                doubleYear = 7 * _dblcurrent
            Case 7
                doubleTotalGrowth = doubleYear8
                doubleYear = 8 * _dblcurrent
            Case 8
                doubleTotalGrowth = doubleYear9
                doubleYear = 9 * _dblcurrent
            Case 9
                doubleTotalGrowth = doubleYear10
                doubleYear = 10 * _dblcurrent
        End Select
        doubleFinalGrowth = _dblcurrent + (doubleYear * _dblincrease)
        doublereturn9 = 9 * (doubleFinalGrowth + (_dblcurrent + (_dblcurrent * _dblincrease)))
        Return doublereturn9
    End Function
    Private Function tenthYeargrowth(ByVal doubleYear As Double, ByVal doublecalc As Double) As Double
        'This function calculates the growth of tenth Year
        Dim doubleTotalGrowth As Double
        Dim doubleFinalGrowth As Double
        Dim doublereturn10 As Double
        Dim doubleYear1 As Double
        Dim doubleYear2 As Double
        Dim doubleYear3 As Double
        Dim doubleYear4 As Double
        Dim doubleYear5 As Double
        Dim doubleYear6 As Double
        Dim doubleYear7 As Double
        Dim doubleYear8 As Double
        Dim doubleYear9 As Double
        Dim doubleYear10 As Double


        Select Case doubleYear
            Case 0
                doubleTotalGrowth = doubleYear1
                doubleYear = _dblcurrent
            Case 1
                doubleTotalGrowth = doubleYear2
                doubleYear = 2 * _dblcurrent
            Case 2
                doubleTotalGrowth = doubleYear3
                doubleYear = 3 * _dblcurrent
            Case 3
                doubleTotalGrowth = doubleYear4
                doubleYear = 4 * _dblcurrent
            Case 4
                doubleTotalGrowth = doubleYear5
                doubleYear = 5 * _dblcurrent
            Case 5
                doubleTotalGrowth = doubleYear6
                doubleYear = 6 * _dblcurrent
            Case 6
                doubleTotalGrowth = doubleYear7
                doubleYear = 7 * _dblcurrent
            Case 7
                doubleTotalGrowth = doubleYear8
                doubleYear = 8 * _dblcurrent
            Case 8
                doubleTotalGrowth = doubleYear9
                doubleYear = 9 * _dblcurrent
            Case 9
                doubleTotalGrowth = doubleYear10
                doubleYear = 10 * _dblcurrent
        End Select
        doubleFinalGrowth = _dblcurrent + (doubleYear * _dblincrease)
        doublereturn10 = 10 * (doubleFinalGrowth + (_dblcurrent + (_dblcurrent * _dblincrease)))
        Return doublereturn10
    End Function


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'This event handler clears the form and resets the form for reuse when the user clicks the Clear button.
        cboComboBox.Text = "Select Location"
        txtyear.Clear()
        lstYear.Items.Clear()
        lblYearSelected.Text = ""
        lblFinalGrowth.Text = ""
        lblyear.Visible = False
        txtyear.Visible = False
        lblSelect.Visible = False
        lstYear.Visible = False
        btnGrowth.Visible = False
        btnClear.Visible = False
        lblYearSelected.Visible = False
        lblFinalGrowth.Visible = False

    End Sub
    Private Sub frmAirlinePassengerGrowth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pause 5 second for splash Sreen
        Threading.Thread.Sleep(5000)

    End Sub
End Class
