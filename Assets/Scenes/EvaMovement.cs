using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // add to display the text; 

public class EvaMovement : MonoBehaviour
{
    public Text Posx;
    public Text Posy;
    public Text Posz;

    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {

        //Posx.text = "x = " + transform.position.x;
        //Posy.text = "y = " + transform.position.y;
        //Posz.text = "z = " + transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = -Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float zedAxys = 0;
        if (Input.GetKey(KeyCode.R))
        {
            zedAxys = -1;
        }

        if (Input.GetKey(KeyCode.F))
        {
            zedAxys = 1;
        }

        transform.Translate(new Vector3(horizontalInput, verticalInput, zedAxys) * speed * Time.deltaTime);

        // float posIndic = transform.position.x;
        Posx.text = "x \n" + transform.position.x.ToString("F2");
        Posy.text = "y \n" + transform.position.y.ToString("F2");
        Posz.text = "z \n" + transform.position.z.ToString("F2");


    }
}
