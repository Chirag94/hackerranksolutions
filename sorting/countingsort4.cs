﻿using System;
using System.Collections.Generic;

namespace sorting
{
    public class countingsort4
    {
        static void Mains(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, String> dict = new Dictionary<int,String>();
            Dictionary<int, List<String>> valueListDict = new Dictionary<int, List<string>>();
            List<String> values ;
            List<String> strvalue;
            HashSet<int> intvalues = new HashSet<int>();
                for (int a0 = 0; a0 < n; a0++)
            {
                values = new List<string>();
                string[] tokens_x = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(tokens_x[0]);
                string s = tokens_x[1];
                values.Add(x.ToString() + ":" + s);
                dict.Add(a0, x.ToString() + ":" + s);
                intvalues.Add(x);
                strvalue = new List<string>();

                if(!valueListDict.ContainsKey(x)){
                    strvalue.Add(s);
                    valueListDict.Add(x, strvalue);
                }
                else{
                    strvalue = valueListDict[x];
                    strvalue.Add(s);
                    valueListDict[x] = strvalue;
                }
            }
            List<int> intkeys = new List<int>();
            foreach(var k in valueListDict.Keys){
                intkeys.Add(k);
            }
            intkeys.Sort();
            List<String> temp;

            foreach(var i in intkeys)
            {
                temp=new List<string>();
                temp = valueListDict[i];
                foreach(var k in temp){
                    //check the index of i and k in dict
                    //Console.WriteLine("Validating "+i +"against: "+k);
                    if (valid(i, k,dict))
                    {   
                        Console.Write(k+" ");
            
                    }
                    else{
                        Console.Write("-"+" ");

                    }
                   

                }
            }
                
        }

        private static bool valid(int i, string k, Dictionary<int, string> dict)
        {
            foreach(var key in dict.Keys){
                
                if (dict[key].Equals(i+":"+k)){
                    if (key < dict.Count / 2) return false;
                    else return true;
                }

            }
            return false;
        }

       
    }
}
