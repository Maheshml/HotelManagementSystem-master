using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SpecialOffer : ISpecialOffer
    {
        public SpecialOffer(int ID, Decimal discount, DateTime startDate, DateTime endDate, string name, string Description, string state)
        {
            this.id = ID;
            this.discount = discount;
            this.startDate = startDate;
            this.endDate = endDate;
            this.name = name;
            this.description = Description;
            this.state = state;
        }

        public int id { get; set; }
        public Decimal discount { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string state { get; set; }

        int ISpecialOffer.Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        decimal ISpecialOffer.discount
        {
            get
            {
                return discount;
            }

            set
            {
                discount = value;
            }
        }

        DateTime ISpecialOffer.startDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        DateTime ISpecialOffer.endDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }
    }
}
