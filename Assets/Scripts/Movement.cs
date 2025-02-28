using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;
    public Vector3 moves;
    public float speed = 8f;
    public Vector2 dir;
    Camera cam;
    void Start ()
    {
        cam = Camera.main;
    }
    void Update()
    {
        //Movement
        moves.x = Input.GetAxis("Horizontal");
        moves.y = Input.GetAxis("Vertical");
        if (moves.x != 0 || moves.y != 0)
        {            
            player.transform.position += moves * speed * Time.deltaTime;
        }

        //Rotation
        dir = Input.mousePosition - cam.WorldToScreenPoint(player.transform.position);
        float ang = Vector2.SignedAngle(Vector2.up, dir);
        transform.rotation = Quaternion.AngleAxis(ang, Vector3.forward);
    }
}
