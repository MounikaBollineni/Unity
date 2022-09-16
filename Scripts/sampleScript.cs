using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sampleScript : MonoBehaviour
{
    public GameObject Sphere;
 
    // Start is called before the first frame update
    public Button button1, button2, button3;
    private int Index;
    private Color[] colors={Color.red,Color.green,Color.blue};
    void Start()
    {
        button1.onClick.AddListener(() => ButtonClicked(1));
        button2.onClick.AddListener(() => ButtonClicked(2));
        button3.onClick.AddListener(() => ButtonClicked(3));
    }

    public void ButtonClicked(int index){
        Index=index-1;
        Debug.Log(colors[Index]);
        Sphere.GetComponent<MeshRenderer>().material.color=colors[Index];
    }


}
