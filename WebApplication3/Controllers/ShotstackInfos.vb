Imports Microsoft.VisualBasic

Public Class ShotstackInfos
    Public Class Asset
        Public Property type As String
        Public Property html As String
        Public Property css As String
        Public Property width As Integer
        Public Property height As Integer
        Public Property position As String
        Public Property src As String
    End Class

    Public Class Offset
        Public Property x As Double
        Public Property y As Double
    End Class

    Public Class Transition
        Public Property [in] As String
        Public Property out As String
    End Class

    Public Class Clip
        Public Property asset As Asset
        Public Property start As Double
        Public Property length As Double
        Public Property position As String
        Public Property offset As Offset
        Public Property transition As Transition
        Public Property fit As String
        Public Property scale As Double?
        Public Property effect As String
    End Class

    Public Class Track
        Public Property clips As Clip()
    End Class

    Public Class Font
        Public Property src As String
    End Class

    Public Class Soundtrack
        Public Property src As String
        Public Property effect As String
    End Class

    Public Class Timeline
        Public Property tracks As Track()
        Public Property fonts As Font()
        Public Property soundtrack As Soundtrack
    End Class

    Public Class Output
        Public Property format As String
        Public Property resolution As String
    End Class

    Public Class ShotstackInfos
        Public Property timeline As Timeline
        Public Property output As Output
    End Class


End Class
