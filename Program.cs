using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Sokolova_BD
{
    interface Database
    {
        void Select();
        void Insert();
        void Update();
        void Delete();
        void Drop();
        void Create();
        void Alter();
        void Commit();
        void Rollback();

    }

    class Client
    {
        Database mydb;
        public Client(Database db)
        {
            mydb = db;
        }

        public void GetOperation(string dbName)
        {
            dbName = dbName.ToLower();
            switch (dbName)
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

            }
        }
    }
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
        static void Main(string[] args)
        {
        }
    }
}
