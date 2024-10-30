
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D Rb;
    void Start()
    {
        Rb.velocity = transform.up * Speed;
    }
}
