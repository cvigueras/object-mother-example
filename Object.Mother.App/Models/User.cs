namespace Object.Mother.Test
{
    public class User
    {
        private static string Name;
        private static int Age;

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public static User Create(string name, int age)
        {
            return new User(name, age);
        }
    }
}