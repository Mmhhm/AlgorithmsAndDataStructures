using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class SortingAlgtms
    {
        // TODO finish the selection sort
        // TODO insertion sort
        // TODO finish merge sort
        public static int[] SelectionSort(int[] arr)
        {
            int i, j, temp, indexMax = 0;
            for(i =0; i < arr.Length; i++)
            {
                for(j = 0; j < arr.Length - i -1; j++)
                {
                    if (arr[j] > arr[indexMax])
                    {
                        indexMax = j;
                    }
                }
                temp = arr[j];
                arr[j] = arr[indexMax];
                arr[indexMax] = temp;
            }
            return arr;
        }


        public static int[] BubbleSort(int[] arr)
        {
            int i, j, temp = arr[0];
            bool swapped;
            
            for (i = 0; i < arr.Length; i++)
            {
                swapped = false;
                for (j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false) break;
            }
            return arr;
        }

/*        public static int[] MergeSort(int[] arr, int left, int right)
        {
            if (right < left) { return arr; }

            int mid = left + (right - left) / 2;

            MergeSort(arr, mid, right);
            MergeSort(arr, left, mid);
        }*/
    }
}
