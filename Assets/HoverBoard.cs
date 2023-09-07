using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class HoverBoard : MonoBehaviour
{
    Rigidbody rb;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }
    public float multiplier;
    public float moveForce, turnTorque ,jumpForce;
    public float jumpThershHold;

    public Transform[] anchors = new Transform[4];
    RaycastHit[] hits = new RaycastHit[4];
    private void FixedUpdate()
    {
        for (int i = 0; i < 4; i++)
        {
            ApplyForce(anchors[i], hits[i]);
        }
        anim.SetFloat("dir", Input.GetAxis("Horizontal"));
        //rb.AddForce(Input.GetAxis("Vertical") * moveForce * transform.forward);
        rb.AddForce(moveForce * transform.forward);
        if(Input.GetAxis("Horizontal") != 0)
        rb.AddForce(Input.GetAxis("Horizontal") * turnTorque * transform.right);

    }
    private void Update()
    {
        RaycastHit hit;
        Physics.Raycast(transform.position, -transform.up, out hit);
        if (Input.GetKeyDown(KeyCode.Space) && hit.distance < jumpThershHold)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }
    }
    void ApplyForce(Transform anchor , RaycastHit hit)
    {
        if(Physics.Raycast(anchor.position , -anchor.up , out hit))
        {
            float force = 0;
            force = Mathf.Abs(1 / (hit.point.y - anchor.position.y));
            rb.AddForceAtPosition(transform.up * force * multiplier, anchor.position, ForceMode.Acceleration);
        }
    }
}
