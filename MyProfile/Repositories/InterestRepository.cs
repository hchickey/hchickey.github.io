using Microsoft.Extensions.Configuration;
using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public class InterestRepository : BaseRepository, IInterestRepository
    {
        public InterestRepository(IConfiguration configuration) : base(configuration) { }
        public List<Interest> GetAll()
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                            SELECT Id, Hobby
                            FROM Interest";
                    var interests = new List<Interest>();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Interest interest = new Interest()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Hobby = reader.GetString(reader.GetOrdinal("Hobby"))
                        };
                        interests.Add(interest);
                    }
                    return interests;
                }
            }
        }
    }
}
