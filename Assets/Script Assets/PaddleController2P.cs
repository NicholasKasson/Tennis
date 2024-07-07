using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController2P : MonoBehaviour
{

    public float speed;
    public float direction;
    public float adjustSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.I)){
            transform.position = new Vector3(transform.position.x,transform.position.y+(speed*Time.deltaTime),transform.position.z);
            direction = 1;
        } else if(Input.GetKey(KeyCode.K)){
            transform.position = new Vector3(transform.position.x,transform.position.y-(speed*Time.deltaTime),transform.position.z);
            direction = -1;
        } else {
            direction = 0;
        }        
    }
    void OnCollisionExit2D(Collision2D other){
        other.rigidbody.velocity = new Vector2(other.rigidbody.velocity.x * 1.1f,other.rigidbody.velocity.y + (direction*adjustSpeed));
    }
}
