Public Class PropertyInfos

    Dim id As Integer
    Dim region As String
    Dim bath As String
    Dim bed As String
    Dim genre As String
    Dim picUrl1 As String
    Dim picUrl2 As String
    Dim picUrl3 As String
    Dim picUrl4 As String
    Dim picUrl5 As String
    Dim picUrl6 As String

    'decerialise
    Private Sub GetPropertyInfos()
        Dim idProperty = "12233793"
        Dim urlProperty = "https://als.id-3.net/api2/property/getrawdata?id="
        Dim propertyInfos = New RestClient(urlProperty)
        Dim request = New RestRequest(Method.[Get])
        Dim response As RestResponse = Execute(request)
        Console.WriteLine(response)

    End Sub


End Class
