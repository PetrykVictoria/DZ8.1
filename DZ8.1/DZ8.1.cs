class Item
{
}
class Order
{
    private List<Item> itemList;

    public List<Item> ItemList
    {
        get { return itemList; }
        set { itemList = value; }
    }

    public void PrintOrder() {/*...*/}
    public void ShowOrder() {/*...*/}
}

class OrderCalculator
{
    public void CalculateTotalSum() {/*...*/}
}

class OrderManager
{
    public void GetItems() {/*...*/}
    public void GetItemCount() {/*...*/}
    public void AddItem() {/*...*/}
    public void DeleteItem() {/*...*/}
}

class OrderPersistence
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}
}
