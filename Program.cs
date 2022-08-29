using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ChangeCharacterName = "Имя";
            const string ChangeCharacterGender = "Пол";
            const string ChangeCharacterAge = "Возраст";
            const string ChangeCharacterAbility = "Способность";
            const string DisplayCharacterInfo = "О персонаже";
            const string Exit = "Выйти";
            string characterName = null;
            string characterGender = null;
            string characterAge = null;
            string characterAbility = null;         
            string answer=null;

            Console.WriteLine("Загрузка редактора персонажа...");
            Console.WriteLine("Загрузка завершена");
            Console.WriteLine("Измените (Имя/Пол/Возраст/Способность) персонажа. Дополнительно: (О персонаже/Выйти)");

            while (answer != Exit)
            {
                answer = Console.ReadLine();

                switch (answer)
                {
                    case ChangeCharacterName:
                        answer = null;
                        Console.WriteLine("-введите имя-");
                        answer = Console.ReadLine();
                        characterName = answer;
                        Console.WriteLine("Теперь имя персонажа - " + characterName);
                        break;

                    case ChangeCharacterGender:
                        answer = null;
                        Console.WriteLine("-укажите пол персонажа-");
                        answer = Console.ReadLine();
                        characterGender = answer;
                        Console.WriteLine("Теперь пол персонажа - " + characterGender);
                        break;

                    case ChangeCharacterAge:
                        answer = null;
                        Console.WriteLine("-введите возраст-");
                        answer = Console.ReadLine();
                        characterAge = answer;
                        Console.WriteLine("Теперь возраст персонажа - " + characterAge);
                        break;

                    case ChangeCharacterAbility:
                        answer = null;
                        Console.WriteLine("-придумайте способность персонажа-");
                        answer = Console.ReadLine();
                        characterAbility = answer;
                        Console.WriteLine("Теперь способность персонажа - " + characterAbility);
                        break;

                    case DisplayCharacterInfo:                       
                        Console.WriteLine("Информация по персонажу: Имя - {0}, Пол - {1}, Возраст - {2}, Способность - {3}", characterName, characterGender, characterAge, characterAbility);
                        break;
                }
            }

            Console.Clear();
        }
    }
}
