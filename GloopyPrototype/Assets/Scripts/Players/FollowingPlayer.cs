using UnityEngine;

public class FollowingPlayer : Player
{    
    private Rigidbody _rigidbody;
    private CrowdController _crowdController;
   
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _crowdController = FindObjectOfType<CrowdController>();
       
        _moveSpeed = 0f;
    }

    private void Update()
    {
        PlayerMove(_rigidbody, transform);
        CheckForFall(transform);
    }

    private void OnTriggerEnter(Collider other)
    {
        var otherPlayer = other.GetComponent<Player>();
        if (otherPlayer)
        {
            if (!_crowdController.Players.Contains(this))
            {
                _moveSpeed = 12f;
                _crowdController.Players.Add(this);
            }
        }        
    }
}


