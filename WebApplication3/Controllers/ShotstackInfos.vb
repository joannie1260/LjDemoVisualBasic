Public Class ShotstackInfos

    Private Sub PostCall()

        Dim client = New RestClient("https://api.shotstack.io/stage/render")
        Dim request = New RestRequest(Method.Post)
        request.AddHeader("cache-control", "no-cache")
        request.AddHeader("content-type", "application/json")
        request.AddHeader("x-api-key", "qDiyycLgsc8xI1kdKIGn84D4x4hyOIhk15qFtljm")
        Dim response As RestResponse = client.Execute(request)
        Console.WriteLine(response)

    End Sub
    Private Sub GetRender()
        Dim idShotstack = "qDiyycLgsc8xI1kdKIGn84D4x4hyOIhk15qFtljm"
        Dim client = New RestClient("https://api.shotstack.io/stage/render/" & idShotstack & "?timeline=false")
        Dim request = New RestRequest(Method.[Get])
        request.AddHeader("x-api-key", "qDiyycLgsc8xI1kdKIGn84D4x4hyOIhk15qFtljm")
        Dim response As RestResponse = client.Execute(request)
        Console.WriteLine(response.Content)

    End Sub


End Class
