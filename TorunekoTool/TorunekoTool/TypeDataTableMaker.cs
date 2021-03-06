﻿using System.Collections.Generic;
using System.Data;
using System.Linq;

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

            DaoItem dao = new DaoItemNoDb();

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

        /// <summary>
        /// TypeNumberからDtoTypeを1つだけ返す
        /// </summary>
        /// <param name="typeNumber"></param>
        /// <returns></returns>
        public DtoType GetType(int typeNumber)
        {
            return TypeList.Single(x => x.TypeNumber == typeNumber);
        }
    }
}