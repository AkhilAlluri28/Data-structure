<Query Kind="Program" />

void Main()
{
	Console.WriteLine(OneEditAway("ale","bale")); //tried with ale, bale, pale, sky, zoom, universe
}

bool OneEditAway(string s1, string s2){

	if(Math.Abs(s1.Length-s2.Length)>1) 
		return false;
	
	if(s1.Length == s2.Length) 
		return oneEditReplace(s1, s2);
	
	if(s1.Length > s2.Length){
		return oneEditInsertOrRemove(s2, s1);
	}
	
	return oneEditInsertOrRemove(s1, s2);
}

bool oneEditReplace(string s1, string s2){

	bool foundDifference = false;
	for(int i=0; i<s1.Length; i++){
		if(s1[i] != s2[i]){
			if(foundDifference) 
				return false;
			foundDifference = true;
		}
	}
	return true;
}

bool oneEditInsertOrRemove(string shorterString, string longerString){
	bool foundDifference = false;
	int shorterIndex = 0;
	int longerIndex = 0;
	
	while(shorterIndex < shorterString.Length && longerIndex < longerString.Length){
		if(shorterString[shorterIndex] != longerString[longerIndex]){
			if(foundDifference) 
				return false;
			foundDifference = true;
			longerIndex++;
		}
		else{
			shorterIndex++;
			longerIndex++;
		}
	}
	return true;
}