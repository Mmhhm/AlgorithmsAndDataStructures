using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class SortingAlgtms
    {
        // TODO selection sort
        // TODO insertion sort
        // TODO merge sort
        // TODO finish bubble sort
        static int[] BubbleSort(int[] arr, int num)
        {
            int temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
                // Unfinished
            }
        }
}
