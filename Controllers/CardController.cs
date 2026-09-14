using System;
using Microsoft.AspNetCore.Mvc;
using GameWeb.Models;

namespace GameWeb.Controllers
{
    [ApiController]
    [Route("api/card")]
    public class CardController : ControllerBase
    {
        static string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        static string[] values = { "A","2","3","4","5","6","7","8","9","10","J","Q","K" };

        static Card currentCard = GenerateCard();

        static Card GenerateCard()
        {
            var rand = new Random();
            return new Card
            {
                Suit = suits[rand.Next(suits.Length)],
                Value = values[rand.Next(values.Length)]
            };
        }

        [HttpPost("guess")]
        public IActionResult Guess([FromBody] Card guess)
        {
            if (guess.Suit == currentCard.Suit && guess.Value == currentCard.Value)
            {
                currentCard = GenerateCard();
                return Ok("🎉 Correct!");
            }
            return Ok("❌ Wrong!");
        }
    }
}