using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _currentTarget;
    private Vector3 _offset;
    private void Start()
    {
        _currentTarget = CrowdController.Instance.Players[0].transform;
        _offset = transform.position - _currentTarget.position;
    }

    private void LateUpdate()
    {
        CameraMove();   
    }

    private void CameraMove()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, _offset.z + _currentTarget.position.z);
        transform.position = newPosition;

        SwitchCamera();
        
    }

    private void SwitchCamera()
    {
        if (CrowdController.Instance.Players.Count == 0) return;

        if (!_currentTarget.gameObject.activeInHierarchy)
        {   
            _currentTarget = CrowdController.Instance.Players[0].transform;
        }
    }
}
