Public Class FruitTree
    Inherits Tree
    ' attributes
    Private Fruit1() As fruit '(100)
    Private fruitname As String
    Private fruitsize As String
    Private fruitweight As Double
    Private fruittaste As String



    Public Function Getfruitname() As String



        Dim name As String = ""
        name = fruitname
        Select Case fruitname
            Case 0
                fruitname = "bannana"
            Case 1
                fruitname = "strawberry"



        End Select
        fruitname = "the fruitname is " & fruitname



        Return fruitname
    End Function
    Public Function Getfruitsize() As String
        Return fruitsize
    End Function
    Public Function Getfruitweight() As Double
        Return fruitweight
    End Function
    Public Function Getfrutitaste() As String
        Return fruittaste
    End Function



    Public Enum fruitnames
        bannana
        strawberry
    End Enum



    ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' '' ' ' '  '' ' ' ' ' '
    Public Class fruit
        Private fruitname As String
        Private fruitsize As String
        Private fruitweight As Double
        Private fruittaste As String



        Private Function GetFruitName() As fruitnames
            Return fruitname
        End Function
        Public Function Getfruitsize() As String
            Return fruitsize
        End Function
        Public Function Getfruitweight() As Double
            Return fruitweight
        End Function
        Public Function Getfrutitaste() As String
            Return fruittaste
        End Function
        Public Enum fruitnames
            bannana
            strawberry
        End Enum
        Public Sub SetFruitName(newFruitName As fruitnames)
            fruitname = newFruitName
        End Sub
        Public Sub SetfruitSize(newSize As Double)
            If newSize >= 0 And newSize <= 100 Then
                fruitsize = newSize
            End If
        End Sub
        Public Sub SetfruitWeight(newWeight As Double)
            If newWeight >= 0 And newWeight <= 100 Then
                fruitweight = newWeight
            End If
        End Sub
        Public Sub Setfruittaste(newTaste As String)
            fruittaste = newTaste
        End Sub
        Public Overrides Function ToString() As String
            Dim str As String = ""
            str = "The name of the Fruit is: " & fruitname & vbCrLf
            str = str & "The Size of the Fruit: " & fruitsize & vbCrLf
            str = str & "The Weight of the Fruit is: " & fruitweight & vbCrLf
            str = str & fruittaste & vbCrLf
            str = str & vbCrLf & "******"
            Return str
        End Function
    End Class





End Class