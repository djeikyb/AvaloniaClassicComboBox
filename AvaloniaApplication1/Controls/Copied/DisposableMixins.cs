using System;
using R3;

namespace AvaloniaApplication1.Controls.Copied;

public static class DisposableMixins
{
    public static T DisposeWith<T>(this T item, CompositeDisposable compositeDisposable) where T : IDisposable
    {
        compositeDisposable.Add(item);
        return item;
    }
}
