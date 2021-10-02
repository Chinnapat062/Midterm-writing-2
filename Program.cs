using System;
using System.Collections.Generic;
namespace ข้อ_2_กลางภาค_ห้องสมุด
{
    enum Menu
    {
       Login = 1,
       Register,
    }
    enum RegisterChoose
    {
        Student = 1,
        Employee,
    }
    enum Bookmenu
    {
        borrow = 1, 
    }
  ///Class person   
    class person 
    {
        public string Name;
        public string Password;
        

        public person(string name, string pass)
        {
            this.Name = name;
            this.Password = pass;
        }
        
        public string GetName()
        {
            return this.Name;
        }
        public string GetPass()
        {
            return this.Password;
        }
        
    }
    
  ///Class Student
    class Student : person
    {
        public string StudentID;
        public List<Student> studentlist;

        public Student(string name, string pass, string studentid) : base(name, pass)
        {
            this.StudentID = studentid;
            studentlist = new List<Student>();
        }
        public void addstudent(Student studentlists)
        {
            studentlist.Add(studentlists);
        }
        public void getstudentname()
        {
            studentlist.ForEach(value => { Console.WriteLine(value.Name); });
        }
        public void getstudentpass()
        {
            studentlist.ForEach(value => { Console.WriteLine(value.Password); });
        }
    }
    
    /// Class Employee
    class Employee : person
    {
        public string EmployeeID;
        public List<Employee> employeelist;

        public Employee(string name, string pass, string employeeid) : base(name, pass)
        {
            this.EmployeeID = employeeid;
            employeelist = new List<Employee>();
        }
        public void addEmployee(Employee employeelists)
        {
            employeelist.Add(employeelists);
        }
        public void getemployeename()
        {
            employeelist.ForEach(value => { Console.WriteLine(value.Name); });
        }
        public void getemployeepass()
        {
            employeelist.ForEach(value => { Console.WriteLine(value.Password); });
        }

    }
   
    
    /// Class Book
    class Book
    {
        public string name;
        public string ID;

        public Book(string namebook,string id)
        {
            this.name = namebook;
            this.ID = id;
        }
        public string Getname()
        {
            return this.name;
        }
        public string GetID()
        {
            return this.ID;
        }
        public List<string> booknamelist = new List<string>();

