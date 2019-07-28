using System;
namespace CcubeLogicLayer
{
    public class Table
    {
        string tableID;
        bool busy;
        bool reserved;

        public Table(){}

		public Table(string id)
		{
            this.tableID = id;
            busy = false;
            reserved = false;
		}

        public string TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }

        public bool Busy
        {
            get { return busy; }
            set { busy = value; }
        }

		public bool Reserved
		{
			get { return reserved; }
			set { reserved = value; }
		}
    }
}
