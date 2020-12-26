using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Main : MonoBehaviour {

static public Main S;

static Dictionary<WeaponType, WeaponDefinition> WEAP_DICT;
public Text e1Kills, e2Kills, e3Kills, e4Kills, e0Kills,scoreLabel,timeLabel,levelLabel;

private int e1=0, e2=0, e3=0, e4=0, e0=0,score=0;
int numEnemiesDisplayed = 0;
[Header("Set in Inspector")]
public GameObject[] prefabEnemies;
public GameObject[] backgroundImages;
public float enemySpawnPerSecond = 0.5f;
public float enemyDefaultPadding = 1.5f;
public WeaponDefinition[] weaponDefinitions;
public GameObject prefabPowerUp;
public WeaponType[] powerUpFrequency = new WeaponType[]{
WeaponType.blaster,WeaponType.blaster,
WeaponType.spread, WeaponType.shield
}  ;
public WeaponType[] activeWeaponTypes;
private BoundsCheck bndCheck;

public void ShipDestroyed(Enemy e)
{
enemyText (e);
if (Random.value <= e.powerUpDropChance) {
int ndx = Random.Range (0, powerUpFrequency.Length);
WeaponType puType = powerUpFrequency [ndx];
GameObject go = Instantiate (prefabPowerUp) as GameObject;
PowerUp pu = go.GetComponent<PowerUp> ();
pu.SetType (puType);
pu.transform.position = e.transform.position;
}
}
float enemiesFallingRate;
void Awake() {
S = this;
//Sc = GetComponent<SetPrefabScene> ();
enemiesFallingRate =1f/enemySpawnPerSecond;
bndCheck = GetComponent<BoundsCheck> ();
Invoke ("SpawnEnemy", enemiesFallingRate);


WEAP_DICT = new Dictionary<WeaponType, WeaponDefinition> ();

foreach (WeaponDefinition def in weaponDefinitions) {
WEAP_DICT [def.type] = def;
}
}

public void SpawnEnemy()
{
int ndx = Random.Range (0, prefabEnemies.Length);
GameObject go = Instantiate<GameObject> (prefabEnemies[ndx]);
float enemyPadding = enemyDefaultPadding;
if (go.GetComponent<BoundsCheck> () != null) {
enemyPadding = Mathf.Abs (go.GetComponent<BoundsCheck> ().radius);
}
Vector3 pos = Vector3.zero;
float xMin = -bndCheck.camWidth + enemyPadding;
float xMax = bndCheck.camWidth - enemyPadding;
pos.x = Random.Range (xMin, xMax);
pos.y = bndCheck.camHeight + enemyPadding;
go.transform.position = pos;

Invoke ("SpawnEnemy", 1f / enemySpawnPerSecond);

}

public void DelayedRestart(float delay)

{
//if(PlayerPrefs.GetInt("Levels")==1){


//}

Invoke ("Restart", delay);

}

public void Restart()
{

SceneManager.LoadScene ("_Scene_0");
}

static public WeaponDefinition GetWeaponDefinition(WeaponType wt)
{
if (WEAP_DICT.ContainsKey (wt)) {
return(WEAP_DICT [wt]);
}

return(new WeaponDefinition ());
}
void Start()
{
PlayerPrefs.SetInt ("Score1", 0);

for (int i = 0; i < 3; i++) {
backgroundImages [i].gameObject.SetActive (false);
//backgroundImages [i].gameObject.transform.localScale = new Vector3 (PlayerPrefs.GetFloat ("backgroundScaleX"), PlayerPrefs.GetFloat ("backgroundScaleY"), 1f);
}
int a = PlayerPrefs.GetInt ("backgroundImageIndex");
//Debug.Log (a);
backgroundImages [a].gameObject.SetActive (true);

activeWeaponTypes = new WeaponType[weaponDefinitions.Length];
for (int i = 0; i < weaponDefinitions.Length; i++)
{
activeWeaponTypes[i] = weaponDefinitions[i].type;
}
}
public void enemyText(Enemy e)
{
if (e.name == "Enemy_0(Clone)") {

score = score + 5;
e0 = e0+ 1;
scoreLabel.text = "Score :" + score;
e0Kills.text = "E0Kills : " + e0;


}
else if (e.name == "Enemy_1(Clone)") {

score = score + 5;
e1 = e1 + 1;
scoreLabel.text = "Score :" + score;
e1Kills.text = "E1Kills : " + e1;


}
else if (e.name == "Enemy_2(Clone)") {

score = score + 5;
e2 = e2 + 1;
scoreLabel.text = "Score :" + score;
e2Kills.text = "E2Kills : " + e2;


}
else if (e.name == "Enemy_3(Clone)") {

score = score + 5;
e3 = e3 + 1;
scoreLabel.text = "Score :" + score;
e3Kills.text = "E3Kills : " + e3;


}
else if (e.name == "Enemy_4(Clone)") {

score = score + 5;
e4 = e4 + 1;
scoreLabel.text = "Score :" + score;
e4Kills.text = "E4Kills : " + e4;


}
}



}