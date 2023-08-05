// See https://aka.ms/new-console-template for more information


using DictionaryExample;

Console.WriteLine("Hello, dictionary!");

MyDictionaryExample<int, string> dict = new MyDictionaryExample<int, string>();
dict.Add(25, "Player1");
dict.Add(28, "Player2");
dict.Add(32, "Player3");

Console.WriteLine(dict.Count);
