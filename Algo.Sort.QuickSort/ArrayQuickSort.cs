namespace Algo.Sort.QuickSort;

public static class ArrayQuickSort
{
    public static void QuickSort(this int[] input)
    {
        QuickSort(input, 0, input.Length - 1);
    }

    private static void QuickSort(int[] input, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        int pivot = input[(left + right) / 2];
        int index = Partition(input, left, right, pivot);

        QuickSort(input, left, index - 1);
        QuickSort(input, index, right);
    }

    private static int Partition(int[] input, int left, int right, int pivot)
    {
        while (left <= right)
        {
            while (input[left] < pivot)
            {
                left++;
            }

            while (input[right] > pivot)
            {
                right--;
            }

            if (left <= right)
            {
                Swap(input, left, right);
                left++;
                right--;
            }
        }

        return left;
    }

    private static void Swap(int[] input, int left, int right)
    {
        int tmp = input[left];
        input[left] = input[right];
        input[right] = tmp;
    }
}

