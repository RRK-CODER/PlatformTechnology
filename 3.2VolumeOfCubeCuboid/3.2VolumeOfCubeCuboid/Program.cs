using System;

class FindVolume
{
    public void VolumeDisplay(int r)
    {
        Console.WriteLine("Volume of cube {0}", (r * r * r));
    }
    public void VolumeDisplay(int l, int b, int h)
    {
        Console.WriteLine("Volume of cuboid {0}", (l * b * h));
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        FindVolume f = new FindVolume();
        f.VolumeDisplay(4);
        f.VolumeDisplay(4, 5, 6);
    }
}