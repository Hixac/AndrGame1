using UnityEngine;

public class GameManager : MonoBehaviour
{
    Vector3 startHeroPos;

    //Пустые карты
    public GameObject[] cardsArray;
    //Враги размещены без карточек, требуют родительскую карту, ибо размеры скейлятся ровно на карту
    public GameObject[] enemyArray;
    public GameObject[] itemsArray;
    public GameObject blankCard;

    private void Start()
    {
        startHeroPos = cardsArray[4].transform.position;
    }
    bool blankCardExist = true;
    private void Update()
    {
        if (cardsArray[4].transform.position != startHeroPos & blankCardExist == true)
        {
            Instantiate(blankCard, startHeroPos, Quaternion.identity);
            blankCard.GetComponent<ClickFeature>().hero = cardsArray[4];
            blankCardExist = false;
        }
    }
}
