using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColorChange : MonoBehaviour
{
    [SerializeField] private Material sphereMaterial;

    void Start(){
        sphereMaterial.color=Color.white;
    }
    void Update(){
        if(Input.GetMouseButtonDown(0)){
            SelectImage();
        }
    }

    public void SelectImage(){
        RaycastHit2D hit=Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
        if(hit.collider!=null){
            Debug.DrawLine(transform.position, hit.point, hit.collider.GetComponent<SpriteRenderer>().color,1f);
            sphereMaterial.color=hit.collider.GetComponent<SpriteRenderer>().color;
        }
    }

    public void Exit(){
        sphereMaterial.color=Color.white;
    }
}
