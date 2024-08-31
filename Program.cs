namespace SortColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 0, 1, 1, 0, 1, 2, 1, 0, 0, 1, 2, 2, 2, 1 };
            Console.WriteLine("Orignal Array");
            PrintArray(myArray);
            Console.WriteLine("Sorted Array");
            PrintArray(SortArray1(myArray));
        }

        static int[] SortArray1(int[] nums)
        {
            int n = nums.Length;
            int low = 0, mid = 0, high = n - 1;

            while (mid <= high)
            {
                if (nums[mid] == 0)
                {
                    (nums[low], nums[mid]) = (nums[mid], nums[low]);
                    low++;
                    mid++;
                }
                else if (nums[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    (nums[high], nums[mid]) = (nums[mid], nums[high]);
                    high--;
                }
            }
            return nums;

        }

        static int[] SortArray(int[] a)
        {
            int n = a.Length;
            int countZero = 0, countOne = 0, countTwo = 0;
            ///Console.WriteLine(countZero + ": " + countOne + ": " + countTwo);
            for (int i = 0; i < n; i++)
            {
                if(a[i] == 0)
                    countZero++;
                else if (a[i] == 1)
                {
                    countOne++;
                }
                    
                else if(a[i] == 2)
                    countTwo++;
            }

            Console.WriteLine(countZero + ": "+ countOne + ": " + countTwo);

            for(int i = 0; i < countZero; i++)
            {
                a[i] = 0;
            }
            for (int i = countZero; i < countZero + countOne; i++)
            {
                a[i] = 1;
            }
            for (int i = countZero + countOne; i < countZero + countOne + countTwo; i++)
            {
                a[i] = 2;
            }

            return a;
        }

        static void PrintArray(int[] a)
        {
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
