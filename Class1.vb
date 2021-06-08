Public Class Tree
    '   Attributes
    '   All attributes MUST be PRIVATE
    '   Private means it is only accessible inside
    '   this class - Make it PUBLIC ONLY if you have a VERY good reason
    Private trunkH As Double
    Private trunkC As Double
    Private trunkColour As Colours
    Private numRoots As Integer
    Private numBranches As Integer
    Private numLeaves As Integer


    '   more usefull methods
    '   method to chop a tree

    Public Function chop() As Integer
        Dim wood As Integer = 0
        wood = numBranches / 2
        wood = wood + (trunkC * trunkH)

        numBranches = 0
        trunkH = 0
        trunkC = 0
        numRoots = 0
        trunkColour = Colours.none
        numLeaves = 0


        Return wood
    End Function


    '   Constructor
    ''   The constructors MUST be PUBLIC
    Public Sub New()
        trunkH = 2
        trunkC = 3
        trunkColour = Colours.Pink
        numRoots = 5
        numBranches = 100
        numLeaves = 1234
    End Sub

    '   A different constructor, that takes in values
    '   We will define parameters in the brackets
    Public Sub New(trunkH As Double, trunkC As Double, trunkColour As Colours)
        Me.trunkH = trunkH
        Me.trunkC = trunkC
        Me.trunkColour = trunkColour
        numRoots = 10
        numBranches = 200
        numLeaves = 1000
    End Sub

    '   Define the Getters and Setters for our attributes
    '   These are methods that grant access to the attribute
    '   Getters retrieve the value of the attribute
    '   Setters set the value of the attribute
    '   Since we are granting external access, these need to be PUBLIC

    '   Getters - these are functions because they will return a value
    Public Function GetTrunkH() As Double
        Return trunkH
    End Function
    Public Function GetTrunkC() As Double
        Return trunkC
    End Function
    Public Function GetTrunkColour() As String
        Dim str As String = ""
        Select Case trunkColour
            Case = 0
                str = "Brown"
            Case = 1
                str = "Green"
            Case = 2
                str = "White"
            Case = 3
                str = "Black"
            Case = 4
                str = "Pink"
            Case = 5
                str = "Red"

        End Select

        Return str
    End Function
    Public Function GetNumRoots() As Integer
        Return numRoots
    End Function
    Public Function GetNumBranches() As Integer
        Return numBranches
    End Function
    Public Function GetNumLeaves() As Integer
        Return numLeaves
    End Function


    '   Settersw
    Public Sub SetTrunkH(newTrunkH As Double)
        If newTrunkH >= 0 Then
            trunkH = newTrunkH
        End If
    End Sub
    Public Sub SetTrunkC(newTrunkC As Double)
        If newTrunkC >= 0 Then
            trunkC = newTrunkC
        End If
    End Sub
    Public Sub SetTrunkcolour(newTrunkcolour As Colours)
        trunkColour = newTrunkcolour
    End Sub
    Public Sub Setnumroots(newnumroots As String)
        If newnumroots >= 0 Then
            numRoots = newnumroots
        End If
    End Sub
    Public Sub Setnumbranches(newnumbranches As String)
        If newnumbranches >= 0 Then
            numBranches = newnumbranches
        End If
    End Sub
    Public Sub Setnumleaves(newnumleaves As String)
        If newnumleaves >= 0 Then
            numLeaves = newnumleaves
        End If
    End Sub

    Public Enum Colours
        Brown
        Green
        White
        Black
        Pink
        Red
        none
    End Enum
    Public Overrides Function Tostring() As String
        Dim str As String = ""
        str = "Trunk height: " & trunkH & vbCrLf
        str = str & "Trunk circuference: " & trunkC & vbCrLf
        str = str & "Trunk colour: " & GetTrunkColour() & vbCrLf
        str = str & "Trunk number of Roots: " & GetNumRoots() & vbCrLf
        str = str & "Trunk number of branches " & GetNumBranches() & vbCrLf
        str = str & "Trunk number of leaves" & GetNumLeaves() & vbCrLf


        Return str
    End Function

End Class
