using System;
using System.Text;
class IsoscelesTriangle
{
    static void Main()
    {
        //09.Write a program that prints an isosceles triangle of 9 copyright symbols ©. 
        //Use Windows Character Map to find the Unicode code of the © symbol.
        //Note: the © symbol may be displayed incorrectly.
        //The algorithm description of the code can be found on:
        //http://forums.academy.telerik.com/24922/%D1%81%D1%82%D0%B0%D1%80-%D0%BF%D0%BE%D0%B4%D1%85%D0%BE%D0%B4-%D0%B7%D0%B0-%D1%80%D0%B5%D1%88%D0%B0%D0%B2%D0%B0%D0%BD%D0%B5-%D0%BD%D0%B0-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B0
        
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Enter a positive integer number [3-99]!\nHow many symbols would like to use : ");
        int symbolNumber;
        // Handling exceptions, which can occur when the user enter a different type number
        if (!int.TryParse(Console.ReadLine(), out symbolNumber))
        {
            Console.WriteLine("Invalid Number");
            Main();
        }
        else
        {
            int enteredNumber = symbolNumber;
            int bonusSymbol = 0;
            int rowCounter = 0;
            int averageColumn = 0;
            int maxRows = 0;
            int maxColumns = 0;
            string emptySymbol = " ";
            string copyRight = "©";
            // Is the user number in the range ?
            if ((symbolNumber >= 3)&(symbolNumber<=99))
            {
                // Is the number multiple of three?
                while ((symbolNumber % 3) != 0)
                {
                    symbolNumber--;
                    bonusSymbol++;
                }
                maxRows = (symbolNumber / 3) + 1;
                averageColumn = symbolNumber / 3;
                maxColumns = ((symbolNumber / 3) * 2) + 1;
                string[,] matrix = new string[maxRows, maxColumns];
                // Assigning values to the first row of the matrix
                for (int count = 0; count < maxColumns; count++)
                {
                    matrix[rowCounter, count] = emptySymbol;
                }
                matrix[rowCounter, averageColumn] = copyRight;
                rowCounter = rowCounter + 1;
                symbolNumber = symbolNumber - 1;
                // Assigning values to the "middle" rows of the matrix
                while (rowCounter < maxRows)
                {
                    for (int count = 0; count < maxColumns; count++)
                    {
                        matrix[rowCounter, count] = emptySymbol;
                    }
                    matrix[rowCounter, (averageColumn - rowCounter)] = copyRight;
                    matrix[rowCounter, (averageColumn + rowCounter)] = copyRight;
                    symbolNumber = symbolNumber - 2;
                    rowCounter = rowCounter + 1;
                }
                // Assigning values to the last row of the matrix
                for (int count = 0; count < maxColumns; count++)
                {
                    if ((count % 2) == 0)
                    {
                        matrix[rowCounter - 1, count] = copyRight;
                    }
                    else
                    {
                        matrix[rowCounter - 1, count] = emptySymbol;
                    }
                }
                // Assigning values to elements inside the triangle, if needed!
                if (bonusSymbol != 0)
                {
                    //catching the only the two exceptions which can appear, if the size of the triangle is too small!
                    //enteredNumber = 5 and enteredNumber = 8.
                    if (((maxRows == 2) && (enteredNumber == 5)) || ((maxRows == 3) && (enteredNumber == 8)))
                    {
                        matrix[1, averageColumn] = copyRight;
                        bonusSymbol = 0;
                        Console.WriteLine("There is no space inside the triangle to draw the last symbol!");
                    }
                    else
                    {
                        matrix[bonusSymbol, averageColumn] = copyRight;
                        bonusSymbol--;
                        matrix[bonusSymbol, averageColumn] = copyRight;
                    }
                }
                //Print the matrix
                for (int countX = 0; countX < maxRows; countX++)
                {
                    for (int countY = 0; countY < maxColumns; countY++)
                    {
                        Console.Write(matrix[countX, countY]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
                Main();
            }
        }
    }
}
