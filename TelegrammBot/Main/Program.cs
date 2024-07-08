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
            string Photo = "";
            if (Messag.Text != null) 
            {
                switch (Messag.Text.ToLower()) 
                {
                    case "/start":
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, @"Приветствую! Я бот-советник, помогу тебе советом.Напиши мне ""помоги советом""");
                        break;
                    case "помоги советом":
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Конечно! На какую тему?");
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Помогу советом на такие темы как", replyMarkup: GetButtons());
                        break;
                    //Самое начало
                    case "развлечение🎉":
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Отлично! Давай помогу определиться. Что тебе нравится?", replyMarkup: GetButtons_for_entertainments());
                        break;
                    case "путешествие🗺":
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Помогу советом на такие темы как", replyMarkup: GetButtons_for_journey());
                        break;
                    case "образование👨‍🎓":
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Помогу советом на такие темы как", replyMarkup: GetButtons_for_education());
                        break;
                    //Пул Развлечение🎉 - "📀фильмы🎥"
                    case "📀фильмы🎥":
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "А какой жанр тебе подходит?",replyMarkup: GetButtons_movie());
                        break;
                    case "🧛‍♂️хоррор🎃":
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\хорроры\\proch.jpg";
                        
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Любишь жуть?😱 А ты смелый!😉 Вот мой список для тебя!😘");
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\t🏃‍♂️Прочь🕯\n" +
                                "Открывает наш топ хорроров детективный триллер, в котором главные злодеи — не призраки или чудовища, а люди.\n" +
                                "Парень по имени Крис отправляется вместе со своей девушкой Роуз на выходные в поместье к ее богатым родителям.\n" +
                                "Он немного волнуется по поводу того, как его встретят, ведь он чернокожий, а его девушка — белая.\n" +
                                "По приезде все кажется нормальным, родители Роуз ведут себя дружелюбно, но вскоре Крис начинает замечать странности в поведении не только семьи, но и темнокожих слуг.\n" +
                                "Атмосфера становится все более мрачной и напряженной, а Крис понимает: что-то не так с этим местом и со всеми людьми в особняке, проявляющими к главному герою какой-то нездоровый интерес.\n" +
                                "✨7.1 из 10✨</b>",
                                parseMode: ParseMode.Html);
                        }
                        Thread.Sleep(3000);
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\хорроры\\OHO.jpg";
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\t🤡Оно🎈\n" +
                                "В списки фильмов ужасов с высоким рейтингом входит и этот фильм, и предыдущая экранизация 1990 года.\n" +
                                "Однако картина 2017-го — не ремейк, а переосмысление одноименной книги-хоррора от Стивена Кинга.\n" +
                                "Небольшой городок Дерри в штате Мэн уже несколько веков имеет дурную славу — здесь бесследно исчезают дети.\n" +
                                "В 1989 году пропадает еще один — шестилетний Джорджи.\n" +
                                "Спустя год его старший брат Билл, который не может смириться с этим ужасом, со своими друзьями отправляется на поиски Джорджи.\n" +
                                "Они еще не догадываются, что им предстоит столкнуться с древним злом — потусторонним существом по имени Пеннивайз, которое приняло облик страшного клоуна, пожирающего как страхи детей, так и их самих.\n" +
                                "Во время съемок фильма юным исполнителям главных ролей специально не показывали актера в костюме Пеннивайза до сцены их первой встречи, чтобы их реакция на его появление была максимально естественной.\n" +
                                "🎈7.3🤡 из 10🤡🎈</b>",
                                parseMode: ParseMode.Html
                                );
                        }
                        Thread.Sleep(3000);
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\хорроры\\Promitey.jpg";
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\t✨✨Прометей💫💫\n" +
                                "Первый из приквелов к серии про Чужих, и знакомство с франшизой вполне можно начать именно с этого фильма.\n" +
                                "В 2089 году археологи Элизабет Шоу и Чарли Холлоуэй находят древнюю звездную карту, указывающую путь к Раю — месту, в котором, вероятно, живут те, кто создал жизнь на Земле. \n" +
                                "Мультимиллиардер Питер Вейланд организует космическую экспедицию с участием главных героев — Шоу и Холлоуэя.\n" +
                                "Первооткрыватели достигают искомой планеты, но не находят на ней ни одного представителя фауны, как и предполагаемых Создателей: от последних остались только древние руины.\n" +
                                "Вскоре появляется нечто, убившее всю разумную жизнь в этом мире, и оно не оставит землянам ни единого шанса на выживание.\n" +
                                "🌌7 из 10🌌</b>",
                                parseMode: ParseMode.Html
                                );
                        }
                        break;
                    case "🌌фантастика💫":
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\фантастика\\interstellar.jpg";
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Ого!😱 Любишь помечтать о бедующем и других мирах?😙🌌 Вот моя подборка!😘\n");
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\t🌌Интерстеллар🌌\n" +
                                "В недалёком будущем человечество столкнулось с нехваткой еды и голодом. Чтобы спасти общество, NASA посылает космическую экспедицию на другой конец галактики.😱\n" +
                                "Участникам миссии предстоит отыскать миры, пригодные для переселения.🚀🌌\n" +
                                "Режиссёр произвёл глобальную работу, чтобы снять нестандартный фильм о путешествиях в космосе.\n" +
                                "Он показал, что в мире есть вещи, к которым люди не будут готовы. Например, что существует другое восприятие пространства, а на некоторых планетах время течёт в другом ритме.\n" +
                                "🚀🌌8.6 из 10🌌🚀</b>",
                                parseMode: ParseMode.Html);
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\фантастика\\Duna.jpg";
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\t🏜Дюна🏜\n" +
                                "История рассказывает об одном из домов правителей — Атрейдесах, которым поступает приказ от императора занять планету Арракис, чтобы обеспечить производство специи.\n" +
                                "Другое название этой планеты — Дюна. Она много столетий принадлежала другому дому — Харконненам.\n" +
                                "У планеты столько ресурсов, что с её помощью можно захватить Вселенную. Старые правители не планируют отдавать это место Атрейдесам и начинают борьбу.\n" +
                                "Так же у дюны есть продолжение, где схватка между домами продолжается!\n" +
                                "🐫🏜8 из 10🏝🐪</b>",
                                parseMode: ParseMode.Html);
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\фантастика\\Ghost_int_he_Shell.jpg";
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>👻Призрак в доспехах👻\n" +
                                "Действия происходят в 2029 году.\n" +
                                "Общество повсеместно использует искусственный интеллект, в людей вшивают нейронные импланты. Это помогает улучшить возможности тела и сознания.\n" +
                                "Девятому отделу и майору Мотоко Кусанаги поручают расследовать преступление неизвестного хакера по кличке Кукловод.\n" +
                                "Но Кусанаги быстро понимает, что это дело не такое простое, каким могло показаться.\n" +
                                "Графика произвела фурор, а вложенный смысл привлёк внимание критиков и аудитории.\n" +
                                "👻🎯8 из 10🎯👻</b>",
                                parseMode: ParseMode.Html);
                        }
                        break;
                    case "🔍детектив🕵️‍♂️":
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\детективы\\Inferno.jpg";

                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Ну-ка, ну-ка!🕵️‍♂️Давайте раскроем пару дел!🔍 Вот что я могу предложить!");
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>🕯Инферно🕯\n" +
                                "Профессор Роберт Лэнгдон приходит в сознание в одной из итальянских больниц, полностью потеряв память.\n" +
                                "Местный врач Сиенна Брукс пытается помочь Роберту не только восстановить воспоминания, но и остановить загадочных злоумышленников, которые намерены распространить смертоносный вирус.\n" +
                                "Разгадка таинственной истории связана с «Адом» (ит. Inferno) - первой частью «Божественной комедии» Данте.\n" +
                                "👣🔍7 из 10🔍👣</b>",
                                parseMode: ParseMode.Html);
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\детективы\\Ace_Ventura_wanted_pets.jpg";
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>🐾Эйс Вентура: Розыск домашних животных🐾\n" +
                                "Он - лучший в своем деле, единственный и неповторимый! Он - Эйс Вентура, детектив по розыску домашних любимцев.\n" +
                                "Когда таинственные злоумышленники похищают дельфина по кличке Снежинка, талисман местной футбольной команды «Дельфины», Эйс тут же приступает к работе, проявляя чудеса изобретательности.\n" +
                                "История принимает странный оборот, когда похищают еще и ведущего игрока «Дельфинов».\n" +
                                "Теперь Эйсу приходится разыскивать сразу двух млекопитающих.\n" +
                                "Он сталкивается нос к носу с акулой-людоедом, спасает любимую команду и очаровывает женщин.\n" +
                                "Находится ли он под прикрытием, под огнем или под водой, он обязательно найдет то, что ищет!\n" +
                                "🐾🔍8 из 10🔍🐾</b>",
                                parseMode: ParseMode.Html);
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\детективы\\seven.jpg";
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>🔪🥓Семь🥓🔪\n" +
                                "Детектив Уильям Сомерсет - ветеран уголовного розыска, мечтающий уйти на пенсию и уехать подальше от города и грешных обитателей.\n" +
                                "За 7 дней до пенсии на Сомерсета сваливаются две неприятности: молодой напарник Миллс и особо изощренное убийство.\n" +
                                "Острый ум опытного сыщика сразу определяет, что за этим преступлением, скорее всего, последуют другие. Новости подтверждают его догадку.\n" +
                                "Поняв, что убийца наказывает свои жертвы за совершенные ими смертные грехи, детектив встает перед выбором: вернуться к работе либо уйти и передать дело своему менее опытному напарнику?\n" +
                                "🔪🔍9 из 10🔍🔪</b>",
                                parseMode: ParseMode.Html);
                        }
                        break;
                    //Пул Развлечение🎉 - "🕹игры🎮"

                    case "🕹игры🎮":
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Стало скучно? Давай-ка подберём игры на такие темы как😁", replyMarkup:GetButtons_game());
                        break;
                    case "💀боевик🔫":
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\боевик\\Dying_Light.jpg";

                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Давай-ка постреляем!🏃‍♂️🔫");
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\tDying Light\n" +
                                "Добро пожаловать в мир зомби-апокалипсиса, где вы можете паркурить по улицам, как сумасшедший Человек-паук на стероидах.\n" +
                                "В роли главного героя вы будете путешествовать по огромному открытому миру, наводненному полчищами плотоядных зомби.\n" +
                                "В течение дня вы собираете припасы и готовитесь к ночи, когда нежить станет быстрее, сильнее и бесконечно страшнее. Прямо как спортсмены на олимпийских играх.\n" +
                                "Эта игра научит вас важности хорошей кардиотренировки и тому, насколько полезным может быть молот для разбивания черепов зомби.\n" +
                                "💀🔨7 из 10💀🔨</b>",
                                parseMode: ParseMode.Html);
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\боевик\\Call-Of-Duty-Modern-Warfare-2.jpg";


                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\tModern Warfare 2\n" +
                                "Игрок участвует в линейных миссиях за нескольких бойцов регулярных частей и спецназа западных стран.\n" +
                                "Игрок выполняет простейшие задачи: пробивается через разнообразные уровни, уничтожает противников, сбивает из ракетных установок вертолёты, управляет стационарными пулемётами.\n" +
                                "Иногда использует транспорт и т. д.\n" +
                                "🔫9 из 10🔫</b>",
                                parseMode: ParseMode.Html);
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\боевик\\Overwatch.jpg";


                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\tOverwatch\n" +
                                "В войне против машин (омников) человечество решило использовать главный козырь — международное спецподразделение героев Overwatch.\n" +
                                "После победы над восставшими омниками влияние организации ослабевало, и она вскоре была распущена.\n" +
                                "Но в связи с быстрорастущим уровнем преступности героям вновь предстоит объединиться.\n" +
                                "😁10 из 10😁</b>",
                                parseMode: ParseMode.Html);
                        }
                        break;
                    case "😵головоломки😵":
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\головоломки\\Portal-2.jpg";
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Вот мой том головокружительных игр😵😁");
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\tPortal 2\n" +
                                "Действия второй части истории разворачиваются в заброшенной Лаборатории исследования природы порталов.\n" +
                                "В центре сюжета по-прежнему подопытная Челл и суперкомпьютер GLaDOS — искусственный интеллект с маниакальными наклонностями.\n" +
                                "Особенность игры в создании порталов, которые позволяют выполнять самые разные задания: перемещать Челл и предметы вместе с ней, обходить врагов, преодолевать препятствия.\n" +
                                "Самое сложное — выйти из игры в реальный мир и обнаружить, что никаких порталов в нём нет.\n" +
                                "🌌9 из 10🌌</b>",
                                parseMode: ParseMode.Html);
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\головоломки\\Machinarium.jpg";
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\tMachinarium\n" +
                                "Маленькому роботу, которого выбросили на помойку, непросто улучшить своё положение. Но ради вызволения подруги можно и горы свернуть!\n" +
                                "Это ещё один квест, в котором нужно искать спрятанные предметы. Но взаимодействовать можно только с объектами, которые находятся рядом с вами. Зато есть возможность увеличивать и уменьшать тело робота, а также посмотреть, как пройти область.\n" +
                                "Для этого надо либо сыграть в скролл-шутер, либо взять подсказку-намёк.\n" +
                                "🤖8 из 10🤖</b>",
                                parseMode: ParseMode.Html);
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\головоломки\\Unravel.jpg";
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\tUnravel\n" +
                                "В последние годы хорошие головоломки выходят редко — всё же шедевры в этом жанре появлялись чаще, когда компьютеры были слабее.\n" +
                                "Но Unravel — счастливое исключение. Здесь такая графика, что хочется потрогать объекты на экране, переместиться в этот волшебный мир и вместе с Ярни путешествовать по нему.\n" +
                                "Ярни — это забавный не то котёнок, не то чертёнок из красных ниток. С его помощью вам предстоит распутать сюжетный клубок. Собственно, Unravel и переводится как «распутать», и порой вам придётся разматывать тело персонажа, чтобы решить головоломки и попасть на следующий уровень.\n" +
                                "Но — спойлер! — расходуйте нить экономно, чтобы хватило до финала." +
                                "😁10 из 10😁</b>",
                                parseMode: ParseMode.Html);
                        }
                        break;
                    case "🏹тактика🗿":
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\тактика\\Wildermyth.jpg";
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Вот мой подборка");
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\tWildermyth\n" +
                                "Wildermyth, наоборот, игра в сеттинге типичного фэнтези: с крестьянами, рыцарями, демонами, орками и колдунами.\n" +
                                "Но это совсем не мешает ей быть удивительной, оригинальной и непредсказуемой.\n" +
                                "В ней столько необычных, но интересных механик, что поначалу можно даже запаниковать, но довольно скоро вместо ужаса начинаешь испытывать восторг.\n" +
                                "🔮🧙‍♂️9 из 10🧙‍♂️🔮</b>",
                                parseMode: ParseMode.Html);
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\тактика\\Gears Tactics.jpg";
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\tGears Tactics\n" +
                                "Gears Tactics – захватывающий и по-своему уникальный пошаговый боевик.\n" +
                                "Он идеально дополняет линейку фантастических экшенов из серии Gears, полностью соответствует ее духу и впечатляет динамикой, но вместе с тем бросает серьезнейший вызов интеллекту, внимательности и выдержке геймеров, словно какая-нибудь XCOM.\n" +
                                "🕹🗺9 из 10🗺🕹</b>",
                                parseMode: ParseMode.Html);
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\тактика\\xcom2.jpg";
                        Thread.Sleep(3000);
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>\t\tXCOM 2\n" +
                                "Земля изменилась. Двадцать лет прошло, с тех пор как мировые лидеры подписали акт о безоговорочной капитуляции перед пришельцами.\n" +
                                "Организация XCOM, последний рубеж обороны Земли, уничтожена, а её остатки рассеяны по миру.\n" +
                                "В XCOM 2 планетой правят пришельцы, застраивая её сверкающими городами и обещая человечеству безоблачное будущее.\n" +
                                "Однако инопланетяне втайне вынашивают зловещие планы и уничтожают всех, кто отказывается жить по новым правилам.\n" +
                                "🛸👾9 из 10👾🛸</b>",
                                parseMode: ParseMode.Html);
                        }
                        break;
                    //Пул Развлечение🎉 - "🏠интересные места🗻"
                    case "🏠интересные места🗻":
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\Интересные места\\Батутный центр Невесомость.jpg";
                        await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Давай-ка сходим погулять!Вот интересные места:");
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>Батутный центр \"Невесомость\"</b>",
                                parseMode: ParseMode.Html);
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.4925169, longitude: 36.2213831, title: "Батутный центр \"Невесомость\"", address: "ул. Генерала Попова, 3 (Спорткомплекс Рубин, этаж 1)");
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\Интересные места\\EXIT Квест.jpg";
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>EXIT Квест:Логово</b>",
                                parseMode: ParseMode.Html);
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.5153033, longitude: 36.2500973, title: "EXIT Квест:Логово", address: "ул. Кирова, 15, Калуга");
                        }
                        Photo = "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo\\Интересные места\\vision.jpg";
                        using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            await Botclient.SendPhotoAsync(
                                chatId: Messag.Chat.Id,
                                photo: new InputFileStream(fileStream),
                                caption: "<b>VISION | VR клуб | Виртуальная реальность Калуга</b>",
                                parseMode: ParseMode.Html);
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.5134904, longitude: 36.2503768, title: "VISION | VR клуб |", address: "ул. Достоевского, 29, Калуга");
                        }
                        break;

                    default:
                        break;
                }
            }
            
        }

        

        private static IReplyMarkup? GetButtons()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("Развлечение🎉"), new KeyboardButton("Путешествие🗺") , new KeyboardButton("Образование👨‍🎓") }
                }
            );
        }
        private static IReplyMarkup? GetButtons_for_entertainments()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("📀фильмы🎥"), new KeyboardButton("🕹игры🎮") , new KeyboardButton("🏠интересные места🗻") }
                }
            );
        }
        private static IReplyMarkup? GetButtons_for_journey()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("Развлечение2🎉"), new KeyboardButton("Путешествие2🗺") , new KeyboardButton("образование2👨‍🎓") }
                }
            );
        }
        private static IReplyMarkup? GetButtons_for_education()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("Развлечение2🎉"), new KeyboardButton("Путешествие2🗺") , new KeyboardButton("образование2👨‍🎓") }
                }
            );
        }
        private static IReplyMarkup? GetButtons_movie()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("🧛‍♂️хоррор🎃"), new KeyboardButton("🌌фантастика💫") , new KeyboardButton("🔍детектив🕵️‍♂️") }
                }
            );
        }
        private static IReplyMarkup? GetButtons_game()
        {
            return new ReplyKeyboardMarkup
            (
                new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton("💀боевик🔫"), new KeyboardButton("🏹тактика🗿") , new KeyboardButton("😵головоломки😵") }
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