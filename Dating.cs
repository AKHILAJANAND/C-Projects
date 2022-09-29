using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
       Profile a = new Profile("Sasikala",22,"kerala","India","she/her");
         
       
         a.SetHobbies( new string[]{
           "listening to audiobooks and podcasts",
           "playing rec sports like bowling and kickball",

"writing a speculative fiction novel",
"reading advice columns"});
  Console.WriteLine(a.ViewProfile());
         
    }
  }
}
