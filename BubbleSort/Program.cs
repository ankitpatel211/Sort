using System;

namespace BubbleSort
{
    class Program
    {
        static int[] BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int j = 0; j < n; j++) {
                for (int i = 0; i < n - 1; i++) {
                    int left = i;
                    int right = i + 1;
                    if (array[left] > array[right]) {
                        int temp = array[left];
                        array[left] = array[right];
                        array[right] = temp;
                    }
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] array = { 4, 2, 7, 1 };
            Console.Write("Unsorted Elements: ");
            foreach (int element in array) {
                Console.Write(element + " ");
            }
            int[] sortArray = BubbleSort(array);
            Console.Write("\nSorted Elements: ");
            foreach (int element in sortArray) {
                Console.Write(element + " ");
            }
        }
    }
}
