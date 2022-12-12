using Microsoft.Extensions.Configuration;
using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public class VolunteerRepository : BaseRepository, IVolunteerRepository
    {
        public VolunteerRepository(IConfiguration configuration) : base(configuration) { }
        public List<Volunteer> GetAll()
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                            SELECT Id, Organization, Sumary
                            FROM Volunteer";
                    var volunteers = new List<Volunteer>();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Volunteer volunteer = new Volunteer()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Organization = reader.GetString(reader.GetOrdinal("Organization")),
                            Sumary = reader.GetString(reader.GetOrdinal("Sumary"))
                        };
                        volunteers.Add(volunteer);
                    }
                    return volunteers;
                }
            }
        }
    }
}
