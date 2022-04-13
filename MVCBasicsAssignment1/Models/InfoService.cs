using System.Collections.Generic;

namespace MVCBasicsAssignment1.Models
{
    public class InfoService
    {

        static string about;
        string[] contact;
        static List<string[]> gitHubLinks;
        

        public InfoService()
        {
            
            gitHubLinks = new List<string[]>();
           
            about = " Hej! Jag heter Jörgen Pettersson och bor i Mörrum";
            contact = new string[] { "Namn: Jörgen Pettersson", "Adress: Östravägen 9", " Ort: Mörrum", "Telefon: 0706329725" };
            string[] gitHubHangman = new string[] { "https://github.com/jorgenpe/Hangman", "Guess a word or character" };
            string[] gitHubSokoban = new string[] { "https://github.com/jorgenpe/Sokoban", " Push block to green area by using arrow keys" };

            gitHubLinks.Add(gitHubSokoban);
            gitHubLinks.Add(gitHubHangman);
        }

        public string GetAbout() { return about; }  

        public string[] GetContact() { return contact;}

        public List<string[]> GetGitHubLinks() { return gitHubLinks;}
    }
}
