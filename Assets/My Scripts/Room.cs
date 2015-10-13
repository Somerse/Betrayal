using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Room
{
    private RoomType roomType;
    private Vector2 location;
    private int size;
    private List<Item> items;

    public int Size
    {
        get { return size;  }
    }

    public Room(RoomType _roomType, Vector2 _location, int _size)
    {
        roomType = _roomType;
        location = _location;
        size = _size;
        items = new List<Item>();
    }
}
