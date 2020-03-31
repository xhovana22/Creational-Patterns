﻿using FactoryPattern.ConcreteCreator;
using FactoryPattern.Creator;
using FactoryPattern.Products;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
         
                // Note: constructors call Factory Method

                Document[] documents = new Document[2];

                documents[0] = new Resume();
                documents[1] = new Report();

                // Display document pages

                foreach (Document document in documents)
                {
                    Console.WriteLine("\n" + document.GetType().Name + "--");
                    foreach (Page page in document.Pages)
                    {
                        Console.WriteLine(" " + page.GetType().Name);
                    }
                }

                // Wait for user

                Console.ReadKey();
            }
        }
    }
