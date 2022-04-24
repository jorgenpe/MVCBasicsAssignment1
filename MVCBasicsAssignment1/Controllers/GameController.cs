using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCBasicsAssignment1.Models;
namespace MVCBasicsAssignment1.Controllers
{
    public class GameController : Controller
    {
        
        RandomNumberGame randomNumber;
        public GameController()
        {
            randomNumber = new RandomNumberGame();
        }
        
        [HttpGet]
        public IActionResult GuessGame()
        {
             
            string randomGame = HttpContext.Session.GetString("GuessGames");
            if (randomGame != null)
            {

                string[] randomGameArray = (randomGame as string).Split('|');

                if(randomGame == "Victory")
                {
                    HttpContext.Session.Clear();
                }
                else if (randomGameArray.Length > 1 && randomGameArray[0] == randomGameArray[randomGameArray.Length - 1])
                {

                    HttpContext.Session.Clear();
                    ViewBag.GuessGames = "Victory";

                }
                else if (randomGame != null)
                {
                    ViewBag.GuessGames = randomGame;
                }
            }
           

            return View();
        }

        [HttpPost]
        public IActionResult GuessGame(string guessGame)
        {
            try { 
                if(!string.IsNullOrWhiteSpace(guessGame))
                {
                    string randomGame = HttpContext.Session.GetString("GuessGames");

                    if(randomGame == null)
                    {
                        string random = randomNumber.GetRandomNumber();
                        HttpContext.Session.SetString("GuessGames", random + '|'+ guessGame);
                    
                    }
                    else
                    {
                        randomGame += '|' + guessGame;
                        HttpContext.Session.SetString("GuessGames", randomGame);
                    }
                }
            }
            catch (ArgumentException exData)
            {
                ViewBag.ExceptionMsg = exData.Message;
            }

            return RedirectToAction(nameof(GuessGame));
        }
    }
}
