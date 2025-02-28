using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;
    public Vector3 moves;
    void Start()
    {
        
    }

    void Update()
    {
        moves.x = Input.GetAxis("Horizontal");
        moves.y = Input.GetAxis("Vertical");
        if (moves.x != 0 || moves.y != 0)
        {
            player.transform.position += moves;
        }
        
    }
}
