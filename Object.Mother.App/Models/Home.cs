namespace Object.Mother.Test
{
    public class Home
    {
        public string Access(User user)
        {
            if(user.Age < 18)
            {
                return "Aplicación web solo para personas mayores de edad";
            }
            return string.Empty;
        }
    }
}