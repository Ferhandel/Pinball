using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    public enum FlipperSide {Left, Right};
    public FlipperSide side;

    private Rigidbody rb;

    private Vector3 initRotation;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initRotation = rb.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(GetActivationKey())) {
            //Movemos el flipper hacia arriba
            rb.MoveRotation(Quaternion.Euler(new Vector3 (0, initRotation.y + GetSentidoRotacion() * 40, 0)));
        }
        if(Input.GetKeyUp(GetActivationKey())) {
            rb.MoveRotation(Quaternion.Euler(new Vector3 (0, initRotation.y, 0)));
        }
    }

    private KeyCode GetActivationKey() {
        return side == FlipperSide.Left ? KeyCode.LeftControl : KeyCode.RightControl;
    }

    private int GetSentidoRotacion() {
        return side == FlipperSide.Left ? -1 : 1;
    }


}
