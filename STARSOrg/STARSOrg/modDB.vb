Imports System.Data.SqlClient
Module modDB
    'connection string

    'Sebastian's Database: F:\StarsOrg\STARSOrg\STARSDB.mdf

    Public gstrConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= E:\StarsOrg\STARSOrg\STARSDB.mdf;Integrated Security=True"
    'Database objects
    Public objSQLConn As SqlConnection
    Public objSQLCommand As SqlCommand
    Public objSQLDR As SqlDataReader
End Module
