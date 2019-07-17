using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public Camera MainCamera;

    void Start()
    {
        
    }

    // REFACTOR
    void PerformMovement()
    {
        float hm = Input.GetAxis("Horizontal");
        Vector3 movementVector = new Vector3(hm, 0, 0);
        Vector3 newPlayerPosW =
            this.transform.position +
            Speed * movementVector * Time.deltaTime;
        Vector3 newPlayerPos =
            MainCamera.WorldToScreenPoint(newPlayerPosW);

        if (newPlayerPos.x >= 0 && newPlayerPos.x <= Screen.width)
        {
            this.transform.position = newPlayerPosW;
        }
    }

    void PerformShooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("PEW PEW");
        }
    }

    void Update()
    {
        PerformMovement();
        PerformShooting();
    }
}
