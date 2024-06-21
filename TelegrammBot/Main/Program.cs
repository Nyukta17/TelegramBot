using System;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;


namespace TelegrammBot
{

    class Nyukta17_bot
    {
        static void Main(String[] args)
        {
            {
                var client = botClient();
                client.StartReceiving(Updata, Error);
                
                Console.ReadLine();

            }
        }
        async static Task Updata(ITelegramBotClient Botclient, Update update, CancellationToken token)
        {
            var Messag = update.Message;
            if (Messag.Text != null) 
            {
                if(Messag.Text == "/start") 
                {
                    await Botclient.SendTextMessageAsync(Messag.Chat.Id, @"Приветствую! Я бот-советник, помогу тебе советом.Напиши мне ""помоги советом""");
                }
                else if(Messag.Text.ToLower() =="помоги советом") 
                {
                    await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Конечно! На какую тему?");
                    
                    Botclient.SendTextMessageAsync(Messag.Chat.Id,"Помогу советом на такие темы как",replyMarkup:GetButtons());
                    
                }
                else if (Messag.Text == "Книги📚")
                {
                    await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Отличный выбор!😁\n💭Вот что я могу предложить:\n1-«Дюна»,Фрэнк Герберт👽\n" +
                        "Действие происходит в далёком будущем, где общественная жизнь и культура вращаются вокруг специи, за добычу и использование этого особого вещества идёт постоянная борьба. На первый взгляд может показаться, что это ещё одна история противостояния добра и зла, благородства и корыстных интересов. Однако книга полифоничнее." +
                        "\n2-«Сами боги», Айзек Азимов💫\n" +
                        "Перед читателем предстают два мира: умирающий и полный сил. Величайшее научное открытие в истории человечества дарит людям неисчерпаемый источник дешёвой энергии, которая и даёт надежду на спасение угасающей вселенной. Но всё не так просто, и плата за это открытие оказывается слишком большой для всех.");

                }
                else if (Messag.Text == "Туризм🏛")
                {
                    await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Могу предложить");
                    await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.5178519, longitude: 36.2299906, title: "Государственный музей истории космонавтики имени К. Э. Циолковского", address: "ул. Академика Королева, 2, Калуга, Калужская обл., 248000");
                }
            }
            
        }

        

        private static IReplyMarkup? GetButtons()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("Книги📚"), new KeyboardButton("Туризм🏛") }
                }
            );
        }

        static Task Error(ITelegramBotClient BotClient, Exception exception, CancellationToken token)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;
        }
        static TelegramBotClient botClient()
        {
            return new TelegramBotClient("7453668670:AAHtJ0VL0qyEMxrLSv58gi0TUbzPIkGWq8E");
        }
    }
}

//if (Messag.Text != null)
//{
//    Console.WriteLine($"{Messag.Chat.Username}  | {Messag.Text}");
//    if (Messag.Text.ToLower().Contains("привет"))
//    {
//        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "мир!");
//        return;
//    }
//}
//if (Messag.Photo != null)
//{
//    await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Попробуйте отправить фото документом");
//}
//if (Messag.Document != null)
//{
//    await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Один момент");

//    var FileId = update.Message.Photo.Last().FileId;
//    var FileInfo = await Botclient.GetFileAsync(FileId);
//    var filePath = FileInfo.FilePath;

//    const string destinationFilePath = "../downloaded.file";

//    await using Stream fileStream = System.IO.File.Create(destinationFilePath);
//    await Botclient.DownloadFileAsync(
//        filePath: filePath,
//        destination: fileStream);
//    fileStream.Close();
//    return;
//}