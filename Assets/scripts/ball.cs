using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    private int speed=6;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
       // Reset();
    }

    // Update is called once per frame
    void Update()
    {   // Check if the ball is offscreen to reset


    }

    Vector3 GetRandomBallDirection()
    {
        float x = 1;
        float y = 1;
        if (Random.Range(0, 2) == 0)
        {
            x = -1;
        }
        if (Random.Range(0, 2) == 0)
        {
            y = -1;
        }
        return new Vector3(x, y, 0);
    }

    void Launch(Vector3 movement,float speed)
    {   //newtons does not need to be used here if we use the ForceMode.Impulse param
        //rb.AddForce(speed * movement, ForceMode.Impulse);
        rb.linearVelocity = movement * speed;
    }

    public void Reset()
    {
        transform.position = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
        Vector3 movement = GetRandomBallDirection();
        Debug.Log(movement);
        Launch(movement, speed);
    }
}
