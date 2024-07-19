using System;
using System.Net.NetworkInformation;

class Selection
{
    static int[] SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int step = 0; step < n - 1; step++)
        {
            // Tìm chỉ số của phần tử nhỏ nhất trong phần chưa sắp xếp
            int minIdx = step;

            for (int i = step + 1; i < n; i++)
            {
                if (array[i] < array[minIdx])
                {
                    minIdx = i;
                }
            }

            // Hoán đổi phần tử nhỏ nhất với phần tử đầu tiên của phần chưa sắp xếp
            int temp = array[minIdx];
            array[minIdx] = array[step];
            array[step] = temp;
        }

        return array; // Trả về mảng đã sắp xếp
    }

     static int[] BubbleSort(int[] array)
    {
        int n = array.Length;

        for (int step = 0; step < n - 1; step++)
        {
            for (int i = 0; i < n - step - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    // Hoán đổi phần tử nếu cần
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
        }

        return array; // Trả về mảng đã sắp xếp
    }

     static int[] MergeSort(int[] arr)
    {
        // Hàm merge để gộp hai mảng đã sắp xếp
        int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                result[k++] = left[i++];
            }

            while (j < right.Length)
            {
                result[k++] = right[j++];
            }

            return result;
        }

        if (arr.Length <= 1)
        {
            return arr;
        }

        int mid = arr.Length / 2;
        int[] leftHalf = new int[mid];
        int[] rightHalf = new int[arr.Length - mid];

        Array.Copy(arr, 0, leftHalf, 0, mid);
        Array.Copy(arr, mid, rightHalf, 0, rightHalf.Length);

        leftHalf = MergeSort(leftHalf);
        rightHalf = MergeSort(rightHalf);

        return Merge(leftHalf, rightHalf);
    }


     static void InsertionSort(int[] arr)
    {
        for (int step = 1; step < arr.Length; step++)
        {
            int key = arr[step];
            int j = step - 1;

            // Di chuyển các phần tử của arr[0..step-1] mà lớn hơn key lên một vị trí so với vị trí hiện tại của chúng
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            // Đặt key vào vị trí đúng của nó
            arr[j + 1] = key;
        }
    }


    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
       
    }
    

}
