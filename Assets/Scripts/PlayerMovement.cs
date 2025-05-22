using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    public float speed = 5f;

    void Update()

    {

        float moveX = Input.GetAxis("Horizontal"); // A/D

        float moveZ = Input.GetAxis("Vertical");   // W/S

        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        transform.Translate(movement * speed * Time.deltaTime, Space.World);

    }

}

