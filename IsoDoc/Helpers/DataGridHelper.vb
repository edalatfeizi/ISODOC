Module DataGridHelper
    ''' <summary>
    ''' Adds a row number column to a DataTable and updates the DataGrid with the new column.
    ''' </summary>
    ''' <param name="persist">Persistent instance.</param>
    ''' <param name="dt">The DataTable to modify.</param>
    ''' <param name="ts">The DataGridTableStyle to modify.</param>
    ''' <param name="dg">The DataGrid to bind to.</param>

    Public Sub AddRowNumberToGrid(persist As Persistent.DataAccess.DataAccess, dt As DataTable, ts As DataGridTableStyle, dg As DataGrid)
        ' Add a new column for the row numbers
        Dim rowNumberCol As New DataColumn("RowNumber", GetType(Integer))
        rowNumberCol.AutoIncrement = True
        rowNumberCol.AutoIncrementSeed = 1
        rowNumberCol.AutoIncrementStep = 1
        dt.Columns.Add(rowNumberCol)

        ' Recalculate row numbers (in case additional logic needs updates)
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("RowNumber") = i + 1
        Next

        ' Apply the grid style to display the row number column
        persist.SetGridStyle_Dt(ts, Persistent.DataAccess.TxtBol.Text, dt, dg, "RowNumber", "ردیف", 40, False, False)

    End Sub


End Module
