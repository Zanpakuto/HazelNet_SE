using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kards.NET.Models;

namespace Kards.NET.ViewModels;

public partial class StudyWindowViewModel : ObservableObject
{
    [ObservableProperty] 
    private Decks _deck;

    [ObservableProperty]
    private bool _isVisible;

  
    public ObservableCollection<Cards> Kards { get; set; } = new();
    
    
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CurrentCard))]
    private int _currentCardIndex;
    
    public Cards? CurrentCard => CurrentCardIndex >= 0 && CurrentCardIndex <= Kards.Count ? Kards[CurrentCardIndex] : null;
    
    
    public void LoadCard(Decks d)
    { 
      
        Deck = d;
        Kards.Clear();
        foreach (var c in Deck.Cards)
        {
            Kards.Add(c);
        }
        CurrentCardIndex = 0;
        OnPropertyChanged(nameof(CurrentCard));

    }

    [RelayCommand]
    public void FlipCard()
    {
        if (CurrentCard != null)
            CurrentCard.IsFlipped = !CurrentCard.IsFlipped;
        IsVisible = !IsVisible;
    }

    public void ResetVisibility()
    {
        IsVisible = false;
    }

    [RelayCommand]
    public void EasyDifficulty(Cards card)
    {
        Console.WriteLine($"Rating of {card.Id} of deck {Deck.Id}is set to Easy");
    }
    
    [RelayCommand]
    public void MediumDifficulty(Cards card)
    {
        Console.WriteLine($"Rating of {card.Id} of deck {Deck.Id}is set to Medium");
    }
    
    [RelayCommand]
    public void HardDifficulty(Cards card)
    {
        Console.WriteLine($"Rating of {card.Id} of deck {Deck.Id}is set to Hard");
    }
    
}