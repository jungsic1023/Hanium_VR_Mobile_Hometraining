using System.Collections;
using System.Collections.Generic; 
 using UnityEngine;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Car : MonoBehaviour 
    {
    public float speed = 2f;
public float jumpPower = 5f; 
public float rotateSpeed = 4f; //회전 스피드 변수 선언
    float horizontalMove; 
float verticalMove; 
Rigidbody rigdbody; 
Animator animator;
Vector3 movement; 
bool Isjumping;
void Awake()
{
    rigdbody= GetComponent<Rigidbody>();
    animator= GetComponent<Animator>();
    void Update()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal");
            verticalMove = Input.GetAxisRaw("Vertical");
            if (Input.GetButtonDown("Jump"))
                Isjumping = true;
          
        }
        void FixedUpdate()
        {
           
            Run();
            Turn(); //회전 
          
        }
        void Run()
        {
            movement.Set(horizontalMove, 0, verticalMove);
            movement = movement.normalized * speed * Time.deltaTime;
            rigdbody.MovePosition(transform.position + movement);
        }

        void Turn()
        {
            if (horizontalMove == 0 && verticalMove == 0)
                return;

            Quaternion newRotation = Quaternion.LookRotation(movement);
            rigdbody.rotation = Quaternion.Slerp(rigdbody.rotation, newRotation, rotateSpeed * Time.deltaTime);
        }

        void Start()
        {

        }

    }
}

