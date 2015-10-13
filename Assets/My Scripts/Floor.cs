using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum RoomType { Bedroom, Lounge, BoilerRoom, Library}

public class Floor
{
    private int size;
    private FloorType floorType;
    private List<Room> rooms;

    public Floor(int _size, FloorType _floorType)
    {
        size = _size;
        floorType = _floorType;
        rooms = new List<Room>();
    }
}
