using System;
using System.Collections;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Imaging;
using Sce.PlayStation.Core.Graphics;


using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace ShootingApp
{
	public static class Rayer
	{
		private static Texture2D[] CharacterStackTexture;
		private static TextureInfo[] CharacterStackTextureInfo;
		private static Texture2D scoreTexture;
		private static Texture2D 
		
		
		private static SpriteUV stackSprite;
		private static SpriteUV scoreSprite;
		private static SpriteUV bossHpSprite;
		private static SpriteUV skillPointSprite;
		
		public static void InitRayer()
		{
			CharacterStackTexture = new Texture2D[5];
			CharacterStackTextureInfo = new TextureInfo[5];
			
			var image0 = new Image("/Application/resourses/myCharacterStack.png");
			var image04 = image0.Crop(new ImageRect(0,0,128,32));
			var image03 = image0.Crop(new ImageRect(0,32,128,32));
			var image02 = image0.Crop(new ImageRect(0,64,128,32));
			var image01 = image0.Crop(new ImageRect(0,96,128,32));
			var image00 = image0.Crop(new ImageRect(0,128,128,32));
			
			CharacterStackTexture[0] = Convert.CreateTextureFromImage(image00);
			CharacterStackTextureInfo[0] = new TextureInfo(CharacterStackTexture[0]);
			CharacterStackTexture[1] = Convert.CreateTextureFromImage(image01);
			CharacterStackTextureInfo[1] = new TextureInfo(CharacterStackTexture[1]);
			CharacterStackTexture[2] = Convert.CreateTextureFromImage(image02);
			CharacterStackTextureInfo[2] = new TextureInfo(CharacterStackTexture[2]);
			CharacterStackTexture[3] = Convert.CreateTextureFromImage(image03);
			CharacterStackTextureInfo[3] = new TextureInfo(CharacterStackTexture[3]);
			CharacterStackTexture[4] = Convert.CreateTextureFromImage(image04);
			CharacterStackTextureInfo[4] = new TextureInfo(CharacterStackTexture[4]);
			
			image0.Dispose();
			image00.Dispose();
			image01.Dispose();
			image02.Dispose();
			image03.Dispose();
			image04.Dispose();
		}
		
		/// <summary>
		/// スコアを更新する
		/// </summary>
		/// <param name='inc'>
		/// 指定された分だけ増加させる
		/// </param>
		public static void UpdateScore(int inc){
			Scenes.sceneOnGame.RemoveChild(scoreSprite,true);
			
			Global.score += inc;
			var texture = Convert.CreateTextureFromText("SCORE  "+Global.score,new Font(FontAlias.System, 20, FontStyle.Bold),0xffffffff);
			var textureInfo = new TextureInfo(texture);
			scoreSprite = new SpriteUV(){TextureInfo = textureInfo};
			scoreSprite.Quad.S = textureInfo.TextureSizef;
			scoreSprite.CenterSprite();
			scoreSprite.Position = new Vector2(700,520);
			
			Scenes.sceneOnGame.AddChild(scoreSprite);
			
		}
		
		/// <summary>
		/// 自機の残機を更新する
		/// </summary>
		/// <param name='d'>
		/// 変化量
		/// </param>
		public static void UpdateCharacterStack(int d)
		{
			if((Global.characterStack + d >= 0) && (Global.characterStack + d <= 4)){
				Global.characterStack += d;
				Scenes.sceneOnGame.RemoveChild(stackSprite,true);
				stackSprite = new SpriteUV(){TextureInfo = CharacterStackTextureInfo[Global.characterStack]};
				stackSprite.Quad.S = CharacterStackTextureInfo[Global.characterStack].TextureSizef;
				stackSprite.CenterSprite();
				stackSprite.Position = new Vector2(850,520);
				Scenes.sceneOnGame.AddChild(stackSprite);
			}
		}
		
		/// <summary>
		/// ボスのHP表示を更新する
		/// </summary>
		/// <param name='hp'>
		/// Hp.
		/// </param>
		/// <param name='maxhp'>
		/// Maxhp.
		/// </param>
		public static void UpdateBossHp(int hp,int maxhp){
			Scenes.sceneOnGame.RemoveChild(bossHpSprite,true);
			float rate = (float)hp / maxhp;
			
			var image = new Image(ImageMode.Rgba,new ImageSize((int)(600*rate),5),new ImageColor(255,0,0,255));
			var texture = new Texture2D((int)(600*rate),5,false, PixelFormat.Rgba);
			texture.SetPixels(0, image.ToBuffer());
			image.Dispose();
			var textureInfo = new TextureInfo(texture);
			bossHpSprite = new SpriteUV(){TextureInfo = textureInfo};
			bossHpSprite.Quad.S = textureInfo.TextureSizef;
			bossHpSprite.CenterSprite(new Vector2(0,0));
			bossHpSprite.Position = new Vector2(200,470);
			
			Scenes.sceneOnGame.AddChild(bossHpSprite);	
		}
		
		/// <summary>
		/// スキルポイントの表示を更新
		/// </summary>
		/// <param name='skillPoint'>
		/// skillPointだけ増加させる。マイナスの値も可
		/// </param>
		public static void UpdateSkillPoint(int skillPoint){
			if((Global.skillPoint + skillPoint >= 0) && (Global.skillPoint + skillPoint <= 3)){
				Global.skillPoint += skillPoint;
				Scenes.sceneOnGame.RemoveChild(skillPointSprite,true);
				var baseImage = new Image("Application/resourses/SPgause.png");
				var starImage = new Image("Application/resourses/star.png");
				
				baseImage.Decode();
				starImage.Decode();
				for(int i = 0; i < Global.skillPoint; i++){
					baseImage.DrawImage(starImage,new ImagePosition(40*(i+1),0));
				}
				
				var texture = Convert.CreateTextureFromImage(baseImage);
				var textureInfo = new TextureInfo(texture);
				
				skillPointSprite = new SpriteUV(){TextureInfo = textureInfo};
				skillPointSprite.Quad.S = textureInfo.TextureSizef;
				skillPointSprite.CenterSprite(new Vector2(0,0));
				skillPointSprite.Position = new Vector2(0,490);
				
				Scenes.sceneOnGame.AddChild(skillPointSprite);
			}
		}
	}
}

