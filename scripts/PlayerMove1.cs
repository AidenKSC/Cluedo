using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove1 : tacticsMove1
{
    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
      if (!moving){
        FindSelectableTiles();
        CheckMouse();
      }
      else {
      //  Move();
      }

    }

    void CheckMouse(){ // this method will be us clicking on a tile
      RaycastHit hit;
        if (Input.GetMouseButtonUp(0)){ // Left click
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);// makes a ray from the where the mouse was clicked

          if(Physics.Raycast(ray, out hit)){
            if (hit.collider.tag == "Tile"){ // if they click on a tiles
              Tile t = hit.collider.GetComponent<Tile>();

              if (t.selectable){
                MoveToTile(t);
              }
            }
          }
        }
    }
}
