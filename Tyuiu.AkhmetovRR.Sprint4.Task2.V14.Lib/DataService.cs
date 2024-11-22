﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AkhmetovRR.Sprint4.Task2.V14.Lib
{
    public class DataService : ISprint4Task2V14
    {
        public int Calculate(int[] array)
        {
            int multpy = 1;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2 == 1)
                {
                    multpy *= array[i];
                }
            }
            return multpy;
        }
        public int[] rnd(int len, int startValue, int stopValue)
        {
            Random cmd = new Random();
            int[] end = new int[len];
            for (int i = 0; i < len; i++)
            {
                end[i] = cmd.Next(startValue, stopValue + 1);
            }
            return end;
        }
    }
}