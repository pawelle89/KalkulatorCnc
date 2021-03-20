using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IToolData
    {
        Task<List<ToolModel>> GetTool();
        Task InsertTool(ToolModel tool);
    }
}