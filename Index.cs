using System;

namespace FutureDev
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arr = {"First", "Second", "Third", "Fourth", "Fifth"};
            Shuffle(arr);

            foreach(string item in arr){
                Console.WriteLine(item);
            }
		}
        private static void Shuffle<T>(T[] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
        }
	}
}
