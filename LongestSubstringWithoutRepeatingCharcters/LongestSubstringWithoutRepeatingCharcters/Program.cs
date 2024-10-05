 int LengthOfLongestSubstring(string s)
{
    Dictionary<string, int> dict = new Dictionary<string, int>();

    string subStringTemp = "";

  
    //anviaj
    for (int i = 0; i < s.Length; i++)
    {
        subStringTemp = s[i].ToString();
        if (s.Length == 1)
        {
            return 1;
        }
        for (int j = i + 1; j < s.Length; j++)
         {
            if (!subStringTemp.Contains(s[j]))
            {
                subStringTemp = subStringTemp + s[j];
            }

            else
            {
                if (!dict.ContainsKey(subStringTemp))
                {
                    dict.Add(subStringTemp, subStringTemp.Length);

                }
                subStringTemp = "";
                break;
            }

            if (j==s.Length-1 && !dict.Keys.Contains(subStringTemp))
            {
                dict.Add(subStringTemp, subStringTemp.Length);
                subStringTemp = "";

            }


        }
   
    }
    var result = dict.OrderByDescending(x => x.Value).FirstOrDefault().Value;


    return result;
}

Console.WriteLine("Determine string : ");
string tryingValue = Console.ReadLine();
Console.WriteLine($"Result : {LengthOfLongestSubstring(tryingValue)}");
Console.ReadLine();
