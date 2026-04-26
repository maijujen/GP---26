using UnityEngine;

namespace AH2721
{

    public class PlayerController : MonoBehaviour
    {
        //Changed from public to private: testing is done, can be set in stone now.
        private float speed = 15.0f;
        private float turnSpeed = 45.0f;
        private float horizontalInput;
        private float forwardInput;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Get player input
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

            //Move the vehicle with vertical input (up & down)
            transform.Translate(Vector3.forward * Time.deltaTime * speed *forwardInput);
            //Move the vehicle with horizontal input (left & right)
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
    }
}

