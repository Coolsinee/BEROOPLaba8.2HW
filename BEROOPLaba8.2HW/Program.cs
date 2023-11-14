using BEROOPLaba8._2HW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEROOPLaba8._2HW
{
    class Song
    {
        string name;
        string author;
        Song prev;

        // Конструктор по умолчанию
        public Song()
        {
            name = "Unknown";
            author = "Unknown";
            prev = null;
        }

        // Конструктор с параметрами name и author
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
            prev = null;
        }

        // Конструктор с параметрами name, author и предыдущая песня
        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void SetPrev(Song prev)
        {
            this.prev = prev;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Название песни: {name}");
            Console.WriteLine($"Автор песни: {author}");
        }

        public string Title()
        {
            return $"{name} - {author}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song other = (Song)obj;
            return name == other.name && author == other.author;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект mySong с использованием первого конструктора (по умолчанию)
            Song mySong1 = new Song();
            Ы
            // Создаем объект mySong с использованием второго конструктора (с указанием названия и автора)
            Song mySong2 = new Song("Песня 2", "Автор 2");

            // Создаем объект mySong с использованием третьего конструктора (с указанием названия, автора и предыдущей песни)
            Song prevSong = new Song("Песня 0", "Автор 0");
            Song mySong3 = new Song("Песня 2", "Автор 2", prevSong);

            // Выводим информацию о песнях
            Console.WriteLine("Информация о песне 1:");
            mySong1.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Информация о песне 2:");
            mySong2.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Информация о песне 3:");
            mySong3.PrintInfo();
            Console.WriteLine();

            // Сравниваем первую и вторую песни
            if (mySong2.Equals(mySong3))
            {
                Console.WriteLine("Первая и вторая песни идентичны.");
            }
            else
            {
                Console.WriteLine("Первая и вторая песни различны.");
            }
        }
    }
}
