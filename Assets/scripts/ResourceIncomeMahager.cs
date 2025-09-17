using UnityEngine;
using UnityEngine.UI;

public class DevPanelManager : MonoBehaviour
{
    public UIResourceManager uiManager;

    public void IncreaseOxygenIncome()
    {
        uiManager.ChangeIncome("oxygen", 10);
    }

    public void DecreaseOxygenIncome()
    {
        uiManager.ChangeIncome("oxygen", -10);
    }

    public void IncreaseProteinIncome()
    {
        uiManager.ChangeIncome("protein", 10);
    }

    public void DecreaseProteinIncome()
    {
        uiManager.ChangeIncome("protein", -10);
    }

    public void IncreaseGlucoseIncome()
    {
        uiManager.ChangeIncome("glucose", 10);
    }

    public void DecreaseGlucoseIncome()
    {
        uiManager.ChangeIncome("glucose", -10);
    }

    public void IncreasevitIncome()
    {
        uiManager.ChangeIncome("vitamins", 10);
    }

    public void DecreasevitIncome()
    {
        uiManager.ChangeIncome("vitamins", -10);
    }
}