        public Book()
        {
            booknamelist.Add("NOW I UNDERSTAND");
            booknamelist.Add(" REVOLUTIONARY WEALTH");
            booknamelist.Add(" Six Degrees");
            booknamelist.Add(" Les Vacances");
        }
        
    }
    
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Menuscreen();   
            Userselectmenu();  
        }
       public static  void Menuscreen()  //หน้าเมนู
        {
            Console.Clear();
            Console.WriteLine("Welcome to Digital Library");  
            Console.WriteLine("------------------");
            Console.WriteLine("");

            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");

            Userselectmenu();
        }
        static void Userselectmenu()    //ผู้ใช้เลือกเมนู
        {
            Console.WriteLine("Select Menu :");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            Choosenmenu(menu);
           
        }
        static void Choosenmenu(Menu menu)  //เงื่อนไขเลือกเมนู
        {
            if (menu == Menu.Login)
            {
                ShowLoginscreen();
            }
            else if (menu == Menu.Register)
            {
                ShowRegisterscreen();
            }
            else
            {
                ShowIncorrectmenu();
            }
        }
        static void ShowIncorrectmenu()   //เลือกผิดเมนู
        {
            Console.Clear();
            Console.WriteLine("wrong menuinput please try again");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");

            Userselectmenu();
        }
        static void ShowLoginscreen()     //หน้าแสดงLogin
        {
            Console.Clear();
            Console.WriteLine("Login Screen");
            Console.WriteLine("--------------");
            Console.WriteLine("");

            Inputlogin();
            Showstudentborrowbook();   


        }
        static void ShowRegisterscreen()   //หน้าแสดง Regisater
        {
            Console.Clear();
            Console.WriteLine("Register New Person");
            Console.WriteLine("-------------------");
            Console.WriteLine("");

            Console.WriteLine("1.Student Register");
            Console.WriteLine("2.Employee Register");

            userinputchooseregister();


        }
        static void userinputchooseregister()     //ผู้ใช้เลือกRegister นักเรียนหรือพนักงาน
        {
            Console.WriteLine("Input your type :");
            RegisterChoose chooseregister = (RegisterChoose)(int.Parse(Console.ReadLine()));
            Showregisterchoosen(chooseregister);


        }
        static void Inputlogin()         //login
        {
            Inputname();
            Inputpassword();
            
        }
        static void ShowinfoafterloginforEmployee() //พนักงานลอคอิน
        {
            Console.Clear();
            Employee employeetologin = new Employee("name : Chinnapat", "pass: 009", "studentid: 062");
            employeetologin.addEmployee(employeetologin);
            employeetologin.getemployeename();
            employeetologin.getemployeepass();

            Userinputbookborrowchoose();  //เลือกหนังสืที่อจะยืม
        }
        static void Showstudentborrowbook()    //นักเรียนลอคอิน
        {
            
            Console.Clear();
            Student studenttologin = new Student("name : Chinnapat", "pass: 009", "studentid: 062");
            studenttologin.addstudent(studenttologin);
            studenttologin.getstudentname();
            studenttologin.getstudentpass();

            Userinputbookborrowchoose();  //เลือกหนังสืที่อจะยืม
            

        }
        static void Inputnumforborrowbook(Bookmenu choosetoborrow) //เงื่อนไขเมนูหนังสือ
        {
            if (choosetoborrow == Bookmenu.borrow)
            {
                Showlistbook();
            }
        }
        static void Userinputbookborrowchoose()        //เลือกฟเมนูหนังสือ
        {
            Console.WriteLine("Inputname Menu");
            Bookmenu choosetoborrow = (Bookmenu)(int.Parse(Console.ReadLine()));
            Inputnumforborrowbook(choosetoborrow);
        }
        static void Showlistbook()   //โชว์ลิสหนังสือ
        {
            Console.WriteLine("Book List");
            Console.WriteLine("----------");

            bookselectid();
        }
        static void bookselectid()     //แสดงลิสและเลือก
        { 
            Book book1 = new Book("NOW I UNDERSTAND", "1");
            Book book2 = new Book("REVOLUTIONARY WEALTH", "1");
            Book book3 = new Book(" Six Degrees", "1");
            Book book4 = new Book("Les Vacances", "1");

            Console.WriteLine(book1.ID);
            Console.WriteLine(book1.name);
            Console.WriteLine(book2.ID);
            Console.WriteLine(book2.name);
            Console.WriteLine(book3.ID);
            Console.WriteLine(book3.name);
            Console.WriteLine(book4.ID);
            Console.WriteLine(book4.name);

            Choosebook();


        }
        static void Choosebook()
        {
            Console.WriteLine("Input Book ID");
        }

        static void Showregisterchoosen(RegisterChoose chooseregister)
        {
           
            if (chooseregister == RegisterChoose.Student)
            {
                Showstudentregister();
                
            }
            else if (chooseregister == RegisterChoose.Employee)
            {
                Showemployeeregister();
                
            }
        }
        static void Showstudentregister()     //แสดงนักเรียนลงทะเบียน
        {
            Console.Clear();
            Console.WriteLine("Register new person ");
            Console.WriteLine("-------------");

            Student student = CreateNewstudent();
            Menuscreen();
        }
        static void Showemployeeregister()   //แสดงพนักงานลงทะเบียน
        {
            Console.Clear();
            Console.WriteLine("Register new person ");
            Console.WriteLine("-------------");

            Employee employee = CreateNewemployee();
            Menuscreen();
        }
        static Student CreateNewstudent()   //ชื่อ พาสเวิร์ด ไอดี นนักเรียน
        {
            return new Student(Inputname(),
                Inputpassword(),
                Inputstudentid());
            
        }
        static Employee CreateNewemployee()   // ชื่อ พาสเวิร์ด ไอฟดี พนักงาน
        {
            return new Employee(Inputname(),
                Inputpassword(),
                Inputemployeeid());

        }
        static string Inputname()
        {
            Console.Write("Name:");
            return Console.ReadLine();
            
        }
        static string Inputpassword()
        {
            Console.Write("Password:");
            return Console.ReadLine();
        }
        static string Inputstudentid()
        {
            Console.Write("Student ID:");
            return Console.ReadLine();
            
        }
        static string Inputemployeeid()
        {
            Console.Write("Employee ID:");
            return Console.ReadLine();

        }
    }
    
}
