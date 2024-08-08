string[] strs = ["flower", "flow", "flight"];
Console.WriteLine(LongestCommon(strs));

string s = "MCMXCIV";
Console.WriteLine(RomanToInt(s));

//14. Longest Common Prefix
string LongestCommon(string[] strs)
{
  string strBase = "";

  for (int i = 0; i < strs[0].Length; i++)
  {
    for (int j = 1; j < strs.Length; j++)
    {
      if (i > strs[j].Length || strs[j][i] != strs[0][i])
      {
        return strBase;
      }
    }
    strBase += strs[0][i];
  }
  return strBase;
}

//13. Roman to Integer
int RomanToInt(string s)
{
  int sum = 0;

  Dictionary<char, int> map = new()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

  for (int i = 0; i < s.Length - 1; i++)
  {
    if (map[s[i]] < map[s[i + 1]])
    {
      sum -= map[s[i]];
    }
    else
    {
      sum += map[s[i]];
    }
  }
  return sum + map[s[s.Length - 1]];
}