﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections_Homework_5
{
    class T_14_1_4
    {

        public void Task_14_1_4()
        {
            /*14.1.4.შექმენით 10 - ელემენტიანი დინამიური მასივი სტრიქონების მასივის საფუძველზე.
            დინამიურ მასივში მოძებნეთ თქვენი სახელი.ეკრანზე გამოიტანეთ მოძებნილი ელემენტის
            ინდექსი, დინამიურ მასივში ელემენტების რაოდენობა და თვით დინამიური მასივი.*/


            List<string> list = new List<string>() {
                "One", "Two", "Three", "Alex",
                "Five", "Six", "Seven",
                "Eight", "Nine", "Ten" };

            if (list.Contains("Alex"))
            {
                Console.WriteLine($"Name Alex is exist and his index is - {list.IndexOf("Alex")}");
            }
            else
            {
                Console.WriteLine($"Name Alex is not exist");
            }

            Console.WriteLine();

            Console.Write("Elements:");
            foreach (object o in list)
            {
                Console.Write($"{o}  ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Amount of elements : {list.Count}");

        }
    }
}
