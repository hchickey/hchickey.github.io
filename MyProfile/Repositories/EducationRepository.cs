using Microsoft.Extensions.Configuration;
using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public class EducationRepository : BaseRepository, IEducationRepository
    {
        public EducationRepository(IConfiguration configuration) : base(configuration) { }
        public List<Education> GetAll()
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                            SELECT Id, School, Area, StudyType, StartDate, EndDate
                            FROM Education";
                    var educations = new List<Education>();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Education education = new Education()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            School = reader.GetString(reader.GetOrdinal("School")),
                            Area = reader.GetString(reader.GetOrdinal("Area")),
                            StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate")),
                            EndDate = reader.GetDateTime(reader.GetOrdinal("EndDate"))
                        };

                        if (!reader.IsDBNull(reader.GetOrdinal("StudyType")))
                        {
                            education.StudyType = reader.GetString(reader.GetOrdinal("StudyType"));
                        }
                        educations.Add(education);
                    }
                    return educations;
                }
            }
        }
    }
}
