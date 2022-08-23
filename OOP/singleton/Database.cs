using System;

namespace OOP.singleton
{
    public class Database
    {
        private static Database _database;
        private Database(){
            Console.WriteLine("Устанавливаю связь с БД");
        }

        public static Database GetDatabase()
        {
            if (_database == null)
            {
                _database = new Database();
            }

            return _database;
        }
    }
    

}