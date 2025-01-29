using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball ball;
    private int scoreP1 = 0;
    private int scoreP2 = 0;
    private int minboundx = -12;
    private int maxboundx = 12;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // if (ball != null)
        {
            ball.Reset();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x > maxboundx || ball.transform.position.x < minboundx)
        {
            if (transform.position.x > maxboundx) scoreP2++;
            else scoreP1++;

            ball.Reset();
        }
    }
}
