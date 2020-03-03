Public Class ClsStudent
#Region "Constucters"
    Public Sub New()
        id = ""
        name = ""
        birthDate = ""
    End Sub
    Public Sub New(_id As Integer, _name As String, _birthDate As Date)
        id = _id
        name = _name
        birthDate = _birthDate
    End Sub

#End Region
#Region "Attributes"
    Public id As Integer
    Protected name As String
    Protected avg As Double
    Protected result As String
    Protected birthDate As Date
    Private allSubjectNames() As String = {"البرمجة والأتمتة", "الرياضيات", "اللغة العربية", "اللغة الانجليزية", "الاتصالات والالكترونيات", "التربية الدينية", "الثقافة العلمية", "الادارة والريادة"}
    Private schoolMarks(7) As Integer
#End Region
#Region "Properities"
    Public Property _id As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property
    Public Property _name As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
    Public Property _schoolMarks As Integer()
        Get
            Return schoolMarks
        End Get
        Set(value As Integer())
            schoolMarks = value
        End Set
    End Property
    Public ReadOnly Property _avg As Double
        Get
            Return avg
        End Get
    End Property
    Public ReadOnly Property _result As String
        Get
            Return result
        End Get
    End Property
    Public Property _birthDate As Date
        Get
            Return birthDate
        End Get
        Set(value As Date)
            birthDate = value
        End Set
    End Property
    Public Property _allSubjectName As String()
        Get
            Return allSubjectNames
        End Get
        Set(value As String())
            allSubjectNames = value
        End Set
    End Property
#End Region

#Region "Methods"
    Public Sub insertSubjectMark()
        For i = 0 To (allSubjectNames.Length - 1)
            schoolMarks(i) = InputBox("Enter the Mark of " + allSubjectNames(i))
        Next
    End Sub

    Public Overridable Sub caculate_average()
        Dim sum As Integer
        Dim count As Integer = 0
        If schoolMarks(0) >= 100 Then
            count += 1
        End If
        For i = 1 To (allSubjectNames.Length - 1)
            If schoolMarks(i) >= 50 Then
                count += 1
            End If
        Next
        If count = allSubjectNames.Length Then
            For i = 0 To (allSubjectNames.Length - 1)
                sum += schoolMarks(i)
            Next
            avg = sum / (allSubjectNames.Length + 1.0)
        Else
            avg = -99.0
        End If
    End Sub
    Public Overridable Sub caculate_result()
        If avg <> -99.0 Then
            result = "ناجح"
        Else
            result = "راسب"
        End If
    End Sub

#End Region
End Class
