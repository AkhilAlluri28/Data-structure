<Query Kind="Program" />

///Bit Manipulation
/// 1(2^0), 2(2^1), 4(2^2), 8(2^3), 16(2^4), 32(2^5), 64(2^6), 128(2^7), 256(2^8), 512(2^9), 1024(2^10) etc
/// 586 = (1001001010) to base 2 (come from higher power to lower)


/// Bitwise Operators(6)
/// 1. NOT(~)
/// 2. AND (&)
/// 3. OR(|)
/// 4. XOR (^)
/// 5. left shift (<<)
/// 6. right shift (>>)


/// <summary>
/// Let A= 60(2^5(32) + 2^4(16) + 2^3(8) + 2^2(4) == 00111100) and B = 13 (8+4+1 == 00001101)
/// 
/// 
/// </summary>
void Main()
{
	OddOrEven(12);
}


public void OddOrEven(int number){
	if((number&1) == 1){ //for odd last value will be 2^0 == 1. so for & operator (1&1 == 1 else 0)
		Console.WriteLine("odd");
	}
	else{
	Console.WriteLine("even");	
	}
}