using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ToolData : IToolData
    {
        private readonly ISqlDataAccess _db;

        public ToolData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ToolModel>> GetTool()
        {
            string sql = "select * from dbo.Tool";

            return _db.LoadData<ToolModel, dynamic>(sql, new { });
        }

        public Task InsertTool(ToolModel tool)
        {
            string sql = @"insert into dbo.Tool (ToolName, CuttingSpeed, SpindleSpeed, Diameter, NumberOfTeeth, Feed, FeedPerTooth);";

            return _db.SaveData(sql, tool);
        }
    }
}
