﻿using System.ComponentModel.Design;

void hinh1(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0 || j == n - 1 || i/2 == j &&)
            {
                Console.Write("*");

            }
            else 
                Console.Write(' ');
        }
       Console.WriteLine();

    }
}
hinh1(20);