using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PressAnyButton : MonoBehaviour
{
    public InputAction Press;
   // public enum PlayerJoinBehavior : 0;

    private void Awake()
    {
        Press.AddBinding();
    }
    private void Update()
    {
        
      //  if(TrackedDevice)
    }
    
}
