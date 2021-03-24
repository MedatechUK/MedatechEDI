Public Class frmConfig

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles Me.Load

        setbuttons()

        With Tree.Nodes(0)
            Dim i As Integer = 0
            For Each loc As runbatconfigLoc In config.loc
                Dim n As New tvObject
                With n
                    .SelectedImageIndex = 2
                    .ImageIndex = 2
                    .Text = loc.path
                    .myObject = loc
                    .ContextMenuStrip = Me.ContextMenuStrip2
                    .Tag = i
                    i += 1
                End With
                .Nodes.Add(n)

            Next
            .ExpandAll()

        End With
        AddHandler PropertyGrid.Leave, AddressOf hSelectedGridItemChanged

    End Sub

    Private Sub hSelectedGridItemChanged(sender As Object, e As EventArgs)
        If Tree.SelectedNode Is Nothing Then Exit Sub
        If Not PropertyGrid.SelectedObject.GetType Is GetType(runbatconfigLoc) Then Exit Sub
        With TryCast(PropertyGrid.SelectedObject, runbatconfigLoc)
            Tree.SelectedNode.Text = .path
        End With

    End Sub

    Private Sub Tree_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Tree.AfterSelect

        If Not Tree.SelectedNode Is Nothing Then
            If Tree.SelectedNode.GetType Is GetType(tvObject) Then
                With TryCast(Tree.SelectedNode, tvObject)
                    If Not .myObject Is Nothing Then
                        PropertyGrid.SelectedObject = .myObject
                    End If
                End With

            ElseIf Tree.SelectedNode.Name = "root" Then
                PropertyGrid.SelectedObject = oconfig

            Else
                PropertyGrid.SelectedObject = Nothing

            End If

        Else
            PropertyGrid.SelectedObject = Nothing

        End If

    End Sub

    Private Sub AddMonitorFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMonitorFolderToolStripMenuItem.Click
        If Tree.SelectedNode Is Nothing Then Exit Sub
        changes = True
        config.loc.Add(New runbatconfigLoc("c:\", "", "demo", "*"))
        With Tree.Nodes(0)
            Dim n As New tvObject
            With n
                .Text = "c:\"
                .myObject = config.loc.Last
                .ContextMenuStrip = Me.ContextMenuStrip2
                .SelectedImageIndex = 2
                .ImageIndex = 2

            End With

            Dim i As Integer = .Nodes.Add(n)
            .Nodes(i).Tag = i
            Tree.SelectedNode = .Nodes(i)

        End With
    End Sub

    Private Sub Tree_MouseClick(sender As Object, e As MouseEventArgs) Handles Tree.MouseClick
        Tree.SelectedNode = Tree.GetNodeAt(New Point(e.X, e.Y))

    End Sub

    Private Sub DeleteMonitorFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMonitorFolderToolStripMenuItem.Click

        If MsgBox(
            String.Format(
                "The folder '{0}' will no longer be monitored." & vbCrLf &
                "Are you sure you wish to continue",
                TryCast(TryCast(Tree.SelectedNode, tvObject).myObject, runbatconfigLoc).path
            ), vbYesNo, "Delete?"
        ) = vbYes Then

            changes = True
            config.loc.RemoveAt(Tree.SelectedNode.Tag)
            Tree.SelectedNode.Remove()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        setbuttons()

    End Sub

    Private Sub setbuttons()

        ServiceController1.Refresh()

        Me.Label2.Text = ServiceController1.Status.ToString
        Me.SplitContainer1.Enabled = (ServiceController1.Status = ServiceProcess.ServiceControllerStatus.Stopped)
        Me.Save.Enabled = Me.SplitContainer1.Enabled

        Select Case ServiceController1.Status
            Case ServiceProcess.ServiceControllerStatus.Stopped
                btn_start.Enabled = True
                btn_stop.Enabled = False
                btn_pause.Enabled = False
                btn_restart.Enabled = False

            Case ServiceProcess.ServiceControllerStatus.Running
                btn_start.Enabled = False
                btn_stop.Enabled = True
                btn_pause.Enabled = ServiceController1.CanPauseAndContinue
                btn_restart.Enabled = True

            Case ServiceProcess.ServiceControllerStatus.Paused
                btn_start.Enabled = True
                btn_stop.Enabled = True
                btn_pause.Enabled = False
                btn_restart.Enabled = False

            Case ServiceProcess.ServiceControllerStatus.ContinuePending,
                 ServiceProcess.ServiceControllerStatus.PausePending,
                 ServiceProcess.ServiceControllerStatus.StartPending,
                 ServiceProcess.ServiceControllerStatus.StopPending

                btn_start.Enabled = False
                btn_stop.Enabled = False
                btn_pause.Enabled = False
                btn_restart.Enabled = False

        End Select

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn_start.Click, btn_stop.Click, btn_pause.Click, btn_restart.Click

        btn_start.Enabled = False
        btn_stop.Enabled = False
        btn_pause.Enabled = False
        btn_restart.Enabled = False

        Select Case TryCast(sender, Button).Name.ToLower
            Case "btn_start"
                If changes Then
                    If MsgBox("Save configuration before starting the service?", vbOKCancel, "Save?") Then
                        toFile(config)
                        oDatatoFile(oconfig)
                        changes = False
                        MsgBox("Settings saved.")
                        MedatechUK.Logging.Log("Settings saved by [{0}].", Environment.UserName)
                    End If

                End If

                Select Case ServiceController1.Status
                    Case ServiceProcess.ServiceControllerStatus.Paused
                        ServiceController1.Continue()
                    Case ServiceProcess.ServiceControllerStatus.Stopped
                        ServiceController1.Start()
                    Case Else
                End Select

            Case "btn_pause"
                ServiceController1.Pause()

            Case "btn_stop"
                ServiceController1.Stop()

            Case "btn_restart"
                ServiceController1.Stop()
                While Not ServiceController1.Status = ServiceProcess.ServiceControllerStatus.Stopped
                    Threading.Thread.Sleep(100)
                    setbuttons()
                End While
                ServiceController1.Start()

        End Select

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        toFile(config)
        oDatatoFile(oconfig)
        changes = False
        MsgBox("Settings saved.")
        MedatechUK.Logging.Log("Settings saved by [{0}].", Environment.UserName)

    End Sub

    Private Sub Abandon_Click(sender As Object, e As EventArgs) Handles Abandon.Click

        If changes Then
            If MsgBox("Save your configuration changes?", vbOKCancel, "Save?") = MsgBoxResult.Ok Then _
                Save_Click(Me, Nothing)

        End If

        If Not ServiceController1.Status = ServiceProcess.ServiceControllerStatus.Running Then
            Select Case MsgBox("The service is not currently running." & vbCrLf & "Start the service?", vbYesNoCancel)
                Case vbYes
                    Select Case ServiceController1.Status
                        Case ServiceProcess.ServiceControllerStatus.Paused
                            ServiceController1.Continue()
                        Case ServiceProcess.ServiceControllerStatus.Stopped
                            ServiceController1.Start()
                        Case Else
                    End Select

                    While Not ServiceController1.Status = ServiceProcess.ServiceControllerStatus.Running
                        Threading.Thread.Sleep(100)
                        setbuttons()

                    End While

                Case vbNo
                    Me.DialogResult = DialogResult.Cancel

                Case vbCancel

            End Select

        End If

        Me.DialogResult = DialogResult.Cancel

    End Sub

End Class
