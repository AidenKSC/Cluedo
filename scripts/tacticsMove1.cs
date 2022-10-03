using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tacticsMove1 : MonoBehaviour
{
  List<Tile> selectableTiles = new List<Tile>(); // array of our tiles
  GameObject[] tiles;

  Stack<Tile> path = new Stack<Tile>(); // path calculates in reverese order, so stack is helpful
  Tile currentTile; //calculated at the start of every turn

  public bool moving = false;
  public int move = 5; // needs to link to dice roll, this is how many spaceces they can move
  public float jumpHeight=3 ;
  public float moveSpeed = 2;

  Vector3 velocity = new Vector3(); // player speed across tiles
  Vector3 heading = new Vector3(); // direction player goes interface

  float halfHeight = 0; // distance from the tile to the center of the player

protected void Init(){
  tiles = GameObject.FindGameObjectsWithTag("Tile");
  halfHeight = GetComponent<Collider>().bounds.extents.y;
}

public void GetCurrentTile(){// starting point for path finding
  currentTile = GetTargetTile(gameObject);
  currentTile.current = true;
}

public Tile GetTargetTile(GameObject target){ // end goal for path finding
  RaycastHit hit;
  Tile tile = null;
  if(Physics.Raycast(target.transform.position, -Vector3.up, out hit, 10)){
    tile = hit.collider.GetComponent<Tile>();
  }
  return tile;
}

public void ComputeAdjacencyLists(float jumpHeight, Tile target){ // works out adjacency lists
Tile t = new Tile();
  foreach (GameObject tile in tiles){
    // t = tile.GetComponent<Tile>();
    t.FindNeighbours(jumpHeight, target); // will find walkable tiles for this particular unit
    //SebTest mate;
    //mate.bruh();
  //  t.seb();
  }
}

public void max(){
  print("what");
}

public void FindSelectableTiles(){ //BFS method
  ComputeAdjacencyLists(jumpHeight, null);
  GetCurrentTile();

  Queue<Tile> process = new Queue<Tile>();

  process.Enqueue(currentTile); // add current tile to queue
  currentTile.visited = true;

  while (process.Count > 0){
    Tile t = process.Dequeue(); // pops off tile at the front, so we can process it

    selectableTiles.Add(t); // adds it to array
    t.selectable = true;

    if (t.distance < move){

    foreach (Tile tile in t.adjacencyList){
      if (!tile.visited){
        tile.parent =t; // any adjacent tiles will be children of the initial tile
        tile.visited = true;
        tile.distance = 1 + t.distance; // distance variable keeps track of how far away from start tile we are
        process.Enqueue(tile);
      }
    }
}
  }

}

public void MoveToTile(Tile tile){
  path.Clear();
  tile.target = true;
  moving = true;

  Tile next = tile;
  while(next != null){ // whn next is null we will reach the start tile
    path.Push(next); // push the tile onto the path
    next = next.parent; // walking from the parent
  }
}

// public void Move(){
//   Tile t = new Tile();
//   Vector3 target = new Vector3();
//   if (path.Count >0){
//      t = path.Peek();
//      target = t.transform.position;
//
//     target.y += halfHeight + t.GetComponent<Collider>().bounds.extents.y; // calculates the players position on top of the target tile
//
//     if (Vector3.Distance(transform.position, target) >= 0.5f){
//       CalculateHeading();
//       SetHorizontalVelocity();
//
//       transform.forward = heading;
//       transform.position += velocity * Time.deltaTime; // the new position
//     }
//     else{
//       transform.position = target;
//       path.Pop(); // it is no longer part of the path, so we pop it, eventually we will have popped all the tiles
//     }
//   }
//   else{
//     RemoveSelectableTiles();
//     moving = false;
//   }
//
// }


protected void RemoveSelectableTiles(){
  if (currentTile != null){
    currentTile.current = false;
    currentTile =null;
  }
  foreach(Tile tile in selectableTiles){
  tile.Reset();
  }
  selectableTiles.Clear();
}


void CalculateHeading(Vector3 target){
  heading = target - transform.position;
  heading.Normalize();
}

void SetHorizontalVelocity(){ // this will move forward
  velocity = heading * moveSpeed;
}
}
