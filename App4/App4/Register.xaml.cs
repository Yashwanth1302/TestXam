using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

namespace App4
{
    public partial class Register : ContentPage
    {
        public StudentDB studentdb;
        public Student student;
        //string name_reg, address_reg, phoneno;
        public Register()
        {
            InitializeComponent();
        }
        public void adddata(Object o, EventArgs e)
        {
            //string folder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //var conn = new SQLiteConnection(System.IO.Path.Combine(folder, "stocks.db"));
            //conn.CreateTable<Student>();
            //conn.CreateTable<Valuation>();
            // string path = db.DatabasePath;

            studentdb = new StudentDB();
            student = new Student();
            //student.Id =Convert.ToInt32(id1.Text);
            student.Name = name.Text;

            student.Address = address.Text;
            student.Phone = phone.Text;
            studentdb.AddStusent(student);
            //studentdb.UpdateStudent(student);
            //studentdb.DeleteStudent(Convert.ToInt32(student.Name));
        }
        public void updatedata(Object o, EventArgs e)
        {
            //string folder = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //var conn = new SQLiteConnection(System.IO.Path.Combine(folder, "stocks.db"));
            //conn.CreateTable<Student>();
            //conn.CreateTable<Valuation>();
            // string path = db.DatabasePath;

            studentdb = new StudentDB();
            student = new Student();
            student.Id = Convert.ToInt32(id1.Text);
            student.Name = name.Text;

            student.Address = address.Text;
            student.Phone = phone.Text;
            //studentdb.AddStusent(student);
            studentdb.UpdateStudent(student);
            //studentdb.DeleteStudent(Convert.ToInt32(student.Name));
        }
        public void Getdata(Object o, EventArgs e)
        {
            studentdb = new StudentDB();
            Student stu = studentdb.GetStudent(Convert.ToInt32(id1.Text));
            name.Text= stu.Name;
            address.Text= stu.Address;
            phone.Text= stu.Phone;            
        }
        public void showdata(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new Studentlist());//Studentlist(Convert.ToInt32(name.Text)));
        }

    }
}