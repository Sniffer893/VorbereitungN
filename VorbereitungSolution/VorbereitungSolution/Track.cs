using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VorbereitungSolution
{
    class Track
    {
        private string _title;
        private int _duration;
        private Artist _writer;
        private Artist _performer;
        private int _year;

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public int Duration
        {
            get
            {
                return _duration;
            }

            set
            {
                _duration = value;
            }
        }

        internal Artist Writer
        {
            get
            {
                return _writer;
            }

            set
            {
                _writer = value;
            }
        }

        internal Artist Performer
        {
            get
            {
                return _performer;
            }

            set
            {
                _performer = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }
    }
}
