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

        [Test]
        public void get_message_over_eighteen_under_thirty_years()
        {
            //Given
            var givenUserOverEighteenUnderThirty = User.Create("Pepito Grillo", 29);

            //When
            var home = new Home();
            var message = home.Access(givenUserOverEighteenUnderThirty);

            //Then
            Assert.IsTrue(string.Equals(message, "Consigue un descuento de 20€ en tu primer pedido",
                StringComparison.OrdinalIgnoreCase));
        }


        [Test]
        public void get_message_over_thirty_under_sixty_five_years()
        {
            //Given
            var givenUserOverEighteenOverThirtyUnderSixtyFive = User.Create("Pepito Grillo", 46);

            //When
            var home = new Home();
            var message = home.Access(givenUserOverEighteenOverThirtyUnderSixtyFive);

            //Then
            Assert.IsTrue(string.Equals(message, "Consigue un descuento de 25€ en tu primer pedido",
                StringComparison.OrdinalIgnoreCase));
        }
    }
}