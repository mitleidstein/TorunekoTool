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
        private OdbcConnection con;

        public void OpenConnection() {
            con = new OdbcConnection();
            con.ConnectionString = 
                "DSN=PostgreSQL35W;SERVER=localhost;DATABASE=postgres;UID=postgres;PWD=postgresql;PORT=5432;";
            con.Open();
        }

        public List<UnidentifiedItem> GetUnidentifiedItemList(DtoItem item) {
            string sql = "SELECT UNIDENTIFIEDNAME " +
                "FROM UNIDENTIFIEDNAMEMASTER " +
                $"WHERE TYPENUMBER = {item.TypeNumber}";

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

        public List<DtoType> GetTypeList()
        {
            string sql = "SELECT TYPENUMBER, TYPENAME FROM TYPEMASTER";

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
                            TypeName = reader[1].ToString()
                        };

                        typeList.Add(retType);
                    }
                }
            }

            return typeList;
        }

        public List<DtoItem> GetItemList(DtoItem item)
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

        public List<DtoItem> SearchItem(DtoItem item) {
            string sql = "SELECT ITEMNAME, ITEMMASTER.TYPENUMBER, MONEYTOBUY, MONEYTOSELL, NOTE " +
                "FROM ITEMMASTER JOIN TYPEMASTER ON ITEMMASTER.TYPENUMBER = TYPEMASTER.TYPENUMBER " +
                $"WHERE ITEMMASTER.TYPENUMBER = {item.TypeNumber}";

            var itemList = new List<DtoItem>();

            using (var cmd = new OdbcCommand(sql, con)) {
                //var param = new OdbcParameter("TypeNumber", item.TypeNumber);
                /*
                var param = new OdbcParameter("TypeNumber", OdbcType.Int, 1,
                    ParameterDirection.Input, false, 1, 1, "TYPEMASTER.TYPENUMBER", 
                    DataRowVersion.Default, item.TypeNumber);
                  */
                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        //0: ITEMNAME, 1: ITEMMASTER.TYPENUMBER, 2: MONEYTOBUY, 3: MONEYTOSELL, 4: NOTE
                        var retItem = new DtoItem()
                        {
                            ItemName = reader[0].ToString(),
                            TypeNumber = int.Parse(reader[1].ToString()),
                            MoneyToBuy = int.Parse(reader[2].ToString()),
                            MoneyToSell = int.Parse(reader[3].ToString()),
                            Note = reader[4].ToString(),
                        };

                        itemList.Add(retItem);
                    }
                }
            }
            
            return itemList;
        }

        public int GetTypeNumber() {
            return 0;
        }
        
        public void CloseConnection() {
            if (con != null) {
                con.Close();
            }
        }

    }
}
