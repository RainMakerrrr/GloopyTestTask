using UnityEngine;

public class EndGame : MonoBehaviour, ITriggerable
{
    public void Trigger(Player player)
    {
        Debug.Log("You win!");
        player.gameObject.SetActive(false);
    }
}
