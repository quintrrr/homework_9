using file.classes;
using file.classes.games;
using file.enums;
using file.interfaces;

internal class Program
{
    public static void Main()
    {
        Task1();
    }

    public static void Task1()
    {
        /* На шоу Большие гонки собираются 4 команды из разных стран. В команде по 15 человек.
           Всего за одну игру команда проходит по 6 испытаний (6 разных игр). Будет неинтересно,
           если каждый раз игры будут одинаковыми, поэтому каждый раз игры разные. Главный
           организатор, Оливье Ганьян, добавляет новые игры. Необходимо правильно организовать
           классы, чтобы класс передачи «Большие Гонки» не изменял свой функционал, а добавлял
           новый. В консоли необходимо создать 4 команды: Россия, Франция, Китай и Казахстан, и
           чтобы они сыграли в 6 игр.
           Какие игры создать:
           1. Пляж
           2. Мышеловка
           3. Море
           4. Рыбалка
           5. Почтальоны
           6. Горка

           Также вам необходимо создать свою игру, но не изменяя класс, а расширяя функционал
           класса. Подумайте, какой паттерн нужно использовать. */
        BigRaces races = new BigRaces(new List<Team>(), new List<IGame>());
        Organizer organizer = new Organizer("Оливье Ганьян", races);
        Team russianTeam = new Team(Countries.Россия, new List<Player>
        {
            new("Александр Иванов"),
            new("Дмитрий Сидоров"),
            new("Сергей Петров"),
            new("Андрей Федоров"),
            new("Михаил Васильев"),
            new("Евгений Николаев"),
            new("Иван Смирнов"),
            new("Павел Кузнецов"),
            new("Николай Попов"),
            new("Артем Морозов"),
            new("Григорий Волков"),
            new("Юрий Лебедев"),
            new("Олег Киселев"),
            new("Максим Зайцев"),
            new("Виктор Титов")
        });

        Team frenchTeam = new Team(Countries.Франция, new List<Player>
        {
            new("Пьер Дюпонт"),
            new("Луи Лефевр"),
            new("Жан Жирар"),
            new("Андре Бонне"),
            new("Франсуа Дюваль"),
            new("Антуан Ришар"),
            new("Томас Лукас"),
            new("Лоран Фурнье"),
            new("Филипп Маршан"),
            new("Мишель Бертран"),
            new("Клеман Ламбер"),
            new("Арно Готье"),
            new("Жорж Мартен"),
            new("Кристоф Роже"),
            new("Эмиль Шевалье")
        });

        Team kasakhTeam = new Team(Countries.Казахстан, new List<Player>
        {
            new("Тимур Токтаров"),
            new("Ержан Жуманов"),
            new("Айбек Айтбаев"),
            new("Нурсултан Кабанов"),
            new("Даурен Нурсеитов"),
            new("Марат Омаров"),
            new("Ербол Ермеков"),
            new("Сабит Сардаров"),
            new("Алишер Аманов"),
            new("Кайрат Сеитов"),
            new("Мурат Рахметов"),
            new("Алтын Шарипов"),
            new("Жанат Жаксылыков"),
            new("Бахыт Кайратов"),
            new("Арман Абдрахманов")
        });

        Team chineseTeam = new Team(Countries.Китай, new List<Player>
        {
            new("Чен Ван"),
            new("Ли Чжао"),
            new("Сунь Дун"),
            new("Чжао Фу"),
            new("Чжан Хуа"),
            new("Лун Юань"),
            new("Цзинь Бо"),
            new("Гуан Мин"),
            new("Юань Линь"),
            new("Чжоу Ши"),
            new("Ма Тянь"),
            new("Хуан Лэй"),
            new("Фэн Сяо"),
            new("Ян Бэй"),
            new("Шэнь Ли")
        });
        
        organizer.Game.AddTeam(russianTeam);
        organizer.Game.AddTeam(frenchTeam);
        organizer.Game.AddTeam(kasakhTeam);
        organizer.Game.AddTeam(chineseTeam);
        
        organizer.Game.AddGame(new BeachGame());
        organizer.Game.AddGame(new MyGame());
        organizer.Game.AddGame(new MouseTrapGame());
        organizer.Game.AddGame(new PostmenGame());
        organizer.Game.AddGame(new SeaGame());
        organizer.Game.AddGame(new SlideGame());
        
        organizer.Game.Start();
    }
}