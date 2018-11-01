using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {
    public int row;
    public int col;
    public GameObject core;

    public void OnMouseDown()
    {

        int[,] boxes = core.GetComponent<gamecontroller2>().boxes;
        int flag = core.GetComponent<gamecontroller2>().flag;

        /*if ()//已經被點過了
        { }*/

        if (flag%2==0) //基數次被點
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<gamecontroller2>().icon[0];

            flag += 1;
        }

        else if (flag%2==1) //偶數次被點
        {
            GetComponent<SpriteRenderer>().sprite = core.GetComponent<gamecontroller2>().icon[1];
            boxes[,]= 2;
            flag += 1;
        }
    }

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
