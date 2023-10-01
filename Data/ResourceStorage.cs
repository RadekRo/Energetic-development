namespace Energetic_development.Data
{
    public class ResourceStorage
    {
        private static ResourceStorage? instance;
        int CoalStorage = 0;
        int UraniumStorage = 0;
        int HeliumStorage = 0;
        int AntimatterStorage = 0;
        int EnergyStorage = 0;

        public ResourceStorage() { }

        public static ResourceStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ResourceStorage();
                }
                return instance;
            }
        }

    }
}
