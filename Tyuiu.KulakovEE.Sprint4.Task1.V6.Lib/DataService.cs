﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KulakovEE.Sprint4.Task1.V6.Lib
{
    public class DataService: ISprint4Task1V6
    {
        public int Calculate(int[] array)
        {
            int x = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    x *= array[i];
            }
            return x;
        }
    }
}