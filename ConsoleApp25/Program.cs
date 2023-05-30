

1 - Write a program with java to reverse an
array?

int[] intArray = { 1, 2, 3, 4, 5};
int intArrayLegth = intArray.length;
int[] reversedArray = new int[intArrayLegth];
for (int i = intArrayLegth - 1, j = 0; i >= 0; i--, j++)
{
    reversedArray[j] = intArray[i];
}

System.out.println("Original Array");
for (int i: intArray)
    System.out.print(i + ",");

System.out.println("");

System.out.println("Reversed Array");


for (int i = reversedArray)
    System.out.print(i + ",");
---------------------------------------

2 - Write a program with java to sum and
average of an array?

public static void main(String[] args)
{
    int sum = 0;
    float avr;
}
int[] intArray
=
{13, 2, 88, 4, 5};
for (int i = 0; i < intArray.length; i++)
{
    sum = sum + intArray[i];
}
avr = (float)sum / intArray.length;
System.out.println(avr);
}
--------------------------------------------------
3 - Write a program with java to sort string
array?

import java.util.Scanner;
import java.lang.Math;
import java.util.Arrays;
public class Java Application1
{

    public static void main(String[] args)
    {
        String[] strArray =
        { "roB", "century",
};
        "Browser", "ak56",
"Raphael", "Aztec", "Playhouse", "Zintec",
"200", "Accenture",
"Yokohama", "xBox",
"nIntendo", "PlayStation",
"CAke", "boB"
     Arrays.sort(strArray);

        System.out.println(Arrays.toString(strArray));
    }
    --------------------------------------------------
    4 - Write a program in java to
copy a source array into a destination array?

package javaappiicativ,
import java.util.Scanner;
    import java.lang.Math;
    import java.util.Arrays;
public class JavaApplication1
{

    public static void main(String[] args)
    {
        char[] copyFrom = { 'd', 'e', 'c', 'a', 'f', 'f', 'e' 'i', 'n', 'a', 't', 'e', 'd' };

        char[] copyTo = new char[7];

        System.arraycopy(copyFrom, 2, copyTo, 0, 7);
        System.out.println(String.valueOf(copyTo));
    }
--------------------------------------------------------
5- Write a Java program to print the
following grid?
000000000000
00000000000
0000000000
0000000000
000000000

public class JavaApplication1
    {
        public static void main(String[] args)
        {
            int[][] a = new int[10][10]; for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    System.out.print(a[i][j]);
                }
            System.out.println();
        }
-----------------------------------------------
6- Write a Java program to test if an array
contains a specific value?

public class JavaApplication1
        {

            public static void main(String[] args)
            {
                System.out.print("enter the value?");
                Scanner ob new Scanner(System.in);
                int item-ob.nextInt();
                int[] my_arrayl = {

1789, 2035, 1899, 1456, 2013,
 1458, 2458, 1254, 1472, 2365,
1456, 2265, 1457, 2456};
                for (int n my_arrayl)
                {
                    if (item == n)
                    {
                        System.out.println("true");
                    }
                }
                ------------------------------------------
                7 - Write a Java program to add two matrices of
            the same size ?
            
public static void main(String[] args)
                {
                    int m, n, c, d;
                    Scanner in = new Scanner(System.in);
                    System.out.println("Input number of rows of matrix");
                    m = in.nextInt();
                    System.out.println("Input number of columns of matrix");
                    n = in.nextInt();

                    int array1[][] = new int[m][n];
                    int array2[][] = new int[m][n];
                    int sum[][] = new int[m][n];
                    System.out.println("Input elements of first matrix");
                    for (c = 0; c < m; c++)
                        for (d = 0; d < n; d++)
                            array1[c][d] = in.nextInt();
                    System.out.println("Input the elements of second matrix");
                    for (c = 0; c < m; c++)
                        for (d = 0; d < n; d++)
                            array2[c][d] = in.nextInt();
                    for (c = 0; c < m; c++)
                        for (d = 0; d < n; d++)
                            sum[c][d] = array1[c][d] + array2[c][d];
                    System.out.println("Sum of the matrices:-");
                    for (c = 0; c < m; c++)
                    {
                        for (d = 0; d < n; d++)
                            System.out.print(sum[c][d] + "\t");
                        System.out.println();
                    }
                }
                -----------------------------
                8 - Write a Java program to test the equality of
            two arrays?

public static void main(String[] args)
                {
                    int[] array1 = (2, 5, 7, 9, 11};
                int[] array2 = (2, 5, 7, 8, 11};
            boolean equalorNot = true;
if (array1.length == array2.length)
{
for (int i = 0; i<array1.length; i++)
{
if (array1[i] = array2[i])
{
equalOrNot = false;
  }
    }
}
else
{
    equalOrNot = false;
}
if (equalorNot)
{
    System.out.println("Two arrays are equal.");
}
else
    System.out.println("Two arrays are not equal.");
}
}