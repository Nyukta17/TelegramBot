using System;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TelegrammBot.Main;

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

            Button button = new Button();
            var Messag = update.Message;
            string Photo = get_way();
            string buffer = "";
            
            if (Messag != null) 
            {
                if (Messag.Text != null) 
                {
                 
                    Console.WriteLine(Messag.Chat.FirstName + $"({Messag.Chat.Id})" + ":" + Messag.Text);
                    switch (Messag.Text.ToLower())
                    {
                        case "/start":
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, @"Приветствую! Я бот-советник, помогу тебе советом.Напиши мне ""помоги советом""");
                            break;
                        case "помоги советом":
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Конечно! На какую тему?");
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Помогу советом на такие темы как", replyMarkup: button.GetButtons());
                            break;
                        //Самое начало
                        case "путешествие🗺":
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Помогу советом на такие темы как", replyMarkup: button.GetButtons_for_journey());
                            break;
                        case "образование👨‍🎓":
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Помогу советом на такие темы как", replyMarkup: button.GetButtons_for_education());
                            break;
                        case "развлечение🎉":
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Отлично! Давай помогу определиться. Что тебе нравится?", replyMarkup: button.GetButtons_for_entertainments());
                            break;
                        case "назад⬅":
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Сделаем шаг назад", replyMarkup: button.GetButtons());
                            break;
                            
                            break;
                        case "⬅назад":
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Cделаем шаг назад", replyMarkup:  button.GetButtons_for_entertainments());
                            break;
                        
                        //Пул Развлечение🎉 - "📀фильмы🎥"
                        case "📀фильмы🎥":
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "А какой жанр тебе подходит?", replyMarkup: button.GetButtons_movie());
                            break;
                        case "🧛‍♂️хоррор🎃":
                            Photo += "\\хорроры\\proch.jpg";

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
                            Photo = get_way();
                            Photo += "\\хорроры\\OHO.jpg";
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
                            Photo = get_way();
                            Photo += "\\хорроры\\Promitey.jpg";
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
                            Photo = get_way();
                            Photo += "\\фантастика\\interstellar.jpg";
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
                            Photo = get_way();
                            Photo += "\\фантастика\\Duna.jpg";
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
                            Photo = get_way();
                            Photo += "\\фантастика\\Ghost_int_he_Shell.jpg";
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
                            Photo = get_way();
                            Photo += "\\детективы\\Inferno.jpg";

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
                            Photo = get_way();
                            Photo += "\\детективы\\Ace_Ventura_wanted_pets.jpg";
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
                            Photo = get_way();
                            Photo += "\\детективы\\seven.jpg";
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
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Стало скучно? Давай-ка подберём игры на такие темы как😁", replyMarkup: button.GetButtons_game());
                            break;
                        case "💀боевик🔫":
                            Photo = get_way();
                            Photo += "\\боевик\\Dying_Light.jpg";

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
                            Photo = get_way();
                            Photo += "\\боевик\\Call-Of-Duty-Modern-Warfare-2.jpg";


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
                            Photo = get_way();
                            Photo += "\\боевик\\Overwatch.jpg";


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
                            Photo = get_way();
                            Photo += "\\головоломки\\Portal-2.jpg";
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
                            Photo = get_way();
                            Photo += "\\головоломки\\Machinarium.jpg";
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
                            Photo = get_way();
                            Photo += "\\головоломки\\Unravel.jpg";
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
                            Photo = get_way();
                            Photo += "\\тактика\\Wildermyth.jpg";
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
                            Photo = get_way();
                            Photo += "\\тактика\\Gears Tactics.jpg";
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
                            Photo = get_way();
                            Photo += "\\тактика\\xcom2.jpg";
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
                            Photo = get_way();
                            Photo += "\\Интересные места\\Батутный центр Невесомость.jpg";
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Давай-ка сходим погулять!Вот интересные места:");
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {
                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Батутный центр \"Невесомость\"</b>",
                                    parseMode: ParseMode.Html);
                                await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.49212873923435, longitude: 36.220911968357271, title: "Батутный центр \"Невесомость\"", address: "ул. Генерала Попова, 3 (Спорткомплекс Рубин, этаж 1)");
                            }
                            Photo = get_way();
                            Photo += "\\Интересные места\\EXIT Квест.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {
                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>EXIT Квест:Логово</b>",
                                    parseMode: ParseMode.Html);
                                await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.51553300685988, longitude: 36.25108707516181, title: "EXIT Квест:Логово", address: "ул. Кирова, 15, Калуга");
                            }
                            Photo = get_way();
                            Photo += "\\Интересные места\\vision.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {
                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>VISION | VR клуб | Виртуальная реальность Калуга</b>",
                                    parseMode: ParseMode.Html);
                                await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.512219141564564, longitude: 36.253490525150625, title: "VISION | VR клуб |", address: "ул. Достоевского, 29, Калуга");
                            }
                            break;
                        //Пул Путешествие🗺
                        case "в калуге🌍🚀":
                            Photo = get_way();
                            Photo += "\\Калуга\\kaluga.jpg";
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Отлично! Давай покажу тебе Город😁");
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Калуга — красивый древний город, который расположен на холмах вдоль реки Ока. Уже на въезде вас встретят корабельные сосны и стела с изображением Гагарина, устремлённая ввысь, к мечтам и звёздам. Всё в городе дышит космической темой: здесь более 40 лет жил и работал отец русской космонавтики Константин Эдуардович Циолковский.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Советую Посетить");
                            Thread.Sleep(1000);
                            Photo = get_way();
                            Photo += "\\Калуга\\Muzey_cosmonaftici.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Музей космонавтики\n" +
                                    "Музей совсем не скучный и для детей, и для взрослых. Здесь можно даже купить настоящее космическое питание — например, борщ из тюбика, разогретый космогрелкой. Это самое популярное блюдо, но ассортимент очень широкий — есть даже шаурма и торт «Москва». Ещё можно опробовать симулятор стыковки космического корабля — это стоит 200 рублей, сеансы проводят каждые 15 минут. Можно посмотреть на небесные объекты в телескоп астрономической обсерватории, но только в ясную погоду.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.5171892117552, longitude: 36.23066380623499, title: "Музей космонавтики", address: "ул. Академика Королева, 2, Калуга, Калужская обл., 248000");
                            Thread.Sleep(2000);
                            Photo = get_way();
                            Photo += "\\Калуга\\parck.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Городской парк\n" +
                                    "Парк в Калуге маленький, но очень приличный. Внутри — смотровая площадка с видом на Оку, Свято-Троицкий кафедральный собор и старый фонтан с таинственной незнакомкой под зонтиком. История этой барышни уходит в 1809 год, когда калужский купец Макаров привёз скульптуру девочки с зонтиком из Будапешта и подарил её городу. Скульптуру несколько раз похищали, разрушали, сдавали на металл. Исторический облик фонтану вернули только в 2010 году.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.50751348469984, longitude: 36.25075558235559, title: "Городской парк", address: "пл. Старый Торг, 5, Калуга, Калужская обл., 248000");
                            Thread.Sleep(2000);
                            Photo = get_way();
                            Photo += "\\Калуга\\skamia.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Гигантская скамейка\n" +
                                    "Эта скамейка в шесть раз больше обычной. Отличный шанс почувствовать себя лилипутом в стране великанов, полюбоваться на Оку и сделать забавные фотографии.\r\n\r\nНеобычный арт-объект расположен на площадке у памятника 600-летию Калуге.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.51081389425695, longitude: 36.23554889350016, title: "Гигантская скамейка", address: "Смоленский пер., 4, Калуга, Калужская обл., 248000");
                            break;
                        case "в москве🏙":
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Отлично! Давай покажу тебе Город😁");
                            Photo = get_way();
                            Photo += "\\Москва\\Moscow.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Москва — это город, в котором уживаются средневековые улочки XVI века и небоскрёб с самой высокой смотровой площадкой Европы, где в бывшем хрустальном заводе или шоколадной фабрике создают креативные пространства, а светский клуб — это не лимузин и фрак, а кино в ночи и танцы под винил.\r\n\r\nВ столице почти 450 музеев и около 10 000 ресторанов, кафе и баров. В десятках парков можно угоститься вкусным кофе и фирменными пончиками. Или посетить международные выставки, соревнования и марафоны. И это очень нравится 12 миллионам москвичей и 20 миллионам туристов, которые ежегодно посещают самый большой российский город. Для поездки удобнее всего бронировать отели заранее на Яндекс Путешествиях.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Советую Посетить");
                            Thread.Sleep(1000);
                            Photo = get_way();
                            Photo += "\\Москва\\Парящий мост в Парке Зарядье.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Парящий мост в Парке Зарядье\n" +
                                    "Парк Зарядье, построенный на месте гостиницы «Россия», задумывали как «парк настоящего будущего»Природные зоны и ботанические коллекции, детские научные программы в лабораториях, виртуальный «Полёт над Россией» над самыми красивыми уголками страны и экскурс в прошлое на «Машине времени» в Медиахолле с круговым экраном, аттракцион из снега и светомузыки в «Ледяной пещере».Это не только необычное зрелище, но и великолепные панорамные фото Москвы. Видны Кремль, сталинская высотка на Яузских воротах, река с прогулочными корабликами, в ясную погоду видна ещё одна высотка — здание МИДа.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 55.749586824304245, longitude: 37.62945386874243, title: "Парящий мост в Парке Зарядье", address: "Москворецкая наб., Москва, 109012");
                            Thread.Sleep(2000);
                            Photo = get_way();
                            Photo += "\\Москва\\ГЭС 2.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>ГЭС-2: современное искусство\n" +
                                    "Бывшая электростанция на Болотной набережной после реконструкции стала средоточием современного искусства, разных направлений и проявлений. Пусть название «Дом культуры» не вводит в заблуждение посетителей — ничего общего с советским Домом культуры из «Карнавальной ночи» ГЭС-2 не имеет.Это не столько музей, сколько постоянно меняющее резидентов пространство. Здесь проходят выставки, однако визуальное искусство — не единственный формат Дома культуры ГЭС-2. Экспериментальный балет и стендап, рейв и возможность понаблюдать за 100-дневным перформансом, во время которого снимают 100 серий «Санта Барбары» на русском языке.\r\n\r\nСоздание ГЭС-2 не обошлось без инноваций: 5500 кв. м солнечных батарей и огромная стеклянная крыша, уникальная система полива берёзовой рощи и 80 тысяч кустарников на искусственном холме.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 55.74261581514436, longitude: 37.6129874399913, title: "ГЭС-2: современное искусство", address: "Болотная набережная, вл. 15, корп. 1, Болотная наб., 15 строение 9, 2,4, Москва, 119072");
                            Thread.Sleep(2000);
                            Photo = get_way();
                            Photo += "\\Москва\\Парк Горького.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Парк Горького: отдых на природе\n" +
                                    "Парку почти сто лет, и он постоянно развивается, собирая современные варианты отдыха и развлечений. Здесь многое было впервые: народная обсерватория и светомузыкальный фонтан, бесплатный Wi-Fi на всей территории парка и виртуальный прыжок с парашютной вышки.В Парке Горького гуляют, занимаются спортом и танцами, участвуют в научных концертах и литературных дуэлях в павильоне «Школа», посещают обсерватории и лектории.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 55.72959722891101, longitude: 37.60126782262783, title: "Парк Горького", address: "ул. Крымский Вал, 9 строение 61, Москва, Московская обл., 119049");

                            break;
                        case "в туле🎫":
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Отлично! Давай покажу тебе Город😁");
                            Photo = get_way();
                            Photo += "\\Тула\\Тула.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Тула\n" +
                                    "Тула — один из старейших городов России (в 2021 году ей исполнилось 875 лет). Самые очевидные ассоциации с ней — оружие, самовары, Лев Толстой и пряники. Туляки относятся к ним с любовью и лёгкой иронией и при случае обыгрывают в граффити, сувенирах и забавных памятниках.\r\n\r\nИзначально Тула была городом-крепостью, защищавшей Россию от набегов крымских татар, а позже стала торгово-промышленным центром. Сейчас город делает ставку на успешный апгрейд исторического и культурного наследия, и наблюдать за этой трансформацией чрезвычайно интересно.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Советую Посетить");
                            Thread.Sleep(1000);
                            Photo = get_way();
                            Photo += "\\Тула\\Тульский кремль.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Тульский кремль\n" +
                                    " Сейчас на территории кремля находятся Свято-Успенский (1762–1764) и Богоявленский (1855–1862) соборы и торговые ряды, где продаются сувениры и расположен небольшой Музей международного пряника. В музее можно самостоятельно сделать и раскрасить пряничного человечка или лошадку, или купить вырубку для домашних пряников. Есть несколько тематических экскурсий (стоимость — от 350 ₽).</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.195299521326035, longitude: 37.620106416204706, title: "Тульский кремль", address: "Менделеевская ул., 12б, Тула, Тульская обл., 300041");
                            Thread.Sleep(2000);
                            Photo = get_way();
                            Photo += "\\Тула\\Музей Старая тульская аптека.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Музей «Старая тульская аптека»\n" +
                                    "Аптеку с ледниками в подвале и чердаком для сушки трав открыл провизор Фердинанд Белявский в 1884 году, и она долгое время считалась одной из лучших в городе. Сейчас здесь находится музей, где воссоздан типовой аптечный зал XIX века. Есть приспособления для пускания крови, старинные бланки рецептов, стеклянные пузырьки, в которых когда-то хранились препараты с кокаином, опиумом, морфием и сладкая спиртовая настойка для детей, так называемый киндербальзам. Главная гордость музея — блоха, которую подковал золотыми подковками тульский токарь, мастер микроминиатюры Николай Алдунин. А в одном из залов работает выставка, посвящённая первым владельцам аптеки.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.19014561651427, longitude: 37.61450534170273, title: "Музей «Старая тульская аптека»", address: "пр. Ленина, 27, Тула, Тульская обл., 300041");
                            Thread.Sleep(2000);
                            Photo = get_way();
                            Photo += "\\Тула\\Тульский государственный музей оружия.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "<b>Тульский государственный музей оружия\n" +
                                    "Статус оборонительного рубежа и природные запасы бурого железняка способствовали развитию оружейного дела. В 1712 году по указу Петра I в Туле открылся оружейный завод, а в 1873 году — музей оружия.\r\n\r\nВ «Шлеме» расположена постоянная экспозиция «История стрелкового и холодного оружия с XIV века до современности». Она включает в себя не только экспозиции привычного формата, но и мультимедийные комплексы с электронными экскурсоводами. Есть интерактивные зоны для детей, где можно примерить военную форму и собрать автомат. А в страйкбольном тире посетители могут пострелять из копий реального боевого оружия, аналогичного по габаритам и весу.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendVenueAsync(Messag.Chat.Id, latitude: 54.20423883397419, longitude: 37.61599168579931, title: "Тульский государственный музей оружия", address: "ул. Октябрьская, 2, Тула, Тульская обл., 300041");
                            break;
                        // Пул Образование👨‍🎓
                        case "📚документалки📖":
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "Давай-ка расширим твой кругозор!Попробуй посмотреть эти документалки");
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "https://www.youtube.com/watch?v=2hL9bzs7yZw");
                            Thread.Sleep(2000);
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "https://www.youtube.com/watch?v=YLeXoLX_AjM&t=1746s");
                            Thread.Sleep(2000);
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "https://www.youtube.com/watch?v=spgR3gENfnw");
                            break;
                        case "👩‍🎓учебные заведения👨‍🎓":
                            
                            Photo = get_way();
                            Photo += "\\Учебноые заведения\\Калужский государственный университет им. К.Э. Циолковского.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "Калужский государственный университет им. К.Э. Циолковского<b>" +
                                    "Калужский государственный педагогический институт был организован на базе учительского института в соответствии с распоряжением Совета Министров СССР от 17.02.1948 года № 1741-р и распоряжением Совета Министров РСФСР от 25.02.1948 № 242-р.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendVenueAsync(chatId: Messag.Chat.Id, 54.509109904440685, 36.272622806346114, title: "Калужский государственный университет им. К.Э. Циолковского", address: "улица Степана Разина, 26, Калуга, Калужская обл., 248023");
                            Thread.Sleep(2000);
                            
                            Photo = get_way();
                            Photo += "\\Учебноые заведения\\Калужский филиал МГТУ имени Н. Э. Баумана.jpg";
                            using (var fileStream = new FileStream(Photo, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                await Botclient.SendPhotoAsync(
                                    chatId: Messag.Chat.Id,
                                    photo: new InputFileStream(fileStream),
                                    caption: "Калужский филиал МГТУ имени Н. Э. Баумана<b>" +
                                    "Высшее учебное заведение, один из филиалов Московского государственного технического университета имени Н. Э. Баумана, расположенный в городе Калуга.\r\n\r\nПолное наименование: Калужский филиал федерального государственного бюджетного образовательного учреждения высшего образования «Московский государственный технический университет имени Н. Э. Баумана (национальный исследовательский университет)».В 1959 году по приказу Министерства высшего образования СССР № 441 от 20 апреля 1959 года с 1 августа этого же года в Калуге был организован вечерний факультет Московского высшего технического училища им. Н. Э. Баумана, впоследствии преобразованный в Калужский филиал МГТУ им. Н. Э. Баумана. Первым руководителем факультета назначен кандидат технических наук, доцент Сутырин Глеб Васильевич. В мае 1959 года для размещения факультета было выделено строящееся четырёхэтажное здание по улице Советской (ныне улица Ленина), предназначавшееся для техникума пищевой промышленности.</b>",
                                    parseMode: ParseMode.Html);

                            }
                            await Botclient.SendVenueAsync(chatId: Messag.Chat.Id, 54.508119966167335, 36.248023541963555, title: "Калужский филиал МГТУ имени Н. Э. Баумана", address: "ул. Баженова, 2, Калуга, Калужская обл., 248");
                            
                            break;
                       
                        default:
                            await Botclient.SendTextMessageAsync(Messag.Chat.Id, "не понимаю вас");
                            break;
                    }
                }
                
            }
            

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
            return new TelegramBotClient("7453668670:AAE8kv670SsYRcpqNU5VnsC5j0RDPlQOGM8");
        }
        static string get_way() 
        {
            return "C:\\Users\\User\\source\\repos\\TelegrammBot\\TelegrammBot\\photo";
        }
    }
}