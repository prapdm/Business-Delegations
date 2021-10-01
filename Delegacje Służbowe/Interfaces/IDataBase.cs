
namespace Delegations.Interfaces
{
    interface IDataBase
    {
        int Add(object data);
        int  Delete(int row_id);

        dynamic Get();

        dynamic Find(int row_id);

        dynamic Filter(dynamic fields);

        int Update(object data, int row_id);
    }
}
