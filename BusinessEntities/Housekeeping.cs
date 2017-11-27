using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Housekeeping:IHousekeeping
    {
        public Housekeeping(int keepingId, int Roomid, string Cleaner, string Description, DateTime DateOfCleaning, string CleaningType)
            {
            this.housekeepingId = keepingId;
            this.Roomid = Roomid;
            this.Cleaner = Cleaner;
            this.Description = Description;
            this.dateOfCleaning = DateOfCleaning;
            this.typeOfCleaning = CleaningType;

            }

        public int housekeepingId { get; set; }
        public int Roomid { get; set; }
        public string Cleaner { get; set; }
        public string Description { get; set; }
        public DateTime dateOfCleaning { get; set; }
        public string typeOfCleaning { get; set; }

        int IHousekeeping.housekeepingId
        {
            get
            {
                return housekeepingId;
            }

            set
            {
                housekeepingId = value;
            }
        }

        int IHousekeeping.Roomid
        {
            get
            {
                
                return Roomid;
            }

            set
            {
                
                Roomid = value;
            }
        }

        string IHousekeeping.Cleaner
        {
            get
            {
                return Cleaner;
            }

            set
            {
                Cleaner = value;
            }
        }

        string IHousekeeping.Description
        {
            get
            {
                return Description;
            }

            set
            {
                Description = value;
            }
        }

        public DateTime DateOfCleaning
        {
            get
            {
                return dateOfCleaning;
            }

            set
            {
                dateOfCleaning = value;
            }
        }

        public string TypeOfCleaning
        {
            get
            {
                return typeOfCleaning;
            }

            set
            {
                typeOfCleaning = value;
            }
        }
    }
}
