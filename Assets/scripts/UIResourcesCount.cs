using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIResourceManager : MonoBehaviour
{
    private float timer = 0f;

    public TextMeshProUGUI oxygenText;
    public TextMeshProUGUI proteinText;
    public TextMeshProUGUI glucoseText;
    public TextMeshProUGUI vitText;
    public TextMeshProUGUI aGensText;

    //Tx refering to Text

    public TextMeshProUGUI oxygenincomeTx;
    public TextMeshProUGUI proteinincomeTx;
    public TextMeshProUGUI glucoseincomeTx;
    public TextMeshProUGUI vitincomeTx;


    // Starting resources
    private int oxygen = 100;
    private int protein = 50;
    private int glucose = 100;
    private int vit = 20;
    private int aGens = 10;

    private int oxygenIncome = 0;
    private int proteinIncome = 0;
    private int glucoseIncome = 0;
    private int vitIncome = 0;

    public void ChangeIncome(string type, int delta)
    {
        switch (type)
        {
            case "oxygen": oxygenIncome += delta; break;
            case "protein": proteinIncome += delta; break;
            case "glucose": glucoseIncome += delta; break;
            case "vitamins": vitIncome += delta; break;
        }
    }
    void Update()
    {

        oxygenText.text = "" + oxygen;
        proteinText.text = "" + protein;
        glucoseText.text = "" + glucose;
        vitText.text = "" + vit;
        aGensText.text = "" + aGens;

        timer += Time.deltaTime;
        if (timer >= 10f) // co 10 sekund
        {
            ApplyIncome();
            timer = 0f;
        }
        oxygenincomeTx.text = "" + oxygenIncome * 6 + "/min";
        proteinincomeTx.text = "" + proteinIncome * 6 + "/min";
        glucoseincomeTx.text = "" + glucoseIncome * 6 + "/min";
        vitincomeTx.text = "" + vitIncome * 6 + "/min";
    }
    private void ApplyIncome()
    {
        oxygen += oxygenIncome;
        protein += proteinIncome;
        glucose += glucoseIncome;
        vit += vitIncome;
    }
}
