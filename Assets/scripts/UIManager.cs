using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject panelToShow;

    public void TogglePanel()
    {
        if (panelToShow != null)
        {
            panelToShow.SetActive(!panelToShow.activeSelf);
        }
    }
}