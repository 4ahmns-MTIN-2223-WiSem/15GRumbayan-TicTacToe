using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    bool tilePlaced;
    public GameObject redTile;
    public GameObject blueTile;
    public GameObject whiteTile;

    private void Start()
    {
        tilePlaced = false;
        redTile.SetActive(false);
        blueTile.SetActive(false);
        whiteTile.SetActive(true);
    }
  
    private void OnMouseDown()
    {
        if(tilePlaced == false)
        {
            PlaceTile();
        }
    }
    void PlaceTile()
    {
        tilePlaced = true;
        if(TurnManager.redsTurn == true)
        {
            redTile.SetActive(true);
            TurnManager.redsTurn = false;
            whiteTile.SetActive(false);
        }
        else
        {
            blueTile.SetActive(true);
            TurnManager.redsTurn = true;
            whiteTile.SetActive(false);
        }
    }
}
