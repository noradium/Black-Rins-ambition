using System;
using System.Collections;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Graphics;
using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace ShootingApp
{
	public enum BulletType
	{	Single, Line, Circle, Spiral,
		SingleUp, LineUp, CircleUp, SpiralUp,
		SingleDown, LineDown, CircleDown, SpiralDown,
		SingleAimed, LineAimed, CircleAimed,
		Boss
	}
	
	
	/// <summary>
	/// 1つの弾丸を管理するクラス
	/// </summary>
	public class Bullet1
	{
		public float X,Y; // 発射地点の座標
		public float DX,DY; // 飛ばす方向
		public SpriteUV Sprite;
		
		public Bullet1(float x,float y, float dx, float dy){
			X = x; Y = y; DX = dx; DY = dy;
		}
	}
	
	/// <summary>
	/// 自機から発射された弾丸をまとめて管理するクラス
	/// </summary>
	public static class MyBullet
	{
		public static ArrayList BulletList; // 弾丸を登録するArrayList
		private static Texture2D Texture;
		private static TextureInfo TextureInfo;
		
		public static void InitMyBullet(){
			BulletList = new ArrayList();
			Texture = new Texture2D("Application/resourses/arrow.gif", false);
			TextureInfo = new TextureInfo(Texture);
		}
		
		/// <summary>
		/// 新たに弾丸を生成
		/// </summary>
		/// <param name='x'>
		/// 初期位置のx座標
		/// </param>
		/// <param name='y'>
		/// 初期位置のy座標
		/// </param>
		/// <param name='dx'>
		/// x方向の速度
		/// </param>
		/// <param name='dy'>
		/// y方向の速度
		/// </param>
		public static void MakeNewBullet(float x, float y, float dx, float dy){
			var newBullet = new Bullet1(x,y,dx,dy);
			
			newBullet.Sprite = new SpriteUV(){TextureInfo = TextureInfo};
			newBullet.Sprite.Quad.S = TextureInfo.TextureSizef;
			newBullet.Sprite.CenterSprite();
			newBullet.Sprite.Position = new Sce.PlayStation.Core.Vector2(x,y);
			BulletList.Add(newBullet);
			Scenes.sceneOnGame.AddChild(((Bullet1)BulletList[BulletList.Count-1]).Sprite);
		}
		
		/// <summary>
		/// 弾丸の位置を更新する
		/// </summary>
		/// <param name='bl'>
		/// Bullet1
		/// </param>
		public static void Update(Bullet1 bl){
			var newblPosition = new Vector2(bl.Sprite.Position.X,bl.Sprite.Position.Y);
			newblPosition += new Vector2(bl.DX,bl.DY);
			bl.Sprite.RunAction(new MoveTo(newblPosition,0.0f));
		}
		
		/// <summary>
		/// 弾丸を削除する
		/// </summary>
		/// <param name='bl'>
		/// Bullet1
		/// </param>
		public static void RemoveBullet(Bullet1 bl){
			bl.Sprite.RemoveAllChildren(true);
			Scenes.sceneOnGame.RemoveChild(bl.Sprite,true);
			BulletList.Remove(bl);
		}
		public static void TextureDispose(){
			Texture.Dispose();
			TextureInfo.Dispose();
		}
		
	}
	
	/// <summary>
	/// 敵の弾丸をまとめて管理するクラス
	/// </summary>
	public static class EnemyBullet
	{
		public static ArrayList BulletList; // 弾丸を登録するArrayList
		
		private static Texture2D[] BulletTexture;
		private static TextureInfo[] BulletTextureInfo;
		
		public static void InitEnemyBullet(){
			BulletList = new ArrayList();
			BulletTexture = new Texture2D[4];
			BulletTextureInfo = new TextureInfo[4];
			
			var image2 = new Image("/Application/resourses/Bullet01_16x16.png");
			var image20 = image2.Crop(new ImageRect(0,0,16,16));
			var image21 = image2.Crop(new ImageRect(0,16,16,16));
			var image22 = image2.Crop(new ImageRect(0,32,16,16));
			var image23 = image2.Crop(new ImageRect(0,48,16,16));
			
			BulletTexture[0] = Convert.CreateTextureFromImage(image20);
			BulletTextureInfo[0] = new TextureInfo(BulletTexture[0]);
			BulletTexture[1] = Convert.CreateTextureFromImage(image21);
			BulletTextureInfo[1] = new TextureInfo(BulletTexture[1]);
			BulletTexture[2] = Convert.CreateTextureFromImage(image22);
			BulletTextureInfo[2] = new TextureInfo(BulletTexture[2]);
			BulletTexture[3] = Convert.CreateTextureFromImage(image23);
			BulletTextureInfo[3] = new TextureInfo(BulletTexture[3]);
			image2.Dispose();
			image20.Dispose();
			image21.Dispose();
			image22.Dispose();
			image23.Dispose();
		}
		
		public static void TextureDispose(){
			foreach(Texture2D texture in BulletTexture)
				texture.Dispose();
			foreach(TextureInfo textureInfo in BulletTextureInfo)
				textureInfo.Dispose();
		}
		
		/// <summary>
		/// 単品の弾丸を生成
		/// </summary>
		/// <param name='x'>
		/// 初期位置
		/// </param>
		/// <param name='y'>
		/// 初期位置
		/// </param>
		/// <param name='dx'>
		/// フレームあたり変化量
		/// </param>
		/// <param name='dy'>
		/// フレームあたり変化量
		/// </param>
		public static void MakeSingleBullet(float x, float y, float dx, float dy){
			NewBullet(BulletType.Single,x,y,dx,dy);
		}
		
		/// <summary>
		/// 縦に並んだ弾丸を生成
		/// </summary>
		/// <param name='x'>
		/// 初期位置（中心座標）
		/// </param>
		/// <param name='y'>
		/// 初期位置（中心座標）
		/// </param>
		/// <param name='n'>
		/// 個数
		/// </param>
		/// <param name='interval'>
		/// 弾丸と弾丸の間[pixel]
		/// </param>
		/// <param name='dx'>
		/// フレームあたり変化量
		/// </param>
		/// <param name='dy'>
		/// フレームあたり変化量
		/// </param>
		public static void MakeLineBullets(float x, float y, int n, int interval, float dx, float dy){
			NewBullet(BulletType.Line,x,y,dx,dy);
			for(int i = 1; i < n; i++){
				NewBullet(BulletType.Line,x,y+i*interval,dx,dy);
				NewBullet(BulletType.Line,x,y+i*interval*(-1),dx,dy);
			}
		}
		
		/// <summary>
		/// 放射状に広がる弾丸を生成
		/// </summary>
		/// <param name='x'>
		/// 初期位置
		/// </param>
		/// <param name='y'>
		/// 初期位置
		/// </param>
		/// <param name='n'>
		/// 円を構成する弾丸の個数
		/// </param>
		/// <param name='dr'>
		/// フレームあたり変化する半径
		/// </param>
		public static void MakeCircleBullets(float x, float y, int n, float dr){
			for(int i = 0;i < n; i++){
				NewBullet(BulletType.Circle,x,y,dr*FMath.Cos(FMath.DegToRad * (360/n*i)),dr*FMath.Sin(FMath.DegToRad * (360/n*i)));	
			}
		}
		
		/// <summary>
		/// 自機狙い円形の弾丸を生成
		/// </summary>
		/// <param name='x'>
		/// 初期位置
		/// </param>
		/// <param name='y'>
		/// 初期位置
		/// </param>
		/// <param name='n'>
		/// 個数
		/// </param>
		/// <param name='r'>
		/// 半径
		/// </param>
		/// <param name='dx'>
		/// フレームあたり変化量
		/// </param>
		/// <param name='dy'>
		/// フレームあたり変化量
		/// </param>
		public static void MakeDirectionCircleBullets(float x, float y, int n, float r, float dx, float dy){
			for(int i = 0;i < n; i++){
				NewBullet(BulletType.Circle,x+r*FMath.Cos(FMath.DegToRad * (360/n*i)),y+r*FMath.Sin(FMath.DegToRad * (360/n*i)),dx,dy);	
			}
		}
		
		/// <summary>
		/// 螺旋状に広がる弾丸を生成
		/// </summary>
		/// <param name='x'>
		/// 初期位置
		/// </param>
		/// <param name='y'>
		/// 初期位置
		/// </param>
		/// <param name='n'>
		/// １周の個数
		/// </param>
		/// <param name='times'>
		/// 何周するか
		/// </param>
		public static void MakeSpiralBullets(float x, float y, int n, int times){
			for(int i = 0;i < n * times; i++){
				NewBullet(BulletType.Spiral,x,y,(float)(i+n/3)/n*FMath.Cos(FMath.DegToRad * (360/n*i)),(float)(i+n/3)/n*FMath.Sin(FMath.DegToRad * (360/n*i)));	
			}
		}
		
		/// <summary>
		/// 弾丸１つ生成
		/// </summary>
		/// <param name='type'>
		/// 弾丸タイプ
		/// </param>
		/// <param name='x'>
		/// 初期位置
		/// </param>
		/// <param name='y'>
		/// 初期位置
		/// </param>
		/// <param name='dx'>
		/// フレームあたり変化量
		/// </param>
		/// <param name='dy'>
		/// フレームあたり変化量
		/// </param>
		private static void NewBullet(BulletType type, float x, float y, float dx, float dy){
			var newBullet = new Bullet1(x,y,dx,dy);
			newBullet.Sprite = new SpriteUV(){TextureInfo = BulletTextureInfo[(int)type]};
			newBullet.Sprite.Quad.S = BulletTextureInfo[(int)type].TextureSizef;
			newBullet.Sprite.CenterSprite();
			newBullet.Sprite.Position = new Sce.PlayStation.Core.Vector2(x,y);
			BulletList.Add(newBullet);
			Scenes.sceneOnGame.AddChild(((Bullet1)BulletList[BulletList.Count-1]).Sprite);
		}
		
		/// <summary>
		/// 弾丸の位置を更新
		/// </summary>
		/// <param name='bl'>
		/// 更新する弾丸
		/// </param>
		public static void Update(Bullet1 bl){
			var newblPosition = new Vector2(bl.Sprite.Position.X,bl.Sprite.Position.Y);
			newblPosition += new Vector2(bl.DX,bl.DY);
			bl.Sprite.RunAction(new MoveTo(newblPosition,0.0f));
		}
		
		/// <summary>
		/// 弾丸を削除する
		/// </summary>
		/// <param name='bl'>
		/// 削除する弾丸
		/// </param>
		public static void RemoveBullet(Bullet1 bl){
			bl.Sprite.RemoveAllChildren(true);
			Scenes.sceneOnGame.RemoveChild(bl.Sprite,true);
			BulletList.Remove(bl);
		}
		
		/// <summary>
		/// 敵弾丸リストに登録されている弾丸を自機弾丸リストに移動
		/// </summary>
		/// <param name='myShipSpritePosition'>
		/// 自機の位置
		/// </param>
		public static void moveToMyBulletList(Vector2 myShipSpritePosition){
			foreach(Bullet1 bl in BulletList){
				var newDirectionVector = Vector2.Normalize(bl.Sprite.Position - myShipSpritePosition) * 2;
				bl.DX = newDirectionVector.X;
				bl.DY = newDirectionVector.Y;
				MyBullet.BulletList.Add(bl);
			}
			BulletList.Clear();
		}
	}
}

