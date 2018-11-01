using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller2 : MonoBehaviour {
    public Sprite[] icon;
    public int flag = 0;
    public int[,] boxes = new int[3, 3];
    public GameObject NewText;

    // Use this for initialization
    void Start () 
    {


        if ((boxes[0, 0] == 1 && boxes[0, 1]== 1 && boxes[0, 2] == 1)
            || (boxes[1, 0] == 1 && boxes[1, 1] == 1 && boxes[1, 2] == 1)
            || (boxes[2, 0] == 1 && boxes[2, 1] == 1 && boxes[2, 2] == 1)
            || (boxes[0, 0] == 1 && boxes[1, 0] == 1 && boxes[2, 0] == 1)
            || (boxes[0, 1] == 1 && boxes[1, 1] == 1 && boxes[2, 1] == 1)
            || (boxes[0, 2] == 1 && boxes[1, 2] == 1 && boxes[2, 2] == 1)
            || (boxes[0, 0] == 1 && boxes[1, 1] == 1 && boxes[2, 2] == 1)
            || (boxes[0, 2] == 1 && boxes[1, 1] == 1 && boxes[2, 0] == 1)
            )
        {
            NewText.GetComponent<TextMesh>().text = ("O Win!");
        }

        else if ((boxes[0, 0] == 2 && boxes[0, 1] == 2 && boxes[0, 2] == 2)
            || (boxes[1, 0] == 2 && boxes[1, 1] == 2 && boxes[1, 2] == 2)
            || (boxes[2, 0] == 2 && boxes[2, 1] == 2 && boxes[2, 2] == 2)
            || (boxes[0, 0] == 2 && boxes[1, 0] == 2 && boxes[2, 0] == 2)
            || (boxes[0, 1] == 2 && boxes[1, 1] == 2 && boxes[2, 1] == 2)
            || (boxes[0, 2] == 2 && boxes[1, 2] == 2 && boxes[2, 2] == 2)
                 || (boxes[0, 0] == 2 && boxes[1, 1] == 2 && boxes[2, 2] == 2)
                 || (boxes[0, 2] == 2 && boxes[1, 1] == 2 && boxes[2, 0] == 2))
        {
            NewText.GetComponent<TextMesh>().text = ("X Win!");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
