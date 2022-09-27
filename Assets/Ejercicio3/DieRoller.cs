using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
public class DieRoller : MonoBehaviour
{
    public Toggle flankingToggle;
    public SOModifier soModifier;
    public Text totalText;
    public void RollDie()
    {
        int total = Random.Range(1, 20);
        total += GetTotalBonus();
        Debug.Log("Rolled a d20 for a total of " + total);
    }

    public int GetTotalBonus()
    {
       return flankingToggle.isOn ? soModifier.value : 0;
    }
}
