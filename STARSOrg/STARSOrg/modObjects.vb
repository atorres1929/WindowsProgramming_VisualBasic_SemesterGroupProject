Module modObjects
    Public Sub ClearScreenControls(ByVal objContainer As Control)
        'This procedure will clear all controls on the form passed in as the argument.
        'Not all control types have been implement. Add as needed.
        Dim strControlType As String
        Dim obj As Control
        For Each obj In objContainer.Controls
            strControlType = TypeName(obj) 'TypeName returns the class name of the control
            Select Case strControlType
                Case "TextBox"
                    Dim cntrl As TextBox
                    cntrl = DirectCast(obj, TextBox)
                    cntrl.Clear()
                Case "CheckBox"
                    Dim cntrl As CheckBox
                    cntrl = DirectCast(obj, CheckBox)
                    cntrl.Checked = False
                Case "ComboBox"
                    Dim cntrl As ComboBox
                    cntrl = DirectCast(obj, ComboBox)
                    'clear the selection only, not the list contents
                    cntrl.SelectedIndex = -1
                Case "ListBox"
                    Dim cntrl As ListBox
                    cntrl = DirectCast(obj, ListBox)
                    'clear the selection only, not the list contents
                    cntrl.SelectedIndex = -1
                Case "RadioButton"
                    Dim cntrl As RadioButton
                    cntrl = DirectCast(obj, RadioButton)
                    cntrl.Checked = False
                Case "GroupBox"
                    Dim cntrl As GroupBox
                    cntrl = DirectCast(obj, GroupBox)
                    'must recruse through its controls collection
                    ClearScreenControls(cntrl)
                Case "MaskedTextBox"
                    Dim cntrl As MaskedTextBox
                    cntrl = DirectCast(obj, MaskedTextBox)
                    cntrl.Clear()
                Case Else 'for all other types of controls
                    'do nothing or add error trapping if needed
            End Select
        Next
    End Sub
End Module
