Imports System.Net
Imports System.Web.Http

Public Class ValuesController
    Inherits ApiController

    ' GET api/values
    Public Function GetValues() As IEnumerable(Of String)

        Dim idProperty = "12233793"
        Dim urlProperty = "https://als.id-3.net/api2/property/getrawdata?id="

        Dim propertyInfos = New RestClient(urlProperty)
        Dim request = New RestRequest(Method.[Get])
        Dim response As RestResponse = Execute(request)
        Console.WriteLine(response)


    End Function

    ' GET api/values/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function

    ' POST api/values
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/values/5 passer un object avec une class 
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
