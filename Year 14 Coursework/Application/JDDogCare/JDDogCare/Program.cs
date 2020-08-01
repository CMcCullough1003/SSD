using System;
using DataStore;

namespace JDDogCare
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStore.ClientTable clientTable = new ClientTable();
            clientTable.createNewClient();
        }
    }
}
