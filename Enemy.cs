using System;
using System.Collections;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace ShootingApp
{
	//                  　　　　　　  こうもり    パラソル   ロケット　　おばけ　　 りん天使    リンドラゴン
	public enum EnemyType{Enemy1,    Enemy2,   Enemy3,   Enemy4,   Enemy5,   Boss1,    Boss2}
	
	
	/// <summary>
	/// １つの敵を管理するクラス
	/// </summary>
	public class Enemy1
	{
		public float X,Y; // 初期位置の座標
		public BulletType BulletType; //発射する弾丸のタイプ
		public int AttackInterval; // 発射間隔[フレーム]
		public int CurrentHP; // 現在の体力
		public int MaxHP; // 最大体力
		public float TimeOut; // 敵が消えるまでの時間
		public SpriteUV Sprite;
		
		public Enemy1(float x,float y, BulletType bulletType, int attackInterval, int hp,float timeout){
			X = x; Y = y; BulletType = bulletType; AttackInterval = attackInterval; CurrentHP = hp; MaxHP = hp; TimeOut = timeout;
		}
	}
	/// <summary>
	/// 敵をまとめて管理するクラス
	/// </summary>
	public static class Enemy
	{
		public static ArrayList EnemyList;
		public static Texture2D[] Texture;
		public static TextureInfo[] TextureInfo;
		
		public static void InitEnemy(){
			EnemyList = new ArrayList();
			Texture = new Texture2D[10];
			TextureInfo = new TextureInfo[10];
			
			//Texture[(int)EnemyType.Enemy1] = new Texture2D("Application/resourses/enemy1.png", false);
			//TextureInfo[(int)EnemyType.Enemy1] = new TextureInfo(Texture[(int)EnemyType.Enemy1]);
			Texture[(int)EnemyType.Enemy2] = new Texture2D("Application/resourses/enemy2.gif", false);
			TextureInfo[(int)EnemyType.Enemy2] = new TextureInfo(Texture[(int)EnemyType.Enemy2]);
			Texture[(int)EnemyType.Enemy3] = new Texture2D("Application/resourses/enemy3.gif", false);
			TextureInfo[(int)EnemyType.Enemy3] = new TextureInfo(Texture[(int)EnemyType.Enemy3]);
			Texture[(int)EnemyType.Enemy4] = new Texture2D("Application/resourses/enemy4.gif", false);
			TextureInfo[(int)EnemyType.Enemy4] = new TextureInfo(Texture[(int)EnemyType.Enemy4]);
			Texture[(int)EnemyType.Enemy5] = new Texture2D("Application/resourses/enemy5.gif", false);
			TextureInfo[(int)EnemyType.Enemy5] = new TextureInfo(Texture[(int)EnemyType.Enemy5]);
			
			Texture[(int)EnemyType.Boss1] = new Texture2D("Application/resourses/boss1.gif", false);
			TextureInfo[(int)EnemyType.Boss1] = new TextureInfo(Texture[(int)EnemyType.Boss1]);
			Texture[(int)EnemyType.Boss2] = new Texture2D("Application/resourses/boss2.gif", false);
			TextureInfo[(int)EnemyType.Boss2] = new TextureInfo(Texture[(int)EnemyType.Boss2]);
		}
		
		public static void TextureDispose(){
			foreach(Texture2D texture in Texture)
				texture.Dispose();
			foreach(TextureInfo textureInfo in TextureInfo)
				textureInfo.Dispose();
		}
		
		/// <summary>
		/// 新しい敵を作成する
		/// </summary>
		/// <returns>
		/// 作成した敵
		/// </returns>
		/// <param name='textureId'>
		/// Texture identifier.
		/// </param>
		/// <param name='x'>
		/// 初期位置
		/// </param>
		/// <param name='y'>
		/// 初期位置
		/// </param>
		/// <param name='bulletType'>
		/// 攻撃の弾丸タイプ
		/// </param>
		/// <param name='attackInterval'>
		/// Attack interval.
		/// </param>
		/// <param name='hp'>
		/// Hp.
		/// </param>
		/// <param name='timeout'>
		/// 生成してから消えるまでの時間
		/// </param>
		public static Enemy1 MakeNewEnemy(EnemyType textureId, float x, float y,BulletType bulletType, int attackInterval, int hp, float timeout){
			var newEnemy = new Enemy1(x,y, bulletType, attackInterval,hp,timeout);
			
			newEnemy.Sprite = new SpriteUV(){TextureInfo = TextureInfo[(int)textureId]};
			newEnemy.Sprite.Quad.S = TextureInfo[(int)textureId].TextureSizef;
			
			newEnemy.Sprite.CenterSprite();
			newEnemy.Sprite.Position = new Sce.PlayStation.Core.Vector2(x,y);
			EnemyList.Add(newEnemy);
			Scenes.sceneOnGame.AddChild(((Enemy1)EnemyList[EnemyList.Count-1]).Sprite);
			return ((Enemy1)EnemyList[EnemyList.Count-1]);
		}
		
		/// <summary>
		/// 敵を削除する
		/// </summary>
		/// <param name='en'>
		/// 削除する敵
		/// </param>
		public static void RemoveEnemy(Enemy1 en){
			en.Sprite.RemoveAllChildren(true);
			Scenes.sceneOnGame.RemoveChild(en.Sprite,true);
			EnemyList.Remove(en);
		}		
		
		/// <summary>
		/// 弾丸とあたっている敵を返すメソッド
		/// </summary>
		/// <returns>
		/// 敵 or null
		/// </returns>
		/// <param name='en'>
		/// 敵
		/// </param>
		/// <param name='bulletlist'>
		/// 弾丸リスト
		/// </param>
		public static Bullet1 EnemyCollisionDetection(Enemy1 en, ArrayList bulletlist){
			foreach(Bullet1 bl in bulletlist){
				if(en.Sprite.Position.Distance(bl.Sprite.Position) < 50){
					return bl;
				}
			}
			return null;
		}
		
		/// <summary>
		/// 敵の弾丸を作成
		/// </summary>
		/// <param name='tickCount'>
		/// Tick count.
		/// </param>
		/// <param name='characterPosition'>
		/// 自機スプライトの位置
		/// </param>
		public static void GenerateEnemyBullets(int tickCount, Vector2 characterPosition){
			foreach(Enemy1 en in EnemyList){
			var directionVector = Vector2.Normalize(characterPosition - en.Sprite.Position);
				if(tickCount % en.AttackInterval == 0 && Global.characterActive){
					switch(en.BulletType){
					case BulletType.Single :
						EnemyBullet.MakeSingleBullet(en.Sprite.Position.X,en.Sprite.Position.Y,-2,0);
						break;
					case BulletType.Circle :
						EnemyBullet.MakeCircleBullets(en.Sprite.Position.X,en.Sprite.Position.Y,7,2);
						break;
					case BulletType.Line :
						EnemyBullet.MakeLineBullets(en.Sprite.Position.X,en.Sprite.Position.Y,2,30,-2,0);
						break;
					case BulletType.Spiral :
						EnemyBullet.MakeSpiralBullets(en.Sprite.Position.X,en.Sprite.Position.Y,8,3);
						break;
					case BulletType.SingleUp :
						EnemyBullet.MakeSingleBullet(en.Sprite.Position.X,en.Sprite.Position.Y,-4,2);
						break;
					case BulletType.LineUp :
						EnemyBullet.MakeLineBullets(en.Sprite.Position.X,en.Sprite.Position.Y,2,30,-4,2);
						break;
					case BulletType.CircleUp :
						EnemyBullet.MakeDirectionCircleBullets(en.Sprite.Position.X,en.Sprite.Position.Y,7,100,-2,3);
						break;
					case BulletType.SingleDown :
						EnemyBullet.MakeSingleBullet(en.Sprite.Position.X,en.Sprite.Position.Y,-4,2);
						break;
					case BulletType.LineDown :
						EnemyBullet.MakeLineBullets(en.Sprite.Position.X,en.Sprite.Position.Y,2,30,-4,-2);
						break;
					case BulletType.CircleDown :
						EnemyBullet.MakeDirectionCircleBullets(en.Sprite.Position.X,en.Sprite.Position.Y,7,100,-2,-3);
						break;
					case BulletType.SingleAimed :
						EnemyBullet.MakeSingleBullet(en.Sprite.Position.X,en.Sprite.Position.Y,directionVector.X*3,directionVector.Y*3);
						break;
					case BulletType.LineAimed :
						EnemyBullet.MakeLineBullets(en.Sprite.Position.X,en.Sprite.Position.Y,2,30,directionVector.X*3,directionVector.Y*3);
						break;
					case BulletType.CircleAimed :
						EnemyBullet.MakeDirectionCircleBullets(en.Sprite.Position.X,en.Sprite.Position.Y,7,100,directionVector.X*3,directionVector.Y*3);
						break;
					}
				}
			}
		}
		
		/// <summary>
		/// 敵の登録されているアクションを一時停止する
		/// </summary>
		public static void PauseAction(){
			foreach(Enemy1 en in EnemyList){
				en.Sprite.ActionsPaused = true;	
			}
		}
		
		/// <summary>
		/// 敵の登録されているアクションを再開する
		/// </summary>
		public static void ResumeAction(){
			foreach(Enemy1 en in EnemyList){
				en.Sprite.ActionsPaused = false;	
			}
		}
	}
}

