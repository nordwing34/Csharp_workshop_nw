// Сортировка выбором
// https://gb.ru/lessons/316875


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_select
{
	class Sorting
	{
		// Сортировка выбором
		public static int[] Main(int[] collection)
		{
			int size = collection.Length;
			for (int i = 0; i < size - 1; i++) 
			{
				int pos = i;
				for(int j = i+1; j < size; j++)
				{
					if (collection[j] < collection[pos]) pos = j;
				}
				int temp = collection[i];
				collection[i] = collection[pos];
				collection[pos] = temp;
			}
			return collection;
		}

		//int[] arr = new int[] { 9, 6, 0, 5, 7, 3, 1, 2 };
	}
	
}

//int arr = new int[] { 9, 6, 0, 5, 7, 3, 1, 2 };
//System.Console.WriteLine(string.Join(' ', arr));
