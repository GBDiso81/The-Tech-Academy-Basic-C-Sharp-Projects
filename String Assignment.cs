using System;


namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is my assignment on how to Concatenates three strings.
            string a = "Hello ";
            string b = "AOL,";
            string c = " This is my string assignment.";
            string sentence = a + b + c;
            Console.WriteLine(sentence);
            Console.ReadLine();

            //This is how i Converts a string to uppercase.
            string uppercase = sentence.ToUpper();
            Console.WriteLine(uppercase);
            Console.ReadLine();


            //This is how i Create a Stringbuilder and builds a paragraph of text, one sentence at a time.
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Hello, I am Glen Mark. \nI am a student of AOL. \nI am taking up Software and Web Developer Program.");
            string paragraph = sb.ToString();
            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
