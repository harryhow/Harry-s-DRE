using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeHandler
{
    private Rigidbody rb;
    private Vector3 startPosition, endPosition, direction, torque = Vector3.zero;
    float touchStartTime, touchEndTime, intervalTime = 0f;

    private float throwForceY = 0.2f;
    private float throwForceZ = 20f; // Need to optimzie z force to have better throwing experience
    
    // Dice object
    private GameObject _dice;
    private bool _isRolled;
    private bool _isRollable;

    bool onTouchHold = false;

    public SwipeHandler() {
        this._isRolled = false;
        this._isRollable = true;
    }

    public void SwipeDice() 
    {
        if (Input.touchCount > 0) 
        {
            Touch touch = Input.GetTouch(0);
            
            if(touch.phase == TouchPhase.Began) 
            {
                startPosition = touch.position;
                touchStartTime = Time.time;

                Ray ray = Camera.current.ScreenPointToRay(startPosition);
                RaycastHit hitObject;

                if (Physics.Raycast(ray, out hitObject)) {
                    if(hitObject.transform.tag.Equals("dice")) {
                        onTouchHold = true;
                        rb.isKinematic = true;
                    }
                }
            }

            if (onTouchHold && touch.phase == TouchPhase.Ended) 
            {
                onTouchHold = false;
                // Force Detected
                touchEndTime = Time.time;
                intervalTime = touchEndTime - touchStartTime;
                endPosition = touch.position;
                direction = endPosition - startPosition;
                
                // Reset camera
                float xCameraRotation = Camera.current.transform.forward.x;
                float zCameraRotation = Camera.current.transform.forward.z;
                // Calculate force by touch interval and cam rotation
                float xForce = (throwForceZ / intervalTime) * xCameraRotation;
                float zForce = (throwForceZ / intervalTime) * zCameraRotation;
                float yForce = throwForceY * direction.y;

                // Add some physics!
                rb.isKinematic = false;
                rb.AddForce(xForce, yForce, zForce);
                rb.AddTorque(Random.Range(-200, 200), Random.Range(-200, 200), Random.Range(-200, 200));

                // Update dice throw status after touch hold and ended 
                _isRolled = true;
                _isRollable = false;
               
            }
        }
    }

    
    public void UpdateDiePosition() 
    {
        _dice.transform.position = Camera.current.ViewportToWorldPoint(new Vector3(0.5f, 0.2f, 0.5f));
        _dice.transform.rotation = Camera.current.transform.rotation;
    }


    // Dice object setter, getter
    public GameObject Dice 
    {
        get => _dice;    
        set {
            _dice = value;
            _isRolled = false;
            _isRollable = true;
            rb = _dice.GetComponent<Rigidbody>();
            rb.isKinematic = true;

            Vector3 v = new Vector3(_dice.transform.position.x, _dice.transform.position.y, 1f);
            _dice.transform.position = v;
        }
    }

    public bool IsRolled
    {
        get => _isRolled;
        set {
            _isRolled = value;
        }
    }

    public bool IsRollable
    {
        get => _isRollable;
        set {
            _isRollable = value;
        }
    }
}
