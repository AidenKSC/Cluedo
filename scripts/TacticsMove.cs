using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacticsMove : MonoBehaviour
{
//   List<Tile> selectableTiles = new List<Tile>(); // array of our tiles
//   GameObject[] tiles;
//
//   Stack<Tile> path = new Stack<Tile>(); // path calculates in reverese order, so stack is helpful
//   Tile currentTile; //calculated at the start of every turn
//
//   public int move = 5; // needs to link to dice roll, this is how many spaceces they can move
//   public float jumpHeight;
//   public float moveSpeed = 2;
//
//   Vector3 veolocity = new Vector3(); // player speed across tiles
//   Vector3 heading = new Vector3(); // direction player goes interface
//
// protected void Init(){
//   tiles = GameObject.FindGameObjectsWithTag("Tile");
//
//   halfHeight = GetComponent<Collider>().bounds.extends.y;
// }
//
// public void GetCurrentTile(){// starting point for path finding
//   currentTile = GetTargetTile(gameObject);
//   currentTile.current = true;
// }
//
// public void GetTargetTile(GameObject target){ // end goal for path finding
//   RaycastHit hit;
//   Tile tile = null;
//   if(Physics.Raycast(target.transform.position, -Vector3.up, out hit, 10)){
//     tile = hit.collider.GetComponent<Tile>();
//   }
//   return tile;
// }
//
// public void ComputeAdjacencyLists(){ // works out adjacency lists
//   foreach (GameObject tile in tiles){
//     Tile t = tile.GetComponent<Tile>();
//     t.FindNeighbours(jumpHeight); // will find walkable tiles for this particular unit
//
//   }
// }
//
// public void FindSelectableTiles(){ //BFS method
//   ComputeAdjacencyLists();
//   GetCurrentTile();
//
//   Queue<Tile> process = new Queue<Tile>();
//
//   process.Enqueue(currentTile); // add current tile to queue
//   currentTile.visited = true;
//
//   while (process.Count > 0){
//     Tile t = process.Dequeue(); // pops off tile at the front, so we can process it
//
//     selectableTiles.Add(t); // adds it to array
//     t.selectable = true;
//
//     if (t.distance < move){
//
//     foreach (Tile tile in t.adjacencyList){
//       if (!tile.visited){
//         tile.parent =t; // any adjacent tiles will be children of the initial tile
//         tile.visited = true;
//         tile.distance = 1 + t.distance; // distance variable keeps track of how far away from start tile we are
//         process.Enqueue(tile);
//       }
//     }
// }
//   }
//
// }
}
