using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject redCubes;
    public GameObject blueCubes;

    GameObject[] redCubeArr;
    GameObject[] blueCubeArr;

    public int redCubeCount;
    public int blueCubeCount;
    public static int cubeBalance;

    private static string redCubeTag = "redCube";
    private static string blueCubeTag = "blueCube";

    private void instCubes(GameObject Cubes) //Создание рандомно кубов на сцене
    {
        for (int i = 0; i < Random.Range(1, 5); i++)
        {
            Instantiate(Cubes, new Vector3(Random.Range(-40, 40), 10, Random.Range(-20, 40)), Quaternion.identity);
        }
    }
    private void Start()
    {
        instCubes(blueCubes); //Создали кубы на сцене
        instCubes(redCubes);

        redCubeArr = GameObject.FindGameObjectsWithTag(redCubeTag); //Получили массив созданных кубов разного цвета
        blueCubeArr = GameObject.FindGameObjectsWithTag(blueCubeTag);

        redCubeCount = redCubeArr.Length; //Определили длину массива из кубов разного цвета
        blueCubeCount = blueCubeArr.Length;

        cubeBalance = redCubeCount + blueCubeCount;

        Debug.Log("Red " + redCubeCount);
        Debug.Log("Blue " + blueCubeCount);
        Debug.Log("All " + cubeBalance);
    }

    private void Update()
    {
        if (cubeBalance == 0) //Кубы закончились = закончилась игра
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
