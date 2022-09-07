
namespace ComputerRepairShop.Domain.Modules
{
    public class Computer
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public bool Portable { get; set; }
        public Service Service { get; set; }

    }
}
