using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPCalc : MonoBehaviour
{
    [SerializeField] public TextMesh hpTextMesh;
    [SerializeField] public TextMesh dmgTextMesh;

    int EnemyHP;
    int EnemyDMG;
    private void Start()
    {
        EnemyHP = int.Parse(hpTextMesh.text);
        EnemyDMG = int.Parse(dmgTextMesh.text);
    }
    public HPnDMGHero HPnDMGHero;
    public void EnemyCalc()
    {
        HPnDMGHero.HeroCalc(ref EnemyHP, ref EnemyDMG);

        hpTextMesh.text = EnemyHP.ToString();
        dmgTextMesh.text = EnemyDMG.ToString();
    }
}
