namespace shopinventory
{
    public class Shop
    {
        private Dictionary<int, string> _inventory = new Dictionary<int, string>();

        public string this[int index]
        {
            get
            {
                string itemName;
                if (_inventory.TryGetValue(index, out itemName))
                {
                    return itemName;
                }

                throw new ArgumentException("Inventory item missing or unassigned...");
            }

            set
            {
                if (_inventory.ContainsKey(index))
                {
                    throw new ArgumentException("Duplicate inventory item found...");
                }

                _inventory[index] = value;
            }
        }
    }
}