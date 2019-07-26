Option Strict On

' Author Name:    Abohweyere Theodore Oghenefejiro
' Project Name:   CarList
' Date:           11th July 2019
' Description     This program keeps a list of  cars and information about the cars. It was made for the NETD2201 course

Public Class frmCarList

    Private carList As New SortedList                                 ' collection of all the carsList in the list
    Private currentCarIdentificationNumber As String = String.Empty ' current selected carr identification number
    Private editMode As Boolean = False                                 '

    ''' <summary>
    ''' btnEnter_Click - Will validate that the data entered into the controls is appropriate.
    '''                - Once the data is validated a car object will be create using the  
    '''                - parameterized constructor. It will also insert the new car object
    '''                - into the carList collection. It will also check to see if the data in
    '''                - the controls has been selected from the listview by the user. In that case
    '''                - it will need to update the data in the specific car object and the 
    '''                - listview as well.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car            ' declare a Car object
        Dim carItem As ListViewItem    ' declare a ListViewItem class

        ' validate the data in the form
        If IsValidInput() = True Then

            ' set the edit flag to true
            editMode = True

            ' 
            lbResult.Text = "It worked!"

            ' if the current car identification number has a no value
            ' then this is not an existing item from the listview
            If currentCarIdentificationNumber.Trim.Length = 0 Then

                ' create a new car object using the parameterized constructor
                car = New Car(cmbMake.Text, txtModel.Text, CInt(cmbYear.Text), CDbl(txtPrice.Text), chkNew.Checked)

                ' add the car to the carList collection
                ' using the identoification number as the key
                ' which will make the car object easier to
                ' find in the carList collection later
                carList.Add(car.IdentificationNumber.ToString(), car)

            Else
                ' if the current car identification number has a value
                ' then the user has selected something from the list view
                ' so the data in the car object in the carList collection
                ' must be updated

                ' so get the car from the custmers collection
                ' using the selected key
                car = CType(carList.Item(currentCarIdentificationNumber), Car)

                ' update the data in the specific object
                ' from the controls
                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = CInt(cmbYear.Text.ToString)
                car.Price = CDbl(txtPrice.Text.ToString)
                car.isNew = chkNew.Checked
            End If

            ' clear the items from the listview control
            lvwCars.Items.Clear()

            ' loop through the carList collection
            ' and populate the list view
            For Each carEntry As DictionaryEntry In carList

                ' instantiate a new ListViewItem
                carItem = New ListViewItem()

                ' get the car from the list
                car = CType(carEntry.Value, Car)

                ' assign the values to the ckecked control
                ' and the subitems
                carItem.Checked = car.isNew
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year.ToString)
                carItem.SubItems.Add(car.Price.ToString)

                ' add the new instantiated and populated ListViewItem
                ' to the listview control
                lvwCars.Items.Add(carItem)

            Next carEntry


            ' clear the controls
            Reset()

            ' set the edit flag to false
            editMode = False

        End If

    End Sub

    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub Reset()
        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        cmbMake.SelectedIndex = -1
        lbResult.Text = String.Empty

        currentCarIdentificationNumber = String.Empty

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        ' check if the title has been selected
        If cmbMake.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's Make." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If txtModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's model." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        If cmbYear.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's Year." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If
        ' check if the first name has been entered
        If txtPrice.Text.Trim.Length = 0 Then
            outputMessage += "Please enter the car's price" & vbCrLf
        Else
            If Not IsNumeric(txtPrice.Text.Trim) Then
                outputMessage += "Please enter the car's price as number greater than zero." & vbCrLf
            Else
                If Not (CDbl(txtPrice.Text.Trim) > 0) Then
                    ' If not set the error message
                    outputMessage += "Please enter the car's price greater than zero." & vbCrLf

                    ' And, set the return value to false
                    returnValue = False

                End If
            End If
        End If
        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lbResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function

    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnReset_Click EventHandler will clear the form and set
    ''' focus back to the input text box. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' call the rest sub routine
        Reset()

    End Sub
    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnExit_Click EventHandler will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' This will close the form
        Me.Close()

    End Sub

    ''' <summary>
    ''' lvwCars_ItemCheck - used to prevent the user from checking the check box in the list view
    '''                        - if it is not in edit mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCars_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck

        ' if it is not in edit mode
        If editMode = False Then

            ' the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If

    End Sub

    ''' <summary>
    ''' lvwCars_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged

        ' constant that represents the index of the subitem in the list that
        ' holds the car identification number 
        Const identificationSubItemIndex As Integer = 1

        If lvwCars.FocusedItem IsNot Nothing Then
            ' Get the car identification number
            currentCarIdentificationNumber = lvwCars.Items(lvwCars.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

            ' Use the car identification number to get the car from the collection object
            Dim car As Car = CType(carList.Item(currentCarIdentificationNumber), Car)

            ' set the controls on the form
            txtModel.Text = car.Model              ' get the model and set the text box
            txtPrice.Text = car.Price.ToString               ' get the Price and set the text box
            cmbMake.Text = car.Make                    ' get the Make and set the combo box
            cmbYear.Text = car.Year.ToString                  ' get the year and set the combo box
            chkNew.Checked = car.isNew ' get the new status and set the combo box

            lbResult.Text = car.GetSalutation()

        End If

    End Sub




End Class