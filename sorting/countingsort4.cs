using System;
using System.Collections;
using System.Collections.Generic;

namespace sorting
{
    public class countingsort4
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Hashtable dict = new Hashtable();
            Hashtable valueListDict = new Hashtable();
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
                    strvalue = (List<String>)valueListDict[x];
                    strvalue.Add(s);
                    valueListDict[x] = strvalue;
                }
            }
            List<int> intkeys = new List<int>();
            foreach(var k in valueListDict.Keys){
                intkeys.Add((int)k);
            }
            intkeys.Sort();
            List<String> temp;
            foreach(var i in intkeys)
            {
                temp=new List<string>();
                temp = (List<String>)valueListDict[i];
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

        private static bool valid(int i, string k, Hashtable dict)
        {
            
            foreach(var key in dict.Keys){
                
                if (dict[key].Equals(i+":"+k)){
                    if ( (int)key <  dict.Count / 2) return false;
                    else return true;
                }

            }
            return false;
        }

       
    }
}
