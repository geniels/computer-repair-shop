namespace ComputerRepairShop.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userGUI = new UserInterface();
            short exitProgram = 3;

            while (!userGUI.UserMenuOption.Equals(exitProgram))
            {
                userGUI.SelectUserOption();
            }
        }
    }
}
