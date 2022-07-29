using TMPro;
using UnityEngine;

public class DestroyCubes : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI redCount, blueCount;

    private int redScore = 0;
    private int blueScore = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("redCube") && gameObject.tag.Equals("redWall")) //Проверка на соответствие цветов
        {
            redScore++; //Плюс количество "забитых" красных кубов
            CreateCubes.cubeBalance--; //Уменьшение количества оставшихся кубов
            redCount.text = redScore.ToString(); //Вывод количества "забитых" красных кубов
            Destroy(collision.gameObject); //Удаление куба
        }
        if (collision.gameObject.tag.Equals("blueCube") && gameObject.tag.Equals("blueWall"))
        {
            blueScore++;
            CreateCubes.cubeBalance--;
            blueCount.text = blueScore.ToString();
            Destroy(collision.gameObject);
        }
    }
}
