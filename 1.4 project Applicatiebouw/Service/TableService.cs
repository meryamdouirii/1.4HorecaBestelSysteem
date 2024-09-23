using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service
{
    public class TableService
    {
        private TableDao Tabledb;

        public TableService()
        {
            Tabledb = new TableDao();
        }

        public List<Table> GetTables()
        {
            return Tabledb.GetAllTables();
        }

        public List<Table> GetSeatedTables()
        {
            return Tabledb.GetSeatedTables();
        }
        public void UpdateTableReservation(Table table)
        {
            Tabledb.UpdateTableReservation(table);
        }

        public List<WaitingTime> GetWaitingTime(Table table)
        {
            List<WaitingTime> waitingtimes = Tabledb.GetWaitingTime(table);
            return waitingtimes;
        }
        public void SetTableFree(int tableNumber)
        {
            Tabledb.SetTableFree(tableNumber);
        }
    }
}
