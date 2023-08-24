Console.WriteLine("Labas, kelinta valanda siandien atsikielete?");
string userInput = Console.ReadLine();
int userInputInteger = Convert.ToInt32(userInput);
if (userInputInteger < 12)
    Console.WriteLine("Geros dienos");
else if (userInputInteger < 18)
    Console.WriteLine("Geros popieties");
else if (userInputInteger < 24)
    Console.WriteLine("Gero vakoro");