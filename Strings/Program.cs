//string city = "Ankara";
//Console.WriteLine(city[0]);
//foreach (var item in city)
//{
//    Console.WriteLine(item);

//}
//string city2 = "İstanbul";

string sentence = "My name is Demet Özmen";

var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "Her name is Ayşegül Özmen";
bool result3 = sentence.EndsWith("n");
bool result4 = sentence.StartsWith("Her name");

var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0, "Hello, ");
var result9 = sentence.Substring(3,5);
var result10 = sentence.ToLower();
var result11 = sentence.ToUpper();
var result12 = sentence.Replace(" ","-");  
var result13 = sentence.Remove(3,5);

Console.WriteLine(result12);
Console.WriteLine(result13);

//string result = city + city2;
//Console.WriteLine(String.Format("{0} {1}", city, city2));