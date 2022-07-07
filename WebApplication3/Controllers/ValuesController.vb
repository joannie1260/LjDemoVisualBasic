Imports System.Net
Imports System.Web.http
Imports System.Data
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Collections.Generic

Public Class ValuesController

    Public Class Merges
    
        Public Property Find As String
        Public Property Replace As String

    End Class

    ' GET apiShotstack/values
    Public Function GetPropertyInfos() As IEnumerable(Of String)

        Dim wc As New WebClient()
        Dim json As String = wc.DownloadString("https://als.id-3.net/api2/property/getrawdata?id=12233793")
        Dim propertyObject = JsonConvert.DeserializeObject(Of Listings)(json)

        Dim shotStackJson As String = Me.GetShotStackJson()

        Dim propInfos As Reflection.PropertyInfo() = GetType(Listings).GetProperties
        propInfos = propInfos.Where(Function(p) shotStackJson.Contains(String.Concat("{{", p.Name, "}}"))).ToArray

        For Each prop As Reflection.PropertyInfo In propInfos
            ' Remplace {{Genre}} par la valeur de propertyObject.Genre
            shotStackJson = shotStackJson.Replace(String.Concat("{{", prop.Name, "}}"),
                                                  prop.GetValue(propertyObject))
        Next

        'boucle sur certaines valeur pour mettre dans la classe Merges
        'Dim merge1 As Merges = New Merges(propertyObject.Genre)
        'Dim merge2 As Merges = New Merges(propertyObject.Region)

        'Merge les valeurs'
        'merge1.Merge(Merge2)

        'retourne le fichier merger 
        'MergeJson(merge1)

    End Function

    Private Function GetShotStackJson() As String
        Return ""
    End Function

    'Merge des Json
    Public function MergeJson() As IEnumerable(Of String)

        'Prendre json template dans le dossier
        'Dim templateMerge As String = File.ReadAllText(Path.Combine(chemindufichier, fileName))

        ''Merger les jsons
        'Dim FinalMerge As String = JsonHelper.ToClass(Of Example)(rawJson)
        'PostGetId(FinalMerge)

    End function


    ' POST apiShotstack/values
    Public Sub PostGetId(<FromBody()> ByVal value As String)



        Dim wc As New WebClient()
        'j'envoi les infos header avant mon post value
        wc.Headers.Add("cache-control", "no-cache")
        wc.Headers.Add("content-type", "application/json")
        wc.Headers.Add("x-api-key", "qDiyycLgsc8xI1kdKIGn84D4x4hyOIhk15qFtljm")
        Dim postValue As String = wc.UploadString("https://api.shotstack.io/stage/render", "")

        Console.WriteLine(postValue)

        'Dim jsPostValue As String = JsonConvert.SterializeObject(postValue)
        'Dim idShotstack As String = jsPostValue.response.id

        'GetValueShotstack(idShotstack)

    End Sub

    
    ' GET renderShotstack/id
    Public Function GetValueShotstack(ByVal id As Integer) As String

        Dim wc As New WebClient()
        wc.Headers.Add("x-api-key", "qDiyycLgsc8xI1kdKIGn84D4x4hyOIhk15qFtljm")
        Dim getRenderUrl As String = wc.DownloadString("https://api.shotstack.io/stage/render/" & idShotstack)
        'Dim json As String = JsonConvert.SterializeObject(getRenderUrl)

        'prendre la valeur, data.reponse.url
        'Dim urlShotstack As String = getRenderUrl.reponse.url

    End Function

    

End Class


