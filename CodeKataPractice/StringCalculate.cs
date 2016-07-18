using System;
namespace CodeKataPractice
{
    public class StringCalculate
    {
         public int Add(string s)
         {
            int rt = 0;
            if(s == string.Empty)
            {
                rt = 0;
            }
            else
            {
              if(int.TryParse(s,out rt))
                {
                    if (rt < 0)
                    {
                        throw new System.ArgumentException("Can't be negative number");
                    }
                    else
                    {
                        if(rt >1000)
                        {
                            return 0;
                        }
                        else
                        {
                            return rt;
                        }                        
                    }
                }   
              else
                {
                    string[] separate = { ",", "#"};
                    string[] separates = s.Split(separate, StringSplitOptions.RemoveEmptyEntries);
                    int i;
                    foreach(var st in separates)
                    {
                        if (int.TryParse(st, out i))
                        {

                            rt = rt+ Convert.ToInt32(st);
                        }
                    }
                    if (rt > 1000)
                        rt = 0;
                }           
            }
                return rt;
        }
    }
}