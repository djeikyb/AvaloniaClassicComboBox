using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace AvaloniaApplication1.Controls;

public class TemplatedControl2 : ComboBox
{
    public static readonly StyledProperty<string?> TextProperty =
        AvaloniaProperty.Register<TemplatedControl2, string?>(nameof(Text));

    public string? Text
    {
        get => GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }


}
