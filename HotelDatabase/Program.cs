namespace HotelDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DBClient dBClient = new DBClient();
            dBClient.Start();
        }
    }
}
