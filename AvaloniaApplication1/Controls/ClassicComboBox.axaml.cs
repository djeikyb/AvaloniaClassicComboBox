using Avalonia;
using Avalonia.Controls;

namespace AvaloniaApplication1.Controls;

public class ClassicComboBox : ComboBox
{
    private string? _text;

    public static readonly DirectProperty<ClassicComboBox, string?> TextProperty
        = AvaloniaProperty.RegisterDirect<ClassicComboBox, string?>(
            nameof(Text), o => o.Text, (o, v) => o.Text = v);

    public string? Text
    {
        get => _text;
        set => SetAndRaise(TextProperty, ref _text, value);
    }

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        if (change.Property == SelectedItemProperty)
        {
            if (change.NewValue is ComboBoxItem cbi)
            {
                Text = (string?)cbi.Content;
            }
            else
            {
                Text = (string?)change.NewValue;
            }
        }

        base.OnPropertyChanged(change);
    }
}
