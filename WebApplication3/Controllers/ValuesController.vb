Imports System.Net
Imports System.Web.Http
Imports System.Data
Imports Newtonsoft.Json

Public Class ValuesController
    Inherits ApiController

    ' GET apiShotstack/values
    Public Function GetValuesProperty() As IEnumerable(Of String)

        'Dim idProperty = "12233793'
        Dim urlProperty = "https://als.id-3.net/api2/property/getrawdata?id=12233793"

        Dim propertyInfos = New RestClient(urlProperty)
        Dim request = New RestRequest(Method.[Get])
        Dim response As RestResponse = Execute(request)
        Console.WriteLine(response)
        
        'decerealize'
        'Mettre valeur dans une classe Merge'
        'Lancer funtion GetValueShotstack'


    End Function

    ' GET api/values/5
    Public Function GetValueShotstack(ByVal id As Integer) As String
        Dim idShotstack = "qDiyycLgsc8xI1kdKIGn84D4x4hyOIhk15qFtljm"
        Dim client = New RestClient("https://api.shotstack.io/stage/render/" & idShotstack & "?timeline=false")
        Dim request = New RestRequest(Method.[Get])
        request.AddHeader("x-api-key", "qDiyycLgsc8xI1kdKIGn84D4x4hyOIhk15qFtljm")
        Dim response As RestResponse = client.Execute(request)
        Console.WriteLine(response.Content)
        Return "Content"

    End Function

    ' POST api/values
    Public Sub PostValue(<FromBody()> ByVal value As String)

        Dim client = New RestClient("https://api.shotstack.io/stage/render")
        Dim request = New RestRequest(Method.Post)
        request.AddHeader("cache-control", "no-cache")
        request.AddHeader("content-type", "application/json")
        request.AddHeader("x-api-key", "qDiyycLgsc8xI1kdKIGn84D4x4hyOIhk15qFtljm")
        Dim response As RestResponse = client.Execute(request)
        Console.WriteLine(response)

        

    End Sub

    ' PUT api/values/5 passer un object avec une class 
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub


     Private Sub GetPropertyInfos()
        Dim client As New WebClient
        Dim data As String = client.DownloadString("https://api.lifx.com/v1/lights/all")

        Dim idProperty = "12233793"
        Dim urlProperty = "https://als.id-3.net/api2/property/getrawdata?id="
        Dim propertyInfos = New RestClient(urlProperty)

        Dim request = New RestRequest(Method.[Get])
        Dim response As RestResponse = Execute(request)
        Dim json as String = JsonConvert.SterializeObject(response)
        Console.WriteLine(response)

    End Sub






    'You can use the HttpWebRequest class to perform a request and retrieve a response from a given URL. You'll use it like:
    Try
        Dim fr As System.Net.HttpWebRequest
        Dim targetURI As New Uri("https://als.id-3.net/api2/property/getrawdata?id=")         

        fr = DirectCast(HttpWebRequest.Create(targetURI), System.Net.HttpWebRequest)
        If (fr.GetResponse().ContentLength > 0) Then
            Dim str As New System.IO.StreamReader(fr.GetResponse().GetResponseStream())
            Response.Write(str.ReadToEnd())
            str.Close(); 
        End If   
            Catch ex As System.Net.WebException
    'Error in accessing the resource, handle it
    End Try

    'HttpWebRequest is detailed at: http://msdn.microsoft.com/en-us/library/system.net.httpwebrequest.aspx'
    'A second option is to use the WebClient class, this provides an easier to use interface for downloading web resources but is not as flexible as HttpWebRequest:'

    Sub Main()
    'Address of URL
    Dim URL As String = "https://als.id-3.net/api2/property/getrawdata?id="
    ' Get HTML data
    Dim client As WebClient = New WebClient()
    Dim data As Stream = client.OpenRead(URL)
    Dim reader As StreamReader = New StreamReader(data)
    Dim str As String = ""
    str = reader.ReadLine()
    Do While str.Length > 0
        Console.WriteLine(str)
        str = reader.ReadLine()
    Loop
End Sub
'More info on the webclient can be found at: http://msdn.microsoft.com/en-us/library/system.net.webclient.aspx'

End Class
