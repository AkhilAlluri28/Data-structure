<Query Kind="Program" />

void Main()
{
	Console.WriteLine(PrintBinary(0.75));
	//.1011100001010001111010111000010100011110101110000101  for 0.72 (if 32 length not checked)
	//.1 for 0.5
	//.1000001010001111010111000010100011110101110000101001 for 0.51 (if 32 length not checked)
}


String PrintBinary(double decimalNumber){
	if(decimalNumber >= 1 || decimalNumber <= 0){
		return "ERROR";
	}
	StringBuilder binary = new StringBuilder();
	binary.Append(".");
	while (decimalNumber > 0)
	{
		if (binary.Length >= 32)
		{
			return "ERROR";
		}
		
		double r = decimalNumber *2;
		if(r>=1){
			binary.Append(1);
			decimalNumber = r-1;
		}
		else
		{
			binary.Append(0);
			decimalNumber = r;
		}
	}
	return binary.ToString();
}