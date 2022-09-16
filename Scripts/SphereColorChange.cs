using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
     void Update(){
        if (Input.GetMouseButtonUp(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            int layermask=1<<8;
            layermask=~layermask;
            RaycastHit2D hit = Physics2D.Raycast(transform.position,Input.mousePosition,1f,layermask);
            Debug.Log(hit.transform.name);
            Debug.Log(hit.collider.name);
             //RaycastHit2D hit = Physics2D.Raycast(this.gameObject.transform.position, direction);
           
            Debug.DrawLine(transform.position,Input.mousePosition, hit.collider.GetComponent<RawImage>().color,1f); 
        }
    }
}
