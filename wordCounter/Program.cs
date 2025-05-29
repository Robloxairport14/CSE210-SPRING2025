class Program
{
    static void Main(string[] args)
    {
        // This is a simple program that prints "Hello, World!" to the console.
        Console.WriteLine("Hello, World!");

        WordCounter wordCounter = new WordCounter("This is a sample text to count words.");
        wordCounter.DisplayWords();

        int count = wordCounter.CountSingleWord("text");
        Console.WriteLine($"Total words: {count}");
    }

    
    
}
