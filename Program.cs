Sale sale = new Sale(15);
var message = sale.GetInfo();


Console.WriteLine(message);
class Sale {
    public decimal Total {get; set;}

    public Sale(decimal Total)
    {
        this.Total = Total;
    }

    public String GetInfo() {
        return "el total es " + Total;
    }
}