<Query Kind="Program" />

void Main()
{
	Console.WriteLine(IsPalindrome("god","Dog"));
}

bool IsPalindrome(string string1, string string2){
	if(string1.Length != string2.Length) return false;
	
	for(int i=0; i< string1.Length; i++)
	{
		if(string1[i] != string2[string1.Length-1-i])
		{
			return false;
		}
	}
	return true;
}
