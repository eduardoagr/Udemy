
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody body;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            body.AddRelativeForce(Vector3.up);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("Rotating Left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Rotating Right");
        }
    }
}
