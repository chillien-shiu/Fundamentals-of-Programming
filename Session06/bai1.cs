using System;
using System.Collections.Generic;
using System.Linq;

class Part1
{
    public static int[] CreateRandomArray(int length, int minValue, int maxValue)
    {
        Random rand = new Random();
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = rand.Next(minValue, maxValue + 1);
        }
        return arr;
    }

    public static double Tinhtrungbinh(int[] arr)
    {
        int sum = 0;
        foreach (int val in arr) sum += val;
        return (double)sum / arr.Length;
    }

    public static bool Kiemtrachuagiatri(int[] arr, int target)
    {
        foreach (int val in arr)
        {
            if (val == target) return true;
        }
        return false;
    }

    public static int TimIndex(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target) return i;
        }
        return -1; // Không tìm thấy
    }

    public static int[] XoaPhanTu(int[] arr, int target)
    {
        List<int> result = new List<int>();
        foreach (int val in arr)
        {
            if (val != target) result.Add(val);
        }
        return result.ToArray();
    }

    public static (int min, int max) TimMinMax(int[] arr)
    {
        int min = arr[0], max = arr[0];
        foreach (int val in arr)
        {
            if (val < min) min = val;
            if (val > max) max = val;
        }
        return (min, max);
    }

    public static int[] DaoNguocMang(int[] arr)
    {
        int[] reversed = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            reversed[i] = arr[arr.Length - 1 - i];
        }
        return reversed;
    }

    public static int[] TimTrungLap(int[] arr)
    {
        List<int> duplicates = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j] && !duplicates.Contains(arr[i]))
                {
                    duplicates.Add(arr[i]);
                }
            }
        }
        return duplicates.ToArray();
    }

    public static int[] XoaTrungLap(int[] arr)
    {
        List<int> unique = new List<int>();
        foreach (int val in arr)
        {
            if (!unique.Contains(val)) unique.Add(val);
        }
        return unique.ToArray();
    }
}