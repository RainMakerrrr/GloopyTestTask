using UnityEngine;

public class Player : MonoBehaviour
{
	public PlayerState State = PlayerState.NORMAL;

	public void FallDown(Transform player)
	{
		player.Translate(Vector3.down * _moveSpeed);
	}

	protected float _moveSpeed = 12f;

	protected void PlayerMove(Rigidbody rigidbody, Transform player)
	{
	  rigidbody.velocity = player.forward * _moveSpeed;
	}

	protected void CheckForFall(Transform player)
	{
		if (player.position.y <= -2.5f)
			player.gameObject.SetActive(false);
	}
}
public enum PlayerState
{
	REDUCED, NORMAL
}