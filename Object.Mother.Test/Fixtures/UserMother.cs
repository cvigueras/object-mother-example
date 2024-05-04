namespace Object.Mother.Test.Fixtures
{
    public class UserMother
    {
        public static User UserUnderEighteen()
        {
            return User.Create("Pepito Grillo", 16);
        }

        public static User UserOverEighteenUnderThirty()
        {
            return User.Create("Pepito Grillo", 29);
        }

        public static User UserOverThirtyUnderSixtyFive()
        {
            return User.Create("Pepito Grillo", 46);
        }

        public static User UserOverSixtyFive()
        {
            return User.Create("Pepito Grillo", 67);
        }
    }
}
