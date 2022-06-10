using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using System;

public class PlayerController : MonoBehaviour
{
    public bool _MetalGear;
    public bool Stealthy=true;
    public string _tag;
    private float horizontalInput;
    private float verticalInput;
    public InputAction movement;
    public InputAction jump;
    public InputAction Stealth;
    public bool candoublejump=true;
    public Transform LastCheckPoint;
    [SerializeField]
    public float maximumSpeed;

    [SerializeField]
    private float rotationSpeed;

    [SerializeField]
    private float jumpSpeed;

    [SerializeField]
    private float jumpButtonGracePeriod;

    public Transform cameraTransform;

    private Animator animator;
    private CharacterController characterController;
    private float ySpeed;
    private float originalStepOffset;
    private float? lastGroundedTime;
    private float? jumpButtonPressedTime;
    private float _jump;
    private float _Stealth;
    bool disabled;
    Rigidbody rb;
    public float _dashTime;
    public float _dashSpeed;
    public Vector3 movementDirection;
    public bool canDash=true;
    private void Awake()
    {
        Stealthy = true;
        _tag = gameObject.tag;
        jump.performed += ONJumpPreformed;
        jump.canceled += ONJumpPreformed;
        Stealth.performed += ONStealthPreformed;
        Stealth.canceled += ONStealthPreformed;
        movement.performed += OnMovementPreformed;
        movement.canceled += OnMovementPreformed;
    }
    private void start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        jump.Enable();
        movement.Enable();
        Stealth.Enable();
    }
    private void OnDisable()
    {
        jump.Disable();
        movement.Disable();
        Stealth.Disable();
    }
    private void OnMovementPreformed(InputAction.CallbackContext context)
    {
        var dir = movement.ReadValue<Vector2>();
        horizontalInput = dir.x;
        verticalInput = dir.y;        
    }
    private void ONJumpPreformed(InputAction.CallbackContext context)
    {
        _jump = jump.ReadValue<float>();
    }
    private void ONStealthPreformed(InputAction.CallbackContext context)
    {
        _Stealth = Stealth.ReadValue<float>();
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        originalStepOffset = characterController.stepOffset;
    }
    IEnumerator Dash()
    {
        float startTime = Time.time;
        if (canDash)
        {
            while (Time.time < startTime + _dashTime)
            {
                characterController.Move(movementDirection * _dashSpeed * Time.deltaTime);
                yield return null;
            }
            canDash = false;
            StartCoroutine(DashTimer());
        }

        
    }
    IEnumerator DashTimer()
    {

        yield return new WaitForSeconds(5);
        canDash = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (horizontalInput != 0 || verticalInput != 0)
        {
            
            animator.SetBool("ismoving", true);
            
        }

        else
        {
            animator.SetBool("ismoving", false);

        }

         movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);

        if (_Stealth!=0)
        {
            inputMagnitude *= 2;
            StartCoroutine(Dash());

        }
        if (_MetalGear)
        {
            if (_Stealth != 0)
            {
                    inputMagnitude *= 2;
                    transform.GetChild(0).gameObject.SetActive(true);
                    gameObject.tag = "Food";
            }
            else
                transform.GetChild(0).gameObject.SetActive(false);

        }

        // animator.SetFloat("Input Magnitude", inputMagnitude, 0.05f, Time.deltaTime);

        float speed = inputMagnitude * maximumSpeed;
        movementDirection = Quaternion.AngleAxis(cameraTransform.rotation.eulerAngles.y, Vector3.up) * movementDirection;
        movementDirection.Normalize();

         ySpeed += Physics.gravity.y * Time.deltaTime;
       
         if (characterController.isGrounded)
         {
             lastGroundedTime = Time.time;
         }

         if (_jump!=0)
         {
             jumpButtonPressedTime = Time.time;
         }

         if (Time.time - lastGroundedTime <= jumpButtonGracePeriod)
         {
             characterController.stepOffset = originalStepOffset;
             ySpeed = -0.5f;

             if (Time.time - jumpButtonPressedTime <= jumpButtonGracePeriod)
             {
                 ySpeed = jumpSpeed;
                 jumpButtonPressedTime = null;
                 lastGroundedTime = null;
                 animator.SetTrigger("isJumping");
                 candoublejump = true;
             }

         }
         else
         {
             characterController.stepOffset = 0;
         }
       

        Vector3 velocity = movementDirection * speed;
        
        velocity.y = ySpeed;
        characterController.Move(velocity * Time.deltaTime);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Platform")
        {
            transform.parent = other.transform;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Platform")
        {
            transform.parent = null;

        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "CheckPoint")
        {
            Debug.Log(collision.gameObject.name);
            LastCheckPoint = collision.transform;
        }
    }

    private void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

}

