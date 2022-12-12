using Microsoft.Extensions.Configuration;
using MyProfile.Models;
using System.Collections.Generic;

namespace MyProfile.Repositories
{
    public class SkillRepository : BaseRepository, ISkillRepository
    {
        public SkillRepository(IConfiguration configuration) : base(configuration) { }
        public List<Skill> GetAll()
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                            SELECT Id, Title, Level, Keyword
                            FROM Skill";
                    var skills = new List<Skill>();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Skill skill = new Skill()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Level = reader.GetString(reader.GetOrdinal("Level")),
                            Keyword = reader.GetString(reader.GetOrdinal("Keyword"))
                        };
                        skills.Add(skill);
                    }
                    return skills;
                }
            }
        }
    }
}
