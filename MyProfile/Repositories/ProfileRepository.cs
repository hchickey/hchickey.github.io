using Microsoft.Extensions.Configuration;
using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public class ProfileRepository : BaseRepository, IProfileRepository
    {
        public ProfileRepository(IConfiguration configuration) : base(configuration) { }
        public List<Profile> GetAll()
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                            SELECT Id, Network, UserName, Url
                            FROM Profile";
                    var profiles = new List<Profile>();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Profile profile = new Profile()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Network = reader.GetString(reader.GetOrdinal("Network")),
                            UserName = reader.GetString(reader.GetOrdinal("UserName")),
                            Url = reader.GetString(reader.GetOrdinal("Url"))
                        };
                        profiles.Add(profile);
                    }
                    return profiles;
                }
            }
        }
    }
}
