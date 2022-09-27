using UnityEngine;
using UnityEngine.UI;
public class BonusManager : MonoBehaviour
{
    public static BonusManager instance;
    private void Awake()
    {
        instance = this;
    }
    public int flankingBonus = 5;
    public int totalBonus;

    public void ToggleFlanking()
    {
        
    }
}
