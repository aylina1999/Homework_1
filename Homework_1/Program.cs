﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region TASK_1
			/*
			//double money;
			//int grn, cop;
			Console.Write("Введите сумму: ");
			decimal money = Convert.ToDecimal(Console.ReadLine());
			Console.WriteLine(money);
			int grn = (int)money;
			int cop = (int)((money - grn) * 100);
            Console.WriteLine($"{grn} грн. {cop} коп.");
			*/
			#endregion TASK_1

			#region TASK_2
			/*
			                         //Ввод данных:
			Console.Write("Количество тетрадей: ");               
			string s_notes = Console.ReadLine();
			int notes = Convert.ToInt32(s_notes);
				

			Console.Write("Количество карандашей: ");
			string s_pencils = Console.ReadLine();
			int pencils = Convert.ToInt32(s_pencils);	

			                         //Умножение: 
			decimal priceofnotes = (decimal)(notes * 2.75);
			//Console.WriteLine(priceofnotes);
			decimal priceofpencils = (decimal)(pencils * 0.85);
			//Console.WriteLine(priceofpencils);
			
			                         //Результат покупки:
            decimal price = priceofnotes + priceofpencils;
			Console.WriteLine($" {price} грн.");
			*/
			#endregion TASK_2

			#region TASK_3
			/*
			                         //Ввод данных:
			Console.WriteLine("Количесство комплектов: ");
			string s_n = Console.ReadLine();	
			int n = Convert.ToInt32(s_n);
			
			                        //Стоимость одного комплекта:
			double notes = 2.75;
			double covers = 0.5;
			decimal priceofn = Convert.ToDecimal(notes + covers);

			                        //Стоимость покупки:
			decimal fullprice = priceofn * n;
			
			int grn = (int)fullprice;
			int cop = (int)((fullprice - grn) * 100);
			Console.WriteLine($"{grn} грн. {cop} коп.");
			*/
			#endregion TASK_3

			#region TASK_4
			/*
			                       //Расстояние:
			int distance = 67;
			int fulldistance = distance * 2;
			                       //Бензин на 1 км:
			double gasoline = 8.5 / 100;
			double priceofgasoline = (double)(gasoline * 7.6);
			                       //Итог:
			double price = priceofgasoline * fulldistance;
			Console.WriteLine($"Поездка на дачу и обратно обойдётся в {price} грн");
			*/
			#endregion TASK_4

			#region CALCULATOR
			/*
			Console.Write("Введите выражение: ");
			string expression = Console.ReadLine();            //читает строку с клавиатуры
			expression = expression.Replace('.', ',');         //Replace(что заменить, чем заменить) заменяет первый символ вторым символом в строке
			String[] values = expression.Split(new char[] {'+', '-', '*', '/' });  
			//метод Split()разделяет строку на подстроки, по указанным разделителям.
			//Split() принимает массив char, в котором перечисленны разделители,
			//и возвращает массив строк (токенов)
			//Метод Split() не изменяет исходную строку.
			
			//for(int i = 0; i < values.Length; i++)
			//{
			//	Console.Write(values[i]);
			//}

			double a = Convert.ToDouble(values[0]);	
			double b = Convert.ToDouble(values[1]);
			//Метод Contains() проверяет, содержит ли исходная строка указанную подстроку.
			if (expression.Contains("+")) Console.WriteLine($"{a} + {b} = {a + b}");
			else if (expression.Contains("-")) Console.WriteLine($"{a} - {b} = {a - b}");
			else if (expression.Contains("*")) Console.WriteLine($"{a} * {b} = {a * b}");
			else if (expression.Contains("/")) Console.WriteLine($"{a} / {b} = {a / b}");
			else Console.WriteLine("No operation");
			*/
			#endregion CALCULATOR

			#region SHOOTER
			/*
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.W: Console.WriteLine("Вперёд"); break;
					case ConsoleKey.S: Console.WriteLine("Назад"); break;
					case ConsoleKey.A: Console.WriteLine("Влево"); break;
					case ConsoleKey.D: Console.WriteLine("Вправо"); break;
					case ConsoleKey.Spacebar: Console.WriteLine("Прыжок"); break;
					case ConsoleKey.Enter: Console.Beep(); break;
					default: Console.WriteLine("Error"); break;
				}
			} while(key != ConsoleKey.Escape);
			*/
			#endregion SHOOTER

			#region CURSOR


			Console.BufferWidth = Console.WindowWidth + 1;
            Console.BufferHeight = Console.WindowHeight + 1;
			Console.WriteLine($"Buffer: {Console.BufferWidth} {Console.BufferHeight}");
			Console.WriteLine($"Buffer: {Console.WindowWidth} {Console.WindowHeight}");
			
			
			int x = 10;
			int y = 10;
			Console.CursorVisible = false;
			ConsoleKey key;
			do
			{
				int outofRange = 0;
				key = Console.ReadKey(true).Key;
                switch (key)
				{
					case ConsoleKey.UpArrow:
					
					case ConsoleKey.W:  y--; break;
                    case ConsoleKey.DownArrow:
					case ConsoleKey.S:  y++; break;
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A:  x--; break;
					case ConsoleKey.RightArrow:
					case ConsoleKey.D:  x++; break;
					default: Console.Beep(200,1000); break;
				}

				if (x < 0) { x = 0; outofRange++; }
				if (y < 0) { y = 0; outofRange++; }
				if (x >= Console.WindowWidth - 1) { x = Console.WindowWidth - 1; outofRange++; }
				if (y >= Console.WindowHeight - 1) { x = Console.WindowHeight - 1; outofRange++; }
				if (outofRange > 0) Console.Beep();

                Console.Clear();
				Console.BackgroundColor = ConsoleColor.Blue;
				Console.SetCursorPosition(x, y);
				Console.WriteLine(" ");
				Console.BackgroundColor = ConsoleColor.Black;

                Console.SetCursorPosition(0, 0);
				Console.WriteLine("X = " + x);
				Console.WriteLine("Y = " + y);
				try
				{  
					
				}
				catch (Exception e)
				{
					Console.SetCursorPosition(1, Console.BufferHeight - 2);
					Console.WriteLine(e.Message);
					
				}
			} while (key != ConsoleKey.Escape);

			#endregion CURSOR
		}
	}
}
