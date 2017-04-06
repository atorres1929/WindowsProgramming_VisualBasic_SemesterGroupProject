Imports System.Data.SqlClient
Public Class CDB
    Public Function OpenDB() As Boolean
        objSQLCommand = New SqlCommand
        Dim blnResult As Boolean
        If objSQLConn Is Nothing Then 'we need to instantiate the connection object
            Try
                objSQLConn = New SqlConnection(gstrConn)
                objSQLConn.Open()
                blnResult = True
            Catch ex As Exception
                MessageBox.Show("Cannot open database: " & ex.ToString, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnResult = False
                'you should log this error
            End Try
        Else ' check if the connection is open
            If objSQLConn.State = ConnectionState.Open Then
                blnResult = True
            Else
                blnResult = False
            End If
        End If
        Return blnResult
    End Function
    Public Sub CloseDB()
        Try
            objSQLConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error when attempting to close database: " & ex.ToString, "Close error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetDataReaderBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataReader
        Dim sqlComm As New SqlCommand(strSP, objSQLConn)
        If Not OpenDB() Then
            'error log this problem if needed
            Return Nothing
        End If
        sqlComm.CommandType = CommandType.StoredProcedure
        If Not params Is Nothing Then 'add each parameter into the command object
            For Each p As SqlParameter In params
                sqlComm.Parameters.Add(p)
            Next
        End If
        Try
            Return sqlComm.ExecuteReader
        Catch ex As Exception
            MessageBox.Show("Failed to get datareader: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function
    Public Function GetDataAdapterBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataAdapter
        Dim sqlComm As New SqlCommand(strSP, objSQLConn)
        Dim sqlDA As SqlDataAdapter
        sqlComm.CommandType = CommandType.StoredProcedure
        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                sqlComm.Parameters.Add(p)
            Next
        End If
        Try
            sqlDA = New SqlDataAdapter(sqlComm)
            Return sqlDA
        Catch ex As Exception
            MessageBox.Show("Failed to get data adapter: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function
    Public Function ExecSP(ByVal strSP As String, ByRef params As ArrayList) As Integer
        If Not OpenDB() Then
            Return -1
        End If
        Dim sqlComm As New SqlCommand(strSP, objSQLConn)
        sqlComm.CommandType = CommandType.StoredProcedure
        Try
            If Not params Is Nothing Then
                For Each p As SqlParameter In params
                    sqlComm.Parameters.Add(p)
                Next
            End If
            Return sqlComm.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show("Error executing SP: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return -1
    End Function
    Public Function GetSingleValueFromSP(ByVal strSP As String, ByRef params As ArrayList) As String
        Dim dr As SqlDataReader = GetDataReaderBySP(strSP, params)
        Dim strResult As String
        If Not dr Is Nothing Then
            If dr.Read() Then
                strResult = dr.GetValue(0).ToString
                dr.Close()
                Return strResult
            Else
                dr.Close()
                Return -1 'no data
            End If
        End If
        Return -2 'failed to connect to DB
    End Function
End Class
