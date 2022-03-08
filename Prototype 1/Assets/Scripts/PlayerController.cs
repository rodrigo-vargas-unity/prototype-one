using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 15.0f;
    
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput = 1.0f;

    public string horizontalAxisName = "Horizontal Player One";
    public string forwardInputName = "Vertical Player One";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis(horizontalAxisName);
        forwardInput = Input.GetAxis(forwardInputName);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput * 10);
    }
}
