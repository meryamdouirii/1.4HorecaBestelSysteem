using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ReceiptService
    {
        private ReceiptDAO receiptdb;
        public ReceiptService()
        {
            receiptdb = new ReceiptDAO();
        }
        public void PushReceipt(Receipt receipt)
        {
            receiptdb.PushReceipt(receipt); 
        }
    }
}
