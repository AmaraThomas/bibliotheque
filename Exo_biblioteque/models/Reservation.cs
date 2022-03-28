using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_biblioteque.models
{
    internal class Reservation
    {
        private int id;
        private DateTime date_reservation;
        private Boolean deleted;

        public int Id { get => id; set => id = value; }
        public DateTime Date_reservation { get => date_reservation; set => date_reservation = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
