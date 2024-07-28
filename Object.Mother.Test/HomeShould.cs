using Object.Mother.App;
using Object.Mother.Test.Fixtures;

namespace Object.Mother.Test
{
    public class HomeShould
    {
        private Home home;
        [SetUp]
        public void Setup()
        {
            home = new Home();
        }

        [Test]
        public void get_message_under_eighteen_years()
        {
            //Given
            var givenUserUnderEighteen = UserMother.UserUnderEighteen();

            //When
            var message = home.Access(givenUserUnderEighteen);

            //Then
            Assert.IsTrue(string.Equals(message, "Aplicación web solo para personas mayores de edad",
                StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void get_message_over_eighteen_under_thirty_years()
        {
            //Given
            var givenUserOverEighteenUnderThirty = UserMother.UserOverEighteenUnderThirty();

            //When
            var message = home.Access(givenUserOverEighteenUnderThirty);

            //Then
            Assert.IsTrue(string.Equals(message, "Consigue un descuento de 20€ en tu primer pedido",
                StringComparison.OrdinalIgnoreCase));
        }


        [Test]
        public void get_message_over_thirty_under_sixty_five_years()
        {
            //Given
            var givenUserOverThirtyUnderSixtyFive = UserMother.UserOverThirtyUnderSixtyFive();

            //When
            var message = home.Access(givenUserOverThirtyUnderSixtyFive);

            //Then
            Assert.IsTrue(string.Equals(message, "Consigue un descuento de 25€ en tu primer pedido",
                StringComparison.OrdinalIgnoreCase));
        }

        [Test]
        public void get_message_over_sixty_five_years()
        {
            //Given
            var givenUserOverSixtyFive = UserMother.UserOverSixtyFive();

            //When
            var message = home.Access(givenUserOverSixtyFive);

            //Then
            Assert.IsTrue(string.Equals(message, "Consigue un descuento de 30€ en tu primer pedido",
                StringComparison.OrdinalIgnoreCase));
        }
    }
}