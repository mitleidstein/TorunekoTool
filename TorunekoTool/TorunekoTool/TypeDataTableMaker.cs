using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorunekoTool
{
    public class TypeDataTableMaker
    {
        private DataTable Table;
        private List<DtoType> TypeList;

        public DataTable GetDataTable()
        {
            Table = new DataTable();
            
            var column1 = new DataColumn("TYPENUMBER", typeof(int));
            var column2 = new DataColumn("TYPENAME", typeof(string));

            Table.Columns.Add(column1);
            Table.Columns.Add(column2);

            DaoItem dao = new DaoItem();

            try
            {
                dao.OpenConnection();
                TypeList = dao.GetTypeList();
            }
            finally
            {
                dao.CloseConnection();
            }

            if (TypeList != null && TypeList.Count != 0)
            {
                foreach (var type in TypeList)
                {
                    Table.Rows.Add(
                        new object[]
                        {
                            type.TypeNumber, type.TypeName
                        });

                }
            }

            return Table;
        }
    }
}
