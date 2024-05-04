namespace Object.Mother.Test
{
    public partial class UserShould
    {
        [Test]
        public void get_message_under_eighteen_years()
        {
            //Given
            var givenUserUnderEighteen = User.Create("Pepito Grillo", 16);

            //When
            var home = new Home();
            var message = home.Access(givenUserUnderEighteen);

            //Then
            Assert.IsTrue(string.Equals(message, "Aplicación web solo para personas mayores de edad", 
                StringComparison.OrdinalIgnoreCase));
        }
    }
}