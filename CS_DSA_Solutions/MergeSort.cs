using System;

class MergeSort
{
    public static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            Sort(arr, left, mid);
            Sort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    private static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = arr[mid + 1 + j];

        int x = 0, y = 0, k = left;
        while (x < n1 && y < n2)
        {
            if (leftArray[x] <= rightArray[y])
                arr[k++] = leftArray[x++];
            else
                arr[k++] = rightArray[y++];
        }

        while (x < n1)
            arr[k++] = leftArray[x++];
        while (y < n2)
            arr[k++] = rightArray[y++];
    }
}
