﻿using System;
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
            con.ConnectionString = "DSN=PostgreSQL35W;SERVER=localhost;DATABASE=postgres;UID=postgres;PWD=postgresql;PORT=5432;";
            con.Open();
        }

        public List<DtoItem> GetItemList(DtoItem item) {
            string sql = "SELECT UNIDENTIFIEDNAME " +
                "FROM UNIDENTIFIEDNAMEMASTER " +
                $"WHERE TYPENUMBER = {item.TypeNumber}";

            var itemList = new List<DtoItem>();

            using (var cmd = new OdbcCommand(sql, con)) {
                using (var reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        var retItem = new DtoItem()
                        {
                            UnidentifiedName = reader[0].ToString()
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
                            Name = reader[0].ToString(),
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
