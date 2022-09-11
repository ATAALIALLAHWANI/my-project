using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    /*
    public class A
    {
        private static int InvObjects;
        public static List<B> orderItems;
         static A()
        {
            InvObjects = 0;
        }

        public A()
        {
            orderItems = new List<B>();
        }
        public int Count()
        {
            return InvObjects;
        }
        public bool Addprofile(B I)
        {
            if (I != null)
            {
                orderItems.Add(I);
                InvObjects++;
                return true;
            }
            else return false;

        }
    }

        public class B
    {
        
        private string name;
        private string gender;
        private int age;
        private string color;
        


        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Color { get => color; set => color = value; }



       public B()
        {

        }

        public B (string name, string gender, int age, string color)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Color = color;
        }


        public override string ToString()
        {
            return name;
        }
        public override bool Equals(object obj)
        {
            B that = obj as B;
            if (that != null) { return this.name.Equals(that.name); }
            else
                return false;
        }
    }
    */

    public class Data
    {
        public static List<Profile> Profiles;
        public Data()
        {
            Profiles = new List<Profile>();
        }
    }
    public class Profile
    {
        public Profile() {}
        private string name;
        private string gender;
        private  int  age;
        private string color;
        private List<Game> all_games = new List<Game>();


        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Color { get => color; set => color = value; }
        internal List<Game> All_games { get => all_games; set => all_games = value; }

        
        


        public void AddProfile(string name, string gender, int age, string color)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Color = color;
        }


        public override string ToString()
        {
            return name;
        }
        public override bool Equals(object obj)
        {
            Profile that=obj as Profile;
            if (that != null) { return this.name.Equals(that.name); }
            else
                return false; 
        }
    }
}
