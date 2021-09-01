<Query Kind="Program" />

void Main()
{
	Console.Write(IsStringRotation("waterbottle","erbottlewat"));
}

bool IsStringRotation(string s1, string s2)
{
	if ((s1.Length + s2.Length == 0) || s1.Length != s2.Length) return false;
	string s1s1 = s1+s1;  //if gicven string is xy then yx(rotated at particular index) is always substring of xyxy
	return s1s1.Contains(s2);
}


//bool IsStringRotation(string s1, string s2)
//{
//	if(s1.Length == 0 || s2.Length ==0 || s1.Length != s2.Length) return false;
//	
//	for (int i = 0; i < s1.Length; i++) {
//	
//		if(s1[i]!=s2[0]){
//			continue;
//		}
//		string firstHalf = s1.Substring(0, i);
//		string secondHalf = s1.Substring(i, s1.Length-(i));
//		string modifiedString = secondHalf + firstHalf;
//		
//		if(modifiedString == s2){
//			return true;
//		}
//	}
//	
//	return false;
//}