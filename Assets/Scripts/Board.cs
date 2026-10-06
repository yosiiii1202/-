using UnityEngine;

public class Board : MonoBehaviour
{
    [Header("ピン")]
    [SerializeField] private GameObject pinPrefab;

    [Header("ピンの配置数")]
    [SerializeField] private int pinCountX = 8;
    [SerializeField] private int pinCountY = 8;

    [Header("ピンの間隔")]
    [SerializeField] private float spacingX = 90f;
    [SerializeField] private float spacingY = 80f;

    [Header("配置開始位置")]
    [SerializeField] private float startX = -315f;
    [SerializeField] private float startY = 300f;

    private void Start()
    {
        GeneratePins();
    }

    private void GeneratePins()
    {
        if (pinPrefab == null)
        {
            Debug.LogError("Pin Prefabが設定されていません！");
            return;
        }

        for (int y = 0; y < pinCountY; y++)
        {
            for (int x = 0; x < pinCountX; x++)
            {
                float posX = startX + x * spacingX;

                // 偶数行と奇数行で少しずらす
                if (y % 2 == 1)
                {
                    posX += spacingX * 0.5f;
                }

                float posY = startY - y * spacingY;

                Vector3 position = new Vector3(posX, posY, 0);

                Instantiate(
                    pinPrefab,
                    position,
                    Quaternion.identity,
                    transform
                );
            }
        }
    }
}