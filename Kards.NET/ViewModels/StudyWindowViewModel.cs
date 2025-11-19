using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kards.NET.Models;

namespace Kards.NET.ViewModels;

public partial class StudyWindowViewModel : ObservableObject
{
    private Decks Deck {get; set;} =  new();
    public ObservableCollection<Cards> Kards { get; set; } = new();

    [ObservableProperty]
    private int _currentCardIndex;
    
    public Cards? CurrentCard => CurrentCardIndex >= 0 && CurrentCardIndex < Kards.Count ? Kards[CurrentCardIndex] : null;
    
    
    public void LoadCard(Decks d)
    {
        Deck = d;
        Kards.Clear();
        foreach (var c in Deck.Cards)
            Kards.Add(c);
        CurrentCardIndex = 0;
    }

    [RelayCommand]
    public void FlipCard()
    {
        if (CurrentCard != null)
            CurrentCard.IsFlipped = !CurrentCard.IsFlipped;
    }
    
}