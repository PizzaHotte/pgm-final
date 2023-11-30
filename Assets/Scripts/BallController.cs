using UnityEngine;

public class BallController : MonoBehaviour
{
    private bool moveOnXAxis = true;

    public float moveSpeed = 5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
  
            moveOnXAxis = !moveOnXAxis;
        }

        float moveDirection = moveOnXAxis ? Input.GetAxis("Horizontal") : Input.GetAxis("Vertical");

        if (moveOnXAxis)
        {
            transform.Translate(new Vector3(moveDirection, 0f, 0f) * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(new Vector3(0f, 0f, moveDirection) * moveSpeed * Time.deltaTime);
        }
    }
}
