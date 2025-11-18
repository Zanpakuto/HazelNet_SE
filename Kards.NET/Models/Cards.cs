using System;
using System.ComponentModel.DataAnnotations.Schema;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Kards.NET.Models;

public partial class Cards: ObservableObject
{
    public int Id { get; set; }
    public required string CardName { get; set; }
    public string? CardDescription { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.Now;
    public int DeckId { get; set; }
    public Decks Decks { get; set; } = new Decks();

    [NotMapped]
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(DisplayText))]
    [NotifyPropertyChangedFor(nameof(FlipButtonText))]
    private bool _isFlipped;
    
    [NotMapped]
    public string? DisplayText => IsFlipped ? CardDescription: CardName;
    [NotMapped]
    public string FlipButtonText => IsFlipped ? "Show Question" : "Show Answer";
    
}