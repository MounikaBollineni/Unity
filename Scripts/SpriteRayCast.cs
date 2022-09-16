using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRayCast : MonoBehaviour
{
    public float speed;
    public float distance;
    Rigidbody2D rb;

void Start(){
    rb=GetComponent<Rigidbody2D>();
}
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            rb.velocity=new Vector2(-speed, rb.velocity.y);
        }
        else if(Input.GetKey(KeyCode.D))
        {
             rb.velocity=new Vector2(speed, rb.velocity.y);
        }

        int layermask=1<<8;
        layermask=~layermask;
        RaycastHit2D hitdown=Physics2D.Raycast(transform.position,transform.up, distance,layermask);
        Debug.DrawLine(transform.position,transform.up,Color.red,1f);
        if(hitdown.collider!=null){
            Debug.Log(hitdown.collider.name);
            Debug.Log(hitdown.point);
        }

        RaycastHit2D hitright=Physics2D.Raycast(transform.position,transform.right, distance,layermask);
        RaycastHit2D hitleft=Physics2D.Raycast(transform.position,-transform.right, distance,layermask);

        if(hitright.collider!=null){
            Debug.Log("right"+hitright.collider.name);
        }
        if(hitleft.collider!=null){
            Debug.Log("left"+hitleft.collider.name);
        }
    }
}
