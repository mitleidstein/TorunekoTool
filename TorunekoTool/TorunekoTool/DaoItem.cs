using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorunekoTool
{
    public class DaoItem
    {
        protected OdbcConnection con;

        public virtual void OpenConnection() {
            con = new OdbcConnection();
            con.ConnectionString = 
                "DSN=PostgreSQL35W;SERVER=localhost;DATABASE=postgres;UID=postgres;PWD=postgresql;PORT=5432;";
            con.Open();
        }

        public virtual List<UnidentifiedItem> GetUnidentifiedItemList(DtoItem item) {
            string sql = "SELECT UNIDENTIFIEDNAME " +
                "FROM UNIDENTIFIEDNAMEMASTER " +
                $"WHERE TYPENUMBER = {item.TypeNumber} ORDER BY UNIDENTIFIEDNAME";

            var itemList = new List<UnidentifiedItem>();

            using (var cmd = new OdbcCommand(sql, con)) {
                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        var retItem = new UnidentifiedItem()
                        {
                            UnidentifiedName = reader[0].ToString(),
                            TypeNumber  = item.TypeNumber
                        };

                        itemList.Add(retItem);
                    }
                }
            }
            
            return itemList;
        }

        public virtual List<DtoType> GetTypeList()
        {
            string sql = "SELECT TYPENUMBER, TYPENAME, RCOLOR, GCOLOR, BCOLOR FROM TYPEMASTER";

            var typeList = new List<DtoType>();

            using (var cmd = new OdbcCommand(sql, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var retType = new DtoType()
                        {
                            TypeNumber = int.Parse(reader[0].ToString()),
                            TypeName = reader[1].ToString(),
                            RColor = int.Parse(reader[2].ToString()),
                            GColor = int.Parse(reader[3].ToString()),
                            BColor = int.Parse(reader[4].ToString()),
                        };

                        typeList.Add(retType);
                    }
                }
            }

            return typeList;
        }

        public virtual List<DtoItem> GetItemList(DtoItem item)
        {
            object[,] strArr = { 
                { nameof(item.ItemName), item.ItemName },
                { nameof(item.TypeNumber), item.TypeNumber },
                { nameof(item.MoneyToBuy), item.MoneyToBuy },
                { nameof(item.MoneyToSell), item.MoneyToSell },
                { nameof(item.Note), item.Note },
            };

            string sql = "SELECT ITEMNAME, TYPENUMBER, MONEYTOBUY, MONEYTOSELL, NOTE " +
                "FROM ITEMMASTER ";

            string strWhere = "";
            for (int i=0; i<strArr.GetUpperBound(0); i++) {
                if (strArr[i,1] != null) {
                    if (strWhere == "") {
                        strWhere += "WHERE ";
                    }
                    else
                    {
                        strWhere += "AND ";
                    }

                    strWhere += $"{strArr[i,0]} = {strArr[i, 1]} ";

                }
            }

            sql += strWhere;

            Console.WriteLine(sql);

            var itemList = new List<DtoItem>();

            using (var cmd = new OdbcCommand(sql, con))
            {
            
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var retItem = new DtoItem()
                        {
                            // ITEMNAME, TYPENUMBER, MONEYTOBUY, MONEYTOSELL, NOTE
                            ItemName = reader[0].ToString(),
                            TypeNumber = int.Parse(reader[1].ToString()),
                            MoneyToBuy = int.Parse(reader[2].ToString()),
                            MoneyToSell = int.Parse(reader[3].ToString()),
                            Note = reader[4].ToString()
                        };

                        itemList.Add(retItem);
                    }
                }
            }

            return itemList;
        }
        
        public virtual void CloseConnection() {
            if (con != null) {
                con.Close();
            }
        }

    }
}
