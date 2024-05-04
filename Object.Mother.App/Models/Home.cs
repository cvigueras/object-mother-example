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
            if(user.Age < 30)
            {
                return "Consigue un descuento de 20€ en tu primer pedido";
            }
            if(user.Age < 65)
            {
                return "Consigue un descuento de 25€ en tu primer pedido";
            }
            if(user.Age > 65)
            {
                return "Consigue un descuento de 30€ en tu primer pedido";
            }
            return string.Empty;
        }
    }
}