using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
  private bool selected; // it has been clicked on
  private bool full; // is there a player on it
//  private Tile tile; // is it a tile?
//  private Room room; // is it a room?


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FindPossibleTiles(int diceValue){ // returns all the tiles that can potentially be stepped on
      // if there is a room, we can't step there
      // potentially use breadth first search or something

    }
    private void calculatePath(int x, int y){// once the desired square has been selected, we need to get there
      // this would mean getting there without going through rooms or going diagonal
      // possible use djkstra, will assign player to a path
    }
    // could need getter and setter methods

}
