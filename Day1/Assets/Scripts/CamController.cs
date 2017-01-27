using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour {

    Vector2 mouseLook;                  //2D vector that we will use to find out where we are looking at

    Vector2 smooth;                     //new vector that we will strive for

    public float sensitive = 5.0f;      //how fast would you like to turn

    public float smoothing = 2.0f;      //similar to sensitive, however its to keep in mind that its for Larp

    public GameObject player;                  //getting access to the parent object (Dexter), and making it a public var

    // Use this for initialization

    void Start()

    {

        player = this.transform.parent.gameObject;      //Getting access to Dexter
        smooth.x = 180f;
    }



    // Update is called once per frame

    void Update()

    {


        //print("X: " + Input.GetAxisRaw("Mouse X") + " Y: " + Input.GetAxisRaw("Mouse Y"));


        var mul = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));    //multiplying two vectors. Finding point where we are looking at

        //print(mul);


        float smoother = smoothing * sensitive;                                             //convention

        mul = Vector2.Scale(mul, new Vector2(smoother, smoothing));                         //changing position of previous vector



        smooth.x = Mathf.Lerp(smooth.x, mul.x, 1f / smoothing);  //Lerp(from, to, "steps")

        smooth.y = Mathf.Lerp(smooth.y, mul.y, 1f / smoothing);

        //will keep adding the vector needed to get to the point we are looking at
        //if -= everything will be inverted, opposite vector
        mouseLook += smooth;



        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);        //-mouseLook.y, so we are not inverted

        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);  //player.tranform.up, so 


    }

}
