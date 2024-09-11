using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace AvaloniaApplication1.Controls;

public class TemplatedControl1 : TemplatedControl
{
    public static readonly StyledProperty<List<string>> ItemSourceProperty =
        AvaloniaProperty.Register<TemplatedControl1, List<string>>(nameof(ItemSource));

    public List<string> ItemSource
    {
        get => GetValue(ItemSourceProperty);
        set => SetValue(ItemSourceProperty, value);
    }

    public static readonly StyledProperty<string?> SomeTextProperty =
        AvaloniaProperty.Register<TemplatedControl1, string?>(nameof(SomeText));

    public string? SomeText
    {
        get => GetValue(SomeTextProperty);
        set => SetValue(SomeTextProperty, value);
    }

    public static readonly StyledProperty<bool> IsOpenProperty =
        AvaloniaProperty.Register<TemplatedControl1, bool>(nameof(IsOpen), defaultValue: true);

    public bool IsOpen
    {
        get => GetValue(IsOpenProperty);
        set => SetValue(IsOpenProperty, value);
    }
}
