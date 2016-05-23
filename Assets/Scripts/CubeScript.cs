using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

    bool gravitySwitch = false;
	
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * 10 * Time.deltaTime);
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (gravitySwitch)
            {
                GetComponent<Rigidbody2D>().gravityScale = -1.0f;
                gravitySwitch = false;
            }
            else
            {
                GetComponent<Rigidbody2D>().gravityScale = 1.0f;
                gravitySwitch = true;
            }
            
        }
	}
}
