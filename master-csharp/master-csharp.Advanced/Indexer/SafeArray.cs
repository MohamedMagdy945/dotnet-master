namespace master_csharp.App.Indexer
{
    class SafeArray
    {
        private int[] arr = new int[5];

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                    return arr[index];
                else
                    return -1;
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                    arr[index] = value;
            }
        }
    }
}
