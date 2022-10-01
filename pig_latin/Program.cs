using System;
namespace PIG_LATIN{
    class Program{
        static void Main(String[] args){

            Console.WriteLine("Input a sentence to be converted to Pig Latin word and back");
            String english = Console.ReadLine() ?? "";
            


            var splited = english.Split(" ");
            String newWord = "";

            foreach (var split in splited)
            {
                char first = split[0];
                var newSplit = split.Remove(0,1) + char.ToLower(first)+ "ay";
                newWord += " " +newSplit;
            }
            Console.WriteLine("{0} in Pig latin: {1} \n",english,char.ToUpper(newWord[1]) + newWord.Substring(2));

            // back to english
            String removeAy = newWord.Replace("ay","");
            var englishSplit = removeAy.Split(" ");
            String englishWord = "";
            foreach (var split in englishSplit)
            {
                if(split == ""){
                    continue;
                }
                else{
                    char last = split[split.Length-1];
                var newSplit = char.ToLower(last) + split.Remove(split.Length-1,1);
                englishWord += " " +newSplit;
                }
            }
            Console.WriteLine("{0} in English: {1} \n",char.ToUpper(newWord[1]) + newWord.Substring(2),char.ToUpper(englishWord[1]) + englishWord.Substring(2));

        }
    }
}
