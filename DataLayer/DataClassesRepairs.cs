using System.Data.Linq;

namespace DataLayer
{
    partial class DataClassesRepairsDataContext
    {
        public Table<ACT_DICT> ActionDictionary;
        public Table<ACTIVITY> Activities;
        public Table<CLIENT> Clients;
        public Table<OBJ_TYPE> ObjectTypes;
        public Table<OBJECT> Objects;
        public Table<PERSONEL> Personel;
        public Table<REQUEST> Requests;
    }
}