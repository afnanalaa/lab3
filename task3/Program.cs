using System;
namespace task3
{
    #region problem1
    //class student
    //{
    //    string name;
    //    int age;
    //    int id;
    //    public void setdata(string Name, int Id, int Age)
    //    {
    //        string name = Name;
    //        int age = Age;
    //        int id = Id;
    //    }
    //    public void getdata()
    //    {
    //        Console.WriteLine($""" your name is : {name} and your age is : {age} and your id is : {id} ");
    //    }

    //    public string graduted()
    //    {
    //        if (age > 24)
    //            return "he is graduted ";
    //        return "he is not  graduted";
    //    }
    //}
    #endregion


    #region problem2
    //class student(string name, int id, int age)
    //{
    //    static student()
    //    {
    //        Console.WriteLine("hello");
    //    }
    //    public void print()
    //    {
    //        Console.WriteLine($" your name is : {name} and your age is : {age} and your id is : {id} ");
    //    }
    //}
    #endregion


    class book
    {
        String name;
        int id;
        string type;
        DateTime createdon;
        bool isdeleted;
        double price;
        string categoryname;
        static int count = 0;

        public int getcount()
        {
            return count;
        }
        public void setdata1(string Name, int Id)
        {
            this.name = Name;
            this.id = Id;
            count++;
        }
        public void setdata2(string Name, int Id, String Type, DateTime Createdon)
        {
            this.name = Name;
            this.id = Id;
            this.type = Type;
            this.createdon = Createdon;
            count++;

        }
        public void setdata3(string Name, int Id, String Type, DateTime Createdon, double Price)
        {
            this.name = Name;
            this.id = Id;
            this.type = Type;
            this.createdon = Createdon;
            this.price = Price;
            count++;
        }
        public void setdata4(string Name, int Id, String Type, DateTime Createdon, double Price, String Categoryname)
        {
            this.name = Name;
            this.id = Id;
            this.type = Type;
            this.createdon = Createdon;
            this.price = Price;
            this.categoryname = Categoryname;
            count++;

        }
        public void getdatabook()
        {
            Console.WriteLine($" your name is : {name} and your id is : {id} and  the type is:{type} ");
            Console.WriteLine($" this book created on : {createdon} and the price is : {price} and the category name is : {categoryname} ");

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            //student stud1 = new student("name1", 1, 23);
            //student stud2 = new student("name2", 2, 21);
            //student stud3 = new student("name3", 3, 24);
            //student stud4 = new student("name4", 4, 44);

            //stud1.print();
            //stud2.print();
            //stud3.print();
            #endregion

            #region problem2
            // student stud1 = new student();
            // stud1.setdata("afnan", 1, 21);
            // stud1.getdata();
            //Console.WriteLine( stud1.graduted());
            #endregion

            #region task 
            book book1 = new book();
            book book2 = new book();
            book book3 = new book();
            book book4 = new book();
            book1.setdata1("book1", 1);
            book1.setdata2("book1", 1, "type1", DateTime.Now);
            book2.setdata3("book2", 2, "type2", DateTime.Now, 120);
            book3.setdata4("book3", 3, "type3", DateTime.Now, 223.5, "cat1");
            book4.setdata4("book3", 4, "type4", DateTime.Now, 255.75, "cat4");
            book4.setdata1("book4", 4);
            book1.getdatabook();
            book2.getdatabook();
            book3.getdatabook();
            book4.getdatabook();
            Console.WriteLine(book1.getcount());
            Console.WriteLine(book2.getcount());
            Console.WriteLine(book3.getcount());
            Console.WriteLine(book4.getcount());

            #endregion 

        }
    }
}