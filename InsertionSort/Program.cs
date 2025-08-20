using System;

namespace InsertionSort
{
    // See https://aka.ms/new-console-template for more information

    class Program
    {
        static int[] InsertionSort(int[] unsortedElements)
        {
            for (int i = 0; i < unsortedElements.Length; i++)
            {
                int j = i;
                while (j > 0 && unsortedElements[j] < unsortedElements[j - 1])
                {
                    int temp = unsortedElements[j];
                    unsortedElements[j] = unsortedElements[j - 1];
                    unsortedElements[j - 1] = temp;
                    j--;
                }
            }
            return unsortedElements;
        }
        static void Main(string[] args)
        {
            int[] unsortedElements = { 5, 12, 3, 8, 1, 19, 7, 14, 
                2, 10, 16, 4, 11, 6, 18, 9, 13, 17, 0, 15 };
            Console.Write("Unsorted Elements: ");
            foreach (int element in unsortedElements) {
                Console.Write(element + " ");
            }
            int[] sortedArray = InsertionSort(unsortedElements);
            Console.Write("\nSorted Elements: ");
            foreach (int element in sortedArray) {
                Console.Write(element + " ");
            }
        }
    }

}
