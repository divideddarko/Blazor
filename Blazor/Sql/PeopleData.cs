using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Twitch_Tools.Models;
using Twitch_Tools.Sql;

namespace Twitch_Tools
{
    public interface IPeopleData
    {
        Task<List<PersonModel>> GetPeople();
        Task InsertPerson(PersonModel person);

        Task InsertUser(UserModel user);
    }

    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess _db;
        public PeopleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "Select * from dbo.Users";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @"INSERT INTO dbo.Users (FirstName, Surname, EmailAddress)
                            VALUES (@FirstName, @Surname, @EmailAddress);";

            return _db.SaveData(sql, person);
        }

        public Task InsertUser(UserModel user)
        {
            string sql = @"INSERT INTO dbo.Users (EmailAddress, Password)
                        VALUES (@EmailAddress, @Password);";
            return _db.SaveData(sql, user);
        }
    }
}