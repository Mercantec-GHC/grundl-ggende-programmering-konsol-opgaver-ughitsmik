//The code belowiu does the following:
//    1. Converts the original string to a char array
//    2. Reverses the order of the chars, thus reversing the sentence
//    3. Counts every "o"
//    4. Prints out the reversed message and announces how many "o"'s are present 

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage)
{
    if (i == 'o')
    {
        x++;
    }
}
string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");