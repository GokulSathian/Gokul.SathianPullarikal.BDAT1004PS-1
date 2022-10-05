using System;
public class Seperate_EvenOdd
{
    public static void Main()
    {
        int[] user_input = new int[10];
        int[] even_num = new int[10];
        int[] odd_num = new int[10];
        int i, x;
        int j=0,k=0;
        Console.WriteLine("Input the number of elements to be stored in the array:");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input {0} elements in the array:", x);
        for (i = 0; i < x; i++)
        {
            Console.WriteLine("element - {0} : ", i);
            user_input[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (i in user_input)
        {
            if (i % 2 == 0)
            {
                even_num[j] = i;
                j++;
            }
            else
            {
                odd_num[k] = i;
                k++;
            }
        }

        Console.WriteLine("The Even elements are :");
        for (i = 0; i < j; i++)
        {
            Console.Write("{0} ", even_num[i]);
        }

        Console.WriteLine("The Odd elements are :");
        for (i = 0; i < k; i++)
        {
            Console.Write("{0} ", odd_num[i]);
        }
    }
}