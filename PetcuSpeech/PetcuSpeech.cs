using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Determines whether a file path might have been specified.
        if (args.Length != 1)
        {
            Console.WriteLine("Specified argument is not a valid file path.");
        }
        else
        {
            try
            {
                // Represents the Petcu'd version of the text from a specified file.
                var petcuText = "";

                // Keeps track of Petcu's arguments (sentences).
                int index = 1;

                // Reads the file from the specified path.
                using (var reader = new StreamReader(args[0]))
                {
                    while (!reader.EndOfStream)
                    {
                        var potentialPetcuArgument = reader.ReadLine();

                        // Determines whether this is a potential argument of Petcu (in other words, a sentence).
                        if (potentialPetcuArgument != "")
                        {
                            petcuText += "\n" + index++.ToString() + ") " + potentialPetcuArgument + "\n";
                        }
                    }
                }

                // Outputs the Petcu'd version of the original text.
                Console.WriteLine("Original text translated to PetcuSpeech:");
                Console.WriteLine(petcuText);
            }
            catch
            {
                Console.WriteLine("Something went wrong. The file might be #petkd.");
            }
        }
    }
}