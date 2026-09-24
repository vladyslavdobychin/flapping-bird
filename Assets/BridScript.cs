using UnityEngine;
using UnityEngine.InputSystem;


public class BridScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float flapStreangth = 12;

    void Start()
    {

    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rigidbody2D.linearVelocity = Vector2.up * flapStreangth;
        }
    }
}
