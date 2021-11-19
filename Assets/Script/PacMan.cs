using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour { 

    public float speed = 200.0f;

    // Start is called before the first frame update
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {

        CheckInput ();
    }

    void CheckInput()
    {
        /*
                if (Input.GetKeyDown (KeyCode.LeftArrow)) {

                    Move (Vector2.left);

                } else if (Input.GetKeyDown (KeyCode.RightArrow)) {

                    Move (Vector2.right);

                } else if (Input.GetKeyDown(KeyCode.UpArrow)) {

                    Move (Vector2.up);

                } else if (Input.GetKeyDown(KeyCode.DownArrow)) {

                    Move (Vector2.down);
                }


        */

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            Move(Vector2.up);

        }
    }

        void Move (Vector2 d) {
        transform.localPosition += (Vector3)(d * speed ) * Time.deltaTime;
    }
}
