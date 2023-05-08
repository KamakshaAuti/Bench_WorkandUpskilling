// C# program to print the total number of Vowels
// and consonants from a given string
using System;
class GFG{
	
public static void Main()
{
	char[] inputstring = new char[100];
	int i, vowels, consonants, x;
	
	vowels = 0;
	consonants = 0;
	
	// Enter the length of the string
	Console.WriteLine("Please enter the length of the string:\n");
	x = int.Parse(Console.ReadLine());
	
	// Enter the string
	Console.WriteLine("Enter string:\n");
	for (i = 0; i < x; i++)
	{
		inputstring[i] = Convert.ToChar(Console.Read());
	}
	
	// Iterating the string
	for (i = 0; inputstring[i] != '\0'; i++)
	{
		
		// Check if the character is a vowel
		if (inputstring[i] == 'a' || inputstring[i] == 'e' ||
			inputstring[i] == 'i' || inputstring[i] == 'o' ||
			inputstring[i] == 'u' || inputstring[i] == 'A' ||
			inputstring[i] == 'E' || inputstring[i] == 'I' ||
			inputstring[i] == 'O' || inputstring[i] == 'U')
		{
			
			// Increment the vowels
			vowels++;
		}
		
		else
		{
			
			// Increment the consonants
			consonants++;
		}
	}
	
	// Display the count of vowels and consonant
	Console.WriteLine("\ncount of vowel = " + vowels);
	Console.WriteLine("count of consonant = " + consonants);
	
	Console.ReadLine();
	Console.ReadLine();
}
}
