using Microsoft.Extensions.Configuration;
using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public class WorkRepository : BaseRepository, IWorkRepository
    {
        public WorkRepository(IConfiguration configuration) : base(configuration) { }
        public List<Work> GetAll()
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                                SELECT Id, Company, Position, Website, StartDate, EndDate, Summary
                                FROM Work";
                    var works = new List<Work>();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Work work = new Work()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Company = reader.GetString(reader.GetOrdinal("Company")),
                            Position = reader.GetString(reader.GetOrdinal("Position")),
                            Website = reader.GetString(reader.GetOrdinal("Website")),
                            StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate")),
                            EndDate = reader.GetDateTime(reader.GetOrdinal("EndDate")),
                            Summary = reader.GetString(reader.GetOrdinal("Summary")),
                        };
                        works.Add(work);
                    }
                    return works;
                }
            }
        }
    }
}
