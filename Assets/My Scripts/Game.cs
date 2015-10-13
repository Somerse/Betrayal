using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    private House house;
    Character

    public House House
    {
        get { return house; }
    }

	void Start ()
    {
        house = new House(50);
	}
	
	
	void Update ()
    {
        Display.Draw();
	}
}
