using WebApi.Interfaces;

namespace WebApi.Models
{
    public class Cars
    {
        public Wheels myWheels { get; set; }
        public IDoors myDoors { get; set; }

        public Cars(IDoors _doors)
        {
            myDoors = _doors;
        }

        public void OpenDoors()
        {
            myDoors.Open();
        }
    }
}