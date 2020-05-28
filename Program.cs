using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Sokolova_BD
{
    /// <summary>
    /// Интерфейс с методами баз данных
    /// </summary>
    interface Database
    {
        /// <summary>
        /// Метод выборки
        /// </summary>
        void Select();

        /// <summary>
        /// Метод вставки
        /// </summary>
        void Insert();

        /// <summary>
        /// Метод обновления в таблице
        /// </summary>
        void Update();

        /// <summary>
        /// Метод удаления в таблице
        /// </summary>
        void Delete();

        /// <summary>
        /// Метод удаления в схеме
        /// </summary>
        void Drop();

        /// <summary>
        /// Метод создания
        /// </summary>
        void Create();

        /// <summary>
        /// Метод обновления в схеме
        /// </summary>
        void Alter();

        /// <summary>
        /// Метод подтверждения транзакций
        /// </summary>
        void Commit();

        /// <summary>
        /// Метод отката транзакций
        /// </summary>
        void Rollback();

    }

    /// <summary>
    /// Класс управления
    /// </summary>
    class Client
    {
        /// <summary>
        /// База данных
        /// </summary>
        Database mydb;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="db">База данных</param>
        public Client(Database db)
        {
            mydb = db;
        }


        /// <summary>
        /// Функция, считывающая нужный метод и вызывающая его
        /// </summary>
        /// <param name="opName">Название базы данных</param>
        public void GetOperation(string opName)
        {
            opName = opName.ToLower();
            switch (opName)
            {
                case "select":
                    mydb.Select();
                    break;
                case "insert":
                    mydb.Insert();
                    break;
                case "update":
                    mydb.Update();
                    break;
                case "delete":
                    mydb.Delete();
                    break;
                case "drop":
                    mydb.Drop();
                    break;
                case "create":
                    mydb.Create();
                    break;
                case "alter":
                    mydb.Alter();
                    break;
                case "commit":
                    mydb.Commit();
                    break;
                case "rollback":
                    mydb.Rollback();
                    break;
                default:
                    throw new ArgumentException($"Ошибка! Операции {opName} не существует");

            }
        }
    }

    /// <summary>
    /// Класс базы данных Oracle
    /// </summary>
    class Oracle : Database
    {
        public void Select()
        {
            Console.WriteLine("Select in Oracle");
        }
        public void Insert()
        {
            Console.WriteLine("Insert in Oracle");
        }
        public void Update()
        {
            Console.WriteLine("Update in Oracle");
        }
        public void Delete()
        {
            Console.WriteLine("Delete in Oracle");
        }
        public void Drop()
        {
            Console.WriteLine("Drop in Oracle");
        }
        public void Create()
        {
            Console.WriteLine("Create in Oracle");
        }
        public void Alter()
        {
            Console.WriteLine("Alter in Oracle");
        }
        public void Commit()
        {
            Console.WriteLine("Commit in Oracle");
        }
        public void Rollback()
        {
            Console.WriteLine("Rollback in Oracle");
        }
    }

    /// <summary>
    /// Класс базы данных MySQL
    /// </summary>
    class MySQL : Database
    {
        public void Select()
        {
            Console.WriteLine("Select in MySQL");
        }
        public void Insert()
        {
            Console.WriteLine("Insert in MySQL");
        }
        public void Update()
        {
            Console.WriteLine("Update in MySQL");
        }
        public void Delete()
        {
            Console.WriteLine("Delete in MySQL");
        }
        public void Drop()
        {
            Console.WriteLine("Drop in MySQL");
        }
        public void Create()
        {
            Console.WriteLine("Create in MySQL");
        }
        public void Alter()
        {
            Console.WriteLine("Alter in MySQL");
        }
        public void Commit()
        {
            Console.WriteLine("Commit in MySQL");
        }
        public void Rollback()
        {
            Console.WriteLine("Rollback in MySQL");
        }
    }

    /// <summary>
    /// Класс базы данных PostgreSQL
    /// </summary>
    class PostgreSQL : Database
    {
        public void Select()
        {
            Console.WriteLine("Select in PostgreSQL");
        }
        public void Insert()
        {
            Console.WriteLine("Insert in PostgreSQL");
        }
        public void Update()
        {
            Console.WriteLine("Update in PostgreSQL");
        }
        public void Delete()
        {
            Console.WriteLine("Delete in PostgreSQL");
        }
        public void Drop()
        {
            Console.WriteLine("Drop in PostgreSQL");
        }
        public void Create()
        {
            Console.WriteLine("Create in PostgreSQL");
        }
        public void Alter()
        {
            Console.WriteLine("Alter in PostgreSQL");
        }
        public void Commit()
        {
            Console.WriteLine("Commit in PostgreSQL");
        }
        public void Rollback()
        {
            Console.WriteLine("Rollback in PostgreSQL");
        }
    }

    class Program
    {
        /// <summary>
        /// Функция, считывающая название базы данных и создающая соответствующий объект
        /// </summary>
        /// <param name="dbName">Название базы данных</param>
        public static Database GetDatabase(string dbName)
        {
            Database db;
            switch (dbName.ToLower())
            {
                case "mysql":
                    db = new MySQL();
                    break;
                case "oracle":
                    db = new Oracle();
                    break;
                case "postgre":
                    db = new PostgreSQL();
                    break;
                default:
                    throw new ArgumentException($"Ошибка! Базы данных {dbName} не существует");
            }
            return db;
        }
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split(' ');                
                Client cl = new Client(GetDatabase(inputArr[0].ToLower()));
                string oper;
                for (int i = 1; i < inputArr.Length; i++)
                {
                    oper = inputArr[i];
                    cl.GetOperation(oper);
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                return;
            }
            

        }
    }
}
