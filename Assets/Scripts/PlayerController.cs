using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public bool canMove = true;
    [SerializeField]
    float maxPos;

    [SerializeField]
    float moveSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (canMove)
        {
            Move();
        }

    }
    void Move()
    {

        float inputX = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);

        transform.position = new Vector3 (xPos, transform.position.y, transform.position.z);

    }
}
