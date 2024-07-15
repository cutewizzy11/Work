using MongoDB.Bson;
using MongoDB.Driver;

namespace Jurilinka
{
    public class DatabaseContext
    {
        private readonly IMongoDatabase _database;

        public DatabaseContext()
        {
            var client = new MongoClient("mongodb+srv://root:Cutewizzy.11@cluster0.o1cildb.mongodb.net/JurilinkaDB?retryWrites=true&w=majority");
            _database = client.GetDatabase("JurilinkaDB");
        }

        public IMongoCollection<Client> Clients => _database.GetCollection<Client>("Clients");
        public IMongoCollection<Lawyer> Lawyers => _database.GetCollection<Lawyer>("Lawyers");
        public IMongoCollection<Admin> Admins => _database.GetCollection<Admin>("Admins");

        // Method to check if an email exists in Clients or Lawyers collection
        public bool IsEmailAlreadyRegistered(string email)
        {
            var filter = Builders<Client>.Filter.Eq("Email", email.ToLower());
            var clientExists = Clients.Find(filter).Any();

            var lawyerFilter = Builders<Lawyer>.Filter.Eq("Email", email.ToLower());
            var lawyerExists = Lawyers.Find(lawyerFilter).Any();

            return clientExists || lawyerExists;
        }

        // Method to check if a license number exists in Lawyers collection
        public bool IsLicenseNumberAlreadyUsed(string licenseNumber)
        {
            var filter = Builders<Lawyer>.Filter.Eq("LicenseNumber", licenseNumber.ToUpper());
            return Lawyers.Find(filter).Any();
        }
    }

    public class Client
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class Lawyer
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LicenseNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsApproved { get; set; }
    }

    public class Admin
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
