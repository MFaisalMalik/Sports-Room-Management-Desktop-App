using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT_project
{
    internal class BorrowedItem
    {
        public string itemId { get; set; } = "3fa85f64-5717-4562-b3fc-2c963f66afa6";
        public string studentId { get; set; }
        public string itemName { get; set; }
        public string studentName { get; set; }

        public int quantityBorrowed { get; set; }
        public string timeBorrowed { get; set; }
        public string timeToBeReturned { get; set; }
    }
}
