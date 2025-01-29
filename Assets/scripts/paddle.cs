using UnityEngine;

public class paddlemovement : MonoBehaviour
{
    public string vertInputAxis = "VerticalP1"; // Set input axis in the inspector
    public float speed = 5f;  // Speed of the paddle
    private Rigidbody rb;
    private float vertInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Freeze rotation
    }

    // Update is called once per frame
    void Update()
    {
        vertInput = Input.GetAxisRaw(vertInputAxis);  // Get vertical axis input (raw for instant movement)
 
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(0, vertInput * speed * Time.deltaTime, 0);
        Vector3 newPos = transform.position + movement;

        // Limit paddle movement (clamp the y position)
        newPos.y = Mathf.Clamp(newPos.y, -5.5f, 5.5f);  // Assuming the boundary is at Y = ±6

        rb.MovePosition(newPos);  // Move the paddle to the new position
    }

}
