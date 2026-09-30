namespace MaCalculatrice;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // COMMIT 1 : interface seulement.
    // Les methodes ci-dessous existent pour que le XAML compile (chaque bouton
    // designe une methode), mais elles ne font rien pour l'instant.

    void OnDigitClicked(object? sender, EventArgs e) { }

    void OnDecimalClicked(object? sender, EventArgs e) { }

    void OnOperatorClicked(object? sender, EventArgs e) { }

    void OnEqualsClicked(object? sender, EventArgs e) { }

    void OnClearClicked(object? sender, EventArgs e) { }

    void OnBackspaceClicked(object? sender, EventArgs e) { }

    void OnSignClicked(object? sender, EventArgs e) { }

    void OnPercentClicked(object? sender, EventArgs e) { }
}