<Query Kind="Program" />


void Main()
{
	var result = IsUnique("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
	Console.WriteLine(result);
}

bool IsUnique(string sentense) {
	if(sentense.Length > 128) return false;  //if the string is ASCII extended then replace 128 with 256
	bool[] charArray = new bool[128];
	foreach(char c in sentense){
		if(charArray[c]){
			return false;
		}
		charArray[c] = true;
	}
	return true;
}
