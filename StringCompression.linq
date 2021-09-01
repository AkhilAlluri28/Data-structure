<Query Kind="Program" />

void Main()
{
	Console.WriteLine(StringCompression("Aaaaa")); //case-sensitive
}

string StringCompression(string input){

	if(string.IsNullOrWhiteSpace(input))
		return input;
		
	StringBuilder compressedString = new StringBuilder();
	int count = 1;
	for(int i=0; i < input.Length; i++) {
	
		if(i == input.Length-1)
		{
			compressedString.Append(input[i]+count.ToString());
		}
		else if(input[i] == input[i+1])
		{
			count++;
		}
		else
		{
			compressedString.Append(input[i]+ count.ToString());
			count=1;
		}
	}
	string formattedString = compressedString.ToString();
	
	if(formattedString.Length < input.Length)
		return formattedString;
		
	return input;
}
