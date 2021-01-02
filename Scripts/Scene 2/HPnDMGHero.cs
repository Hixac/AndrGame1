using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPnDMGHero : MonoBehaviour
{
    [SerializeField] public TextMesh hpTextMesh;
    [SerializeField] public TextMesh dmgTextMesh;

    int HeroHP;
    int HeroDMG;
    private void Start()
    {
        HeroHP = int.Parse(hpTextMesh.text);
        HeroDMG = int.Parse(dmgTextMesh.text);
    }

    public void HeroCalc(ref int HPEnemy, ref int DMGEnemy)
    {
        if (HeroHP > DMGEnemy)
        {
            HeroHP -= DMGEnemy;
        }
        if (HPEnemy > HeroDMG)
        {
            HPEnemy -= HeroDMG;
        }

        hpTextMesh.text = HeroHP.ToString();
        dmgTextMesh.text = HeroDMG.ToString();
    }
}
