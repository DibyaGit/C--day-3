using System;
using System.Speech.Synthesis;

class Program
{
    static void Main()
    {
        // Step 2: Create SpeechSynthesizer object
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        // Step 3: Take user input
        Console.Write("Enter text to speak: ");
        string text = Console.ReadLine();

        // Step 4: Speak the text
        synthesizer.Speak(text);

        Console.WriteLine("Done speaking!");
    }
}