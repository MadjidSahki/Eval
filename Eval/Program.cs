﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var o = new int[] { 15, 4, 32, 7, 1 };
            EvalAlgo.Exo3(o, 8);

        }
    }

    public static class EvalAlgo
    {
        public static string Exo1(string str1)
        {

            //Je créer un hashset, qui ajoute tout les char de la string dedans, puis j'initialise un stringbuilder
            //qui va créer une string à partir de chaque char du hashset.
            //J'utilise un string builder au lieu d'une concaténation, pour des raisons d'optimisation.
            HashSet<char> values = new HashSet<char>();
            foreach (var c in str1)
            {
                values.Add(c);
            }

            StringBuilder builder = new StringBuilder();
            foreach (var value in values)
            {
                builder.Append(value);
            }
            return builder.ToString();

        }

        public static int? Exo2(int[] intArray)
        {

            //J'ai décidé de faire une requete linQ, qui groupe tout les mêmes nombre dans une liste
            //Puis je fais un count de chaque liste, et retourne la liste ayant pour longueur la bonne longueur
            var count = intArray.GroupBy(e => e).Where(e => e.Count() == (intArray.Length / 2) + 1).Select(e => e.First());

            if (count.Count() != 0)
            {
                return count.First();
            }
            else
            {
                return null;
            }
        }


        public static void Exo3(int[] intArray, int nb)
        {

            //L'algo est en place, c'était l'approche qui me semblait la plus logique
            //On  parcours le tableau, et on compare chaque nb au nb de référence, si il est inférieur on continue
            //Sinon on repacours le tableau une 2nd fois, si le nb comparé est plus petit que le nb de référence on le laisse
            //Sinon, on swap 
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] >= nb)
                {
                    continue;
                }
                else
                {

                    for (int x = 0; x < intArray.Length; x++)
                    {
                        if (intArray[x] <= nb)
                        {
                            continue;
                        }
                        else
                        {
                            int stockValue = intArray[i];
                            intArray[i] = intArray[x];
                            intArray[x] = stockValue;
                        }
                    }
                }
            }

        }
    }
}
