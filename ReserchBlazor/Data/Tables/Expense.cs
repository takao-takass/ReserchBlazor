namespace ReserchBlazor.Data.Tables;

public class Expense
{
    public int Id { get; set; }
    public DateTime DateTime { get; set; }
    public string Title { get; set; } = String.Empty;
    public int Amount { get; set; }
}
