using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Ability;

public class CharacterScript : MonoBehaviour
{
    public ability _ability;
    public GameObject redEffect;
    public float[] rows = new float[] { -1, 0, 1 };     // x position of each row
    public int targetRow = 1;
    private CharacterController charController;
    public Controls PlayerControls;
    float _hor;
    float _jump;
    float _attack1;
    float _attack2;
    float _attack3;
    float _attack4;
    float _crouch;
    public Animator anim;
    Vector3 movement;
    public float jumpHeight=0.8f;
    public float gravityMultiplier = 1f;
    public float speedrotation;
    public Camera cam;
    public BoxCollider bc;
    public bool _firstAttack;
    public bool _secondAttack;
    public bool _thirdAttack;
    public bool _freez;
    public bool _inv;
    public float playerSpeed;
    public int playerid;
    public int Chances;
    private void Awake()
    {
        bc = GetComponent<BoxCollider>();
        anim = GetComponent<Animator>();
        charController = GetComponent<CharacterController>();   
        transform.position = new Vector3(rows[targetRow], 0, 0);
        Debug.Log(rows[targetRow]);
    }
    public void PlayerChances()
    {
        Chances--;
    }
    public IEnumerator turnRedEffect()
    {
        redEffect.SetActive(true);
        yield return new WaitForSeconds(1f);
        redEffect.SetActive(false);
    }

    public void OnMovePreformed(InputAction.CallbackContext context)
    {
        _hor = context.ReadValue<float>();
    }
    public void OnCrouchPreformed(InputAction.CallbackContext context)
    {
        _crouch = context.ReadValue<float>();
    }
    public void OnJumpPreformed(InputAction.CallbackContext context)
    {
        _jump = context.ReadValue<float>();
    }
    public void OnAttack1Preformed(InputAction.CallbackContext context)
    {
        _attack1 = context.ReadValue<float>();
    }
    public void OnAttack2Preformed(InputAction.CallbackContext context)
    {
        _attack2 = context.ReadValue<float>();
    }
    public void OnAttack3Preformed(InputAction.CallbackContext context)
    {
        _attack3 = context.ReadValue<float>();
    }
    public void OnAttack4Preformed(InputAction.CallbackContext context)
    {
        _attack4 = context.ReadValue<float>();
    }
    void Update()
    {
        if (_freez)
            _hor = 0;
        if (_inv)
            _hor = -_hor;
        if (_hor==-1 && targetRow > 0)
        {
            anim.SetBool("Run", true);
            targetRow--;
            _hor = 0;
        }

        if (_hor == 1 && targetRow < rows.Length - 1)
        {
            anim.SetBool("Run", true);
            targetRow++;
            _hor = 0;
        }
        if ((_jump != 0)&&(charController.isGrounded))
        {
            //cam.transform.Rotate(10, 0, 0);
            movement.y = jumpHeight;
            anim.SetTrigger("Jump");
            anim.SetBool("Run", true);
            _jump = 0;
        }
        // Applying Gravity
        if (charController.isGrounded == false)
        {
            //cam.transform.Rotate(-10, 0, 0);
            movement.y += Physics.gravity.y * gravityMultiplier;
        }
        // Applying Movement
        transform.position = new Vector3(rows[targetRow], 0, 0);
        charController.Move(movement * Time.deltaTime);

        //Move Character Controller towards target row when distance is greater than 0.05
        if (Mathf.Abs(transform.position.x - rows[targetRow]) > 0.05f)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime * speedrotation);
            

            if (transform.position.x < rows[targetRow])
            {
                charController.Move(Vector3.right * Time.deltaTime*playerSpeed);
            }
            else if (transform.position.x > rows[targetRow])
            {
                charController.Move(Vector3.left * Time.deltaTime*playerSpeed);
            }
        }
        //Lerp transform to position when character controller is close enough
        else
        {
            Quaternion rot = Quaternion.Euler(0, 0, 0);
            transform.rotation = rot;
            transform.position = Vector3.Lerp(transform.position, new Vector3(rows[targetRow], 0, 0), Time.deltaTime);
        }
        if (_attack1 != 0)
        {
            anim.SetTrigger("Attack");
            anim.SetBool("Run", false);
            _firstAttack = true;
            StartCoroutine(FirstAttack());
            _attack1 = 0;
            
        }
        if (_attack2 != 0)
        {
            anim.SetTrigger("Attack");
            anim.SetBool("Run", false);
            _secondAttack = true;
            StartCoroutine(SecondAttack());
            _attack2 = 0;
            
        }
        if (_attack3 != 0)
        {
            anim.SetBool("Run", false);
            anim.SetTrigger("Attack");
            _thirdAttack = true;
            StartCoroutine(thirdAttack());
            _attack3 = 0;
            
        }
        if (_attack4 != 0)
        {
            
            _attack4 = 0;
        }
        if (_crouch != 0)
        {
            bc.size = new Vector3(0.5f, 0.4f, 0.5f);
            bc.center=new Vector3(0, 0.2f, 0);
            StartCoroutine(crouchTimer());
            anim.SetTrigger("Crouch");
            _crouch = 0;
        }
        switch (_ability)
        {
            case ability.None:
                GetComponent<Score>()._x2 = 1;
                break;
            case ability.X2boost:
                GetComponent<Score>()._x2 = 2;
                break;
            case ability.Freeze:
                _freez = true;
                StartCoroutine(Freez());
                break;
            case ability.Inv:
                _inv = true;
                StartCoroutine(Inv());
                break;
        }
        if (Chances < 0)
        {
            Time.timeScale = 0;
            LevelEditor.levelEditorInstance.Again();
        }
    }
    IEnumerator crouchTimer()
    {

        yield return new WaitForSeconds(1);
        bc.size = new Vector3(0.5f, 1f, 0.5f);
        bc.center = new Vector3(0, 0.5f, 0);
    }
    IEnumerator FirstAttack()
    {
        yield return new WaitForSeconds(3f);
        anim.SetBool("Run", true);
        _firstAttack = false;
    }
    IEnumerator SecondAttack()
    {
        yield return new WaitForSeconds(3f);
        anim.SetBool("Run", true);
        _secondAttack = false;
    }
    IEnumerator thirdAttack()
    {
        yield return new WaitForSeconds(0.3f);
        anim.SetBool("Run", true);
        _thirdAttack = false;
    }
    IEnumerator Freez()
    {
        yield return new WaitForSeconds(0.3f);
        _ability = ability.None;
        _freez = false;
    }
    IEnumerator Inv()
    {
        yield return new WaitForSeconds(0.3f);
        _ability = ability.None;
        _inv = false;
    }
}
