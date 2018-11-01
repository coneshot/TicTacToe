using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {
    public int row;
    public int col;
    public GameObject core;


    public void OnMouseDown()
    {
        int[,] boxes = new int[3, 3];
        boxes = core.GetComponent<gamecontroller2>().boxes;
        int flag = core.GetComponent<gamecontroller2>().flag;


        if (boxes[row,col]==0) //還沒被點過了
        {
            if(flag%2==0)
            {
                GetComponent<SpriteRenderer>().sprite = core.GetComponent<gamecontroller2>().icon[0];
                boxes[row, col] = 1;
                flag += 1;
                core.GetComponent<gamecontroller2>().flag = flag;
                Debug.Log(flag);
                Debug.Log(boxes[row,col]);
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = core.GetComponent<gamecontroller2>().icon[1];
                boxes[row, col] = 2;
                flag += 1;
                core.GetComponent<gamecontroller2>().flag = flag;
                Debug.Log(flag);
                Debug.Log(boxes[row, col]);
            }
           
        }

       
        else//偶數次被點
        {
           
        }
       
    }

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
