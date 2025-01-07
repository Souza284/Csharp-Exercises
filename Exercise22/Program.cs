Console.WriteLine("Enter in any word or frase: ");
var word = Console.ReadLine()!;

word = word.ToLower();
word = word.Replace(" ", "");

var letterList = new List<char>();

foreach(char letter in word)
{
    letterList.Add(letter);
}

var _letterList = letterList.GroupBy(l => l, l => l);

foreach(var letter in _letterList)
{
    Console.WriteLine("The letter " + letter.Key + " appeared " + letter.Count() + " times");
}