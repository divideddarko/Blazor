using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Twitch_Tools.Model;
using Twitch_Tools.Sql;

namespace Twitch_Tools
{
    public interface IPeopleData
    {
        Task<List<PersonModel>> GetPeople();
        Task InsertPerson(PersonModel person);
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
            string sql = "Select * from dbo.People";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @"INSERT INTO dbo.People (FirstName, Surname, EmailAddress)
                            VALUES (@FirstName, @Surname, @EmailAddress);";

            return _db.SaveData(sql, person);
        }
    }
}