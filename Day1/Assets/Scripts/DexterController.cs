using UnityEngine;
using System.Collections;

public class DexterController : MonoBehaviour
{
    public float speed = 10.0f;
    // Use this for initialization
    void Start()
    {
        //will keep cursor in the middle 
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //If we press space, we see the cursor again
        if (Input.GetKeyDown("space"))
            Cursor.lockState = CursorLockMode.None;
   
        //move forward and backwards
        float forwardBack = Input.GetAxis("Vertical") * speed;
        //move left to right
        float leftRight = Input.GetAxis("Horizontal") * speed;

        //deltaTime, time it took for last frame to finish
        //without deltaTime it will go too fast, not smooth

        //print("delta Time: " + Time.deltaTime);
        //print("without: " + Input.GetAxis("Horizontal") * speed);

        forwardBack *= Time.deltaTime;
        leftRight *= Time.deltaTime;

        //
        transform.Translate(leftRight, 0, forwardBack);

        }
}
