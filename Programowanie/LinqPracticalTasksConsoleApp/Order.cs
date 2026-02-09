using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticalTasksConsoleApp;

public enum OrderStatus { New, Processing, Shipped, Delivered, Cancelled }

public class Order
{
    public int Id { get; init; }
    public string Customer { get; init; } = default!;
    public string Product { get; init; } = default!;
    public int Quantity { get; init; }
    public decimal PricePerItem { get; init; }
    public DateTime OrderDate { get; init; }
    public OrderStatus Status { get; init; }

    public decimal Total => Quantity * PricePerItem;

    public override string ToString()
        => $"{Id}: {Customer} kupi³ {Product} x{Quantity} za {Total:C} [{Status}] {OrderDate:yyyy-MM-dd}";
}
