using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField] KeyCode _keyUP;
    [SerializeField] KeyCode _keyDown;
    [SerializeField] KeyCode _keyLeft;
    [SerializeField] KeyCode _keyRight;
    [SerializeField] KeyCode _keyJump;
    [SerializeField] Vector3 _moveDirect;
    [SerializeField] Vector3 _moveRight;
    [SerializeField] Vector3 _moveUp;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(_keyDown))
        {
            GetComponent<Rigidbody>().velocity += _moveDirect;
        }
        if (Input.GetKey(_keyUP))
        {
            GetComponent<Rigidbody>().velocity -= _moveDirect;
        }
        if (Input.GetKey(_keyRight))
        {
            GetComponent<Rigidbody>().velocity += _moveRight;
        }
        if (Input.GetKey(_keyLeft))
        {
            GetComponent<Rigidbody>().velocity -= _moveRight;
        }
        if (Input.GetKey(_keyJump))
        {
            GetComponent<Rigidbody>().velocity += _moveUp;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}
