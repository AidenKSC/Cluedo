using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
  public bool walkable = true; // can use this for outside spaces, just set to false
  public bool current = false;
  public bool target = false;
  public bool selectable = false;
  public bool room = false; // is it a room or not?


  public List<Tile> adjacencyList = new List<Tile>();
  // needed for BFS
  public bool visited = false;
  public Tile parent = null;
  public int distance = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (current){
            GetComponent<Renderer>().material.color = Color.magenta;
          }

        else if (target){
            GetComponent<Renderer>().material.color = Color.green;
          }

        else if (selectable){
          GetComponent<Renderer>().material.color = Color.red;
        }

        else {
          GetComponent<Renderer>().material.color = Color.white;
        }
    }

    public void Reset(){ // resets all the tiles and their properties
      adjacencyList.Clear();

      current = false;
      target = false;
      selectable = false;
      room = false; // is it a room or not?

      visited = false;
      parent = null;
      distance = 0;
    }

    public void FindNeighbours3(){
      //Reset();
      //CheckTile(Vector3.forward, 5);
      //CheckTile(-Vector3.forward, 5);
      //CheckTile(Vector3.right, 5);
      //CheckTile(-Vector3.right, 5);
      print("max is gay");
    }

    public void FindNeighbours(float jumpHeight, Tile target){
      Reset();
      CheckTile(Vector3.forward, jumpHeight);
      CheckTile(-Vector3.forward, jumpHeight);
      CheckTile(Vector3.right, jumpHeight);
      CheckTile(-Vector3.right, jumpHeight);
      print("max is gay");
    }

    public void seb(){
      print("hello");
    }

    public void CheckTile(Vector3 direction,float jumpHeight){
      Vector3 halfExtends = new Vector3(0.25f, (10 + jumpHeight)/2.0f, 0.25f);
      Collider[] colliders = Physics.OverlapBox(transform.position + direction, halfExtends );
      RaycastHit hit;

      foreach (Collider item in colliders){
        Tile tile = item.GetComponent<Tile>();
        if (tile != null && tile.walkable)
          //RaycastHit hit;

          if (!Physics.Raycast(tile.transform.position, Vector3.up, out hit, 1)){ // if there isnt a charachter on this square
            adjacencyList.Add(tile);
          }

      }
    }
}
