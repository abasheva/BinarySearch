using System;

namespace BinarySearch
{
    class BinarySearchIterative
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int searchedNumber = int.Parse(Console.ReadLine());
            int indexSearchedNumber = BinarySearch(arr, searchedNumber);

            Console.WriteLine(indexSearchedNumber);
        }

        static int BinarySearch(int[] arr, int searchNumber)
        {
            int leftIndex = 0;
            int rightIndex = arr.Length - 1;

            while (leftIndex <= rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;

                if (arr[middleIndex] == searchNumber)
                    return middleIndex;
                else if (arr[middleIndex] < searchNumber)
                    leftIndex = middleIndex + 1;
                else
                    rightIndex = middleIndex - 1;

            }

            return -1;
        }
    }
}