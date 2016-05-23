using UnityEngine;
using System.Collections;

public class FlyingObjectScript : MonoBehaviour {

    GameObject player, camera;

	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
        camera = GameObject.FindWithTag("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * 5 * Time.deltaTime);
        float distance = Vector2.Distance((Vector2)player.transform.position, (Vector2)transform.position);
        if (distance >= 20)
        {
            int yAxis = Random.Range(-3, 4);
            Vector3 spawnLoc = camera.transform.position + (Vector3.right * 10) + (Vector3.forward * 10) + (Vector3.up * yAxis);
            Object obj = Instantiate(gameObject, spawnLoc, Quaternion.identity);
            obj.name = obj.name.Replace("(Clone)", "");
            Destroy(this.gameObject);
        }
	}
}
