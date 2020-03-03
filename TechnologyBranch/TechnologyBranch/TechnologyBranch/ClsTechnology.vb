Public Class ClsTechnology
    Inherits ClsStudent
#Region "Constructer"
    Public Sub New(_id As Integer, _name As String, _birthDate As Date, tempArray1() As Integer, tempArray2() As Integer)
        MyBase.New(_id, _name, _birthDate)
        mcMarks = tempArray1
        mbMarks = tempArray2
    End Sub
#End Region
#Region "Attributes"
    Private sum1 As Integer = 0
    Private sum2 As Integer = 0
    Private avg1 As Double = 0.0
    Private avg2 As Double = 0.0
    Private mcCourse As String() = {"البرمجة والأتمتة", "الرياضيات", "اللغة العربية", "اللغة الانجليزية"}  ' mcCourse : Ministry Compulsary Course
    Private mbCourse As String() = {"الاتصالات والالكترونيات", "التربية الدينية", "الثقافة العلمية", "الادارة والريادة"}  ' mbCourse : Ministry Basic Course
    Private mcMarks() As Integer
    Private mbMarks() As Integer
#End Region

#Region "Properties"
    Public Property _sum1 As Integer
        Get
            Return sum1
        End Get
        Set(value As Integer)
            sum1 = value
        End Set
    End Property

    Public Property _sum2 As Integer
        Get
            Return sum2
        End Get
        Set(value As Integer)
            sum2 = value
        End Set
    End Property

    Public Property _avg1 As Double
        Get
            Return avg1
        End Get
        Set(value As Double)
            avg1 = value
        End Set
    End Property

    Public Property _avg2 As Double
        Get
            Return avg2
        End Get
        Set(value As Double)
            avg2 = value
        End Set
    End Property

    Public Property _mcCourse As String()
        Get
            Return mcCourse
        End Get
        Set(value As String())
            mcCourse = value
        End Set
    End Property

    Public Property _mbCourse As String()
        Get
            Return mbCourse
        End Get
        Set(value As String())
            mbCourse = value
        End Set
    End Property

    Public Property _mcMark As Integer()
        Get
            Return mcMarks
        End Get
        Set(value As Integer())
            mcMarks = value
        End Set
    End Property

    Public Property _mbMark As Integer()
        Get
            Return mbMarks
        End Get
        Set(value As Integer())
            mbMarks = value
        End Set
    End Property
#End Region

#Region "Methods"
    Public Sub averageCompulsary()
        Dim count1 As Integer = 0
        If mcMarks(0) >= 100 Then
            count1 += 1
            sum1 += mcMarks(0)
        End If
        For i = 1 To (mcMarks.Length - 1)
            If mcMarks(i) >= 50 Then
                count1 += 1
                sum1 += mcMarks(i)
            End If
        Next
        If count1 = 4 Then
            avg1 = sum1 / 5.0
        End If
    End Sub
    Public Sub averageBasic()
        Dim count2 As Integer = 0
        Dim highestMark As Integer = 0

        For i = 0 To (mcMarks.Length - 1)
            If mbMarks(i) >= 50 Then
                count2 += 1
            End If
        Next
        If count2 = 4 Then
            highestMark = max(mbMarks(1), mbMarks(2), mbMarks(3))
            sum2 = mbMarks(0) + highestMark
            avg2 = sum2 / 2.0
        Else
            sum2 = -99.0
            avg2 = -99.0
        End If
    End Sub

    Public Overrides Sub caculate_average()
        If avg1 <> -99 And avg2 <> -99 Then
            avg = (sum1 + sum2) / 7
        Else
            avg = -99
        End If
    End Sub

#End Region
    Public Function max(mark1 As Integer, mark2 As Integer, mark3 As Integer) As Integer
        If mark1 >= mark2 And mark1 >= mark3 Then
            Return mark1
        ElseIf mark2 >= mark1 And mark2 >= mark3 Then
            Return mark2
        Else
            Return mark3
        End If

    End Function
End Class
