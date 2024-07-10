using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegrammBot.Main
{
    internal class Button
    {
        public  IReplyMarkup? GetButtons()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("Развлечение🎉"), new KeyboardButton("Путешествие🗺") , new KeyboardButton("Образование👨‍🎓") },
                    
                }
            );
        }
        public IReplyMarkup? GetButtons_for_entertainments()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("📀фильмы🎥"), new KeyboardButton("🕹игры🎮") , new KeyboardButton("🏠интересные места🗻") },
                    new List<KeyboardButton> { new KeyboardButton("Назад⬅") }
                }
            );
        }
        public IReplyMarkup? GetButtons_for_journey()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("В Калуге🌍🚀"), new KeyboardButton("В Москве🏙") , new KeyboardButton("В Туле🎫") },
                    new List<KeyboardButton> { new KeyboardButton("Назад⬅") }

                }
            );
        }
        public IReplyMarkup? GetButtons_for_education()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("👩‍🎓учебные заведения👨‍🎓"), new KeyboardButton("📚документалки📖") },
                    new List<KeyboardButton> { new KeyboardButton("Назад⬅") }
                }
            );
        }
        public IReplyMarkup? GetButtons_movie()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("🧛‍♂️хоррор🎃"), new KeyboardButton("🌌фантастика💫") , new KeyboardButton("🔍детектив🕵️‍♂️") },
                    new List<KeyboardButton> { new KeyboardButton("⬅Назад") }
                
                }
            );
        }
        public IReplyMarkup? GetButtons_game()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("💀боевик🔫"), new KeyboardButton("🏹тактика🗿") , new KeyboardButton("😵головоломки😵") }, 
                    new List < KeyboardButton > { new KeyboardButton("⬅Назад") }
                }
            );
        }
    }
}
