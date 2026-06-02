namespace NewProgram.StudentApp;

public class SimpleSort
{
    /*
     * Given series numbers [5,4,8,2,4,1]
     * Write a simple sort function for sorting the given numbers
     *  [5,4,8,2,4,1]  => expected result :  [1,2,4,4,5,8]
     */
    public static int[] Sort(int[] arr, bool ascending = true)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var x = arr[i]; // 5
                var y = i < arr.Length - 1 ? arr[i + 1] : arr[i]; // 4
                if (ascending)
                {
                    if (x > y) //5 > 4
                    {
                        arr[i] = y; // newArr[0] = 4
                        arr[i < arr.Length - 1 ? i + 1 : i] = x; // 5
                    }
                }
                else
                {
                    if (x < y) //5 > 4
                    {
                        int temp = x;
                        arr[i] = y; // newArr[0] = 4
                        arr[i < arr.Length - 1 ? i + 1 : i] = temp; // 5
                    }
                }
            }
        }

        return arr;
    }
    public static int[] Sort(params int[] arr)
    {
        return Sort(arr, true);
    }
}
