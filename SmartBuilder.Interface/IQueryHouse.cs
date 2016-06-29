using SmartBuilder;

namespace SmartBuilder.Interface
{
    public interface IQueryHouse
    {

        string GenerateTableInfo(AdonaiBuildStructureInfo buildInfo, SystemSettingsInfo systemSettings);

        string GetTableListByDatabaseName(string dbName);

    }
}
