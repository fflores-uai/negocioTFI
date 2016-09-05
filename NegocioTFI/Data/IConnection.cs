using System.Collections;
using System.Data;

namespace Data
{
    public interface IConnection
    {
        DataSet Read(string query, Hashtable data);

        bool Write(string query, Hashtable data);
    }
}