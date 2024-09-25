using UnityEngine;

public class ToTheMoon : MonoBehaviour
{
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            _rb.useGravity= true;
            _rb.mass= 1.0f;
            _rb.drag = 0;
            _rb.angularDrag = 10.0f;
            _rb.velocity = new Vector3(0, 100, 0);
        }
    }
}