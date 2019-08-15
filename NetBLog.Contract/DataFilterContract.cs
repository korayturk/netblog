namespace NetBLog.Contract
{
    public class DataFilterContract
    {
        public int Page { get; set; } = 1;

        //Default record count on pages
        public int RecordCount { get; set; } = 20;

        private string _search;

        public string Search
        {
            get { return _search?.ToLower(); }
            set { _search = value; }
        }

    }
}
