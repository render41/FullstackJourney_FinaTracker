namespace FinaTracker.Core.Models;

public class Category {
    // Identificação específica do usuário.
    public long Id { get; set; }

    // Título referente com a categoria.
    public string Title { get; set; } = string.Empty;

    // Descrição que pode ser nula.
    public string? Description { get; set; }
    
    // Sempre que criar uma categoria, será relacionada com o user.
    public string UserId { get; set; } = string.Empty;
}