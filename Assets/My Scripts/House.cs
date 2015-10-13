using UnityEngine;
using System.Collections;

public enum FloorType { Attic, Ground, Basement };

public class House 
{
    private int size;
    private Floor attic, ground, basement;

    public int Size
    {
        get{ return size; }
    }

    public House (int _size)
    {
        size = _size;

        attic = new Floor(size, FloorType.Attic);
        ground = new Floor(size, FloorType.Ground);
        basement = new Floor(size, FloorType.Basement);
    }
}
