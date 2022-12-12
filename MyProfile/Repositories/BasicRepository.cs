using Microsoft.Extensions.Configuration;
using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public class BasicRepository : BaseRepository, IBasicRepository
    {
        public BasicRepository(IConfiguration configuration) : base(configuration) { }
        public List<Basic> GetAll()
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                                SELECT Id, Name, ImageUrl, Email, Phone, Summary
                                FROM Basic";
                    var profiles = new List<Basic>();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Basic basic = new Basic()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            ImageUrl = reader.GetString(reader.GetOrdinal("ImageUrl")),
                            Email = reader.GetString(reader.GetOrdinal("Email")),
                            Phone = reader.GetString(reader.GetOrdinal("Phone")),
                            Summary = reader.GetString(reader.GetOrdinal("Summary"))
                        };
                        profiles.Add(basic);
                    }
                    return profiles;
                }
            }
        }

    }
}
