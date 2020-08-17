using System.Collections.Generic;
using UnityEngine;

public class CrowdController : MonoBehaviour
{
    private float _moveSpeed = 5f;

    public List<Player> Players = new List<Player>();
    public static CrowdController Instance;
    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            foreach (var player in Players)
                player.transform.Translate(Vector3.left * _moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            foreach (var player in Players)
                player.transform.Translate(Vector3.right * _moveSpeed * Time.deltaTime);
        }

        CheckForNumbersOfPlayers();
    }

    private void CheckForNumbersOfPlayers()
    {
        if (Players.Count == 0) Debug.Log("You lose");
    }
}
