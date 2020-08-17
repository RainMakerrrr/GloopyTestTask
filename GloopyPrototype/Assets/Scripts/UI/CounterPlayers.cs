using UnityEngine;
using UnityEngine.UI;

public class CounterPlayers : MonoBehaviour
{
    [SerializeField] private Text _counterText;

    private void Update()
    {
        _counterText.text = " " + CrowdController.Instance.Players.Count.ToString() + "	/ 6";
    }
}
