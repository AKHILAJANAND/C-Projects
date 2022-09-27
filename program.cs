using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.Write("enthe the message:");
      string input = Console.ReadLine();
      char[] secretMessage = input.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];
      for(int i=0; i < secretMessage.Length;i++ ){
        char letter = secretMessage[i];
        int index = Array.IndexOf(alphabet,letter);
        int addIndex = (index + 3) % 26;
        char newEncreptedMsg = alphabet[addIndex];
        encryptedMessage[i] =  newEncreptedMsg ;

      }
        
      string decreptedMsg = String.Join("",encryptedMessage);
      Console.WriteLine($"encrypted message is {decreptedMsg}" );
    }
  }
}
