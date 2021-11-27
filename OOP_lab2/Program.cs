using System;

namespace OOP_lab2
{

	class Rmas
	{
		protected float[] msf = new float[5]; //массив
		public float this[int j]
		{
			get
			{
				return msf[j];
			}
			set
			{
				msf[j] = value;
			}
		}
	}
	class Class1
	{
		static void Main(string[] args)
		{
			Rmas arr = new Rmas();
			Rmas arr2 = new Rmas();
			Rmas arr3 = new Rmas();
			Console.WriteLine("Введите первый массив из 5ти чисел: ");
			for (int i = 0; i < 5; i++)
			{
				int z = Convert.ToInt32(Console.ReadLine());
				arr[i] = z;
			}

			Console.WriteLine("Введите второй массив из 5ти чисел: ");
			for (int i = 0; i < 5; i++)
			{
				int z = Convert.ToInt32(Console.ReadLine());
				arr2[i] = z;
			}

			Console.WriteLine("Массив из максимальных элементов: ");
			for (int i = 0; i < 5; i++)
			{
				if (arr[i] >= arr2[i])
				{
					arr3[i] = arr[i];
				}
				else arr3[i] = arr2[i];
				Console.WriteLine(arr3[i]);
			}
		}
	}
}
