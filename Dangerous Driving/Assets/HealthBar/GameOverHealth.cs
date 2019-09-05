using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverHealth : MonoBehaviour
{
    public int currenthealth;
    public HealthBar hb;
    public TextMeshProUGUI Health;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = hb.CurrentValue;
        Health.text = "Remaining health: " +currenthealth.ToString() +"%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
