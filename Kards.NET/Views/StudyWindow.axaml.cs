using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Kards.NET.Models;
using Kards.NET.ViewModels;

namespace Kards.NET.Views;

public partial class StudyWindow : Window
{
    private StudyWindowViewModel ViewModel => (StudyWindowViewModel)DataContext!;
 
    public StudyWindow()
    {
        InitializeComponent();
        if(Design.IsDesignMode)
            DataContext = new StudyWindowViewModel();
    }
    public StudyWindow(StudyWindowViewModel vm, Decks d)
    {
        InitializeComponent();
        DataContext = vm;
        vm.LoadCard(d);
    }
    
    public void Next(object source, RoutedEventArgs args)
    {
        Cards.Next();
        ResetCurrentCardFlipState();
        ViewModel.ResetVisibility();
    }

    public void Previous(object source, RoutedEventArgs args) 
    {
        Cards.Previous();
        ResetCurrentCardFlipState();
        ViewModel.ResetVisibility();
    }
    
    private void ResetCurrentCardFlipState()
    {
        if (ViewModel.CurrentCard != null)
        {
            ViewModel.CurrentCard.IsFlipped = false;
        }
    }
    
}