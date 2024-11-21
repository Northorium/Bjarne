//) Model yourself
// 
// I denne oppgaven skal du prøve å programmere deg selv 🤓 Du har noen gitte egenskaper og ting du liker å gjøre. Lag et hovedprogram der hver av deltakerene har sin klasse som kan printe ut en introduksjonstekst, og også utføre hver sine hobbyer.
// 
// Utskrift i konsollen kan feks se sånn her ut: */

//Velge person
//Be om navn
//Be om alder

using Bjarne;

Console.WriteLine("Hva heter du?");
var name = Console.ReadLine();



Console.WriteLine("Hvor gammel er du?");
var age = Console.ReadLine();
int ageToInt = Convert.ToInt32(age);


Console.WriteLine("Hva liker du å gjøre på fritiden?");
var hobbies = Console.ReadLine();

Person Kim = new Person(name, ageToInt, hobbies);

Kim.printText();