using UnityEngine;
using System.Collections;

public class PlayerInputScript : MonoBehaviour
{
    private PlayerMovementScript MovementScript;
    // Update is called once per frame

    void Start()
    {
        MovementScript = GetComponent<PlayerMovementScript>();
    }

    public void SetInput()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput != 0.0f)
        {
            Vector2 ForceToAdd = Vector2.right * HorizontalInput * MovementScript.f_horPlayAccel * Time.deltaTime;
            MovementScript.ourRigidbody.AddForce(ForceToAdd);
            //print(HorizontalInput);
        }
    }
    
}
