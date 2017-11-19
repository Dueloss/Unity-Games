using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool AutoPlaye = false;

    private Ball ball;

    private void Start()
    {
        ball = GameObject.FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!AutoPlaye)
        {
            moveWithMouse();
        }
        else
        {
            autoPlay();
        }
    }
    void autoPlay()
    {
        Vector3 paddlePos = new Vector3(0, transform.position.y, 0f);
        Vector3 ballPos = ball.transform.position;

        paddlePos.x = Mathf.Clamp(ballPos.x, 0.5f, 15.5f);

        transform.position = paddlePos;
    }
    void moveWithMouse()
    {
        Vector3 paddlePos = new Vector3(0, transform.position.y, 0f);
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);

        transform.position = paddlePos;
    }
}