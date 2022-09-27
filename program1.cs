using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = new string[]
      {
        "The atomic number for lithium is 17", 
        "A cross between a horse and a zebra is called a Hobra",
        "The black box in a plane is black",
        " Alliumphobia is a fear of garlic",
        " Sex Education star Gillian Anderson was born in Chicago, Illinois"
      };
      bool[] answers = new bool[]
      {
        true,false,true,true,false
      };
bool[] responses = new bool[questions.Length];
      if(questions.Length != answers.Length ){
        Console.WriteLine("Warning questions are not equal to answers");
      }
      int askingIndex = 0;
      foreach(string question in questions){
        string input;
        bool isBool;
        bool inputBool;
        Console.WriteLine(question);
        Console.WriteLine("true or false");
        input = Console.ReadLine();
      
      isBool = Boolean.TryParse(input, out  inputBool);
      while(!isBool){
  Console.WriteLine("please enter true or false");
  input = Console.ReadLine();
      
      isBool = Boolean.TryParse(input, out  inputBool);
      }
      responses[askingIndex] = inputBool;
       askingIndex++ ;
      }
     /* foreach (double response in responses)
{
  Console.WriteLine(response);
}*/
 int scoringIndex = 0;
 int score = 0;
foreach ( bool answer in answers){
  bool response = responses[scoringIndex];
  Console.WriteLine(scoringIndex + 1 + ".");
  Console.WriteLine($"Input: {response} | Answer: {answer}");

if(response == answer){
  score++;
}
scoringIndex++;
Console.WriteLine($"You got {score} out of {questions.Length} correct!");
}
    }
  }
}
