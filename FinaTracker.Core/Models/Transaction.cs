namespace FinaTracker.Core.Models;

class Transaction {
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;

    // Consultar as datas das transações.
    public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    public DateTime? PaidOrReceivedAt { get; set; }
}