Module Module1

    ' Title: tryOOP

    ' Author: Z Kadri

    ' Date: 30/09/2020

    ' Version: 0.1

    ' Description: A number with attributes

    Sub Main()

        ' Declare and generate seven integer values and store them in an array

        Dim numArr(7) As Integer


        For counter = 1 To 7
            Console.WriteLine("Input the value of number " & counter & ":")
            numArr(counter) = Console.ReadLine()
        Next




        ' Output all values, from position 1 - 7





        ' Swap the contents of the array values so that the smaller value comes first
        For counter = 1 To 6

            If numArr(counter) > numArr(counter + 1) Then

                numArr(0) = numArr(counter) ' Storing num1 into the temp location

                numArr(counter) = numArr(counter + 1) ' Overwriting num1 with num2

                numArr(counter + 1) = numArr(0) ' Overwriting num2 with the value in temp

            End If
        Next
        ' Output these new values from position 1 to 7

        For x = 1 To 7
            Console.WriteLine("The value of variable&" & x & " is: " & numArr(x))
        Next x



        Console.ReadLine()

    End Sub



End Module
