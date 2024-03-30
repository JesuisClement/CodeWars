/*

I got this exercice from CodeWars, exercice's name : "Duplicate Encoder"

The goal of this exercise is to convert a string to a new string where each character in the new string is "(" if that character appears only once in the 
original string, or ")" if that character appears more than once in the original string. Ignore capitalization when determining if a character is a duplicate.

  exemple:
"din"      =>  "((("
"recede"   =>  "()()()"
"Success"  =>  ")())())"
"(( @"     =>  "))((" 

 */


Console.WriteLine("din ->,? " + DuplicateEncode("din"));
Console.WriteLine("recede ->,? " + DuplicateEncode("recede"));
Console.WriteLine("Success ->,? " + DuplicateEncode("Success"));
Console.WriteLine("(( @ ->,? " + DuplicateEncode("(( @"));
Console.WriteLine("Please choose a word");
Console.WriteLine(DuplicateEncode(Console.ReadLine()));

static string DuplicateEncode(string word)
{
    char[] lettre = word.ToLower().ToCharArray();
    List<char> lettreCheck = new List<char>();

    for (int i = 0; i < lettre.Length; i++)
        if (lettreCheck.Contains(lettre[i]))
        {
            for (int j = 0; j < lettre.Length; j++)
            {
                if (lettre[i] == lettre[j])
                    lettre[j] = ')';
            }
            lettreCheck.Remove(lettre[i]);
        }
        else
        {
            lettreCheck.Add(lettre[i]);
        }

    for (int i = 0; i < lettre.Length; i++)
    {
        if (lettreCheck.Contains(lettre[i]))
            lettre[i] = '(';
    }
    return new string(lettre);
}