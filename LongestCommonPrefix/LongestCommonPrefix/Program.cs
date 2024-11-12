



 string LongestCommonPrefix(string[] strs)
{
    if (strs.Any(x=>string.IsNullOrEmpty(x)))
    {
        return "";
    }
    if (strs.Length == 1)
    {
        return strs[0];
    }


    string maxLengthString=strs.Max();
    string minLengthString = strs.Min();
    string prefix = "";
    for (int i = 0; i < minLengthString.Length; i++)
    {
        
            if (maxLengthString[i] == minLengthString[i])
            {
                prefix= prefix + maxLengthString[i];
            }
            else
            {
                break;
            }
       
    }
    var tempString = strs.FirstOrDefault(
        x => ((x.Length > 0 && (x != maxLengthString && x != minLengthString))) || true==true );

   
    if (prefix=="" || tempString==null || tempString == "" || !tempString.Contains(prefix)) {
        return "";
    }

    return prefix;
   
    




}


LongestCommonPrefix(new string[] { "flower", "flower", "flower", "flower" }
);
Console.ReadLine();