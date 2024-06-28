using System;
using static System.Console;
using System.Collections;
using System.Runtime.InteropServices;

#pragma warning disable CS0219, CS0168

public class CMC
{
    public static void PrintType(object obj)
    {
        Type t = obj.GetType();
        WriteLine(t.Name);
    }

    public static unsafe int SizeOf<T>() where T : unmanaged
    {
        return sizeof(T);
    }

    public static void LogFunctionName(
        [System.Runtime.CompilerServices.CallerMemberName] string name = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int no = 0)
    {
        WriteLine("{0} ({1})", name, no);
    }

    public static void ShowType(object? obj)
    {
        if (obj == null)
        {
            WriteLine("ShowType : error. null reference");
            return;
        }

        Type? t = obj?.GetType();
        Type? objType = typeof(object);

        while (true)
        {
            Write($"{t?.Name}");

            if (t == objType) break;
            Write(" -> ");
            t = t?.BaseType;
        }
        WriteLine();
    }
    public static unsafe void PrintHeapObjectAddr(object o)
    {
        GCHandle h = GCHandle.Alloc(o, GCHandleType.Pinned);
        IntPtr addr = h.AddrOfPinnedObject();
        Console.WriteLine("Heap : 0x{0}", addr.ToString("x"));
        h.Free();
    }
    public static unsafe void PrintAddr<T>(T* v)
    {
        IntPtr addr = (IntPtr)v;
        Console.WriteLine("0x{0}", addr.ToString("x"));
    }
    public static void Show(IEnumerable c)
    {
        foreach (var e in c)
        {
            Write($"{e}, ");
        }
        WriteLine();
    }
    public static void Show<T>(Span<T> c)
    {
        foreach (var e in c)
        {
            Write($"{e}, ");
        }
        WriteLine();
    }
}