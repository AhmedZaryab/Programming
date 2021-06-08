Module module1
    Sub Main()
        Dim myTree1 As Tree = New Tree()
        Dim myTree2 As Tree = New Tree(5.8, 12.2, Tree.Colours.Red)
        Dim myfruittree As FruitTree = New FruitTree()
        Dim choice As Integer
        Dim review As String
        Dim wood As Integer = 0
        Dim numtree As Integer




        Console.WriteLine("What would you like to do?")
        Console.WriteLine("[1]-Add new tree")
        Console.WriteLine("[2]-Read existing file attributes")
        Console.WriteLine("[3]-Chop tree")
        choice = Console.ReadLine
        Console.Clear()

        If choice = 1 Then
            Console.WriteLine("[1]-Add new tree")
            Console.WriteLine("Enter the height of the tree(In meters)")
            myTree1.SetTrunkH(Console.ReadLine())

            Console.WriteLine("Enter the circumference of the tree(In meters)")
            myTree1.SetTrunkC(Console.ReadLine())

            Console.WriteLine("Enter the colour of the tree")
            myTree1.SetTrunkcolour(Console.ReadLine())

            Console.WriteLine("Enter the number of the tree roots")
            myTree1.Setnumroots(Console.ReadLine())

            Console.WriteLine("Enter the number of the tree branches")
            myTree1.Setnumbranches(Console.ReadLine())

            Console.WriteLine("Enter the number of the tree leaves")
            myTree1.Setnumleaves(Console.ReadLine())

            Console.WriteLine("New tree has been successfully updated")
            Console.WriteLine("Would you like to review the entry?")
            review = Console.ReadLine
            If review = "yes" Then
                Console.WriteLine(myTree1)
            End If
            Console.ReadLine()
        End If

        If choice = 2 Then
            Console.WriteLine("[2]-Read existing file attributes")
            Console.WriteLine("Which tree attributes would you like?")
            numtree = Console.ReadLine()
            Select Case numtree
                Case = 1
                    Console.WriteLine(myTree1)
                Case = 2
                    Console.WriteLine(myTree2)
            End Select

            Console.ReadLine()

        End If

        If choice = 3 Then
            Console.WriteLine("[3]-Chop tree")
            Console.WriteLine("Which tree would you like to chop")
            numtree = Console.ReadLine
            Select Case numtree
                Case = 1

                    myTree1.chop()
                    Console.WriteLine(myTree1)
                Case = 2
                    myTree2.chop()

                    Console.WriteLine(myTree2)
            End Select
            Console.ReadLine()


        End If


        If choice = 1 Then
            Console.WriteLine("[1]-Input fruit size:")

            myfruittree.fruitname(Console.ReadLine())

            Console.WriteLine("Enter the circumference of the tree(In meters)")
            myTree1.SetTrunkC(Console.ReadLine())

            Console.WriteLine("Enter the colour of the tree")
            myTree1.SetTrunkcolour(Console.ReadLine())

            Console.WriteLine("Enter the number of the tree roots")
            myTree1.Setnumroots(Console.ReadLine())

            Console.WriteLine("Enter the number of the tree branches")
            myTree1.Setnumbranches(Console.ReadLine())

            Console.WriteLine("Enter the number of the tree leaves")
            myTree1.Setnumleaves(Console.ReadLine())

            Console.WriteLine("New tree has been successfully updated")
            Console.WriteLine("Would you like to review the entry?")
            review = Console.ReadLine
            If review = "yes" Then
                Console.WriteLine(myTree1)
            End If
            Console.ReadLine()
        End If

        If choice = 2 Then
            Console.WriteLine("[2]-Read existing file attributes")
            Console.WriteLine("Which tree attributes would you like?")
            numtree = Console.ReadLine()
            Select Case numtree
                Case = 1
                    Console.WriteLine(myTree1)
                Case = 2
                    Console.WriteLine(myTree2)
            End Select

            Console.ReadLine()

        End If

        '    Console.WriteLine(myTree1)



        '    wood = myTree2.chop


        '    Console.WriteLine(myTree2)

        '    Console.WriteLine("I now have: " & wood & " Wood")
        '    Console.WriteLine("The height of Tree 2 is: " & myTree2.GetTrunkH())

        '    Console.WriteLine("The circ of Tree 1 is: " & myTree1.GetTrunkC())
        '    Console.WriteLine("The colour of Tree 1 is: " & myTree1.GetTrunkColour())

        '    myTree1.SetTrunkH(-8)
        '    Console.WriteLine("The height of Tree 1 is: " & myTree1.GetTrunkH())

        '    Console.ReadLine()
    End Sub
    '    Encapsulation: The process Of combining attributes And methods into an
    '                   object
    '                   It hides the attributes except through the defined
    '                   methods

    '   Change the height of myTree1


End Module
