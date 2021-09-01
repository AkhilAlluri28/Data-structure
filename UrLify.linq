<Query Kind="Program" />

void Main()
{
	Console.WriteLine(UrLify("Mr John Smith    "));
}

string UrLify(string givenInput){
	var input = givenInput.Trim();
	StringBuilder updatedInput = new StringBuilder();
	for(int i =0; i< input.Length; i++){
		if(input[i] == ' ') {
			updatedInput.Append("%20");
			continue;
		}
		updatedInput.Append(input[i]);
	}
	return updatedInput.ToString();
}

// You can define other methods, fields, classes and namespaces here
