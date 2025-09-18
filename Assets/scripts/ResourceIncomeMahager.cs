using UnityEngine;
using UnityEngine.UI;

public class DevPanelManager : MonoBehaviour
{
    public UIResourceManager uiManager;

    public void IncreaseOxygenIncome()
    {
        if (uiManager.points > 0)
        {
            uiManager.oxygenPoints++;
            uiManager.points--;
            uiManager.ChangeIncome("oxygen", 10);
        }
        
    }

    public void DecreaseOxygenIncome()
    {
        if (uiManager.oxygenPoints > 0)
        {
            uiManager.oxygenPoints--;
            uiManager.points++;
            uiManager.ChangeIncome("oxygen", -10);
        }
        
        
    }

    public void IncreaseProteinIncome()
    {
        if (uiManager.points > 0)
        {
            uiManager.proteinPoints++;
            uiManager.points--;
            uiManager.ChangeIncome("protein", 10);
        }
        
    }

    public void DecreaseProteinIncome()
    {
        if (uiManager.proteinPoints > 0)
        {
            uiManager.proteinPoints--;
            uiManager.points++;
            uiManager.ChangeIncome("protein", -10);
        }
       
        
    }

    public void IncreaseGlucoseIncome()
    {
        if (uiManager.points > 0)
        {
            uiManager.glucosePoints++;
            uiManager.points--;
            uiManager.ChangeIncome("glucose", 10);
        }
        
    }

    public void DecreaseGlucoseIncome()
    {
        
        if (uiManager.glucosePoints > 0)
        {
            uiManager.glucosePoints--;
            uiManager.points++;
            uiManager.ChangeIncome("glucose", -10);
        }
        
        
    }

    public void IncreasevitIncome()
    {
        if (uiManager.points > 0)
        {
            uiManager.vitPoints++;
            uiManager.points--;
            uiManager.ChangeIncome("vitamins", 10);
        }
        
    }

    public void DecreasevitIncome()
    {
        
        if (uiManager.vitPoints > 0)
        {
            uiManager.vitPoints--;
            uiManager.points++;
            uiManager.ChangeIncome("vitamins", -10);
        }
        
       
    }
}
