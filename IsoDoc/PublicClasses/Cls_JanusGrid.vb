Public Class Cls_JanusGrid
    Dim mDataGridEX As New Janus.Windows.GridEX.GridEX
    ' Dim mDT As New DataTable
    Public Sub GetBindJGrid_DT(ByVal dt As DataTable, ByRef dg As Janus.Windows.GridEX.GridEX, ByVal cnnstr As String)

        Dim myConnection As New SqlClient.SqlConnection(cnnstr)

        Try

            myConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            dg.DataSource = dt
            dg.SetDataBinding(dt.DefaultView, "")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        myConnection.Close()
        myConnection = Nothing
        Try
            Dim b As New Janus.Windows.GridEX.GridEXTable
            dg.RootTable = b

        Catch ex As Exception

        End Try
        '  dg.RetrieveStructure()
    End Sub
    Public Sub setMyJGrid(ByVal dt As DataTable, ByRef dg As Janus.Windows.GridEX.GridEX, ByVal dtMem As String, ByVal fname As String, ByVal ColWith As Integer, Optional ByVal TxtType As Janus.Windows.GridEX.EditType = Janus.Windows.GridEX.EditType.TextBox, Optional ByVal ColStyle As Janus.Windows.GridEX.ColumnType = Janus.Windows.GridEX.ColumnType.Text, Optional ByVal ColVisible As Boolean = True)
        '  Dim b As Janus.Windows.GridEX.GridEXChildTableCollection

        dg.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003
        dg.RootTable.Columns.Add(dtMem, ColStyle, TxtType)
        dg.RootTable.Columns.Item(dtMem).Caption = fname
        dg.RootTable.Columns.Item(dtMem).Width = ColWith
        dg.RootTable.Columns.Item(dtMem).Visible = ColVisible

    End Sub
    Public Sub SetGroup(ByVal dg As Janus.Windows.GridEX.GridEX, ByVal GroupField As String, Optional ByVal GroupExpand As Janus.Windows.GridEX.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed)
        Dim b As New Janus.Windows.GridEX.GridEXGroup
        b.Column = dg.RootTable.Columns(GroupField)
        dg.RootTable.Groups.Add(b)
        dg.GroupMode = GroupExpand
    End Sub
    Public Sub HighLightRows(ByRef dg As Janus.Windows.GridEX.GridEX, ByVal FieldName As String, ByVal Condition As Janus.Windows.GridEX.ConditionOperator, ByVal FirstValue As Object, ByVal HighLightColor As System.Drawing.Color, Optional ByVal SencondValue As Object = Nothing)
        Dim fc As Janus.Windows.GridEX.GridEXFormatCondition
        fc = New Janus.Windows.GridEX.GridEXFormatCondition(dg.RootTable.Columns(FieldName), Condition, FirstValue, SencondValue)
        fc.FormatStyle.FontStrikeout = Janus.Windows.GridEX.TriState.Empty
        fc.FormatStyle.BackColor = HighLightColor
        fc.FormatStyle.Appearance = Janus.Windows.GridEX.Appearance.RaisedLight
        dg.RootTable.FormatConditions.Add(fc)
    End Sub
End Class
