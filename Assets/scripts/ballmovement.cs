using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    private int scoreP1 = 0;
    private int scoreP2 = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Reset();
    }

    // Update is called once per frame
    void Update()
    {   // Check if the ball is offscreen to reset
        if (transform.position.x > 12 || transform.position.x < -12)
        {
            if (transform.position.x > 12) scoreP2++;
            else scoreP1++;

            Reset();
        }

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

    public void Launch(Vector3 movement,float speed)
    {   //newtons does not need to be used here if we use the ForceMode.Impulse param
        //rb.AddForce(speed * movement, ForceMode.Impulse);
        rb.linearVelocity = movement * speed;
    }

    void Reset()
    {
        transform.position = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
        Vector3 movement = GetRandomBallDirection();
        Debug.Log(movement);
        Launch(movement, 5);
    }
}
