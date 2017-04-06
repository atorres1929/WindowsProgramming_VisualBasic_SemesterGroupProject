Imports System.Data.SqlClient
Module modDB
    'connection string
    Public gstrConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\StarsOrg\STARSOrg\STARSDB.mdf;Integrated Security=True"
    'Database objects
    Public objSQLConn As SqlConnection
    Public objSQLCommand As SqlCommand
    Public objSQLDR As SqlDataReader
End Module
