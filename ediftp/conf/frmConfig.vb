Imports System.Windows.Forms

Public Class frmConfig

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles Me.Load

        With Tree.Nodes(0)
            With .Nodes(0)
                Dim i As Integer = 0
                For Each s As ftpconfigServer In config.server
                    Dim n As New tvObject
                    With n
                        .Text = s.name
                        .myObject = s
                        .ContextMenuStrip = Me.ServerItemContextMenu
                        .Tag = i
                        i += 1
                    End With
                    .Nodes.Add(n)

                Next
                .ExpandAll()

            End With

            With .Nodes(1)
                Dim i As Integer = 0
                For Each s As ftpconfigMode In config.mode
                    Dim n As New tvObject
                    With n
                        .ImageIndex = 3
                        .SelectedImageIndex = 3
                        .Text = s.name
                        .myObject = s
                        .ContextMenuStrip = Me.ActContextMenu
                        .Tag = i
                        i += 1

                    End With

                    With .Nodes(.Nodes.Add(n))
                        Dim i2 As Integer = 0
                        For Each a As ftpconfigModeAct In s.Act
                            Dim n2 As New tvObject
                            With n2
                                .ContextMenuStrip = Me.ModeActContextMenu
                                Select Case a.actType
                                    Case eActType.receive
                                        .ImageIndex = 4
                                        .SelectedImageIndex = 4

                                    Case Else
                                        .ImageIndex = 5
                                        .SelectedImageIndex = 5

                                End Select
                                .Text = a.remotedir
                                .myObject = a
                                .Tag = i2
                                i2 += 1

                            End With
                            .Nodes.Add(n2)

                        Next
                        .ExpandAll()

                    End With
                Next
                .ExpandAll()

            End With

            .ExpandAll()
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
            ElseIf Tree.SelectedNode.Name = "nodeMain" Then
                PropertyGrid.SelectedObject = config

            Else
                PropertyGrid.SelectedObject = Nothing

            End If
        Else
            PropertyGrid.SelectedObject = Nothing
        End If

    End Sub

    Private Sub AddServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddServerToolStripMenuItem.Click

        config.server.Add(New ftpconfigServer("", "New Host Name"))
        With Tree.Nodes(0)
            With .Nodes(0)
                Dim n As New tvObject
                With n
                    .Text = "New Host Name"
                    .myObject = config.server.Last
                    .ContextMenuStrip = Me.ServerItemContextMenu
                End With
                Dim i As Integer = .Nodes.Add(n)
                .Nodes(i).Tag = i

                Tree.SelectedNode = .Nodes(i)
                Tree.SelectedNode.BeginEdit()

            End With
        End With

    End Sub

    Private Sub DeleteServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteServerToolStripMenuItem.Click
        For Each m As ftpconfigMode In config.mode
            If String.Compare(m.server, TryCast(Tree.SelectedNode, tvObject).myObject.name, True) = 0 Then
                MsgBox(String.Format("Server settings are used by mode {0}.", m.name))
                Exit Sub
            End If
        Next
        If MsgBox(
            String.Format(
                "This will delete the '{0}' server configuration." & vbCrLf &
                "Are you sure you wish to continue",
                TryCast(Tree.SelectedNode, tvObject).myObject.name
            ), vbYesNo, "Delete?"
        ) = vbYes Then
            config.server.RemoveAt(Tree.SelectedNode.Tag)
            Tree.SelectedNode.Remove()

        End If
    End Sub

    Private Sub AddModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddModeToolStripMenuItem.Click
        config.mode.Add(New ftpconfigMode("New Mode", ""))
        With Tree.Nodes(0)
            With .Nodes(1)
                Dim n As New tvObject
                With n
                    .Text = "New Mode"
                    .myObject = config.mode.Last
                    .ContextMenuStrip = Me.ActContextMenu
                    .ImageIndex = 3
                    .SelectedImageIndex = 3

                End With
                Dim i As Integer = .Nodes.Add(n)
                .Nodes(i).Tag = i

                Tree.SelectedNode = .Nodes(i)
                Tree.SelectedNode.BeginEdit()

            End With
        End With

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        If String.Compare(config.defaultmode, TryCast(Tree.SelectedNode, tvObject).myObject.name, True) = 0 Then
            MsgBox(String.Format("Cannot remove default mode '{0}'.", config.defaultmode))
            Exit Sub

        End If

        If MsgBox(
            String.Format(
                "This will delete the '{0}' mode." & vbCrLf &
                "Are you sure you wish to continue",
                TryCast(Tree.SelectedNode, tvObject).myObject.name
            ), vbYesNo, "Delete?"
        ) = vbYes Then
            config.mode.RemoveAt(Tree.SelectedNode.Tag)
            Tree.SelectedNode.Remove()

        End If
    End Sub

    Private Sub Tree_KeyUp(sender As Object, e As KeyEventArgs) Handles Tree.KeyUp
        If e.KeyCode = Keys.F2 Then
            With Tree.SelectedNode
                .BeginEdit()
            End With
        End If
    End Sub

    Private Sub Tree_BeforeLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles Tree.BeforeLabelEdit
        With e
            If Not .Node.GetType Is GetType(tvObject) Then
                .CancelEdit = True
            End If
        End With
    End Sub

    Private Sub Tree_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles Tree.AfterLabelEdit

        If e.Label Is Nothing Then Exit Sub
        With TryCast(e.Node, tvObject)
            Select Case .myObject.GetType
                Case GetType(ftpconfigServer)
                    With TryCast(.myObject, ftpconfigServer)
                        .name = e.Label

                    End With

                Case GetType(ftpconfigMode)
                    With TryCast(.myObject, ftpconfigMode)
                        .name = e.Label

                    End With

                Case Else

            End Select
            PropertyGrid.Refresh()

        End With
    End Sub

    Private Sub SendActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendActionToolStripMenuItem.Click

        Dim n As New tvObject
        With TryCast(TryCast(Tree.SelectedNode, tvObject).myObject, ftpconfigMode)
            With .Act
                .Add(New ftpconfigModeSend("/remote/folder"))
                With n
                    .Name = System.Guid.NewGuid.ToString
                    .Text = "/remote/folder"
                    .myObject = TryCast(TryCast(Tree.SelectedNode, tvObject).myObject, ftpconfigMode).Act.Last
                    .ContextMenuStrip = Me.ServerItemContextMenu
                    .ImageIndex = 5
                    .SelectedImageIndex = 5
                End With
            End With
        End With

        Dim i As Integer = Tree.SelectedNode.Nodes.Add(n)
        Tree.SelectedNode.Nodes(i).Tag = i
        Tree.SelectedNode = Tree.Nodes(0).Nodes(1).Nodes(Tree.SelectedNode.Tag).Nodes(i)
        Tree.SelectedNode.BeginEdit()

    End Sub

    Private Sub ReceiveActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiveActionToolStripMenuItem.Click

    End Sub

End Class