using UnityEngine;
using System;

public class Bullets : MonoBehaviour
{
    public Movement move;
    public GameObject bullet;
    Vector2 fdirection;
    public float force;
    void Start()
    {
        force = 500f;
        bullet.GetComponent<Rigidbody2D>().gravityScale = 0f;
    }

    void Update()
    {
        float m = Math.Max(Math.Abs(move.dir.x),Math.Abs(move.dir.y));
        if (m == 0) m = 1f; 
        fdirection  = new Vector2 (move.dir.x/m*force,move.dir.y/m*force);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject clonebullet = Instantiate(bullet, transform.position, transform.rotation);
            clonebullet.GetComponent<Rigidbody2D>().AddForce(fdirection);
        }
        
    }
}
