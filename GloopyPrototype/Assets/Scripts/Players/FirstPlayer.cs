using UnityEngine;

public class FirstPlayer : Player
{
    private Rigidbody _rigidbody;

    private void Start()
    {
       _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerMove(_rigidbody, transform);
        CheckForFall(transform);
    }
}
