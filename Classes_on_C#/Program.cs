using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        bool work = true;
        List<Human> people = new List<Human>();

        while (work)
        {
            Console.WriteLine("----Лабораторная работа №2 ---\t");
            Console.WriteLine("-------------Задание 1--------\t");
            Console.WriteLine(" 1.Имена\t");
            Console.WriteLine("-------------Задание 2--------\t");
            Console.WriteLine(" 2.Человек с именем\t");
            Console.WriteLine(" 3.Человек с родителем\t");
            Console.WriteLine("-------------Задание 3--------\t");
            Console.WriteLine(" 4.Города\t");
            Console.WriteLine("-------------Задание 4--------\t");
            Console.WriteLine(" 5.Создаем Имена\t");
            Console.WriteLine(" 6.Создаем Человека\t");
            Console.WriteLine("-------------Задание 5--------\t");
            Console.WriteLine(" 7.Кот мяукает\t");
            Console.WriteLine("----------Дополнительно-------\t");
            Console.WriteLine(" 8.Создать своего человека\t");
            Console.WriteLine(" 9.Показать созданных людей\t");
            Console.WriteLine("0.Выход");

            int choice = Check.InputInt("Введите номер задачи:");

            switch (choice)
            {
                case 0:
                    work = false;
                    break;

                case 1:
                    {
                        Name[] names =
                        {
                            new Name("Клеопатра"),
                            new Name("Александр", "Пушкин", "Сергеевич"),
                            new Name("Владимир", "Маяковский")
                        };

                        Console.WriteLine("Результат: ");
                        for (int i = 0; i < names.Length; i++)
                        {
                            Console.WriteLine(names[i]);
                        }
                        break;
                    }

                case 2:
                    {
                        Human human1 = new Human(new Name("Клеопатра"), 152);
                        Human human2 = new Human(new Name("Александр", "Пушкин", "Сергеевич"), 167);
                        Human human3 = new Human(new Name("Владимир", "Маяковский"), 189);

                        Console.WriteLine("Результат: ");
                        Console.WriteLine(human1);
                        Console.WriteLine(human2);
                        Console.WriteLine(human3);
                        break;
                    }

                case 3:
                    {
                        Human ivan = new Human(new Name("Иван", "Чудов"), 180);
                        Human petr = new Human(new Name("Пётр", "Чудов"), 178);
                        Human boris = new Human(new Name("Борис"), 175);

                        petr.Father = ivan;
                        boris.Father = petr;

                        Console.WriteLine("Результат: ");
                        Console.WriteLine(ivan);
                        Console.WriteLine(petr);
                        Console.WriteLine(boris);
                        break;
                    }

                case 4:
                    {
                        City a = new City("A");
                        City b = new City("B");
                        City f = new City("F");
                        City c = new City("C");
                        City d = new City("D");
                        City e = new City("E");

                        City.Connect(a, b, 5);
                        a.AddRoute(f, 1);
                        f.AddRoute(b, 1);
                        City.Connect(f, e, 2);
                        City.Connect(b, c, 3);
                        City.Connect(c, d, 4);
                        d.AddRoute(e, 2);
                        City.Connect(a, d, 6);

                        City[] cities = { a, b, c, d, e, f };

                        Console.WriteLine("Результат: ");
                        for (int i = 0; i < cities.Length; i++)
                        {
                            Console.WriteLine(cities[i]);
                        }

                        string cityName = Check.InputString("Введите название города (от A до F):");
                        bool isFound = false;

                        Console.Write("Результат: ");
                        for (int i = 0; i < cities.Length; i++)
                        {
                            if (string.Equals(cities[i].Name, cityName, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(cities[i]);
                                isFound = true;
                            }
                        }

                        if (!isFound)
                        {
                            Console.WriteLine("Такого города нет");
                        }
                        break;
                    }

                case 5:
                    {
                        Name[] names =
                        {
                            new Name("Клеопатра"),
                            new Name("Александр", "Пушкин", "Сергеевич"),
                            new Name("Владимир", "Маяковский"),
                            new Name("Христофор", "Бонифатьевич")
                        };

                        Console.WriteLine("Результат: ");
                        for (int i = 0; i < names.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {names[i]}");
                        }
                        break;
                    }

                case 6:
                    {
                        Human lev = new Human("Лев", 170);
                        Human sergey = new Human(new Name("Сергей", "Пушкин"), 168, lev);
                        Human alexander = new Human("Александр", 167, sergey);

                        Console.WriteLine("Результат: ");
                        Console.WriteLine(lev);
                        Console.WriteLine(sergey);
                        Console.WriteLine(alexander);
                        break;
                    }

                case 7:
                    {
                        Cat barsik = new Cat("Барсик");

                        Console.WriteLine("Результат: ");
                        Console.WriteLine(barsik);
                        barsik.Meow();
                        barsik.Meow(3);

                        Console.WriteLine("Создайте своего кота");
                        string catName = Check.InputString("Введите имя кота:");
                        int count = Check.InputInt("Введите, сколько раз мяукнуть (от 1 до 20):", 1, 20);
                        Cat cat = new Cat(catName);

                        Console.WriteLine("Результат: ");
                        Console.WriteLine(cat);
                        cat.Meow();
                        cat.Meow(count);
                        break;
                    }

                case 8:
                    {
                        string firstname = Check.InputString("Введите имя:");
                        string surname = Check.InputOptionalString("Введите фамилию (Enter - пропустить):");
                        string middlename = Check.InputOptionalString("Введите отчество (Enter - пропустить):");
                        int height = Check.InputInt("Введите рост (от 1 до 250):", 1, 250);
                        Human father = null;

                        if (people.Count > 0)
                        {
                            Console.WriteLine("Созданные люди:");
                            for (int i = 0; i < people.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {people[i]}");
                            }

                            int number = Check.InputInt("Введите номер отца (0 - без отца):", 0, people.Count);
                            if (number > 0)
                            {
                                father = people[number - 1];
                            }
                        }

                        Human human = new Human(new Name(firstname, surname, middlename), height, father);
                        people.Add(human);

                        Console.Write("Результат: ");
                        Console.WriteLine(human);
                        break;
                    }

                case 9:
                    {
                        if (people.Count == 0)
                        {
                            Console.WriteLine("Пока никого нет, создайте человека в пункте 8");
                        }
                        else
                        {
                            Console.WriteLine("Результат: ");
                            for (int i = 0; i < people.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {people[i]}");
                            }
                        }
                        break;
                    }

                default:
                    {
                        ConsoleColor previousColor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет такой задачи, введите другой номер задачи!");
                        Console.ForegroundColor = previousColor;
                        break;
                    }
            }

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
            Console.WriteLine("\n");
        }
    }
}
