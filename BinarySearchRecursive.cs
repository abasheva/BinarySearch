using System;

namespace BinarySearch
{
    class BinarySearchRecursive
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int searchedNumber = int.Parse(Console.ReadLine());
            int indexSearchedNumber = BinarySearchRec(arr, searchedNumber, 0, size - 1);

            Console.WriteLine(indexSearchedNumber);
        }

        static int BinarySearchRec(int[] arr, int serchedNumber, int leftIndex, int rightIndex)
        {
            if(leftIndex <= rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;

                if (arr[middleIndex] == serchedNumber)
                    return middleIndex;
                else if (arr[middleIndex] < serchedNumber)
                    return BinarySearchRec(arr, serchedNumber, middleIndex + 1, rightIndex);
                else
                    return BinarySearchRec(arr, serchedNumber, leftIndex, middleIndex - 1);
            }

            return -1;
        }
    }
}
