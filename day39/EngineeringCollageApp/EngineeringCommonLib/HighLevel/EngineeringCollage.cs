using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringCommonLib.Models
{
    public class EngineeringCollage
    {
        private readonly int _id;
        private readonly string _address;
        private readonly string _date;
        private readonly string _branch;

        public EngineeringCollage(int id, string address, string date)
        {
            _id = id;
            _address = address;
            _date = date;


        }

        public int Id { get { return _id; } }
        public string Address { get { return _address; } }
        public string Date { get { return _date; } }


    }


}
