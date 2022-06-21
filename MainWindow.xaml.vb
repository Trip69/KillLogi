Class MainWindow
    Private Sub b_find_Click(sender As Object, e As RoutedEventArgs) Handles b_find.Click
        Dim logi As Automation.AutomationElement
        logi.FindFirst(Automation.TreeScope.Subtree, New Automation.Condition())
        Dim aeh As Automation.AutomationEventHandler = New Automation.AutomationEventHandler(AddressOf EventHandler)
    End Sub

    Private Sub EventHandler(obj As Object, args As Automation.AutomationEventArgs)
        Dim a As Integer = 1
    End Sub
End Class
