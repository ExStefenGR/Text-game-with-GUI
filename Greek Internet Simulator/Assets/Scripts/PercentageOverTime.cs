using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PercentageOverTime : MonoBehaviour
{
    //TextMeshPro used
    public TextMeshProUGUI Percentage;
    public TextMeshProUGUI Money;
    public TextMeshProUGUI Account;
    public TextMeshProUGUI InternetUp;
    public TextMeshProUGUI PCUp;
    //Percent bar
    float Percent;
    [SerializeField]
    private float Speed;
    //Player's Economy
    public float MoneyBro;
    public float Multiplier = 0;
    private float cost = 5;
    //Objects
    public Slider slider;
    public GameObject PCButton;
    //Sprites used
    public GameObject PC_1;
    //meme stuff
    private Vector3 PogScale;
    void Start()
    {
        PogScale = new Vector3(+0.1f, 0, 0);
        Percent = 0f;
    }

    //Update is used for Ram Based gameplay
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        Account.SetText("Greek Bank Interest: {0:2}", Multiplier);
        List<string> Internets = new List<string>
        {
            "Upgrade to Hellas Offline 0.1 bit/s Cost: ",
            "Upgrade to Hellas Offline 0.9 bit/s Cost: ",
            "Upgrade to Hellas Offline 2 bit/s Cost: ",
            "Upgrade to Hellas Offline 5 bit/s Cost: ",
            "Upgrade to Hellas Offline 12 bit/s Cost: ",
            "Upgrade to Hellas Offline 15 bit/s Cost: ",
            "Upgrade to Hellas Offline 15.1 bit/s Cost: ",
            "Upgrade to Hellas Offline 15.82 bit/s Cost: ",
            "Upgrade to Hellas Offline 16.02 bit/s Cost:  ",
            "Upgrade to TEM 2 B/s Cost: ",
            "Upgrade to TEM 3 B/s Cost: ",
            "Upgrade to TEM 4 B/s Cost: ",
            "Upgrade to TEM 5 B/s Cost: ",
            "Upgrade to TEM 6 B/s Cost: ",
            "Upgrade to TEM 7 B/s Cost: ",
            "Upgrade to TEM 8 B/s Cost: ",
            "Upgrade to TEM 9 B/s Cost: ",
            "Upgrade to TEM 10 B/s Cost: "
        };
        InternetUp.SetText(Internets[0] + "{0:2}", cost);
        Mathf.RoundToInt(Time.deltaTime);
        Mathf.RoundToInt(cost);
        Percent += Speed * Time.deltaTime;
        slider.value = Percent;
        Money.SetText("Greek Drachma {0:2}", MoneyBro);
        if (Percent >= 1)
        {
            MoneyBro += 5.25f + Multiplier;
            Percent = 0;
        }
        Percentage.SetText("{0:2}", Percent);
        if (Multiplier > 0)
        {
            InternetUp.SetText(Internets[0] + cost);
        }
        if (Multiplier > 80)
        {
            InternetUp.SetText(Internets[1] + cost);

        }
        if (Multiplier > 160)
        {
            InternetUp.SetText(Internets[2] + cost);

        }
        if (Multiplier > 240)
        {
            InternetUp.SetText(Internets[3] + cost);
        }
        if (Multiplier > 380)
        {
            InternetUp.SetText(Internets[4] + cost);
        }
        if (Multiplier > 450)
        {
            InternetUp.SetText(Internets[5] + cost);
        }
        if (Multiplier > 520)
        {
            InternetUp.SetText(Internets[6] + cost);
        }
        if (Multiplier > 670)
        {
            InternetUp.SetText(Internets[7] + cost);
        }
        if (Multiplier > 790)
        {
            InternetUp.SetText(Internets[8] + cost);
        }
        if (Multiplier > 800)
        {
            InternetUp.SetText(Internets[9] + cost);
            Speed = 0.9f;

        }
        if (Multiplier > 1000)
        {
            InternetUp.SetText(Internets[10] + cost);
        }
        if (Multiplier > 1080)
        {
            InternetUp.SetText(Internets[11] + cost);

        }
        if (Multiplier > 1600)
        {
            InternetUp.SetText(Internets[12] + cost);

        }
        if (Multiplier > 2400)
        {
            InternetUp.SetText(Internets[13] + cost);
        }
        if (Multiplier > 3800)
        {
            InternetUp.SetText(Internets[14] + cost);
        }
        if (Multiplier > 4500)
        {
            InternetUp.SetText(Internets[15] + cost);
        }
        if (Multiplier > 5200)
        {
            InternetUp.SetText(Internets[16] + cost);
        }
        if (Multiplier > 6700)
        {
            InternetUp.SetText(Internets[17] + cost);
        }
        if (Multiplier > 7900)
        {
            InternetUp.SetText(Internets[18] + cost);
        }
        if (Multiplier > 8000)
        {
            InternetUp.SetText(Internets[19] + cost);
            Speed = 0.9f;

        }
        if (Multiplier >= 900)
        {
            PCUp.SetText("Upgrade Computer");

        }
    }


    public void Pog()
    {
        if (MoneyBro >= cost)
        {
            Multiplier += 12.50f;
            MoneyBro -= cost;
            cost *= 1.1f;
            Speed += 0.09f;
            PC_1.transform.localScale += PogScale;
            print("Money?");

        }
    }
    public void PrestigePC()
    {
        if (Multiplier >= 900)
        {
            MoneyBro -= 1000;
            Speed += 1.00f;
            print("Upgraded PC");
            //set active for Sprite
            PC_1.SetActive(false);
        }
    }
}

