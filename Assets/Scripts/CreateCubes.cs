using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateCubes : MonoBehaviour
{
    [SerializeField] private GameObject redCubes;
    [SerializeField] private GameObject blueCubes;

    GameObject[] redCubeArr;
    GameObject[] blueCubeArr;

    private int redCubeCount;
    private int blueCubeCount;
    internal static int cubeBalance;

    private static string redCubeTag = "redCube";
    private static string blueCubeTag = "blueCube";
    private void Awake()
    {
        instCubes(blueCubes); //Создали кубы на сцене
        instCubes(redCubes);

        redCubeArr = GameObject.FindGameObjectsWithTag(redCubeTag); //Получили массив созданных кубов разного цвета
        blueCubeArr = GameObject.FindGameObjectsWithTag(blueCubeTag);

        redCubeCount = redCubeArr.Length; //Определили длину массива из кубов разного цвета
        blueCubeCount = blueCubeArr.Length;

        cubeBalance = redCubeCount + blueCubeCount;
    }

    private void FixedUpdate()
    {
        if (cubeBalance == 0) //Кубы закончились = закончилась игра
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    private void instCubes(GameObject Cubes) //Создание рандомно кубов на сцене
    {
        for (int i = 0; i < Random.Range(1, 5); i++)
        {
            Instantiate(Cubes, new Vector3(Random.Range(-2.8f, 2.8f), 0.5f, Random.Range(-2.5f, 2.5f)), Quaternion.identity);
        }
    }
}
