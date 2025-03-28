using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
    // SerializeField exposes this value to the Editor, but not to other Scripts!
    // It is "pseudo public"
    // HorizontalPlayerAcceleration indicates how fast we accelerate Horizontally

    private PlayerInputScript InputScript;
    [SerializeField]
    public float f_horPlayAccel = 5000f;
    
    public Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start() 
    {
        // Get OurRigidbodyComponent once at the start of the game and store a reference to it
        // This means that we don't need to call GetComponent more than once! This makes our game faster. (GetComponent is SLOW)
        InputScript = GetComponent<PlayerInputScript>();
        ourRigidbody = GetComponent<Rigidbody2D>(); 
    }
    // Update is called once per frame
    void Update()
    {
        InputScript.SetInput();
    }
        
}
