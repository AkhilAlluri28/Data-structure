<Query Kind="Program" />

void Main()
{
	Console.WriteLine(IsPurmutation("gdw","dwg"));
}

bool IsPurmutation(string string1, string string2){
	if(string1.Length != string2.Length) return false;
	string1 = string.Concat(string1.OrderBy(c=>c));
	string2 = string.Concat(string2.OrderBy(c=>c));
	if(string1 == string2) return true;
	return false;
}